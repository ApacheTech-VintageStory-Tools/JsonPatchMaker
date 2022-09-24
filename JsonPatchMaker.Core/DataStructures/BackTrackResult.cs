// ReSharper disable CollectionNeverQueried.Global

namespace JsonPatchMaker.Core.DataStructures
{
    internal class BackTrackResult
    {
        internal List<object> Sequence { get; } = new();

        internal List<int> FirstIndexSet { get;} = new();

        internal List<int> SecondIndexSet { get; } = new();
    }
}