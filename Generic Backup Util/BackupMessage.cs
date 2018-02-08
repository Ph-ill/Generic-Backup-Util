using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using Dolinay;
using System.IO;

namespace Generic_Backup_Util
{
    public partial class BackupMessage : MetroForm
    {
        private DriveDetector driveDetector = null;
        public static bool CloseForm { get; set; }
        public static string BackupPath { get; set; }
        PinForm PinForm = new PinForm();

        public static class DataContainer
        {
            public static string DrivePath;
        }

        public BackupMessage()
        {
            InitializeComponent();
            driveDetector = new DriveDetector();
            driveDetector.DeviceArrived += new DriveDetectorEventHandler(OnDriveArrived);
        }

        private void OnDriveArrived(object sender, DriveDetectorEventArgs e)
        {
            if (!CloseForm)
            {
                //CloseForm = true;
                DataContainer.DrivePath = e.Drive;
                //try
                //{
                    PinForm.Show();
                    PinForm.TopMost = true;
                //}
                //catch
                //{
                    //cheap hack to stop a million forms opening
                //}
                
                this.Close();
            }
        }

        private void BackupMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
