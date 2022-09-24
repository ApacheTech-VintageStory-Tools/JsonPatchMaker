using JsonPatchMaker.Core.Operations;
using JsonPatchMaker.Core.Tavis;
using JsonPatchMaker.Core.Validation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
// ReSharper disable SwitchStatementHandlesSomeKnownEnumValuesWithDefault

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace JsonPatchMaker.Core
{
    internal static class JsonDiffer
    {
        internal static string Extend(string path, string extension) => path + "/" + extension;

        private static Operation Build(string op, string path, string key, JToken value) => string.IsNullOrEmpty(key)
            ? Operation.Parse("{ 'op' : '" + op + "' , path: '" + path + "', value: " + (value == null
                ? "null"
                : value.ToString(0, Array.Empty<JsonConverter>())) + "}")
            : Operation.Parse("{ op : '" + op + "' , path : '" + Extend(path, key) + "' , value : " + (value == null
                ? "null"
                : value.ToString(0, Array.Empty<JsonConverter>())) + "}");

        internal static Operation Add(string path, string key, JToken value) => Build("add", path, key, value);

        internal static Operation Remove(string path, string key) => Build("remove", path, key, null);

        internal static Operation Replace(string path, string key, JToken value) => Build("replace", path, key, value);

        internal static IEnumerable<Operation> CalculatePatch(
            JToken left,
            JToken right,
            bool useIdToDetermineEquality,
            string path = "")
        {
            if (left.Type != right.Type)
                yield return Replace(path, "", right);
            else switch (left.Type)
            {
                case JTokenType.Array:
                {
                    foreach (var operation3 in HandleArrayOperations(left, right, useIdToDetermineEquality, path)) 
                        yield return operation3;
                    break;
                }
                case JTokenType.Object:
                {
                    foreach (var operation1 in HandleObjectOperations(left, right, useIdToDetermineEquality, path)) 
                        yield return operation1;
                    break;
                }
                default:
                {
                    if (left.ToString() != right.ToString())
                        yield return Replace(path, "", right);
                    break;
                }
            }
        }

        private static IEnumerable<Operation> HandleObjectOperations(JToken left, JToken right, bool useIdToDetermineEquality, string path)
        {
            var lProps = ((IEnumerable<KeyValuePair<string, JToken>>)left).OrderBy(p => p.Key).ToList();
            var rProps = ((IEnumerable<KeyValuePair<string, JToken>>)right).OrderBy(p => p.Key).ToList();

            foreach (var keyValuePair in lProps.Except(rProps, MatchesKey.Instance))
                yield return Remove(path, keyValuePair.Key);
            foreach (var keyValuePair in rProps.Except(lProps, MatchesKey.Instance))
                yield return Add(path, keyValuePair.Key, keyValuePair.Value);
            foreach (var data in lProps.Select(x => x.Key).Intersect(rProps.Select(y => y.Key)).Select(k => new
                     {
                         key = k,
                         left = left[k],
                         right = right[k]
                     }))
            {
                var path1 = path + "/" + data.key;
                foreach (var operation in CalculatePatch(data.left, data.right, useIdToDetermineEquality, path1))
                    yield return operation;
            }
        }

        private static IEnumerable<Operation> HandleArrayOperations(JToken left, JToken right, bool useIdToDetermineEquality, string path)
        {
            var operation1 = (Operation)null;
            foreach (var operation2 in ProcessArray(left, right, path, useIdToDetermineEquality))
            {
                if (operation1 is RemoveOperation removeOperation &&
                    operation2 is AddOperation addOperation &&
                    addOperation.Path.ToString() == removeOperation.Path.ToString())
                {
                    yield return Replace(addOperation.Path.ToString(), "", addOperation.Value);
                    operation1 = null;
                }
                else
                {
                    if (operation1 != null)
                        yield return operation1;
                    operation1 = operation2;
                }
            }

            if (operation1 is not null) yield return operation1;
        }

        private static IEnumerable<Operation> ProcessArray(
            JToken left,
            JToken right,
            string path,
            bool useIdPropertyToDetermineEquality)
        {
            var comparer = new CustomCheckEqualityComparer(useIdPropertyToDetermineEquality, new JTokenEqualityComparer());
            var commonHead = 0;
            var commonTail = 0;
            var array1 = left.ToArray();
            var len1 = array1.Length;
            var array2 = right.ToArray();
            int len2;
            for (len2 = array2.Length; commonHead < len1 && commonHead < len2 && comparer.Equals(array1[commonHead], array2[commonHead]); ++commonHead)
            {
                foreach (var operation in CalculatePatch(array1[commonHead], array2[commonHead], useIdPropertyToDetermineEquality, path + "/" + commonHead))
                    yield return operation;
            }
            for (; commonTail + commonHead < len1 && commonTail + commonHead < len2 && comparer.Equals(array1[len1 - 1 - commonTail], array2[len2 - 1 - commonTail]); ++commonTail)
            {
                var index1 = len1 - 1 - commonTail;
                var index2 = len2 - 1 - commonTail;
                foreach (var operation in CalculatePatch(array1[index1], array2[index2], useIdPropertyToDetermineEquality, path + "/" + index1))
                    yield return operation;
            }
            if (commonHead == 0 && commonTail == 0 && len2 > 0 && len1 > 0 && len1 != len2)
            {
                var replaceOperation = new ReplaceOperation
                {
                    Path = new JsonPointer(path),
                    Value = JArray.FromObject(array2)
                };
                yield return replaceOperation;
            }
            else
            {
                var leftMiddle = array1.Skip(commonHead).Take(array1.Length - commonTail - commonHead).ToArray();
                var rightMiddle = array2.Skip(commonHead).Take(array2.Length - commonTail - commonHead).ToArray();
                int i;
                if (leftMiddle.Length == rightMiddle.Length)
                {
                    for (i = 0; i < leftMiddle.Length; i++)
                    {
                        var left1 = leftMiddle[i];
                        var right1 = rightMiddle[i];
                        var num2 = useIdPropertyToDetermineEquality ? 1 : 0;
                        var num1 = commonHead + i;
                        var str2 = num1.ToString();
                        var path1 = path + "/" + str2;
                        foreach (var operation in CalculatePatch(left1, right1, num2 != 0, path1))
                            yield return operation;
                    }
                }
                else
                {
                    for (i = 0; i < leftMiddle.Length; ++i)
                    {
                        var removeOperation = new RemoveOperation
                        {
                            Path = new JsonPointer(path + "/" + commonHead)
                        };
                        yield return removeOperation;
                    }
                    for (i = 0; i < rightMiddle.Length; ++i)
                    {
                        var addOperation = new AddOperation
                        {
                            Value = rightMiddle[i],
                            Path = new JsonPointer(path + "/" + (i + commonHead))
                        };
                        yield return addOperation;
                    }
                }
            }
        }

        public static PatchDocument Diff(JToken from, JToken to, bool useIdPropertyToDetermineEquality)
        {
            return new PatchDocument(CalculatePatch(from, to, useIdPropertyToDetermineEquality).ToArray());
        }
    }
}