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
            SuspendLayout();
            // 
            // flowLayoutDrivers
            // 
            flowLayoutDrivers.Location = new Point(12, 195);
            flowLayoutDrivers.Name = "flowLayoutDrivers";
            flowLayoutDrivers.Size = new Size(1228, 471);
            flowLayoutDrivers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, 21);
            label1.Name = "label1";
            label1.Size = new Size(219, 81);
            label1.TabIndex = 1;
            label1.Text = "Drivers";
            // 
            // DriversForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 678);
            Controls.Add(label1);
            Controls.Add(flowLayoutDrivers);
            Name = "DriversForm";
            Text = "Drivers";
            Load += DriversForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutDrivers;
        private Label label1;
    }
}