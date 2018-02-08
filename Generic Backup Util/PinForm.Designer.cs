namespace Generic_Backup_Util
{
    partial class PinForm
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
            this.BackupFidgetSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.BackupProgressLabel = new MetroFramework.Controls.MetroLabel();
            this.EnterButton = new MetroFramework.Controls.MetroButton();
            this.PinTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EnterPinLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // BackupFidgetSpinner
            // 
            this.BackupFidgetSpinner.Location = new System.Drawing.Point(122, 148);
            this.BackupFidgetSpinner.Maximum = 100;
            this.BackupFidgetSpinner.Name = "BackupFidgetSpinner";
            this.BackupFidgetSpinner.Size = new System.Drawing.Size(32, 32);
            this.BackupFidgetSpinner.TabIndex = 10;
            this.BackupFidgetSpinner.Visible = false;
            // 
            // BackupProgressLabel
            // 
            this.BackupProgressLabel.AutoSize = true;
            this.BackupProgressLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.BackupProgressLabel.Location = new System.Drawing.Point(64, 115);
            this.BackupProgressLabel.Name = "BackupProgressLabel";
            this.BackupProgressLabel.Size = new System.Drawing.Size(156, 25);
            this.BackupProgressLabel.TabIndex = 9;
            this.BackupProgressLabel.Text = "Backup In Progress";
            this.BackupProgressLabel.Visible = false;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(87, 189);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(102, 36);
            this.EnterButton.TabIndex = 8;
            this.EnterButton.Text = "Submit";
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click_1);
            // 
            // PinTextBox
            // 
            this.PinTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PinTextBox.Location = new System.Drawing.Point(114, 128);
            this.PinTextBox.MaxLength = 4;
            this.PinTextBox.Name = "PinTextBox";
            this.PinTextBox.PasswordChar = '●';
            this.PinTextBox.Size = new System.Drawing.Size(49, 35);
            this.PinTextBox.TabIndex = 7;
            this.PinTextBox.UseSystemPasswordChar = true;
            // 
            // EnterPinLabel
            // 
            this.EnterPinLabel.AutoSize = true;
            this.EnterPinLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.EnterPinLabel.Location = new System.Drawing.Point(77, 80);
            this.EnterPinLabel.Name = "EnterPinLabel";
            this.EnterPinLabel.Size = new System.Drawing.Size(133, 25);
            this.EnterPinLabel.TabIndex = 6;
            this.EnterPinLabel.Text = "Please Enter Pin";
            // 
            // PinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.BackupFidgetSpinner);
            this.Controls.Add(this.BackupProgressLabel);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PinTextBox);
            this.Controls.Add(this.EnterPinLabel);
            this.Name = "PinForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.PinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner BackupFidgetSpinner;
        private MetroFramework.Controls.MetroLabel BackupProgressLabel;
        private MetroFramework.Controls.MetroButton EnterButton;
        private MetroFramework.Controls.MetroTextBox PinTextBox;
        private MetroFramework.Controls.MetroLabel EnterPinLabel;
    }
}