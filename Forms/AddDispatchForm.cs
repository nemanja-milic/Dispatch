using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Dispatch.Enums;
using Dispatch.Models;
using Dispatch.Repositories;

namespace Dispatch
{
    public partial class AddDispatchForm : Form
    {
        List<DispatchStatus> DispatchStatuses = new List<DispatchStatus>();
        public AddDispatchForm()
        {
            InitializeComponent();
        }

        private async void DispatchForm_Load(object sender, EventArgs e)
        {
            await LoadDrivers();
            await LoadTrucks();
            await LoadStatuses();
        }

        private async Task LoadTrucks()
        {
            List<TruckModel> trucks = new List<TruckModel>();
            try
            {
                TruckRepository truckRepository = new TruckRepository();
                trucks = await truckRepository.AllTrucks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load trucks");
                MessageBox.Show(ex.Message);
            }
            dataGridViewTrucks.DataSource = trucks;
        }

        private async Task LoadDrivers()
        {
            List<DriverModel> drivers = new List<DriverModel>();
            try
            {
                DriverRepository driverRepository = new DriverRepository();
                drivers = await driverRepository.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load drivers");
                MessageBox.Show(ex.Message);
            }
            dataGridViewDrivers.DataSource = drivers;
        }

        private async Task LoadStatuses()
        {
            try
            {
                DispatchRepository dispatchRepository = new DispatchRepository();
                DispatchStatuses = await dispatchRepository.FetchDispatchStatuses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load drivers");
                MessageBox.Show(ex.Message);
            }
        }

        private int FindIdOfDispatchStatus(string key)
        {
            foreach(var status in DispatchStatuses)
            {
                if(status.Name == key)
                {
                    return status.Id;
                }
            } 
            MessageBox.Show("Didn`t find the key for dispatch status");
            return 0;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            DriverModel selectedDriver =
                    (DriverModel)dataGridViewDrivers.SelectedRows[0].DataBoundItem;


            TruckModel selectedTruck =
                    (TruckModel)dataGridViewTrucks.SelectedRows[0].DataBoundItem;

            DispatchModel model = new DispatchModel(0, txtOrigin.Text, txtDesitnation.Text, dataTimeDeparture.Value, selectedDriver.Id, selectedTruck.Id, FindIdOfDispatchStatus("Planned"));

            DispatchRepository dispatchRepository = new DispatchRepository();
            
            try
            {
                await dispatchRepository.Insert(model);
                MessageBox.Show("Successfully added new dispatch");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Failed to add dispatch");
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtOrigin.Text))
            {
                MessageBox.Show("Please eneter value for the Origin");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDesitnation.Text))
            {
                MessageBox.Show("Please eneter value for the Destination");
                return false;
            }


            DateTime departure = dataTimeDeparture.Value;

            if (DateTime.Compare(departure, DateTime.Now.Date) < 0)
            {
                MessageBox.Show("Minimum value is today");
                return false;
            }

            if (dataGridViewDrivers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select driver");
                return false;
            }

            if (dataGridViewTrucks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select truck");
                return false;
            }

            if (dataGridViewDrivers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select driver");
                return false;
            }

            if (dataGridViewTrucks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select truck");
                return false;
            }

            return true;
        }
    }
}
