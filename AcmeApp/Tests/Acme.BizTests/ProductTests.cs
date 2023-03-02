namespace Acme.Biz.Tests
{
  [TestClass()]
  public class ProductTests
  {
    [TestMethod()]
    public void Category_DefaultValue()
    {
      //Arrange
      var currentProduct = new Product();

      var expected = "Tools";

      //Act
      var actual = currentProduct.Category;

      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Category_NewValue()
    {
      //Arrange
      var currentProduct = new Product();
      currentProduct.Category = "Garden";

      var expected = "Garden";

      //Act
      var actual = currentProduct.Category;

      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Sequence_DefaultValue()
    {
      //Arrange
      var currentProduct = new Product();

      var expected = 1;

      //Act
      var actual = currentProduct.SequenceNumber;

      //Assert
      Assert.AreEqual(expected, actual);
    }

    //[TestMethod()]
    //public void Sequence_NewValue()
    //{
    //    //Arrange
    //    var currentProduct = new Product();
    //    currentProduct.SequenceNumber = 5;

    //    var expected = 1;

    //    //Act
    //    var actual = currentProduct.SequenceNumber;

    //    //Assert
    //    Assert.AreEqual(expected, actual);
    //}

    [TestMethod()]
    public void ProductName_Format()
    {
      //Arrange
      var currentProduct = new Product();
      currentProduct.ProductName = "  Steel Hammer  ";

      var expected = "Steel Hammer";

      //Act
      var actual = currentProduct.ProductName;

      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void ProductName_TooShort()
    {
      //Arrange
      var currentProduct = new Product();
      currentProduct.ProductName = "aw";

      string expected = "";
      string expectedMessage = "Product Name must be at least 3 characters";

      //Act
      var actual = currentProduct.ProductName;
      var actualMessage = currentProduct.ValidationMessage;

      //Assert
      Assert.AreEqual(expected, actual);
      Assert.AreEqual(expectedMessage, actualMessage);
    }

    [TestMethod()]
    public void ProductName_TooLong()
    {
      //Arrange
      var currentProduct = new Product();
      currentProduct.ProductName = "Steel Bladed Hand Saw";

      string expected = "";
      string expectedMessage = "Product Name cannot be more than 20 characters";

      //Act
      var actual = currentProduct.ProductName;
      var actualMessage = currentProduct.ValidationMessage;

      //Assert
      Assert.AreEqual(expected, actual);
      Assert.AreEqual(expectedMessage, actualMessage);
    }

    [TestMethod()]
    public void ProductName_JustRight()
    {
      //Arrange
      var currentProduct = new Product();
      currentProduct.ProductName = "Saw";

      string expected = "Saw";
      string? expectedMessage = null;

      //Act
      var actual = currentProduct.ProductName;
      var actualMessage = currentProduct.ValidationMessage;

      //Assert
      Assert.AreEqual(expected, actual);
      Assert.AreEqual(expectedMessage, actualMessage);
    }

    [TestMethod()]
    public void SayHelloTest()
    {
      //Arrange
      var currentProduct = new Product();
      currentProduct.ProductName = "Saw";
      currentProduct.ProductId = 1;
      currentProduct.Description =
             "15-inch steel blade hand saw";
      currentProduct.ProductVendor.CompanyName = "ABC Corp";

      var expected = "Hello Saw (1): 15-inch steel blade hand saw";

      //Act
      var actual = currentProduct.SayHello();

      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void SayHello_ParameterizedConstructor()
    {
      //Arrange
      var currentProduct = new Product(1, "Saw",
                 "15-inch steel blade hand saw");

      var expected = "Hello Saw (1): 15-inch steel blade hand saw";

      //Act
      var actual = currentProduct.SayHello();

      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void SayHello_ObjectInitializer()
    {
      //Arrange
      var currentProduct = new Product
      {
        ProductId = 1,
        ProductName = "Saw",
        Description = "15-inch steel blade hand saw"
      };

      var expected = "Hello Saw (1): 15-inch steel blade hand saw";

      //Act
      var actual = currentProduct.SayHello();

      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Product_Null()
    {
      //Arrange
      Product? currentProduct = null;

      var companyName = currentProduct?.ProductVendor?.CompanyName;

      string? expected = null;

      //Act
      var actual = companyName;

      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void ConvertMetersToInchesTest()
    {
      // Arrange
      var expected = 78.74;

      // Act
      var actual = 2 * Product.inchesPerMeter;

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MinimumPriceTest_Default()
    {
      // Arrange
      var currentProduct = new Product();
      var expected = .96m;

      // Act
      var actual = currentProduct.MinimumPrice;

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MinimumPriceTest_Bulk()
    {
      // Arrange
      var currentProduct = new Product(1, "Bulk Tools", "");
      var expected = 9.99m;

      // Act
      var actual = currentProduct.MinimumPrice;

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void ToStringTest()
    {
      // Arrange
      var currentProduct = new Product(1, "Saw", "");
      var expected = "Saw (1)";

      // Act
      var actual = currentProduct.ToString();

      // Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void CalculateSuggestedPriceTest()
    {
      // Arrange
      var currentProduct = new Product(1, "Saw", "");
      currentProduct.Cost = 50m;
      var expected = 55m;

      // Act
      var actual = currentProduct.CalculateSuggestedPrice(10m);

      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}