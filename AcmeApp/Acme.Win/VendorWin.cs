using Acme.Biz;

namespace Acme.Win
{
  public partial class VendorWin : Form
  {
    Vendor? currentVendor;
    VendorRepository? vendorRepository;

    public VendorWin()
    {
      InitializeComponent();
    }

    private void VendorWin_Load(object sender, EventArgs e)
    {
      LoadData();
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      // Update the properties
      if (currentVendor != null && vendorRepository != null)
      {
        currentVendor.CompanyName = this.CompanyNameTextBox.Text;
        currentVendor.Email = this.EmailTextBox.Text;
        vendorRepository.Save(currentVendor);
      }
    }

    private void CancelChangesButton_Click(object sender, EventArgs e)
    {
      LoadData();
    }

    private void LoadData()
    {
      vendorRepository = new VendorRepository();
      currentVendor = vendorRepository.Retrieve(1);

      // Populate the form
      this.CompanyNameTextBox.Text = currentVendor.CompanyName;
      this.EmailTextBox.Text = currentVendor.Email;
    }


  }
}