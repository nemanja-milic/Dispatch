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
    public partial class AddTruckForm : Form
    {
        public AddTruckForm()
        {
            InitializeComponent();
        }

        private void AddTruckForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtRegistrationNumber.Text))
            {
                MessageBox.Show("Please enter a value for registration number");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMake.Text))
            {
                MessageBox.Show("Please enter a value for make");
                return ;
            }

            if(string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Please enter a value for model");
                return ;
            }

            int year = 0;

            if(!int.TryParse(txtYear.Text, out year))
            {
                MessageBox.Show("Incorrect value for year");
                return;
            }

            int miles = 0;

            if (!int.TryParse(txtMiles.Text, out miles))
            {
                MessageBox.Show("Incorrect value for miles");
                return;
            }

            bool isAvailable = false;

            if (rbnNo.Checked) isAvailable = false;
            if(rbnYes.Checked) isAvailable = true;

            TruckRepository truckRepository = new TruckRepository();

            TruckModel truckModel = new TruckModel(0, txtRegistrationNumber.Text, txtMake.Text, txtModel.Text, year, miles, isAvailable);

            try 
            {
                int res = await truckRepository.AddTruck(truckModel);
                if (res == 1)
                {
                    MessageBox.Show("Successully added truck");
                }
            }
            catch
            (Exception ex)
            {
                MessageBox.Show("An error occured\n " + ex);
            }
        }
    }
}
