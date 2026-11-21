namespace Dispatch
{
    partial class AddDriverForm
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
            txtFirstName = new TextBox();
            txtLicenseNumber = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSubmit = new Button();
            flowLayoutDriverStatus = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(342, 143);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(235, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(341, 311);
            txtLicenseNumber.Margin = new Padding(3, 4, 3, 4);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(235, 27);
            txtLicenseNumber.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(342, 228);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(235, 27);
            txtLastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 103);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 192);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 275);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 5;
            label3.Text = "License number";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(341, 535);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(234, 52);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // flowLayoutDriverStatus
            // 
            flowLayoutDriverStatus.FlowDirection = FlowDirection.TopDown;
            flowLayoutDriverStatus.Location = new Point(343, 366);
            flowLayoutDriverStatus.Name = "flowLayoutDriverStatus";
            flowLayoutDriverStatus.Size = new Size(232, 132);
            flowLayoutDriverStatus.TabIndex = 7;
            // 
            // AddDriverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(flowLayoutDriverStatus);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtLicenseNumber);
            Controls.Add(txtFirstName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddDriverForm";
            Text = "AddDriverForm";
            Load += AddDriverForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLicenseNumber;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSubmit;
        private FlowLayoutPanel flowLayoutDriverStatus;
    }
}