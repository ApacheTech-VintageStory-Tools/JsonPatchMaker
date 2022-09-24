using JsonPatchMaker.Core.Abstractions;
using JsonPatchMaker.Core.Operations;
using Newtonsoft.Json.Linq;

// ReSharper disable UnusedType.Global

namespace JsonPatchMaker.Core.Tavis
{
    public class JsonPatcher : AbstractPatcher<JToken>
    {
        protected override JToken Replace(ReplaceOperation operation, JToken target)
        {
            var token = operation.Path.Find(target);
            if (token?.Parent is null) return operation.Value;
            token.Replace(operation.Value);
            return null;
        }

        protected override void Add(AddOperation operation, JToken target)
        {
            var jToken = (JToken)null;
            var jObject = (JObject)null;
            var str = operation.Path.ParentPointer!.ToString();
            var startIndex = str == "/" ? str.Length : str.Length + 1;
            var s = operation.Path.ToString()[startIndex..];
            try
            {
                var jArray = operation.Path.ParentPointer.Find(target) as JArray;
                var flag = operation.Path.IsNewPointer();
                if (jArray == null | flag)
                {
                    jToken = !flag ? operation.Path.Find(target) : operation.Path.ParentPointer.Find(target) as JArray;
                }
                else
                {
                    jArray.Insert(int.Parse(s), operation.Value);
                    return;
                }
            }
            catch (ArgumentException)
            {
                jObject = operation.Path.ParentPointer.Find(target) as JObject;
            }

            switch (jToken)
            {
                case null when jObject != null:
                    jObject.Add(s, operation.Value);
                    break;
                case JArray array:
                    array.Add(operation.Value);
                    break;
                default:
                    {
                        if (jToken!.Parent is not JProperty property) return;
                        property.Value = operation.Value;
                        break;
                    }
            }
        }

        protected override void Remove(RemoveOperation operation, JToken target)
        {
            var jToken = operation.Path.Find(target);
            if (jToken?.Parent is JProperty)
                jToken.Parent.Remove();
            else
                jToken?.Remove();
        }

        protected override void Move(MoveOperation operation, JToken target)
        {
            if (operation.Path.ToString().StartsWith(operation.FromPath.ToString()))
                throw new ArgumentException("To path cannot be below from path");
            var jToken = operation.FromPath.Find(target);
            var operation1 = new RemoveOperation
            {
                Path = operation.FromPath
            };
            Remove(operation1, target);
            var operation2 = new AddOperation
            {
                Path = operation.Path,
                Value = jToken
            };
            Add(operation2, target);
        }

        protected override void Test(TestOperation operation, JToken target)
        {
            if (!operation.Path.Find(target)?.Equals(target) ?? false)
                throw new InvalidOperationException("Value at " + operation.Path + " does not match.");
        }

        protected override void Copy(CopyOperation operation, JToken target)
        {
            var jToken = operation.FromPath.Find(target);
            var operation1 = new AddOperation
            {
                Path = operation.Path,
                Value = jToken
            };
            Add(operation1, target);
        }
    }
}