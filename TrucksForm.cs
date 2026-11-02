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
    public partial class TrucksForm : Form
    {
        public TrucksForm()
        {
            InitializeComponent();
        }

        private async void TrucksForm_Load(object sender, EventArgs e)
        {
            List<TruckModel> trucks = null;
            try
            {
                TruckRepository truckRepository = new TruckRepository();
                trucks = await truckRepository.AllTrucks();
                DisplayTrucks(trucks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Trucks " + ex);
            }
        }

        private void DisplayTrucks(List<TruckModel> trucks)
        {
            foreach (TruckModel truck in trucks)
            {
                GroupBox truckGroupBox = new GroupBox();
                Button btnEdit = new Button();
                btnEdit.Text = "Edit";
                btnEdit.Click += EditTruck;
                btnEdit.Tag = truck;

                truckGroupBox.Height = 210;
                truckGroupBox.Text = $"\n" +
                    $"ID: {truck.Id}\n" +
                    $"Registration number: {truck.RegistrationNumber}\n" +
                    $"Make: {truck.Make}\n" +
                    $"Model: {truck.Model}\n" +
                    $"Year: {truck.Year}\n" +
                    $"Current Mileage Miles: {truck.CurrentMileageMiles}\n" +
                    $"Available: {truck.IsAvailable}\n"
                    ;
                truckGroupBox.Controls.Add(btnEdit);
                flowLayoutTruckPanel.Controls.Add(truckGroupBox);
            }
        }

        private void EditTruck(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button == null)
            {
                MessageBox.Show("Unable to edit truck");
                return;
            }
            TruckModel truck = (TruckModel)button.Tag;
            EditTruckForm editForm = new EditTruckForm(truck);
            editForm.ShowDialog();
        }

        private void addTruck_Click(object sender, EventArgs e)
        {
            AddTruckForm addForm = new AddTruckForm();
            addForm.ShowDialog();
        }
    }
}
