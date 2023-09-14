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
        #region Global data
        private IconTreyControl iconTreyControl;
        private event IconTreyControl.ClickButton ClickB;
        private EditFile_Form editFile_Form = new EditFile_Form();
        private Form3 editFile_Form2 = new Form3();
        private Backup backup = new Backup();
        #endregion Global data

        #region TreatmentThisForm
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
            UpdateData();
            WorkInBackground_PASS();
            FirstSTart();


            ClickB += Click_Tray;
            var t = new IconTreyControl.TypeEvent[]
            {
                IconTreyControl.TypeEvent.Show,
                IconTreyControl.TypeEvent.Close
            };
            iconTreyControl = new IconTreyControl(ClickB, t);
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (tracking != null) tracking.Stop();
            CreateNewFile();
            iconTreyControl.Visual_OFF();
        }
        private void FirstSTart()
        {
            var data = (false, "", new byte[] { });
            if (File.Exists("Data.date"))
            {
                data = FileIO.Read("Data.date");
                if (data.Item1)
                {
                    var t = Serialization.StartDeserialize<ParamDataForm>(data.Item3);
                    if (t.Item1) Apply(t.Item2);
                    else CreateNewFile();
                }
            }
            else CreateNewFile();
            void Apply(ParamDataForm param)
            {
                paramDataForm = param;
                checkBox_AUTOmod.Checked = param.AutoMode;
                if (param.AutoMode) WorkInBackground_ACT();

                listBox_Devases.Items.Clear();
                listBox_Devases.Items.AddRange(param.Devises.ToArray());
            }
        }
        #endregion TreatmentForm

        #region ControlThisForm


        #region Button
        private void button_StartBackground_Click(object sender, EventArgs e)
        {
            WorkInBackground_ACT();
        }
        private void button_Stop_Click(object sender, EventArgs e)
        {
            WorkInBackground_PASS();
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
            Devices_ActionsFile file = new Devices_ActionsFile(curentDeviceName, "PrivateData", "Log", "txt", passWord);
            //editFile_Form.ShowFormCurrentData(file);
            editFile_Form2.ShowForm(file);
        }
        private void button_Run_Click(object sender, EventArgs e)
        {
            var passWord = "0";
            Devices_ActionsFile file = new Devices_ActionsFile(curentDeviceName, "PrivateData", "Log", "txt", passWord);
            backup.RunFile(file);
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = deviceData.GetDataDevices(curentDeviceName);
            if (!listBox_Devases.Items.Contains(name))
            {
                paramDataForm.Devises.Add(name);
                listBox_Devases.Items.Add(name);
            }
        }
        private void button_Del_Click(object sender, EventArgs e)
        {
            if (listBox_Devases.SelectedItem == null) return;
            string name = listBox_Devases.SelectedItem.ToString();
            if (paramDataForm.Devises.Contains(name))
            {
                paramDataForm.Devises.Remove(name);
                listBox_Devases.Items.Remove(name);
            }
        }
        private void button_Sliv_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            ShowIcon = false;
            ShowInTaskbar = false;
        }
        #endregion Button

        #region ComboBox
        private void comboBox_DiskSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            curentDeviceName = deviceData.GetNameByIndex(comboBox_DiskSelection.SelectedIndex);
            button_SelectionConfirmation.Text = $"Настроить устройство: {curentDeviceName}";
        }
        #endregion ComboBox

        #region CheckBox
        private void checkBox_AUTOmod_CheckedChanged(object sender, EventArgs e)
        {
            paramDataForm.AutoMode = checkBox_AUTOmod.Checked;
        }
        #endregion CheckBox

        #region TrayByThisForm
        private void Click_Tray(IconTreyControl.TypeEvent typeEvent)
        {
            switch (typeEvent)
            {
                case IconTreyControl.TypeEvent.Show:
                    this.WindowState = FormWindowState.Normal;
                    ShowIcon = true;
                    ShowInTaskbar = true;
                    Show();
                    break;
                case IconTreyControl.TypeEvent.Close:
                    Application.Exit();
                    break;
            }
        }
        #endregion TrayByThisForm

        #endregion ControlThisForm

        #region WorkCodThisForm

        #region Data
        bool activ_InBackground = false;

        private DeviceTracking tracking;
        private DevicesData deviceData = new DevicesData();
        private char curentDeviceName;



        private ParamDataForm paramDataForm = new ParamDataForm();
        [Serializable]
        private struct ParamDataForm
        {
            public ParamDataForm() { }
            public bool AutoMode { get; set; } = false;
            public List<string> Devises = new List<string>();
        }
        //private DiologForm diologForm;
        #endregion Data

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
            catch(Exception ex)
            {
                MessageBox.Show("!!!ERROR!!!:" + ex.Message, "error");
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
        private void WorkInBackground_ACT()
        {
            if (!activ_InBackground)
            {
                activ_InBackground = true;
                tracking = new DeviceTracking();
                tracking.Start();
                tracking.NewCurentDrive += Tracking_NewCurentDrive;
                tracking.OffCurentDrive += Tracking_OffCurentDrive;

                label2.Text = "Работа в фоне: АКТИВНО";
                label2.ForeColor = Color.DarkGreen;
            }
        }
        private void WorkInBackground_PASS()
        {
            if (activ_InBackground)
            {
                activ_InBackground = false;
                if (tracking != null) tracking.Stop();

                label2.Text = "Работа в фоне: ИНЕРТНО";
                label2.ForeColor = Color.DarkRed;
            }
        }
        private void Tracking_NewCurentDrive(char nameDisk, string volumeLabel)
        {
            UpdateData();
            if (paramDataForm.Devises.Contains(deviceData.GetDataDevices(nameDisk)))
            {
                var passWord = "0";
                Devices_ActionsFile file = new Devices_ActionsFile(nameDisk, "PrivateData", "Log", "txt", passWord);
                backup.RunFile(file);
            }
            else
            {
                var res = MessageBox.Show($"Выбрать устройство: {deviceData.GetDataDevices(nameDisk)}", "Новое устройство", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes) SelectedDisk(deviceData.GetIndexDevices(nameDisk));
            }
        }
        private void Tracking_OffCurentDrive(char nameDisk, string volumeLabel)
        {
            MessageBox.Show($"Устройство [{volumeLabel}] - {nameDisk} отключено");
            UpdateData();
        }
        private void CreateNewFile()
        {
            var t = Serialization.StartSerialize<ParamDataForm>(paramDataForm);
            FileIO.OpenOrCreate(t.Item2, "Data.date");
        }
        #endregion WorkCodThisForm
    }
}