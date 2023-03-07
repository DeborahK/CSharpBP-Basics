using Acme.Biz;

namespace Acme.Wpf.ViewModels;

public class VendorDetailViewModel
{
  public Vendor? CurrentVendor { get; set; }

  VendorRepository VendorRepository = new VendorRepository();

  public VendorDetailViewModel()
  {
    LoadData();
  }

  public void LoadData()
  {
    CurrentVendor = VendorRepository.Retrieve(1);
  }
}
