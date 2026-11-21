namespace Dispatch
{
    partial class AddTruckForm
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
            txtMake = new TextBox();
            txtModel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtYear = new TextBox();
            label4 = new Label();
            txtMiles = new TextBox();
            label5 = new Label();
            groupBox = new GroupBox();
            rbnNo = new RadioButton();
            rbnYes = new RadioButton();
            button1 = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // txtRegistrationNumber
            // 
            txtRegistrationNumber.Location = new Point(128, 78);
            txtRegistrationNumber.Name = "txtRegistrationNumber";
            txtRegistrationNumber.Size = new Size(154, 23);
            txtRegistrationNumber.TabIndex = 0;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(128, 144);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(154, 23);
            txtMake.TabIndex = 1;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(128, 210);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(154, 23);
            txtModel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 51);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 3;
            label1.Text = "Registration Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 116);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 180);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Model";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(128, 275);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(154, 23);
            txtYear.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 246);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "Year";
            // 
            // txtMiles
            // 
            txtMiles.Location = new Point(343, 78);
            txtMiles.Name = "txtMiles";
            txtMiles.Size = new Size(154, 23);
            txtMiles.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 51);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 9;
            label5.Text = "Miles";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(rbnNo);
            groupBox.Controls.Add(rbnYes);
            groupBox.Location = new Point(343, 144);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(200, 100);
            groupBox.TabIndex = 10;
            groupBox.TabStop = false;
            groupBox.Text = "Is available";
            // 
            // rbnNo
            // 
            rbnNo.AutoSize = true;
            rbnNo.Location = new Point(15, 56);
            rbnNo.Name = "rbnNo";
            rbnNo.Size = new Size(41, 19);
            rbnNo.TabIndex = 1;
            rbnNo.Text = "No";
            rbnNo.UseVisualStyleBackColor = true;
            // 
            // rbnYes
            // 
            rbnYes.AutoSize = true;
            rbnYes.Checked = true;
            rbnYes.Location = new Point(15, 22);
            rbnYes.Name = "rbnYes";
            rbnYes.Size = new Size(42, 19);
            rbnYes.TabIndex = 0;
            rbnYes.TabStop = true;
            rbnYes.Text = "Yes";
            rbnYes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(128, 328);
            button1.Name = "button1";
            button1.Size = new Size(415, 47);
            button1.TabIndex = 11;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddTruckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox);
            Controls.Add(label5);
            Controls.Add(txtMiles);
            Controls.Add(label4);
            Controls.Add(txtYear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(txtRegistrationNumber);
            Name = "AddTruckForm";
            Text = "AddTruckForm";
            Load += AddTruckForm_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRegistrationNumber;
        private TextBox txtMake;
        private TextBox txtModel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtYear;
        private Label label4;
        private TextBox txtMiles;
        private Label label5;
        private GroupBox groupBox;
        private RadioButton rbnNo;
        private RadioButton rbnYes;
        private Button button1;
    }
}