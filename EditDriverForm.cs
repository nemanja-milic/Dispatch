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
    public partial class EditDriverForm : Form
    {
        DriverModel SelectedDriver;
        public EditDriverForm(DriverModel driver)
        {
            InitializeComponent();
            SelectedDriver = driver;
        }

        private void EditDriverForm_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = SelectedDriver.FirstName;
            txtLastName.Text = SelectedDriver.LastName;
            txtEditLicenseNumber.Text = SelectedDriver.LicenseNumber;
            Console.WriteLine(SelectedDriver.Id);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            DriverRepository driverRepository = new DriverRepository();

            MessageBox.Show("Editing is not completed yet");

            //DriverModel driver = new DriverModel(SelectedDriver.Id, txtFirstName.Text, txtLastName.Text, txtEditLicenseNumber.Text);

            //try
            //{
            //    await driverRepository.EditDriver(driver);
            //    MessageBox.Show("Successfully edited driver");
            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
