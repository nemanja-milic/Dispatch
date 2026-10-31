using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Dispatch
{
    public partial class DriversForm : Form
    {
        DriverRepository DriverRepository;
        public DriversForm()
        {
            InitializeComponent();
        }

        private async void DriversForm_Load(object sender, EventArgs e)
        {
            DriverRepository = new DriverRepository();

            List<DriverModel> drivers = await DriverRepository.GetAll();

            DisplayDrivers(drivers);

        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            List<DriverModel> drivers = await DriverRepository.GetAll();
            DisplayDrivers(drivers);
        }

        private void DisplayDrivers(List<DriverModel> drivers)
        {
            flowLayoutDrivers.Controls.Clear();
            foreach (DriverModel driver in drivers)
            {
                GroupBox driverBox = new GroupBox();

                Button btnEdit = new Button();
                btnEdit.Text = "Edit Driver";
                btnEdit.Tag = driver;
                btnEdit.Click += EditDriver;

                driverBox.Controls.Add(btnEdit);    
                
                driverBox.Text =
                    "\n\n"+
                    $" Name  {driver.FirstName} \n" +
                    $"Last name {driver.LastName}\n" +
                    $" License Number {driver.LicenseNumber} ";
                    

                flowLayoutDrivers.Controls.Add(driverBox);
            }
        }

        private void btnOpenDriverForm_Click(object sender, EventArgs e)
        {
            AddDriverForm addDriverForm = new AddDriverForm();
            addDriverForm.ShowDialog();
        }


        private async void EditDriver(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(btn.Tag == null || !(btn.Tag is DriverModel))
            {
                MessageBox.Show("Unable to edit driver");
            }

            DriverModel driver = (DriverModel)btn.Tag;

            EditDriverForm editDriverForm = new EditDriverForm(driver);
            editDriverForm.ShowDialog();

            

            //DriverModel? driver = (DriverModel)btn.Tag;

            //DriverRepository driverRepository = new DriverRepository();

            //try
            //{
            //    await driverRepository.EditDriver(driver);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Unable to edit driver, error message "+ ex);
            //}

        }
    }
}
