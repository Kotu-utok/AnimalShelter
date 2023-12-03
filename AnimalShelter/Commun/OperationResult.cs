
namespace Commun
{
    public class OperationResult
    {

        public OperationResult() { }
        public OperationResult(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public OperationResult(bool isSuccess, int createdEntityId)
        {
            IsSuccess = isSuccess;
            CreatedEntityId = createdEntityId;
        }

        public OperationResult(bool isSuccess, string errorMessage )
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
        }

        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public int? CreatedEntityId { get; set; }
    }
}
