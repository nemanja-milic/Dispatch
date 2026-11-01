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
        List<DriverStatus> DriverStatuses = new List<DriverStatus>();

        List<RadioButton> RadioButtonsStatus = new List<RadioButton>();
        public AddDriverForm()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
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

            if(WhichDriverStatus() == 0)
            {
                MessageBox.Show("Please select Driver status");
                return;
            }

            await AddDriver();

        }

        private async Task AddDriver()
        {
            CreateDriverModel newDriver = new CreateDriverModel(txtFirstName.Text, txtLastName.Text, txtLicenseNumber.Text, WhichDriverStatus());

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

        private async void AddDriverForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                DriverRepository driverRepository = new DriverRepository();
                DriverStatuses = await driverRepository.FetchDriverStatus();
            }
            catch
            {
                MessageBox.Show("Failed to load Driver Status");
            }
            
            foreach (DriverStatus status in DriverStatuses)
            {
                RadioButton btn = new RadioButton();
                RadioButtonsStatus.Add(btn);

                btn.Name = "txtRdn" + status.Id;
                btn.AutoSize = true;
                btn.Text = (status.Name);
                btn.Tag = status.Id;


                flowLayoutDriverStatus.Controls.Add(btn);
            }
        }

        private int WhichDriverStatus()
        {
            foreach (RadioButton btn in RadioButtonsStatus) 
            {
                if(btn.Checked)
                {
                    return (int)btn.Tag;
                }
            }
            return 0;
        }
    }
}
