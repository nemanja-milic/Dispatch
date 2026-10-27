using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatch
{
    public partial class AddDriverForm : Form
    {
        public AddDriverForm()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("First name must not be empty");
                return;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Last name must not be empty");
                return;
            }

            if (string.IsNullOrEmpty(txtLicenseNumber.Text))
            {
                MessageBox.Show("License number must not be empty");
                return;
            }

            await AddDriver();

        }

        private async Task AddDriver()
        {
            CreateDriverModel newDriver = new CreateDriverModel(txtFirstName.Text, txtLastName.Text, txtLicenseNumber.Text);

            DriverRepository driverRepository = new DriverRepository();

            try
            {
                await driverRepository.AddDriver(newDriver);
                MessageBox.Show("Driver added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
