using JsonPatchMaker.Core.Operations;

// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace JsonPatchMaker.Core.Abstractions
{
    public abstract class AbstractPatcher<TDoc> where TDoc : class
    {
        public virtual void Patch(ref TDoc target, PatchDocument document)
        {
            target = document.Operations.Aggregate(target, (current, operation) => ApplyOperation(operation, current));
        }

        public virtual TDoc ApplyOperation(Operation operation, TDoc target)
        {
            switch (operation)
            {
                case AddOperation addOperation:
                    Add(addOperation, target);
                    break;
                case CopyOperation copyOperation:
                    Copy(copyOperation, target);
                    break;
                case MoveOperation moveOperation:
                    Move(moveOperation, target);
                    break;
                case RemoveOperation removeOperation:
                    Remove(removeOperation, target);
                    break;
                case ReplaceOperation replaceOperation:
                    target = Replace(replaceOperation, target) ?? target;
                    break;
                case TestOperation testOperation:
                    Test(testOperation, target);
                    break;
            }
            return target;
        }

        protected abstract void Add(AddOperation operation, TDoc target);

        protected abstract void Copy(CopyOperation operation, TDoc target);

        protected abstract void Move(MoveOperation operation, TDoc target);

        protected abstract void Remove(RemoveOperation operation, TDoc target);

        protected abstract TDoc Replace(ReplaceOperation operation, TDoc target);

        protected abstract void Test(TestOperation operation, TDoc target);
    }
}