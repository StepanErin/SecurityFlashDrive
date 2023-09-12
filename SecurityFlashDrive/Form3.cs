using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SecurityFlashDrive.FormatData;

namespace SecurityFlashDrive
{
    public partial class Form3 : Form
    {
        private char disk = '\0';
        /// <summary>
        /// Файл
        /// </summary>
        private ActionsDataFile curentActionsDataFile;
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

        public void ShowFormCurrentData(ActionsDataFile actionsDataFile)
        {
            curentActionsDataFile = actionsDataFile;
            curentActionsDataFile.DownloadData();
            UpdateData(curentActionsDataFile);
            Show();
        }
        private void UpdateData(DataFile dataFile)
        {
            disk = dataFile.Path.NameDisk;
        }

        private void button_OpenOneFromFile_Click(object sender, EventArgs e)
        {
            var t = OpenDirectory();
            if (t != null) textBox_OneFromFile.Text = t;
        }



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

        #region Button

        private void button_Save_Click(object sender, EventArgs e)
        {
            var valid = ValidPWD();
            var res = MessageBox.Show("Перезаписать файл?", "Подтверждение", MessageBoxButtons.YesNo);
            //if (!valid) return;
            //curentActionsDataFile.PassWord = textBox_PassWord.Text;
            if (res == DialogResult.Yes) curentActionsDataFile.SaveData(CollectDataFromForm());
            else MessageBox.Show("Отмена");
        }

        private void button_Del_Click(object sender, EventArgs e)
        {

        }

        private void button_Open_Click(object sender, EventArgs e)
        {

        }

        private void button_Open2_Click(object sender, EventArgs e)
        {

        }

        private void button_AddFile_Click(object sender, EventArgs e)
        {

        }
        #endregion Button


        #region WorkCodThisForm
        private FormatData CollectDataFromForm()
        {
            var parametrsData_TEMP1 = new ParametrsData
            {
                AutoSave = checkBox_AutoSave.Checked,
                AutoBackupSave = checkBox_AutoBackupSave.Checked,
                FolderInStartOrEnd = radioButton_Common.Checked,
                NameFolder = textBox_NameFolder.Text,
            };


            var filesData_TEMP2 = filesData;

            var formatData_RES = new FormatData
            {
                DataSTR = richTextBox_Data.Text,
                Parametrs = parametrsData_TEMP1,
                Files = filesData_TEMP2,
            };

            return formatData_RES;
        }
        private bool ValidPWD()
        {
            if (string.IsNullOrEmpty(textBox_PassWord.Text))
            {
                MessageBox.Show("Введите пароль");
                return false;
            }
            if (textBox_PassWord.Text.Length < 4)
            {
                MessageBox.Show("Пароль слишком короткий");
                return false;
            }
            return true;
        }
        #endregion WorkCodThisForm
    }
}
