using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework;
using MetroFramework.Forms;

namespace Generic_Backup_Util
{ 
    public partial class PinForm : MetroForm
    {
        public bool CloseForm;

        public PinForm()
        {
            InitializeComponent();
        }

        private void PinForm_Load(object sender, EventArgs e)
        {
            if (CloseForm)
            {
                this.Close();
            }
        }

        public void EnterButton_Click(object sender, EventArgs e)
        {

        }

        private void FileDelete()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(BackupMessage.DataContainer.DrivePath);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        public void Backup()
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(Settings.DataContainer.BackupPath, "*",
                SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(Settings.DataContainer.BackupPath, BackupMessage.DataContainer.DrivePath));

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(Settings.DataContainer.BackupPath, "*.*",
                SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(Settings.DataContainer.BackupPath, BackupMessage.DataContainer.DrivePath), true);
            MetroMessageBox.Show(this, "", "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Invoke((MethodInvoker)delegate
            {
                // close the form on the forms thread
                this.Close();
            });
        }

        public void BackupDelay()
        {
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                Backup();
                timer.Dispose();
            },
                        null, 2000, System.Threading.Timeout.Infinite);
        }

        public void DeleteDelay()
        {
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                FileDelete();
                timer.Dispose();
            },
                        null, 1000, System.Threading.Timeout.Infinite);
        }

        private void EnterButton_Click_1(object sender, EventArgs e)
        {
            if (PinTextBox.Text == "1738")
            {
                EnterPinLabel.Hide();
                PinTextBox.Hide();
                EnterButton.Hide();
                BackupFidgetSpinner.Show();
                BackupProgressLabel.Show();
                DeleteDelay();
                BackupDelay();
            }
            else
            {
                MetroMessageBox.Show(this, "Please Try Again", "Incorrect Pin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                PinTextBox.Text = "";
            }
        }

    }
}
