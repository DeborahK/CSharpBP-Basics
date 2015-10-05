using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorTests
    {
        [TestMethod()]
        public void SayHello_ValidCompany_Success()
        {
            // Arrange
            var vendor = new Vendor();
            vendor.VendorId = 1;
            vendor.CompanyName = "ABC Corp";
            var expected = "Hello ABC Corp";

            // Act
            var actual = vendor.SayHello();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHello_EmptyCompany_Success()
        {
            // Arrange
            var expected = "Hello";

            var vendor = new Vendor();
            vendor.CompanyName = "";

            // Act
            var actual = vendor.SayHello();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHello_NullCompany_Success()
        {
            // Arrange
            var expected = "Hello";

            var vendor = new Vendor();
            vendor.CompanyName = null;

            // Act
            var actual = vendor.SayHello();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}