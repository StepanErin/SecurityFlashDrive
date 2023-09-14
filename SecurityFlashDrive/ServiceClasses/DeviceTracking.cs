using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static SecurityFlashDrive.DeviceTracking;

namespace SecurityFlashDrive
{
    internal class DeviceTracking
    {
        internal delegate void NewDrive(char nameDisk, string volumeLabel);
        internal event NewDrive NewCurentDrive;

        internal delegate void OffDrive(char nameDisk, string volumeLabel);
        internal event OffDrive OffCurentDrive;

        private ManagementEventWatcher connectionWatcher = new ManagementEventWatcher();
        private ManagementEventWatcher disconnectionWatcher = new ManagementEventWatcher();

        private bool firstStart = true;
        private bool firstStop = true;

        public void Start()
        {
            if (firstStart && firstStop)
            {
                firstStart = false;
                connectionWatcher.Start();
                disconnectionWatcher.Start();
                connectionWatcher.EventArrived += FlashDriveDetection;
                disconnectionWatcher.EventArrived += FlashDriveOFFDetection;
            }
        }
        public void Stop()
        {
            if (!firstStart && firstStop)
            {
                firstStop = false;
                connectionWatcher.Stop();
                disconnectionWatcher.Stop();
                connectionWatcher.EventArrived -= FlashDriveDetection;
                disconnectionWatcher.EventArrived -= FlashDriveOFFDetection;
            }
        }
        public DeviceTracking()
        {
            UpdateConnectedDevices();
            connectionWatcher.Query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");
            disconnectionWatcher.Query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 3");
        }
        private void FlashDriveDetection(object sender, EventArrivedEventArgs e)
        {
            var info = UpdateConnectedDevices();
            var driveName = e.NewEvent.Properties["DriveName"].Value.ToString()[0];
            if (info.ContainsKey(driveName))
                NewCurentDrive?.Invoke(driveName, info[driveName]);
        }
        private void FlashDriveOFFDetection(object sender, EventArrivedEventArgs e)
        {
            var driveName = e.NewEvent.Properties["DriveName"].Value.ToString()[0];
            if (ConnectedDevices_OLD.ContainsKey(driveName))
                OffCurentDrive?.Invoke(driveName, ConnectedDevices_OLD[driveName]);
        }
        static public DriveInfo[] GetAllDrives()
        {
            return DriveInfo.GetDrives();
        }
        private Dictionary<char, string> ConnectedDevices_OLD = new Dictionary<char, string>();
        private Dictionary<char, string> UpdateConnectedDevices()
        {
            try
            {
                ConnectedDevices_OLD.Clear();
                foreach (var item in DriveInfo.GetDrives())
                    ConnectedDevices_OLD.Add(item.Name[0], item.VolumeLabel);
                return ConnectedDevices_OLD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new Dictionary<char, string>();
            }
        }
    }
}
