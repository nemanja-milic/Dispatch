namespace Dispatch
{
    partial class TrucksForm
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
            flowLayoutTruckPanel = new FlowLayoutPanel();
            addTruck = new Button();
            SuspendLayout();
            // 
            // flowLayoutTruckPanel
            // 
            flowLayoutTruckPanel.Location = new Point(12, 122);
            flowLayoutTruckPanel.Name = "flowLayoutTruckPanel";
            flowLayoutTruckPanel.Size = new Size(1005, 409);
            flowLayoutTruckPanel.TabIndex = 0;
            // 
            // addTruck
            // 
            addTruck.Location = new Point(900, 10);
            addTruck.Name = "addTruck";
            addTruck.Size = new Size(117, 35);
            addTruck.TabIndex = 1;
            addTruck.Text = " + Add Truck";
            addTruck.UseVisualStyleBackColor = true;
            addTruck.Click += addTruck_Click;
            // 
            // TrucksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 541);
            Controls.Add(addTruck);
            Controls.Add(flowLayoutTruckPanel);
            Name = "TrucksForm";
            Text = "Trucks";
            Load += TrucksForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutTruckPanel;
        private Button addTruck;
    }
}