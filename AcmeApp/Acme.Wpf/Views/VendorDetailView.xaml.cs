using Acme.Biz;
using Acme.Wpf.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Acme.Wpf.Views
{
    /// <summary>
    /// Interaction logic for VendorDetailView.xaml
    /// </summary>
    public partial class VendorDetailView : Page
    {
        public VendorDetailView()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var vm = (VendorDetailViewModel)((Button)e.OriginalSource).DataContext;
            if (vm != null)
            {
                var vendorRepository = new VendorRepository();
                vendorRepository.Save(vm.currentVendor);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Refresh();
        }
    }
}
