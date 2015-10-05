using Acme.Biz;
using Acme.Wpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            this.NavigationService.Navigate();
            var vm = (VendorDetailViewModel)((Button)e.OriginalSource).DataContext;
            if (vm != null)
            {
                var vendorRepository = new VendorRepository();
                vm.currentVendor = vendorRepository.Retrieve(vm.currentVendor.VendorId);
            }
        }
    }
}
