namespace Acme.Common
{
  /// <summary>
  /// Provides services to send email.
  /// </summary>
  public class EmailService
  {
    /// <summary>
    /// Sends email message
    /// </summary>
    /// <param name="subject">Subject of the message.</param>
    /// <param name="message">Message text</param>
    /// <param name="recipient">Email address of the message recipient.</param>
    /// <returns></returns>
    public bool SendMessage(string subject, string message, string recipient)
    {
      // Code to send an email
      LoggingService.LogAction("Message sent " + DateTime.Now + ": " + message);
      return true;
    }

  }
}