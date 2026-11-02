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
    public partial class EditTruckForm : Form
    {
        TruckModel SelectedTruck;
        public EditTruckForm(TruckModel truckModel)
        {
            SelectedTruck = truckModel;
            InitializeComponent();
            txtMiles.Text = "" + truckModel.CurrentMileageMiles;
            txtRegistrationNumber.Text = truckModel.RegistrationNumber;
            if (truckModel.IsAvailable)
            {
                rdnYes.Checked = true;
            }
            else rdnNo.Checked = true;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            TruckRepository truckRepository = new TruckRepository();

            int miles = 0;
            if(!int.TryParse(txtMiles.Text, out miles))
            {
                MessageBox.Show("Please enter correct value for miles");
            }
            
            if(string.IsNullOrEmpty(txtRegistrationNumber.Text))
            {
                MessageBox.Show("Please enter a correct calue for registration number");
            }

            SelectedTruck.IsAvailable = SelectedStatus();

            try
            {
                int res = await truckRepository.EditTruck(SelectedTruck);
                if (res == 0) throw new Exception("Editing truck failed");
                MessageBox.Show("Successfully edited truck");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to edit truck" +  ex);
            }

        }

        private bool SelectedStatus()
        {
            if(rdnYes.Checked) return true;
            return false;
        }

    }
}
