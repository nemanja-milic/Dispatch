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



            foreach (DriverModel driver in drivers)
            {
                GroupBox driverBox = new GroupBox();

                driverBox.Text =
                    $" Name  {driver.Name} \n" +
                    $"Last name {driver.LastName}\n" +
                    $" License Number {driver.LicenseNumber} ";

                flowLayoutDrivers.Controls.Add(driverBox);
                
            }
        }
    }
}
