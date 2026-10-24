namespace Dispatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            DatabaseConnection DBconnection = new DatabaseConnection();
            await DBconnection.Connect();
            await DBconnection.SQLConnection.CloseAsync();
        }

        private void btnShowDriversForm_Click(object sender, EventArgs e)
        {
            DriversForm driversForm = new DriversForm();
            driversForm.ShowDialog();
        }
    }
}
