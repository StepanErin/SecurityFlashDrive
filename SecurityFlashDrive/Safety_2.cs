using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using static SecurityFlashDrive.Safety_2;
using static System.Formats.Asn1.AsnWriter;

namespace SecurityFlashDrive
{
    internal class Safety_2
    {
        internal delegate (bool, string) StopedHandler();
        internal event StopedHandler Stoped;

        internal delegate void ReactionHandler(string data);
        internal event ReactionHandler NewDevice;
        private Thread mainThread;
        public Safety_2()
        {
            mainThread = new Thread(() =>
            {
                new InternalThread(ref Stoped, ref NewDevice);
            });
            mainThread.Start();
        }
        public (bool, string) Stop()
        {
            return Stoped.Invoke();
        }
        private class InternalThread
        {
            private ManagementEventWatcher watcher = new ManagementEventWatcher();
            private ReactionHandler newDevice;
            public InternalThread(ref StopedHandler stoped, ref ReactionHandler newDevice)
            {
                var query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");
                watcher.Query = query;
                watcher.EventArrived += FlashDriveDetection;
                watcher.Query = query;
                watcher.Start();
                stoped += InternalThread_Stoped;
                this.newDevice = newDevice;
                //reaction += InternalThread_Reaction;
                //while (true) { System.Threading.Thread.Sleep(100); }
            }
            //private string InternalThread_Reaction()
            //{
            //    return "";
            //}
            private (bool, string) InternalThread_Stoped()
            {
                string error = "";
                try
                {
                    watcher.EventArrived -= FlashDriveDetection;
                    watcher.Stop();
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
                return (error == "", error);
            }

            private void FlashDriveDetection(object sender, EventArrivedEventArgs e)
            {
                DriveInfo[] info = DriveInfo.GetDrives();
                DriveInfo curentDrive = null;
                var driveName = e.NewEvent.Properties["DriveName"].Value.ToString()[0];
                foreach (DriveInfo item in info)
                {
                    if (item.Name[0] == driveName)
                    {
                        curentDrive = item;
                        break;
                    }
                }
                NewFlashDrive(curentDrive);
            }
            private void NewFlashDrive(DriveInfo input)
            {
                newDevice.Invoke(input.Name);
                var passWord = "0";
                if (input == null) return;
                DataFile file = new DataFile(input.Name[0], "PrivateData", "Log.txt", passWord);

                //Data2 data = new Data2(input);
                if (file.FileExists())
                {
                    file.DownloadData();
                    System.Windows.Forms.MessageBox.Show($"Data: |{file.Data}|");

                    file.UpdateCipher();
                    file.PrivatizeFile();
                    file.PrivatizeFileDirectory();
                }
                else
                {
                    var putput = System.Windows.Forms.MessageBox.Show("Перезаписать файл(y/n)", "Подтверждение", MessageBoxButtons.YesNo);
                    if (putput == DialogResult.Yes)
                    {
                        file.SaveData("123");
                        file.PrivatizeFile();
                        file.PrivatizeFileDirectory();
                    }
                    else
                        MessageBox.Show("Отмена");
                }
            }
            private class DataFile
            {
                public DataFile(char nameDisk, string path, string name, string passWord)
                {
                    NameDisk = nameDisk;
                    Path = path;
                    Name = name;
                    PassWord = passWord;
                }
                public bool FileExists()
                {
                    return File.Exists(FullPath);
                }
                public bool SaveData(string data)
                {
                    if (!Directory.Exists(DirectoryPath)) Directory.CreateDirectory(DirectoryPath);
                    Data = data;
                    EncryptedFile = Crypto.ToAes256(Data, PassWord);
                    FileIO.OpenOrCreate(EncryptedFile, FullPath);
                    return true;
                }
                public bool DownloadData()
                {
                    if (!FileExists()) return false;
                    EncryptedFile = FileIO.Read(FullPath).Item3;
                    Data = Crypto.FromAes256(EncryptedFile, PassWord);
                    return true;
                }
                public bool UpdateCipher()
                {
                    if (DownloadData()) return SaveData(Data);
                    return false;
                }
                #region Path
                public char NameDisk { get; }
                public string Path { get; }
                public string Name { get; }
                public string DirectoryPath { get { return $"{NameDisk}:\\{Path}"; } }
                public string FullPath { get { return $"{NameDisk}:\\{Path}\\{Name}"; } }
                #endregion Path

                public string PassWord { get; }
                public string Data { get; private set; } = null;
                public byte[] EncryptedFile { get; private set; } = null;

                public void PrivatizeFile()
                {
                    if (FileExists())
                        File.SetAttributes(FullPath, FileAttributes.Hidden);
                }
                public void DeprivatizeFile()
                {
                    if (FileExists())
                        File.SetAttributes(FullPath, FileAttributes.Normal);
                }
                public void PrivatizeFileDirectory()
                {
                    string str = DirectoryPath;
                    int count = 0;
                    foreach (var item in str) if (item == '\\') count++;

                    for (int i = count; i != 0; i--)
                    {
                        new DirectoryInfo(str).Attributes = FileAttributes.Hidden;
                        str = str.Remove(str.LastIndexOf('\\'));
                    }
                }
                public void DeprivatizeDirectory()
                {
                    string str = DirectoryPath;
                    int count = 0;
                    foreach (var item in str) if (item == '\\') count++;

                    for (int i = count; i != 0; i--)
                    {
                        new DirectoryInfo(str).Attributes = FileAttributes.Normal;
                        str = str.Remove(str.LastIndexOf('\\'));
                    }
                }
            }
        }
    }
}
