using System;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackupFile
{
    public partial class Form1 : Form
    {
        private int curCount = 0;
        private int Countdown = 0;
        private bool IsRegistered;
        private bool _onProgress;


        public Form1()
        {
            InitializeComponent();
        }

        private void CreateZipFile(IProgress<string> progress)
        {
            try
            {
                _onProgress = true;
                var failFile = "";
                var dirToSave = BackupSaveDir.Text;
                var backupName = BackupName.Text + DateTime.Now.ToString("yyyyMMddHHmmssfff");

                Directory.CreateDirectory(dirToSave + $@"\{backupName}");

                foreach (DataGridViewRow row in DirectoryList.Rows)
                {
                    if (row.IsNewRow) continue;
                    var strdummy = row.Cells["Directories"].Value.ToString();
                    var stat = row.Cells["Status"].Value.ToString();
                    //CurrentDir = strdummy;
                    progress.Report($"Creating backup file from:\n {strdummy}");

                    if (stat == "ready")
                    {
                        var strs = strdummy.Split('\\');

                        var strdummy2 = strs[strs.Length - 1];

                        try
                        {
                            ZipFile.CreateFromDirectory(
                            strdummy,
                            dirToSave + $@"\{backupName}\{strdummy2}.zip");
                        }
                        catch (Exception)
                        {
                            failFile += $"Fail to backup: {strdummy}\n";
                        }
                        
                    }
                }
                progress.Report($"Done");

                if (!String.IsNullOrEmpty(failFile))
                {
                    throw new Exception(failFile);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _onProgress = false;
            }

        }

        private bool CheckRegistered()
        {
            var physicalAddress = NetworkInterface.GetAllNetworkInterfaces()
                .FirstOrDefault(nic => nic.OperationalStatus == OperationalStatus.Up && 
                nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)?
                .GetPhysicalAddress().ToString();

            var reg = Properties.Settings.Default.Registered;

            foreach (var item in reg)
            {
                if (item.Replace("-", "") == physicalAddress)
                {
                    return true;
                }
            }
            return false;
        }

        private void ActiveUIControl(bool onProgress)
        {
            StartBackup.Visible = !onProgress;
            LoadingAnimation.Enabled = onProgress;
            ProcessInfo.Visible = onProgress;
            HeaderInfo.Text = (onProgress ? "File backup on progress..." : "No current progress..");
        }

        private async Task StartBackupFile()
        {
            try
            {
                if (!IsRegistered) return;

                CheckStatus();

                ErrorInfo.Text = "";

                DirectoryList.CommitEdit(DataGridViewDataErrorContexts.Commit);
                var dir = BackupSaveDir.Text;
                var error = "";

                if (!String.IsNullOrEmpty(dir))
                {
                    if (Directory.Exists(dir))
                    {
                        if (Settings.Text == "Settings<<")
                        {
                            OpenSettings();
                        }
                        ActiveUIControl(true);

                        IProgress<string> progress = new Progress<string>(update => { ProcessInfo.Text = update; });
                        await Task.Run(() => CreateZipFile(progress));

                        curCount = 0;
                        Countdown = 3;
                        timer.Start();
                    }
                    else
                    {
                        throw new Exception("Save To directory does not exist.");
                    }
                }
                else
                {
                    throw new Exception("Empty backup save directory.");
                }

                ErrorInfo.Text = error;
            }
            catch (Exception ex)
            {
                ActiveUIControl(false);
                ErrorInfo.Text = ex.Message;
            }
            
        }

        private async void StartBackup_Click(object sender, EventArgs e)
        {
            await StartBackupFile();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        private void OpenSettings()
        {
            if (Settings.Text == "Settings>>")
            {
                this.Size = new Size(475, 520);
                Settings.Text = "Settings<<";
            }
            else
            {
                this.Size = new Size(475, 223);
                Settings.Text = "Settings>>";
            }
        }

        private void CheckStatus()
        {
            foreach (DataGridViewRow row in DirectoryList.Rows)
            {
                if (row.IsNewRow) continue;
                var dir = row.Cells["Directories"].Value.ToString();
                if (File.Exists(dir) || Directory.Exists(dir))
                {
                    row.Cells["Status"].Value = "ready";
                }
                else
                {
                    row.Cells["Status"].Value = "missing";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            IsRegistered = CheckRegistered();

            if (!IsRegistered)
            {
                ErrorInfo.Text = "This PC was not register.";
                return;
            } 

            BackupName.Text = Properties.Settings.Default.BackupName;
            BackupSaveDir.Text = Properties.Settings.Default.SaveTo;
            var autoBack = Properties.Settings.Default.Auto;

            Auto.Checked = autoBack;
            Manual.Checked = !autoBack;

            var strArray = Properties.Settings.Default.Directories;

            if (strArray != null)
            {
                foreach (var item in strArray)
                {
                    var rows = item.Split('*');
                    DirectoryList.Rows.Add(new string[] { rows[0], rows[1] });
                }
            }

            CheckStatus();

            if (autoBack)
            {
                await StartBackupFile();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_onProgress)
            {
                MessageBox.Show("Unable to close when backup is on progress.");
                e.Cancel = true;
            }
        }

        private void DirectoryList_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            CheckStatus();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            curCount++;

            if (curCount <= 20)
            {
                ProcessInfo.Text = $"Files getting ready...";
            }
            else if (curCount < 40)
            {
                ProcessInfo.Text = $"File backup successful...";
            }
            else if (Auto.Checked && Settings.Text != "Settings<<")
            {
                if (curCount % 10 == 0)
                {

                    ProcessInfo.Text = $"Application will close in {Countdown}";

                    if (Countdown == 0)
                    {
                        Application.Exit();
                    }
                    Countdown--;
                }
            }
            else
            {
                ActiveUIControl(false);

                timer.Stop();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var dirList = new StringCollection();
            foreach (DataGridViewRow row in DirectoryList.Rows)
            {
                if (row.IsNewRow) continue;
                var dir = row.Cells["Directories"].Value.ToString();
                var stat = row.Cells["Status"].Value.ToString();

                dirList.Add($"{dir}*{stat}");
            }

            Properties.Settings.Default.BackupName = BackupName.Text;
            Properties.Settings.Default.SaveTo = BackupSaveDir.Text;
            Properties.Settings.Default.Auto = Auto.Checked;
            Properties.Settings.Default.Directories = dirList;
            Properties.Settings.Default.Save();

            MessageBox.Show("Settings Saved!");
        }
    }
}
