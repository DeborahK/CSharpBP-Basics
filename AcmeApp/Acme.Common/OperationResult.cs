namespace Acme.Common
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public OperationResult()
        {
        }

        public OperationResult(bool success, string message) : this()
        {
            this.Success = success;
            this.Message = message;
        }
    }
}
