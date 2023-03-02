namespace Acme.BizTests
{
  [TestClass()]
  public class VendorTests
  {
    [TestMethod()]
    public void SayHello_ValidCompany_Success()
    {
      // Arrange
      var vendor = new Vendor();
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
      var vendor = new Vendor();
      vendor.CompanyName = "";
      var expected = "Hello";

      // Act
      var actual = vendor.SayHello();

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void SayHello_NullCompany_Success()
    {
      // Arrange
      var vendor = new Vendor();
      vendor.CompanyName = null;
      var expected = "Hello";

      // Act
      var actual = vendor.SayHello();

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void PlaceOrder_Test()
    {
      // Arrange
      var vendor = new Vendor();
      var product = new Product(1, "Saw", "");
      var expected = new OperationResult(true, "Order from Acme, Inc\r\nProduct: Tools-1\r\nQuantity: 12" +
                                                "\r\nInstructions: standard delivery");

      // Act
      var actual = vendor.PlaceOrder(product, 12);

      // Assert
      Assert.AreEqual(expected.Success, actual.Success);
      Assert.AreEqual(expected.Message, actual.Message);
    }

    [TestMethod()]
    public void PlaceOrder_3Parameters()
    {
      // Arrange
      // Set a delivery date in the future
      var deliverBy = DateTimeOffset.Now.AddDays(5);
      var vendor = new Vendor();
      var product = new Product(1, "Saw", "");
      var expected = new OperationResult(true, "Order from Acme, Inc\r\nProduct: Tools-1\r\nQuantity: 12" +
                                              $"\r\nDeliver By: {deliverBy.ToString("d")}" +
                                                "\r\nInstructions: standard delivery");

      // Act
      var actual = vendor.PlaceOrder(product, 12, deliverBy.Date);

      // Assert
      Assert.AreEqual(expected.Success, actual.Success);
      Assert.AreEqual(expected.Message, actual.Message);
    }

    [TestMethod()]
    public void PlaceOrder_4Parameters()
    {
      // Arrange
      var deliverBy = DateTimeOffset.Now.AddDays(5);
      var vendor = new Vendor();
      var product = new Product(1, "Saw", "");
      var expected = new OperationResult(true, "Order from Acme, Inc\r\nProduct: Tools-1\r\nQuantity: 12" +
                                              $"\r\nDeliver By: {deliverBy.ToString("d")}" +
                                              "\r\nInstructions: Deliver to Suite 42");

      // Act
      var actual = vendor.PlaceOrder(product, 12,deliverBy.Date,
          "Deliver to Suite 42");

      // Assert
      Assert.AreEqual(expected.Success, actual.Success);
      Assert.AreEqual(expected.Message, actual.Message);
    }

    [TestMethod()]
    public void PlaceOrder_NoDeliveryDate()
    {
      // Arrange
      var vendor = new Vendor();
      var product = new Product(1, "Saw", "");
      var expected = new OperationResult(true, "Order from Acme, Inc\r\nProduct: Tools-1\r\nQuantity: 12" +
                                                "\r\nInstructions: Deliver to Suite 42");

      // Act
      var actual = vendor.PlaceOrder(product, 12, instructions: "Deliver to Suite 42");

      // Assert
      Assert.AreEqual(expected.Success, actual.Success);
      Assert.AreEqual(expected.Message, actual.Message);
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentNullException))]
    public void PlaceOrder_NullProduct_Exception()
    {
      // Arrange
      var vendor = new Vendor();

      // Act
      var actual = vendor.PlaceOrder(null, 12);

      // Assert
      // Expected exception
    }

    [TestMethod()]
    public void PlaceOrderTest()
    {
      // Arrange
      var vendor = new Vendor();
      var product = new Product(1, "Saw", "");
      var expected = new OperationResult(true, "Test With Address");

      // Act
      //var actual = vendor.PlaceOrder(product, 12, true, false);
      //var actual = vendor.PlaceOrder(product, 12,
      //                                sendCopy: false,
      //                                includeAddress: true);
      var actual = vendor.PlaceOrder(product, 12,
                                      Vendor.IncludeAddress.Yes,
                                      Vendor.SendCopy.No);

      // Assert
      Assert.AreEqual(expected.Success, actual.Success);
      Assert.AreEqual(expected.Message, actual.Message);
    }

    [TestMethod()]
    public void PlaceOrderRefTest()
    {
      // Arrange
      var vendor = new Vendor();
      var product = new Product(1, "Saw", "");

      var expected = true;
      var expectedOrderText = "Order from Acme";

      // Act
      string orderText = "test";
      bool actual = vendor.PlaceOrderRef(product, 12,
                                         ref orderText);

      // Assert
      Assert.AreEqual(expected, actual);
      Assert.AreEqual(expectedOrderText, orderText);
    }

    [TestMethod()]
    public void PlaceOrderOutTest()
    {
      // Arrange
      var vendor = new Vendor();
      var product = new Product(1, "Saw", "");

      var expected = true;
      var expectedOrderText = "Order from Acme";

      // Act
      string orderText;
      bool actual = vendor.PlaceOrderOut(product, 12,
                                         out orderText);

      // Assert
      Assert.AreEqual(expected, actual);
      Assert.AreEqual(expectedOrderText, orderText);
    }
  }

}
