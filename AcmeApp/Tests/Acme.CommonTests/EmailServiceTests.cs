using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common.Tests
{
    [TestClass()]
    public class EmailServiceTests
    {
        [TestMethod()]
        public void SayHello_Success()
        {
            // Arrange
            var expected = "Hello from the email service";
            var email = new EmailService();

            // Act
            var actual = email.SayHello();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}