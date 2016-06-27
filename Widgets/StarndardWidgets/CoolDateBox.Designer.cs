namespace StandardWidgets
{
    partial class CoolDateBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolDateBox));
            this.datePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.AccessibleDescription = null;
            this.datePicker.AccessibleName = null;
            resources.ApplyResources(this.datePicker, "datePicker");
            this.datePicker.Font = null;
            this.datePicker.Name = "datePicker";
            this.datePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.datePicker.SelectedDateTimeChanged += new System.EventHandler(this.datePicker_SelectedDateTimeChanged);
            // 
            // CoolDateBox
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.datePicker);
            this.Name = "CoolDateBox";
            this.Click += new System.EventHandler(this.CoolDateBox_Click);
            this.TextAccepted += new System.EventHandler(this.CoolDateBox_TextAccepted);
            this.Controls.SetChildIndex(this.datePicker, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FarsiLibrary.Win.Controls.FADatePicker datePicker;
    }
}
