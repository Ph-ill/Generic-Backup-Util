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
using MetroFramework.Forms;
using MetroFramework.Interfaces;

namespace Generic_Backup_Util
{
    public partial class Settings : MetroForm
    {
        public static Int32 SelectedHour;
        public static Timer periodic_timer;
        public static Timer reactivate_timer;

        public static class DataContainer
        {
            public static string BackupPath;
            public static string CloseBackupMessage;
            public static Boolean restart_timer;
        }

        public Settings()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CloseAllOtherForms();
            PopControls();
            CheckSettingsFileExists();
            LoadSettings();
            Timer_Check();   
        }

        public void CloseAllOtherForms()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Settings")
                    Application.OpenForms[i].Close();
            }
        }

        public void PopControls()
        {
            DayComboBox.Items.Add("Monday");
            DayComboBox.Items.Add("Tuesday");
            DayComboBox.Items.Add("Wednesday");
            DayComboBox.Items.Add("Thursday");
            DayComboBox.Items.Add("Friday");
            DayComboBox.Items.Add("Saturday");
            DayComboBox.Items.Add("Sunday");

            HourComboBox.Items.Add("00:00");
            HourComboBox.Items.Add("01:00");
            HourComboBox.Items.Add("02:00");
            HourComboBox.Items.Add("03:00");
            HourComboBox.Items.Add("04:00");
            HourComboBox.Items.Add("05:00");
            HourComboBox.Items.Add("06:00");
            HourComboBox.Items.Add("07:00");
            HourComboBox.Items.Add("08:00");
            HourComboBox.Items.Add("09:00");
            HourComboBox.Items.Add("10:00");
            HourComboBox.Items.Add("11:00");
            HourComboBox.Items.Add("12:00");
            HourComboBox.Items.Add("13:00");
            HourComboBox.Items.Add("14:00");
            HourComboBox.Items.Add("15:00");
            HourComboBox.Items.Add("16:00");
            HourComboBox.Items.Add("17:00");
            HourComboBox.Items.Add("18:00");
            HourComboBox.Items.Add("19:00");
            HourComboBox.Items.Add("20:00");
            HourComboBox.Items.Add("21:00");
            HourComboBox.Items.Add("22:00");
            HourComboBox.Items.Add("23:00");
        }

        public void CheckSettingsFileExists()
        {
            if (File.Exists("Settings.txt"))
            {
                //Do Nothing
            }
            else
            {
                TextWriter tw = new StreamWriter("Settings.txt");
                tw.WriteLine("Monday");
                tw.WriteLine("00:00");
                tw.WriteLine("C:\\");
                tw.Close();
            }
        }

        public void LoadSettings()
        {
            TextReader tr = new StreamReader("Settings.txt");
            string DaySetting = tr.ReadLine();
            string HourSetting = tr.ReadLine();
            string BackupPath = tr.ReadLine();
            tr.Close();

            DayComboBox.Text = DaySetting;
            HourComboBox.Text = HourSetting;
            BackupFolderPath.Text = BackupPath;
        }

        public void SaveSettings()
        {
            File.Delete("Settings.txt");
            TextWriter tw = new StreamWriter("Settings.txt");
            tw.WriteLine(DayComboBox.GetItemText(DayComboBox.SelectedItem));
            tw.WriteLine(HourComboBox.GetItemText(HourComboBox.SelectedItem));
            tw.WriteLine(BackupFolderPath.Text);
            tw.Close();
            SelectedHour = HourComboBox.SelectedIndex;
            this.WindowState = FormWindowState.Minimized;
            Hide();
            notifyIcon.Visible = true;
        }

        public void Timer_Check()
        {
            periodic_timer = new Timer();
            periodic_timer.Tick += new EventHandler(periodic_timer_Tick);
            periodic_timer.Interval = 5000; // in miliseconds
            periodic_timer.Start();
            reactivate_timer = new Timer();
            reactivate_timer.Tick += new EventHandler(reactivate_timer_Tick);
            reactivate_timer.Interval = 5000; // in miliseconds
            reactivate_timer.Start();
        }

        public void periodic_timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == Settings.SelectedHour)
            {
                DataContainer.BackupPath = BackupFolderPath.Text;
                Backup_Message();
            }
        }

        public void Backup_Message()
        {
            periodic_timer.Stop();

            BackupMessage BackupMessage = new BackupMessage();
            BackupMessage.Show();
            BackupMessage.TopMost = true;
        }

        private void BackupBrowseButton_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog.ShowDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackupFolderPath.Text = folderBrowserDialog.SelectedPath.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void DayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        public void reactivate_timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour != Settings.SelectedHour)
            {
                periodic_timer.Start();
                MessageBox.Show("DO WE GET HERE DO WE GET HERE DO WE GET HERE");
            }
        }
    }
}
