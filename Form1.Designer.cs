namespace Dispatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowDriversForm = new Button();
            btnShowTrucksForm = new Button();
            SuspendLayout();
            // 
            // btnShowDriversForm
            // 
            btnShowDriversForm.Location = new Point(56, 76);
            btnShowDriversForm.Margin = new Padding(3, 2, 3, 2);
            btnShowDriversForm.Name = "btnShowDriversForm";
            btnShowDriversForm.Size = new Size(130, 44);
            btnShowDriversForm.TabIndex = 0;
            btnShowDriversForm.Text = "Drivers";
            btnShowDriversForm.UseVisualStyleBackColor = true;
            btnShowDriversForm.Click += btnShowDriversForm_Click;
            // 
            // btnShowTrucksForm
            // 
            btnShowTrucksForm.Location = new Point(56, 142);
            btnShowTrucksForm.Margin = new Padding(3, 2, 3, 2);
            btnShowTrucksForm.Name = "btnShowTrucksForm";
            btnShowTrucksForm.Size = new Size(130, 44);
            btnShowTrucksForm.TabIndex = 1;
            btnShowTrucksForm.Text = "Trucks";
            btnShowTrucksForm.UseVisualStyleBackColor = true;
            btnShowTrucksForm.Click += btnShowTrucksForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 509);
            Controls.Add(btnShowTrucksForm);
            Controls.Add(btnShowDriversForm);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowDriversForm;
        private Button btnShowTrucksForm;
    }
}
