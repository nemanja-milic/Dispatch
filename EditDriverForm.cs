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

        List<DriverStatus> DriverStatuses = new List<DriverStatus>();

        List<RadioButton> RadioButtons = new List<RadioButton>();
        public EditDriverForm(DriverModel driver)
        {
            InitializeComponent();
            SelectedDriver = driver;
        }

        private async void EditDriverForm_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = SelectedDriver.FirstName;
            txtLastName.Text = SelectedDriver.LastName;
            txtEditLicenseNumber.Text = SelectedDriver.LicenseNumber;
            
            DriverRepository driverRepository = new DriverRepository();

            List<DriverStatus> driverStatuses = await driverRepository.FetchDriverStatus();

            LoadRadioBtns(driverStatuses);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            DriverRepository driverRepository = new DriverRepository();

            EditDriverModel driver = new EditDriverModel(SelectedDriver.Id, txtFirstName.Text, txtLastName.Text, txtEditLicenseNumber.Text, WhichStatusIsSelected());

            try
            {
                await driverRepository.EditDriver(driver);
                MessageBox.Show("Successfully edited driver");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void LoadRadioBtns(List<DriverStatus> driverStatuses)
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
                RadioButtons.Add(btn);

                btn.Name = "txtRdn" + status.Id;
                btn.AutoSize = true;
                btn.Text = (status.Name);
                btn.Tag = status.Id;
                if (SelectedDriver.StatusId == status.Id) btn.Checked = true;

                flowLayoutStatusPanel.Controls.Add(btn);
            }
        }

        private int WhichStatusIsSelected()
        {
            foreach(RadioButton btn in RadioButtons)
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
