using System;

namespace Commun
{
    public class FetchOperationResult<T> : OperationResult
    {
        public FetchOperationResult() { }

        public FetchOperationResult(T entity, bool isSuccess) : base(isSuccess)
        {
            Entity = entity;
        }

        public FetchOperationResult(bool isSuccess, string errorMessage) : base(isSuccess, errorMessage) { }

        public T Entity { get; set; }
    }
}
