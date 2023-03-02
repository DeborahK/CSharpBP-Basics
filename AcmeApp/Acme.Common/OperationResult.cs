namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
  public class OperationResult
  {
    public bool Success { get; set; }
    public string? Message { get; set; }

    public OperationResult()
    {
    }

    public OperationResult(bool success, string message) : this()
    {
      Success = success;
      Message = message;
    }
  }
}
