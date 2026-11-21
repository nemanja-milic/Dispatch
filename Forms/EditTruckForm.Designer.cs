namespace Dispatch
{
    partial class EditTruckForm
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
            txtRegistrationNumber = new TextBox();
            label1 = new Label();
            txtMiles = new TextBox();
            lblMiles = new Label();
            label3 = new Label();
            lblTruckName = new Label();
            rdnYes = new RadioButton();
            rdnNo = new RadioButton();
            groupBox1 = new GroupBox();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRegistrationNumber
            // 
            txtRegistrationNumber.Location = new Point(349, 128);
            txtRegistrationNumber.Name = "txtRegistrationNumber";
            txtRegistrationNumber.Size = new Size(232, 27);
            txtRegistrationNumber.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 95);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 1;
            label1.Text = "Registration number";
            // 
            // txtMiles
            // 
            txtMiles.Location = new Point(349, 202);
            txtMiles.Name = "txtMiles";
            txtMiles.Size = new Size(232, 27);
            txtMiles.TabIndex = 2;
            // 
            // lblMiles
            // 
            lblMiles.AutoSize = true;
            lblMiles.Location = new Point(349, 169);
            lblMiles.Name = "lblMiles";
            lblMiles.Size = new Size(154, 20);
            lblMiles.TabIndex = 3;
            lblMiles.Text = "Current Mileage Miles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, 28);
            label3.Name = "label3";
            label3.Size = new Size(89, 38);
            label3.TabIndex = 5;
            label3.Text = "Truck:";
            // 
            // lblTruckName
            // 
            lblTruckName.AutoSize = true;
            lblTruckName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTruckName.Location = new Point(444, 28);
            lblTruckName.Name = "lblTruckName";
            lblTruckName.Size = new Size(0, 38);
            lblTruckName.TabIndex = 6;
            // 
            // rdnYes
            // 
            rdnYes.AutoSize = true;
            rdnYes.Location = new Point(6, 35);
            rdnYes.Name = "rdnYes";
            rdnYes.Size = new Size(51, 24);
            rdnYes.TabIndex = 7;
            rdnYes.TabStop = true;
            rdnYes.Text = "Yes";
            rdnYes.UseVisualStyleBackColor = true;
            // 
            // rdnNo
            // 
            rdnNo.AutoSize = true;
            rdnNo.Location = new Point(63, 35);
            rdnNo.Name = "rdnNo";
            rdnNo.Size = new Size(50, 24);
            rdnNo.TabIndex = 8;
            rdnNo.TabStop = true;
            rdnNo.Text = "No";
            rdnNo.TextAlign = ContentAlignment.MiddleCenter;
            rdnNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdnYes);
            groupBox1.Controls.Add(rdnNo);
            groupBox1.Location = new Point(349, 252);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 79);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Is available";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(349, 350);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(232, 45);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // EditTruckForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 696);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox1);
            Controls.Add(lblTruckName);
            Controls.Add(label3);
            Controls.Add(lblMiles);
            Controls.Add(txtMiles);
            Controls.Add(label1);
            Controls.Add(txtRegistrationNumber);
            Name = "EditTruckForm";
            Text = "EditTruckForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRegistrationNumber;
        private Label label1;
        private TextBox txtMiles;
        private Label lblMiles;
        private Label label3;
        private Label lblTruckName;
        private RadioButton rdnYes;
        private RadioButton rdnNo;
        private GroupBox groupBox1;
        private Button btnSubmit;
    }
}