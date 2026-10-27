namespace Dispatch
{
    partial class DriversForm
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
            flowLayoutDrivers = new FlowLayoutPanel();
            label1 = new Label();
            btnRefresh = new Button();
            btnOpenDriverForm = new Button();
            SuspendLayout();
            // 
            // flowLayoutDrivers
            // 
            flowLayoutDrivers.Location = new Point(10, 146);
            flowLayoutDrivers.Margin = new Padding(3, 2, 3, 2);
            flowLayoutDrivers.Name = "flowLayoutDrivers";
            flowLayoutDrivers.Size = new Size(1074, 353);
            flowLayoutDrivers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 16);
            label1.Name = "label1";
            label1.Size = new Size(176, 65);
            label1.TabIndex = 1;
            label1.Text = "Drivers";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1009, 106);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnOpenDriverForm
            // 
            btnOpenDriverForm.Location = new Point(895, 106);
            btnOpenDriverForm.Name = "btnOpenDriverForm";
            btnOpenDriverForm.Size = new Size(98, 23);
            btnOpenDriverForm.TabIndex = 3;
            btnOpenDriverForm.Text = "+ Add driver";
            btnOpenDriverForm.UseVisualStyleBackColor = true;
            btnOpenDriverForm.Click += btnOpenDriverForm_Click;
            // 
            // DriversForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 508);
            Controls.Add(btnOpenDriverForm);
            Controls.Add(btnRefresh);
            Controls.Add(label1);
            Controls.Add(flowLayoutDrivers);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DriversForm";
            Text = "Drivers";
            Load += DriversForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutDrivers;
        private Label label1;
        private Button btnRefresh;
        private Button btnOpenDriverForm;
    }
}