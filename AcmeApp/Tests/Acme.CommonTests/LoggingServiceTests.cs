using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.CommonTests
{
  [TestClass()]
  public class LoggingServiceTests
  {
    [TestMethod()]
    public void LogAction_Success()
    {
      // Arrange
      var expected = "Action: Test Action";

      // Act
      var actual = LoggingService.LogAction("Test Action");

      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
