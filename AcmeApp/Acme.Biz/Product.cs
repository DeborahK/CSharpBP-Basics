using Acme.Common;
using System.Numerics;

namespace Acme.Biz;

/// <summary>
/// Manages products carried in inventory.
/// </summary>
public class Product
{
  public const double pi = 3.14;
  public const int red = 0xFF0000;
  public const double inchesPerMeter = 39.37;

  public readonly decimal MinimumPrice;

  public Product()
  {
    Category = "Tools";
    MinimumPrice = .96m;
    InventoryCount = GetInventoryCount();
    ProductVendor = new Vendor();
  }

  public Product(int productId,
              string productName,
              string description) : this()
  {
    ProductId = productId;
    ProductName = productName;
    Description = description;

    if (ProductName.StartsWith("Bulk"))
    {
      MinimumPrice = 9.99m;
    }
    Console.WriteLine("Product instance has a name: " + ProductName);
  }

  #region Properties
  public decimal Cost { get; set; }
  internal string Category { get; set; }
  public int SequenceNumber { get; } = 1;

  public Vendor? CurrentVendor { get; set; }

  public int InventoryCount { get; }

  private static int GetInventoryCount()
  {
    return 25;
  }

  private string description = "";

  public string Description
  {
    get { return description; }
    set { description = value; }
  }

  private int productId;

  public int ProductId
  {
    get { return productId; }
    set { productId = value; }
  }

  private string productName = "";
  public string ProductName
  {
    get
    {
      var formattedValue = productName.Trim();
      return formattedValue;
    }
    set
    {
      if (value.Length < 3)
      {
        ValidationMessage = "Product Name must be at least 3 characters";
      }
      else if (value.Length > 20)
      {
        ValidationMessage = "Product Name cannot be more than 20 characters";

      }
      else
      {
        productName = value;
      }
    }
  }

  public Vendor ProductVendor { get; set; } = new Vendor();

  public string? ValidationMessage { get; private set; }

  #endregion

  /// <summary>
  /// Calculates the suggested retail price
  /// </summary>
  /// <param name="markupPercent">Percent used to mark up the cost.</param>
  /// <returns></returns>
  //public decimal CalculateSuggestedPrice(decimal markupPercent)
  //{
  //    return this.Cost + (this.Cost * markupPercent / 100);
  //}

  public decimal CalculateSuggestedPrice(decimal markupPercent) =>
                      this.Cost + (this.Cost * markupPercent / 100);

  public string SayHello()
  {
    var emailGreeting = $"Hello {ProductName} ({ProductId}): {Description}";
    LoggingService.LogAction(emailGreeting);

    return emailGreeting;
  }

  public string? LastName { get; set; }
  public string? FirstName { get; set; }
  public string? FullName => FirstName + " " + LastName;

  //public string FullName
  //{
  //    get { return FirstName + " " + LastName; }
  //}


  public int Quantity { get; set; }
  public int Price { get; set; }
  public int ItemTotal => Quantity * Price;

  //public int ItemTotal
  //{
  //    get { return Quantity * Price; }
  //}



  public string? VendorName => ProductVendor?.CompanyName;

  //public string VendorName
  //{
  //    get { return ProductVendor?.CompanyName; }
  //}

  public override string ToString()
  {
    return this.ProductName + " (" + this.productId + ")";
  }
}