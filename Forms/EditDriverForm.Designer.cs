namespace Dispatch
{
    partial class EditDriverForm
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
            btnSubmit = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEditLicenseNumber = new TextBox();
            label1 = new Label();
            txtEditLastName = new Label();
            label2 = new Label();
            flowLayoutStatusPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(235, 344);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(206, 22);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(235, 68);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(215, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(234, 126);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(215, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtEditLicenseNumber
            // 
            txtEditLicenseNumber.Location = new Point(234, 188);
            txtEditLicenseNumber.Margin = new Padding(3, 2, 3, 2);
            txtEditLicenseNumber.Name = "txtEditLicenseNumber";
            txtEditLicenseNumber.Size = new Size(215, 23);
            txtEditLicenseNumber.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 44);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // txtEditLastName
            // 
            txtEditLastName.AutoSize = true;
            txtEditLastName.Location = new Point(235, 100);
            txtEditLastName.Name = "txtEditLastName";
            txtEditLastName.Size = new Size(63, 15);
            txtEditLastName.TabIndex = 5;
            txtEditLastName.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 160);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 6;
            label2.Text = "License number";
            // 
            // flowLayoutStatusPanel
            // 
            flowLayoutStatusPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutStatusPanel.Location = new Point(235, 225);
            flowLayoutStatusPanel.Name = "flowLayoutStatusPanel";
            flowLayoutStatusPanel.Size = new Size(206, 100);
            flowLayoutStatusPanel.TabIndex = 7;
            // 
            // EditDriverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 460);
            Controls.Add(flowLayoutStatusPanel);
            Controls.Add(label2);
            Controls.Add(txtEditLastName);
            Controls.Add(label1);
            Controls.Add(txtEditLicenseNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnSubmit);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditDriverForm";
            Text = "EditDriverForm";
            Load += EditDriverForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEditLicenseNumber;
        private Label label1;
        private Label txtEditLastName;
        private Label label2;
        private FlowLayoutPanel flowLayoutStatusPanel;
    }
}