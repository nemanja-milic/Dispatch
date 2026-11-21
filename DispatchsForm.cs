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
    public partial class DispatchsForm : Form
    {
        public DispatchsForm()
        {
            InitializeComponent();
        }

        private async void Dispatchs_Load(object sender, EventArgs e)
        {
            await FetchDispatchs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDispatchForm addDispatchForm = new AddDispatchForm();
            addDispatchForm.ShowDialog();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await FetchDispatchs();
        }

        private async Task FetchDispatchs()
        {
            DispatchRepository dispatchRepository = new DispatchRepository();
            try
            {
                List<DisplayDispatchModel> dispatchModels = await dispatchRepository.GetAllDispatch();
                dataGridViewDispath.DataSource = dispatchModels;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dispatchs");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
