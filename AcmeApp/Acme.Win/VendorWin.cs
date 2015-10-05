using Acme.Biz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acme.Win
{
    public partial class VendorWin : Form
    {
        Vendor currentVendor;
        VendorRepository vendorRepository;

        public VendorWin()
        {
            InitializeComponent();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Update the properties
            currentVendor.CompanyName = this.CompanyNameTextBox.Text;
            currentVendor.Email = this.EmailTextBox.Text;
            vendorRepository.Save(currentVendor);
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
