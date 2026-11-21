namespace Dispatch
{
    partial class DispatchsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewDispath = new DataGridView();
            Origin = new DataGridViewTextBoxColumn();
            Destination = new DataGridViewTextBoxColumn();
            DepartureDate = new DataGridViewTextBoxColumn();
            driverNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverRegistrationNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            truckRegistrationNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            truckMakeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dispatchStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            originDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            destinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departureDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            displayDispatchModelBindingSource1 = new BindingSource(components);
            displayDispatchModelBindingSource = new BindingSource(components);
            dispatchModelBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDispath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)displayDispatchModelBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)displayDispatchModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dispatchModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDispath
            // 
            dataGridViewDispath.AutoGenerateColumns = false;
            dataGridViewDispath.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDispath.Columns.AddRange(new DataGridViewColumn[] { Origin, Destination, DepartureDate, driverNameDataGridViewTextBoxColumn, driverRegistrationNumberDataGridViewTextBoxColumn, truckRegistrationNumberDataGridViewTextBoxColumn, truckMakeDataGridViewTextBoxColumn, dispatchStatusDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, originDataGridViewTextBoxColumn, destinationDataGridViewTextBoxColumn, departureDateDataGridViewTextBoxColumn });
            dataGridViewDispath.DataSource = displayDispatchModelBindingSource1;
            dataGridViewDispath.Location = new Point(10, 61);
            dataGridViewDispath.Margin = new Padding(3, 2, 3, 2);
            dataGridViewDispath.Name = "dataGridViewDispath";
            dataGridViewDispath.RowHeadersWidth = 51;
            dataGridViewDispath.Size = new Size(1082, 442);
            dataGridViewDispath.TabIndex = 0;
            // 
            // Origin
            // 
            Origin.DataPropertyName = "Origin";
            Origin.HeaderText = "Origin";
            Origin.Name = "Origin";
            // 
            // Destination
            // 
            Destination.DataPropertyName = "Destination";
            Destination.HeaderText = "Destination";
            Destination.Name = "Destination";
            // 
            // DepartureDate
            // 
            DepartureDate.DataPropertyName = "DepartureDate";
            DepartureDate.HeaderText = "DepartureDate";
            DepartureDate.Name = "DepartureDate";
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            driverNameDataGridViewTextBoxColumn.DataPropertyName = "DriverName";
            driverNameDataGridViewTextBoxColumn.HeaderText = "DriverName";
            driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            // 
            // driverRegistrationNumberDataGridViewTextBoxColumn
            // 
            driverRegistrationNumberDataGridViewTextBoxColumn.DataPropertyName = "DriverRegistrationNumber";
            driverRegistrationNumberDataGridViewTextBoxColumn.HeaderText = "DriverRegistrationNumber";
            driverRegistrationNumberDataGridViewTextBoxColumn.Name = "driverRegistrationNumberDataGridViewTextBoxColumn";
            // 
            // truckRegistrationNumberDataGridViewTextBoxColumn
            // 
            truckRegistrationNumberDataGridViewTextBoxColumn.DataPropertyName = "TruckRegistrationNumber";
            truckRegistrationNumberDataGridViewTextBoxColumn.HeaderText = "TruckRegistrationNumber";
            truckRegistrationNumberDataGridViewTextBoxColumn.Name = "truckRegistrationNumberDataGridViewTextBoxColumn";
            // 
            // truckMakeDataGridViewTextBoxColumn
            // 
            truckMakeDataGridViewTextBoxColumn.DataPropertyName = "TruckMake";
            truckMakeDataGridViewTextBoxColumn.HeaderText = "TruckMake";
            truckMakeDataGridViewTextBoxColumn.Name = "truckMakeDataGridViewTextBoxColumn";
            // 
            // dispatchStatusDataGridViewTextBoxColumn
            // 
            dispatchStatusDataGridViewTextBoxColumn.DataPropertyName = "DispatchStatus";
            dispatchStatusDataGridViewTextBoxColumn.HeaderText = "DispatchStatus";
            dispatchStatusDataGridViewTextBoxColumn.Name = "dispatchStatusDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // originDataGridViewTextBoxColumn
            // 
            originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            originDataGridViewTextBoxColumn.HeaderText = "Origin";
            originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            // 
            // displayDispatchModelBindingSource1
            // 
            displayDispatchModelBindingSource1.DataSource = typeof(DisplayDispatchModel);
            // 
            // displayDispatchModelBindingSource
            // 
            displayDispatchModelBindingSource.DataSource = typeof(DisplayDispatchModel);
            // 
            // dispatchModelBindingSource
            // 
            dispatchModelBindingSource.AllowNew = false;
            dispatchModelBindingSource.DataSource = typeof(DispatchModel);
            // 
            // button1
            // 
            button1.Location = new Point(976, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 1;
            button1.Text = "Add dispatch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Location = new Point(12, 17);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 2;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DispatchsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 512);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewDispath);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DispatchsForm";
            Text = "Dispatchs";
            Load += Dispatchs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDispath).EndInit();
            ((System.ComponentModel.ISupportInitialize)displayDispatchModelBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)displayDispatchModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dispatchModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private BindingSource dispatchModelBindingSource;
        public DataGridView dataGridViewDispath;
        private BindingSource displayDispatchModelBindingSource;
        private BindingSource displayDispatchModelBindingSource1;
        private DataGridViewTextBoxColumn Origin;
        private DataGridViewTextBoxColumn Destination;
        private DataGridViewTextBoxColumn DepartureDate;
        private DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn driverRegistrationNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn truckRegistrationNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn truckMakeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dispatchStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private Button button2;
    }
}