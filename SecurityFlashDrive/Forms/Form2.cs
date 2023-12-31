﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SecurityFlashDrive.Devices_File;
using static SecurityFlashDrive.Devices_FormatData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SecurityFlashDrive
{
    public partial class EditFile_Form : Form
    {
        private char disk = '\0';
        #region TreatmentThisForm
        public EditFile_Form()
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


        #region ControlThisForm

        #region Button

        #region Open
        private void button_OpenFromFile_Click(object sender, EventArgs e)
        {
            var t = OpenFile();
            if (t != null) textBox_FromFile.Text = t;
        }
        private void button_OpenOneFromFile_Click(object sender, EventArgs e)
        {
            var t = OpenDirectory();
            if (t != null) textBox_OneFromFile.Text = t;
        }
        private void button_OpenInFile_Click(object sender, EventArgs e)
        {
            var t = OpenDirectory();
            if (t != null) textBox_InFile.Text = t;
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
        #endregion Open


        private void button_Save_Click(object sender, EventArgs e)
        {
            var valid = ValidPWD();
            var res = MessageBox.Show("Перезаписать файл?", "Подтверждение", MessageBoxButtons.YesNo);
            //if (!valid) return;
            //curentActionsDataFile.PassWord = textBox_PassWord.Text;
            if (res == DialogResult.Yes) curentActionsDataFile.SaveData(CollectDataFromForm());
            else MessageBox.Show("Отмена");
        }
        private void button_AddFile_Click(object sender, EventArgs e)
        {
            /*
            var valid_From = DataPath.NewDataPath(textBox_FromFile.Text);
            var valid_In = DataPath.NewDataPath(textBox_InFile.Text);
            if (filesData == null) filesData = new List<UserFile>();
            if (valid_From.Item1 && valid_In.Item1)
                filesData.Add(new UserFile { PathFromFile = valid_From.Item2, PathInFile = valid_In.Item2 });
            else
                MessageBox.Show($"Путь указан не верно!");
            listBox_Files_UpdateData();
            */
        }
        #endregion Button


        #endregion ControlThisForm



        #region WorkCodThisForm
        private Devices_ActionsFile curentActionsDataFile;
        List<Devices_FormatData.UserFile> filesData = new List<Devices_FormatData.UserFile>();
        private Devices_FormatData CollectDataFromForm()
        {
            var parametrsData_TEMP1 = new ParametrsData
            {
                /*
                AutoSave = checkBox_AutoSave.Checked,
                AutoBackupSave = checkBox_AutoBackupSave.Checked,
                FolderInStartOrEnd = radioButton_Common.Checked,
                NameFolder = textBox_NameFolder.Text,
                */
            };


            var filesData_TEMP2 = filesData;

            var formatData_RES = new Devices_FormatData
            {
                DataSTR = richTextBox_Data.Text,
                Parametrs = parametrsData_TEMP1,
                Files = filesData_TEMP2,
            };

            return formatData_RES;
        }
        private void UpdateData(Devices_File dataFile)
        {
            /*
            disk = dataFile.Path.NameDisk;
            label_InDisk.Text = $"IN (disk {disk}):";
            textBox_PassWord.Text = dataFile.PassWord;
            textBox_InFile.Text = dataFile.Path.FullPath;


            var formatData = dataFile.DataFormat;
            richTextBox_Data.Text = formatData.DataSTR;
            filesData = formatData.Files;

            #region Parametrs
            var parametrsData = formatData.Parametrs;

            checkBox_AutoSave.Checked = parametrsData.AutoSave;
            checkBox_AutoBackupSave.Checked = parametrsData.AutoBackupSave;
            radioButton_Common.Checked = parametrsData.FolderInStartOrEnd;
            radioButton_Separate.Checked = !parametrsData.FolderInStartOrEnd;
            textBox_NameFolder.Text = parametrsData.NameFolder;
            #endregion Parametrs
            */
            listBox_Files_UpdateData();
            /*
            DataFileForm dataFileForm = new DataFileForm(dataFile.Data);
            richTextBox_Data.Text = dataFileForm.Data;
            */
        }
        private void listBox_Files_UpdateData()
        {
            listBox_Files.Items.Clear();
            if (filesData != null)
                foreach (var item in filesData)
                    listBox_Files.Items.Add($"{item}");
        }
        #endregion WorkCodThisForm

        public void ShowFormCurrentData(Devices_ActionsFile actionsDataFile)
        {
            curentActionsDataFile = actionsDataFile;
            curentActionsDataFile.DownloadData();
            UpdateData(curentActionsDataFile);
            Show();
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
        private void textBox_PassWord_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
