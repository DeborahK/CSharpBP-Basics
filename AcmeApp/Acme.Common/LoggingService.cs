namespace Acme.Common;

/// <summary>
/// Provides logging.
/// </summary>
public static class LoggingService
{
  /// <summary>
  /// Logs actions.
  /// </summary>
  /// <param name="action">Action to log.</param>
  public static string LogAction(string action)
  {
          var logText = "Action: " + action;
          Console.WriteLine(logText);

          return logText;
  }
}
