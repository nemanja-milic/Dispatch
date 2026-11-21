using Dispatch.Models;

namespace Dispatch
{
    partial class AddDispatchForm
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
            txtOrigin = new TextBox();
            txtDesitnation = new TextBox();
            label1 = new Label();
            lblOrigin = new Label();
            label3 = new Label();
            dataTimeDeparture = new DateTimePicker();
            label2 = new Label();
            dataGridViewDrivers = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            licenseNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverModelBindingSource = new BindingSource(components);
            dataGridViewTrucks = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            registrationNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            makeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currentMileageMilesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isAvailableDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            truckModelBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)driverModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrucks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)truckModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(52, 96);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(358, 23);
            txtOrigin.TabIndex = 0;
            // 
            // txtDesitnation
            // 
            txtDesitnation.Location = new Point(545, 96);
            txtDesitnation.Name = "txtDesitnation";
            txtDesitnation.Size = new Size(358, 23);
            txtDesitnation.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 99);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "To";
            // 
            // lblOrigin
            // 
            lblOrigin.AutoSize = true;
            lblOrigin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigin.Location = new Point(52, 63);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new Size(54, 21);
            lblOrigin.TabIndex = 3;
            lblOrigin.Text = "Origin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(545, 63);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 4;
            label3.Text = "Destination";
            // 
            // dataTimeDeparture
            // 
            dataTimeDeparture.Location = new Point(52, 159);
            dataTimeDeparture.Margin = new Padding(3, 2, 3, 2);
            dataTimeDeparture.Name = "dataTimeDeparture";
            dataTimeDeparture.Size = new Size(219, 23);
            dataTimeDeparture.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 130);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 6;
            label2.Text = "Departure date";
            // 
            // dataGridViewDrivers
            // 
            dataGridViewDrivers.AutoGenerateColumns = false;
            dataGridViewDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrivers.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, statusNameDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, statusIdDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, licenseNumberDataGridViewTextBoxColumn });
            dataGridViewDrivers.DataSource = driverModelBindingSource;
            dataGridViewDrivers.Location = new Point(52, 199);
            dataGridViewDrivers.Margin = new Padding(3, 2, 3, 2);
            dataGridViewDrivers.Name = "dataGridViewDrivers";
            dataGridViewDrivers.ReadOnly = true;
            dataGridViewDrivers.RowHeadersWidth = 51;
            dataGridViewDrivers.Size = new Size(704, 141);
            dataGridViewDrivers.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusNameDataGridViewTextBoxColumn
            // 
            statusNameDataGridViewTextBoxColumn.DataPropertyName = "StatusName";
            statusNameDataGridViewTextBoxColumn.HeaderText = "StatusName";
            statusNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusNameDataGridViewTextBoxColumn.Name = "statusNameDataGridViewTextBoxColumn";
            statusNameDataGridViewTextBoxColumn.ReadOnly = true;
            statusNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusIdDataGridViewTextBoxColumn
            // 
            statusIdDataGridViewTextBoxColumn.DataPropertyName = "StatusId";
            statusIdDataGridViewTextBoxColumn.HeaderText = "StatusId";
            statusIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusIdDataGridViewTextBoxColumn.Name = "statusIdDataGridViewTextBoxColumn";
            statusIdDataGridViewTextBoxColumn.ReadOnly = true;
            statusIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // licenseNumberDataGridViewTextBoxColumn
            // 
            licenseNumberDataGridViewTextBoxColumn.DataPropertyName = "LicenseNumber";
            licenseNumberDataGridViewTextBoxColumn.HeaderText = "LicenseNumber";
            licenseNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            licenseNumberDataGridViewTextBoxColumn.Name = "licenseNumberDataGridViewTextBoxColumn";
            licenseNumberDataGridViewTextBoxColumn.ReadOnly = true;
            licenseNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverModelBindingSource
            // 
            driverModelBindingSource.DataSource = typeof(DriverModel);
            // 
            // dataGridViewTrucks
            // 
            dataGridViewTrucks.AutoGenerateColumns = false;
            dataGridViewTrucks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrucks.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, registrationNumberDataGridViewTextBoxColumn, makeDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn, currentMileageMilesDataGridViewTextBoxColumn, isAvailableDataGridViewCheckBoxColumn });
            dataGridViewTrucks.DataSource = truckModelBindingSource;
            dataGridViewTrucks.Location = new Point(52, 356);
            dataGridViewTrucks.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTrucks.Name = "dataGridViewTrucks";
            dataGridViewTrucks.ReadOnly = true;
            dataGridViewTrucks.RowHeadersWidth = 51;
            dataGridViewTrucks.Size = new Size(812, 141);
            dataGridViewTrucks.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            registrationNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            registrationNumberDataGridViewTextBoxColumn.ReadOnly = true;
            registrationNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            makeDataGridViewTextBoxColumn.HeaderText = "Make";
            makeDataGridViewTextBoxColumn.MinimumWidth = 6;
            makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            makeDataGridViewTextBoxColumn.ReadOnly = true;
            makeDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.ReadOnly = true;
            modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            yearDataGridViewTextBoxColumn.ReadOnly = true;
            yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentMileageMilesDataGridViewTextBoxColumn
            // 
            currentMileageMilesDataGridViewTextBoxColumn.DataPropertyName = "CurrentMileageMiles";
            currentMileageMilesDataGridViewTextBoxColumn.HeaderText = "CurrentMileageMiles";
            currentMileageMilesDataGridViewTextBoxColumn.MinimumWidth = 6;
            currentMileageMilesDataGridViewTextBoxColumn.Name = "currentMileageMilesDataGridViewTextBoxColumn";
            currentMileageMilesDataGridViewTextBoxColumn.ReadOnly = true;
            currentMileageMilesDataGridViewTextBoxColumn.Width = 125;
            // 
            // isAvailableDataGridViewCheckBoxColumn
            // 
            isAvailableDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.HeaderText = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isAvailableDataGridViewCheckBoxColumn.Name = "isAvailableDataGridViewCheckBoxColumn";
            isAvailableDataGridViewCheckBoxColumn.ReadOnly = true;
            isAvailableDataGridViewCheckBoxColumn.Width = 125;
            // 
            // truckModelBindingSource
            // 
            truckModelBindingSource.DataSource = typeof(TruckModel);
            // 
            // button1
            // 
            button1.Location = new Point(1202, 12);
            button1.Name = "button1";
            button1.Size = new Size(123, 36);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DispatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 791);
            Controls.Add(button1);
            Controls.Add(dataGridViewTrucks);
            Controls.Add(dataGridViewDrivers);
            Controls.Add(label2);
            Controls.Add(dataTimeDeparture);
            Controls.Add(label3);
            Controls.Add(lblOrigin);
            Controls.Add(label1);
            Controls.Add(txtDesitnation);
            Controls.Add(txtOrigin);
            Name = "DispatchForm";
            Text = "DispatchForm";
            Load += DispatchForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)driverModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrucks).EndInit();
            ((System.ComponentModel.ISupportInitialize)truckModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrigin;
        private TextBox txtDesitnation;
        private Label label1;
        private Label lblOrigin;
        private Label label3;
        private DateTimePicker dataTimeDeparture;
        private Label label2;
        private DataGridView dataGridViewDrivers;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn licenseNumberDataGridViewTextBoxColumn;
        private BindingSource driverModelBindingSource;
        private DataGridView dataGridViewTrucks;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentMileageMilesDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
        private BindingSource truckModelBindingSource;
        private Button button1;
    }
}