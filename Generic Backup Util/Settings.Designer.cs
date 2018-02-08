namespace Generic_Backup_Util
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.DayComboBox = new MetroFramework.Controls.MetroComboBox();
            this.HourComboBox = new MetroFramework.Controls.MetroComboBox();
            this.BackupFolderPath = new MetroFramework.Controls.MetroTextBox();
            this.BackupBrowseButton = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // DayComboBox
            // 
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.ItemHeight = 23;
            this.DayComboBox.Location = new System.Drawing.Point(22, 113);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(166, 29);
            this.DayComboBox.TabIndex = 0;
            this.DayComboBox.UseSelectable = true;
            this.DayComboBox.SelectedIndexChanged += new System.EventHandler(this.DayComboBox_SelectedIndexChanged);
            // 
            // HourComboBox
            // 
            this.HourComboBox.FormattingEnabled = true;
            this.HourComboBox.ItemHeight = 23;
            this.HourComboBox.Location = new System.Drawing.Point(194, 113);
            this.HourComboBox.Name = "HourComboBox";
            this.HourComboBox.Size = new System.Drawing.Size(174, 29);
            this.HourComboBox.TabIndex = 1;
            this.HourComboBox.UseSelectable = true;
            // 
            // BackupFolderPath
            // 
            // 
            // 
            // 
            this.BackupFolderPath.CustomButton.Image = null;
            this.BackupFolderPath.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.BackupFolderPath.CustomButton.Name = "";
            this.BackupFolderPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BackupFolderPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BackupFolderPath.CustomButton.TabIndex = 1;
            this.BackupFolderPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BackupFolderPath.CustomButton.UseSelectable = true;
            this.BackupFolderPath.CustomButton.Visible = false;
            this.BackupFolderPath.Lines = new string[] {
        "BackupFolderPath"};
            this.BackupFolderPath.Location = new System.Drawing.Point(22, 84);
            this.BackupFolderPath.MaxLength = 32767;
            this.BackupFolderPath.Name = "BackupFolderPath";
            this.BackupFolderPath.PasswordChar = '\0';
            this.BackupFolderPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BackupFolderPath.SelectedText = "";
            this.BackupFolderPath.SelectionLength = 0;
            this.BackupFolderPath.SelectionStart = 0;
            this.BackupFolderPath.ShortcutsEnabled = true;
            this.BackupFolderPath.Size = new System.Drawing.Size(322, 23);
            this.BackupFolderPath.TabIndex = 2;
            this.BackupFolderPath.Text = "BackupFolderPath";
            this.BackupFolderPath.UseSelectable = true;
            this.BackupFolderPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BackupFolderPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BackupBrowseButton
            // 
            this.BackupBrowseButton.Location = new System.Drawing.Point(350, 84);
            this.BackupBrowseButton.Name = "BackupBrowseButton";
            this.BackupBrowseButton.Size = new System.Drawing.Size(18, 23);
            this.BackupBrowseButton.TabIndex = 3;
            this.BackupBrowseButton.Text = "...";
            this.BackupBrowseButton.UseSelectable = true;
            this.BackupBrowseButton.Click += new System.EventHandler(this.BackupBrowseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(153, 165);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Backup Utility";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick_1);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 216);
            this.ControlBox = false;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackupBrowseButton);
            this.Controls.Add(this.BackupFolderPath);
            this.Controls.Add(this.HourComboBox);
            this.Controls.Add(this.DayComboBox);
            this.Name = "Settings";
            this.Resizable = false;
            this.Text = "Backup Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox DayComboBox;
        private MetroFramework.Controls.MetroComboBox HourComboBox;
        private MetroFramework.Controls.MetroTextBox BackupFolderPath;
        private MetroFramework.Controls.MetroButton BackupBrowseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private MetroFramework.Controls.MetroButton SaveButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

