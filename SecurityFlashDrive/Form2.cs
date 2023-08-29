using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SecurityFlashDrive.DataFile;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SecurityFlashDrive
{
    public partial class DiologForm : Form
    {
        private ActionsDataFile curentActionsDataFile;
        private DataFile.FileFormat fileFormat;
        public void ShowFormCurrentData(ActionsDataFile actionsDataFile)
        {
            curentActionsDataFile = actionsDataFile;
            curentActionsDataFile.DownloadDataBBB();
            UpdateData(curentActionsDataFile);
            Show();
        }
        private void UpdateData(DataFile dataFile)
        {
            label_InDisk.Text = $"IN {dataFile.Path.NameDisk}:/";
            textBox_PassWord.Text = dataFile.PassWord;
            textBox_InFile.Text = dataFile.Path.FullPath;


            fileFormat = dataFile.DataFormat;
            richTextBox_Data.Text = fileFormat.DataSTR;

            /*
            DataFileForm dataFileForm = new DataFileForm(dataFile.Data);
            richTextBox_Data.Text = dataFileForm.Data;
            */
        }
        private void DiologForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public DiologForm()
        {
            InitializeComponent();
        }
        private void richTextBox_Data_TextChanged(object sender, EventArgs e)
        {
            fileFormat.DataSTR = richTextBox_Data.Text;
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            var valid = ValidPWD();
            var res = MessageBox.Show("Перезаписать файл?", "Подтверждение", MessageBoxButtons.YesNo);
            //if (!valid) return;
            //curentActionsDataFile.PassWord = textBox_PassWord.Text;
            if (res == DialogResult.Yes) curentActionsDataFile.SaveData(fileFormat);
            else MessageBox.Show("Отмена");
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

        private void button_OpenFromFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            var fullPach = openFileDialog.FileName;
            textBox_FromFile.Text = fullPach;
        }

    }
}
