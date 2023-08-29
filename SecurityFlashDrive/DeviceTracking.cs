using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
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
            (char, string) curentDrive = ('_', "");
            var driveName = e.NewEvent.Properties["DriveName"].Value.ToString()[0];
            foreach (var item in info)
            {
                if (item.Item1 == driveName)
                {
                    curentDrive = item;
                    break;
                }
            }
            NewCurentDrive?.Invoke(curentDrive.Item1, curentDrive.Item2);
        }
        private void FlashDriveOFFDetection(object sender, EventArrivedEventArgs e)
        {
            var info = ConnectedDevices_OLD;
            (char, string) curentDrive = ('_', "");
            var driveName = e.NewEvent.Properties["DriveName"].Value.ToString()[0];
            foreach (var item in info)
            {
                if (item.Item1 == driveName)
                {
                    curentDrive = item;
                    break;
                }
            }
            OffCurentDrive?.Invoke(curentDrive.Item1, curentDrive.Item2);
        }
        static public DriveInfo[] GetAllDrives()
        {
            return DriveInfo.GetDrives();
        }
        private (char, string)[] ConnectedDevices_OLD;
        private (char, string)[] UpdateConnectedDevices()
        {
            var temp = new List<(char, string)>();
            foreach (var item in DriveInfo.GetDrives()) temp.Add((item.Name[0], item.VolumeLabel));
            ConnectedDevices_OLD = temp.ToArray();
            return ConnectedDevices_OLD;
        }
    }
}
