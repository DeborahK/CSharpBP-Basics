namespace Acme.CommonTests
{
  [TestClass()]
  public class EmailServiceTests
  {
    [TestMethod()]
    public void SendMessage_Success()
    {
      // Arrange
      var email = new EmailService();
      var expected = true;

      // Act
      var actual = email.SendMessage("Test Message",
          "This is a test message", "abc@abc.com");

      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}