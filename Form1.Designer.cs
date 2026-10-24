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
            SuspendLayout();
            // 
            // btnShowDriversForm
            // 
            btnShowDriversForm.Location = new Point(64, 102);
            btnShowDriversForm.Name = "btnShowDriversForm";
            btnShowDriversForm.Size = new Size(149, 59);
            btnShowDriversForm.TabIndex = 0;
            btnShowDriversForm.Text = "Drivers";
            btnShowDriversForm.UseVisualStyleBackColor = true;
            btnShowDriversForm.Click += btnShowDriversForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 679);
            Controls.Add(btnShowDriversForm);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowDriversForm;
    }
}
