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
        public void ToStringTest()
        {
            // Arrange
            var expected = "ABC Corp";

            var vendor = new Vendor();
            vendor.CompanyName = "ABC Corp";

            // Act
            var actual = vendor.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}