using Acme.Common;

namespace Acme.Biz
{
  public class Vendor
  {
    public int VendorId { get; set; }
    public string? CompanyName { get; set; }
    public string? Email { get; set; }

    // Return a default vendor
    public Vendor() : this(1, "Acme Supply", "acmeSupply@gmail.com")
    { }


    public Vendor(int vendorId, string companyName, string email)
    {
      VendorId = vendorId;
      CompanyName = companyName;
      Email = email;
    }

    /// <summary>
    /// Sample method.
    /// </summary>
    /// <returns></returns>
    public string SayHello()
    {
      return ($"Hello {this.CompanyName}").Trim();
    }

    ///// <summary>
    ///// Sends a product order to the vendor.
    ///// </summary>
    ///// <param name="product">Product to order.</param>
    ///// <param name="quantity">Quantity of the product to order</param>
    ///// <returns></returns>
    //public OperationResult PlaceOrder(Product product, int quantity)
    //{
    //    return PlaceOrder(product, quantity, null, null);
    //}

    ///// <summary>
    ///// Sends a product order to the vendor.
    ///// </summary>
    ///// <param name="product">Product to order.</param>
    ///// <param name="quantity">Quantity of the product to order</param>
    ///// <param name="deliverBy">Requested delivery by date</param>
    ///// <returns></returns>
    //public OperationResult PlaceOrder(Product product, int quantity, DateTimeOffset? deliverBy)
    //{
    //    return PlaceOrder(product, quantity, deliverBy, null);
    //}

    /// <summary>
    /// Sends a product order to the vendor.
    /// </summary>
    /// <param name="product">Product to order.</param>
    /// <param name="quantity">Quantity of the product to order</param>
    /// <param name="deliverBy">Requested delivery by date</param>
    /// <param name="instructions">Delivery instructions</param>
    /// <returns></returns>
    public OperationResult PlaceOrder(Product? product, int quantity,
                                        DateTimeOffset? deliverBy = null,
                                        string instructions = "standard delivery")
    {
      // Guard clauses to check the parameters
      if (product == null) throw new ArgumentNullException(nameof(product));
      if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
      if (deliverBy <= DateTimeOffset.Now) throw new ArgumentOutOfRangeException(nameof(deliverBy));

      var productIdentifier = product.Category + "-" + product.SequenceNumber;
      var orderText = "Order from Acme, Inc" + System.Environment.NewLine +
                      "Product: " + productIdentifier + System.Environment.NewLine +
                      "Quantity: " + quantity;
      if (deliverBy.HasValue)
      {
        orderText += System.Environment.NewLine +
                    "Deliver By: " + deliverBy.Value.ToString("d");
      }
      if (!string.IsNullOrWhiteSpace(instructions))
      {
        orderText += System.Environment.NewLine +
                    "Instructions: " + instructions;
      }

      var success = false;
      if (this.Email != null)
      {
        var emailService = new EmailService();
        success = emailService.SendMessage("New Order", orderText, Email);
      }

      var operationResult = new OperationResult(success, orderText);
      return operationResult;

    }

    ///// <summary>
    ///// Sends a product order to the vendor.
    ///// </summary>
    ///// <param name="product">Product to order.</param>
    ///// <param name="quantity">Quantity of the product to order.</param>
    ///// <param name="includeAddress">True to include the shipping address in the order.</param>
    ///// <param name="sendCopy">True to send a copy of the email to the current user.</param>
    ///// <returns>Success flag and order text</returns>
    //public OperationResult PlaceOrder(Product product, int quantity, 
    //                                    bool includeAddress, bool sendCopy)
    //{
    //    var orderText = "Test";
    //    if (includeAddress) orderText += " With Address";
    //    if (sendCopy) orderText += " With Copy";

    //    var operationResult = new OperationResult(true, orderText);
    //    return operationResult;
    //}

    public enum IncludeAddress { Yes, No };
    public enum SendCopy { Yes, No };

    /// <summary>
    /// Sends a product order to the vendor.
    /// </summary>
    /// <param name="product">Product to order.</param>
    /// <param name="quantity">Quantity of the product to order.</param>
    /// <param name="includeAddress">True to include the shipping address in the order.</param>
    /// <param name="sendCopy">True to send a copy of the email to the current user.</param>
    /// <returns>Success flag and order text</returns>
    public OperationResult PlaceOrder(Product product, int quantity,
                                      IncludeAddress includeAddress,
                                      SendCopy sendCopy)
    {
      var orderText = "Test";
      if (includeAddress == IncludeAddress.Yes) orderText += " With Address";
      if (sendCopy == SendCopy.Yes) orderText += " With Copy";

      var operationResult = new OperationResult(true, orderText);
      return operationResult;
    }

    public bool PlaceOrderRef(Product product, int quantity,
                            ref string orderText)
    {
      var success = true;
      quantity = 42;
      orderText = "Order from Acme";

      return success;
    }


    public bool PlaceOrderOut(Product product, int quantity,
                              out string orderText)
    {
      var success = true;
      quantity = 42;
      orderText = "Order from Acme";

      return success;
    }

  }
}
