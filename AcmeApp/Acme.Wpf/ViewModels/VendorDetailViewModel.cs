using Acme.Biz;

namespace Acme.Wpf.ViewModels
{
    public class VendorDetailViewModel
    {
        public Vendor currentVendor { get; set; }

        VendorRepository vendorRepository = new VendorRepository();

        public VendorDetailViewModel()
        {
            LoadData();
        }

        public void LoadData()
        {
            currentVendor = vendorRepository.Retrieve(1);
        }
    }
}
