using System.Collections;
using JsonPatchMaker.Core.DataStructures;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace JsonPatchMaker.Core.Validation
{
    internal class LongestCommonSubsequence
    {
        private readonly Func<object[], object[], int, int, IDictionary, bool> _match;

        public LongestCommonSubsequence(Func<object, object, bool> matchObject)
        {
            _match = (array1, array2, index1, index2, _) => matchObject(array1[index1], array2[index2]);
        }

        private int[][] LengthMatrix(object[] array1, object[] array2, IDictionary context)
        {
            var length1 = array1.Length;
            var length2 = array2.Length;
            var numArray = new int[length1 + 1][];
            for (var index = 0; index < numArray.Length; ++index)
                numArray[index] = Enumerable.Repeat(0, length2 + 1).ToArray();
            for (var index1 = 1; index1 < length1 + 1; ++index1)
            {
                for (var index2 = 1; index2 < length2 + 1; ++index2)
                    numArray[index1][index2] = !_match(array1, array2, index1 - 1, index2 - 1, context) ? Math.Max(numArray[index1 - 1][index2], numArray[index1][index2 - 1]) : 1 + numArray[index1 - 1][index2 - 1];
            }
            return numArray;
        }

        private BackTrackResult BackTrack(
            IReadOnlyList<int[]> matrix,
            object[] array1,
            object[] array2,
            int index1,
            int index2,
            IDictionary context)
        {
            if (index1 == 0 || index2 == 0) return new BackTrackResult();
            if (!_match(array1, array2, index1 - 1, index2 - 1, context))
                return matrix[index1][index2 - 1] > matrix[index1 - 1][index2]
                    ? BackTrack(matrix, array1, array2, index1, index2 - 1, context)
                    : BackTrack(matrix, array1, array2, index1 - 1, index2, context);
            var backTrackResult = BackTrack(matrix, array1, array2, index1 - 1, index2 - 1, context);
            backTrackResult.Sequence.Add(array1[index1 - 1]);
            backTrackResult.FirstIndexSet.Add(index1 - 1);
            backTrackResult.SecondIndexSet.Add(index2 - 1);
            return backTrackResult;
        }

        public BackTrackResult Get(object[] array1, object[] array2, IDictionary context)
        {
            context ??= new Dictionary<string, object>();
            return BackTrack(LengthMatrix(array1, array2, context), array1, array2, array1.Length, array2.Length, context);
        }
    }
}