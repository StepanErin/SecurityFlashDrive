using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SecurityFlashDrive.Devices_FormatData;
using static System.Net.Mime.MediaTypeNames;

namespace SecurityFlashDrive
{
    public partial class Form3 : Form
    {
        //System.Diagnostics.Process.Start("explorer", "C:\\");




        #region Data
        private char disk = '\0';
        /// <summary>
        /// Управление файлом
        /// </summary>
        private Devices_ActionsFile curentActionsDataFile;
        #endregion Data

        #region TreatmentThisForm
        public Form3()
        {
            InitializeComponent();
            FormClosing += DiologForm_FormClosing;
        }

        private void DiologForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        #endregion TreatmentThisForm

        #region Show
        /// <summary>
        /// Показать форму
        /// </summary>
        /// <param name="actionsDataFile">Файл для управления</param>
        public void ShowForm(Devices_ActionsFile actionsDataFile)
        {
            curentActionsDataFile = actionsDataFile;
            curentActionsDataFile.DownloadData();
            UpdateData(curentActionsDataFile);
            Show();
        }
        private List<UserFile> userFiles = new List<UserFile>();
        #endregion Show



        #region UpdateData
        /// <summary>
        /// Обновить форму
        /// </summary>
        /// <param name="dataFile"></param>
        private void UpdateData(Devices_File dataFile)
        {
            disk = dataFile.Path.NameDisk;

            var data = dataFile.DataFormat;
            radioButton_Saving_YesAsk.Checked = data.Parametrs.AskAboutSaving;
            richTextBox_Data.Text = data.DataSTR;
            userFiles = data.Files;
            UpdateData_Files();
        }

        private void UpdateData_Files()
        {
            int i = listBox_Files.SelectedIndex;
            listBox_Files.Items.Clear();
            foreach (var item in userFiles) listBox_Files.Items.Add(item.PathFile);

            int c = listBox_Files.Items.Count;
            if (i < c)
                listBox_Files.SelectedIndex = i;
            else if (c != 0)
                listBox_Files.SelectedIndex = c - 1;
        }
        #endregion UpdateData


        #region Button

        private void button_OpenOneFromFile_Click(object sender, EventArgs e)
        {
            var t = OpenDirectory();
            if (t != null) textBox_GlobalFile.Text = t;
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            var valid = ValidPWD(textBox_PassWord.Text);
            var res = MessageBox.Show("Перезаписать файл?", "Подтверждение", MessageBoxButtons.YesNo);
            //if (!valid) return;
            //curentActionsDataFile.PassWord = textBox_PassWord.Text;
            if (res == DialogResult.Yes) curentActionsDataFile.SaveData(CollectDataFromForm());
            else MessageBox.Show("Отмена");
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            int i = listBox_Files.SelectedIndex;
            if (i != -1)
                userFiles.RemoveAt(i);
            UpdateData_Files();
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            var res = OpenFile();
            if (res != null && res[0] != disk)
                textBox_FilePach.Text = res;
        }
        private void button_OpenDirectory_Click(object sender, EventArgs e)
        {
            var t = OpenDirectory();
            if (t != null) textBox_Directory.Text = t;
        }

        private void button_AddFile_Click(object sender, EventArgs e)
        {
            var pwd = textBox_PassWord_File.Text;
            if (string.IsNullOrEmpty(pwd))
            {
                if (MessageBox.Show("добавить файл без пороля?", "Подтверждение", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                    return;
            }
            else if (!ValidPWD(pwd)) return;

            var p1 = DataPath.NewDataPath(textBox_FilePach.Text);
            if (!p1.Item1)
            {
                MessageBox.Show("Ошибка в пути к файлу");
                return;
            }
            var p2 = DataPath.NewDataDirectory(textBox_Directory.Text);
            if (!p2.Item1)
            {
                MessageBox.Show("Ошибка в пути Директории");
                return;
            }
            if (p2.Item2.NameDisk != disk)
            {
                MessageBox.Show("Неверный диск");
                return;
            }

            userFiles.Add(new UserFile(p1.Item2, p2.Item2, pwd));
            UpdateData_Files();
        }
        #endregion Button


        #region WorkCodThisForm
        /// <summary>
        /// Собрать данные с формы
        /// </summary>
        /// <returns></returns>
        private Devices_FormatData CollectDataFromForm()
        {
            var parametrsData_TEMP = new ParametrsData
            {
                AskAboutSaving = radioButton_Saving_YesAsk.Checked
            };

            var formatData_RES = new Devices_FormatData
            {
                DataSTR = richTextBox_Data.Text,
                Parametrs = parametrsData_TEMP,
                Files = userFiles,
            };

            return formatData_RES;
        }
        private bool ValidPWD(string txt)
        {
            if (string.IsNullOrEmpty(txt))
            {
                MessageBox.Show("Введите пароль");
                return false;
            }
            if (txt.Length < 4)
            {
                MessageBox.Show("Пароль слишком короткий");
                return false;
            }
            return true;
        }
        #endregion WorkCodThisForm








        private string OpenFile()
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return null;
            return openFileDialog.FileName;
        }
        private string OpenDirectory()
        {
            folderBrowserDialog.SelectedPath = "";
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel) return null;
            if (folderBrowserDialog.SelectedPath[0] != disk) return null;
            return folderBrowserDialog.SelectedPath;
        }

        /// <summary>
        /// Выбор вкладки данных
        /// </summary>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox_Info.Text = CollectDataFromForm().ToString();
        }
    }
}
