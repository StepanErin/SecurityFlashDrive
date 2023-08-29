using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SecurityFlashDrive
{
    public partial class Form1 : Form
    {
        private DiologForm diologForm = new DiologForm();

        #region TreatmentThisForm
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
            UpdateData();
            label2.Text = "Работа в фоне: ИНЕРТНО";
            label2.ForeColor = Color.DarkRed;
            //diologForm = new DiologForm(this);
        }
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (tracking != null) tracking.Stop();
        }
        #endregion TreatmentForm


        #region ControlThisForm


        #region Button
        bool activ = false;
        private void button_StartBackground_Click(object sender, EventArgs e)
        {
            if (!activ)
            {
                activ = true;
                tracking = new DeviceTracking();
                tracking.Start();
                tracking.NewCurentDrive += Tracking_NewCurentDrive;
                tracking.OffCurentDrive += Tracking_OffCurentDrive;
                WorkInBackground_ACT();
            }
        }
        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (activ)
            {
                activ = false;
                if (tracking != null) tracking.Stop();
                WorkInBackground_PASS();
            }
        }
        private void button_TEST_Click(object sender, EventArgs e)
        {
            List<byte> bytes_INP = new List<byte>();
            for (int i = 0; i < 255; i++) bytes_INP.Add((byte)i);


            //PRINT
            string str_INP = "";
            foreach (var item in bytes_INP) str_INP += ((int)item).ToString();
            MessageBox.Show(str_INP);


            var t = Crypto.ToAes256_Byte(bytes_INP.ToArray(), "0");
            //var t = Crypto.ToAes256(Crypto.TTT_IN(bytes_INP.ToArray()), "0");
            var bytes_OUT = Crypto.FromAes256_Byte(t, "0");
            //var bytes_OUT = Crypto.TTT_OUT(Crypto.FromAes256(t, "0"));




            //PRINT
            string str_OUT = "";
            foreach (var item in bytes_OUT) str_OUT += ((int)item).ToString();


            MessageBox.Show(str_OUT);
            MessageBox.Show((str_INP == str_OUT).ToString());
        }
        private void button_SelectionConfirmation_Click(object sender, EventArgs e)
        {
            var passWord = "0";
            //ActionsDataFile2 file = new ActionsDataFile2(curentDeviceName, "PrivateData", "Log", "txt", passWord);
            ActionsDataFile file = new ActionsDataFile(curentDeviceName, "PrivateData", "Log", "txt", passWord);

            diologForm.ShowFormCurrentData(file);

            /*
            diologForm.ShowForm(curentDeviceName);
            
            //Data2 data = new Data2(input);
            if (file.FileExists())
            {
                file.DownloadData();
                MessageBox.Show($"Data: |{file.Data}|");

                file.UpdateCipher();
                FileIO.VisualHiding.PrivatizeFile(file.Path);
                FileIO.VisualHiding.PrivatizeFileDirectory(file.Path);
            }
            else
            {
                var putput = MessageBox.Show("Перезаписать файл(y/n)", "Подтверждение", MessageBoxButtons.YesNo);
                if (putput == DialogResult.Yes)
                {
                    file.SaveData("123");
                    FileIO.VisualHiding.PrivatizeFile(file.Path);
                    FileIO.VisualHiding.PrivatizeFileDirectory(file.Path);
                }
                else
                    MessageBox.Show("Отмена");
            }*/
        }
        #endregion Button

        #region ComboBox
        private void comboBox_DiskSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            curentDeviceName = deviceData.GetNameByIndex(comboBox_DiskSelection.SelectedIndex);
            button_SelectionConfirmation.Text = $"Выбранный диск: {curentDeviceName}";
        }
        #endregion ComboBox


        #endregion ControlThisForm


        #region WorkCodThisForm
        private DeviceTracking tracking;
        private DevicesData deviceData = new DevicesData();
        private char curentDeviceName;
        //private DiologForm diologForm;

        /// <summary>
        /// Подключённые устройства
        /// </summary>
        private class DevicesData
        {
            private List<char> namesDevices = new List<char>();

            private List<string> stringData = new List<string>();
            public List<string> StringData
            {
                get { return stringData; }
            }

            public void UpDate()
            {
                namesDevices.Clear();
                stringData.Clear();
                foreach (var item in DeviceTracking.GetAllDrives())
                {
                    namesDevices.Add(item.Name[0]);
                    stringData.Add($"[{item.VolumeLabel}] - {item.Name}");
                }
            }
            public char GetNameByIndex(int index)
            {
                return namesDevices[index];
            }
            public int GetIndexDevices(char name)
            {
                return namesDevices.IndexOf(name);
            }
            public string GetDataDevices(char name)
            {
                return stringData[GetIndexDevices(name)];
            }
        }
        /// <summary>
        /// Обновить данные в форме
        /// </summary>
        private void UpdateData()
        {
            deviceData.UpDate();
            try
            {
                Action action = () =>
                {
                    int t = comboBox_DiskSelection.SelectedIndex;
                    comboBox_DiskSelection.Items.Clear();
                    comboBox_DiskSelection.Items.AddRange(deviceData.StringData.ToArray());
                    if (comboBox_DiskSelection.Items.Count > t) SelectedDisk(t);
                };
                if (InvokeRequired) Invoke(action);
                else action();
            }
            catch
            {
            }
        }
        private void SelectedDisk(int i)
        {
            Action action = () =>
            {
                if (comboBox_DiskSelection.Items.Count > i) comboBox_DiskSelection.SelectedIndex = i;
            };
            if (InvokeRequired) Invoke(action);
            else action();
        }
        private void WorkInBackground_PASS()
        {
            label2.Text = "Работа в фоне: ИНЕРТНО";
            label2.ForeColor = Color.DarkRed;
        }
        private void WorkInBackground_ACT()
        {
            label2.Text = "Работа в фоне: АКТИВНО";
            label2.ForeColor = Color.DarkGreen;
        }
        private void Tracking_NewCurentDrive(char nameDisk, string volumeLabel)
        {
            UpdateData();
            var res = MessageBox.Show($"Выбрать устройство: {deviceData.GetDataDevices(nameDisk)}", "Новое устройство", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) SelectedDisk(deviceData.GetIndexDevices(nameDisk));
        }
        private void Tracking_OffCurentDrive(char nameDisk, string volumeLabel)
        {
            MessageBox.Show($"Устройство [{volumeLabel}] - {nameDisk} отключено");
            UpdateData();
        }
        #endregion WorkCodThisForm
    }
}