namespace SecurityFlashDrive
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage_Save = new TabPage();
            button_Save = new Button();
            label_Information = new Label();
            richTextBox1 = new RichTextBox();
            tabPage_Files = new TabPage();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button_Open = new Button();
            button_Open2 = new Button();
            label5 = new Label();
            button_Del = new Button();
            button_AddFile = new Button();
            listBox1 = new ListBox();
            tabPage_Data = new TabPage();
            richTextBox_Data = new RichTextBox();
            tabPage_Parametrs = new TabPage();
            label_FileDirectory = new Label();
            button_OpenOneFromFile = new Button();
            textBox_OneFromFile = new TextBox();
            label_PassWord = new Label();
            textBox_PassWord = new TextBox();
            checkBox_AutoBackupSave = new CheckBox();
            checkBox_AutoSave = new CheckBox();
            tabControl = new TabControl();
            openFileDialog = new OpenFileDialog();
            folderBrowserDialog = new FolderBrowserDialog();
            tabPage_Save.SuspendLayout();
            tabPage_Files.SuspendLayout();
            tabPage_Data.SuspendLayout();
            tabPage_Parametrs.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage_Save
            // 
            tabPage_Save.Controls.Add(button_Save);
            tabPage_Save.Controls.Add(label_Information);
            tabPage_Save.Controls.Add(richTextBox1);
            tabPage_Save.Location = new Point(4, 29);
            tabPage_Save.Name = "tabPage_Save";
            tabPage_Save.Padding = new Padding(3);
            tabPage_Save.Size = new Size(522, 242);
            tabPage_Save.TabIndex = 3;
            tabPage_Save.Text = "Save";
            tabPage_Save.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            button_Save.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Save.Location = new Point(355, 196);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(164, 43);
            button_Save.TabIndex = 24;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // label_Information
            // 
            label_Information.AutoSize = true;
            label_Information.Location = new Point(6, 3);
            label_Information.Name = "label_Information";
            label_Information.Size = new Size(87, 20);
            label_Information.TabIndex = 3;
            label_Information.Text = "Information";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(510, 164);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // tabPage_Files
            // 
            tabPage_Files.Controls.Add(textBox3);
            tabPage_Files.Controls.Add(textBox4);
            tabPage_Files.Controls.Add(textBox5);
            tabPage_Files.Controls.Add(label2);
            tabPage_Files.Controls.Add(label3);
            tabPage_Files.Controls.Add(label4);
            tabPage_Files.Controls.Add(radioButton1);
            tabPage_Files.Controls.Add(radioButton2);
            tabPage_Files.Controls.Add(button_Open);
            tabPage_Files.Controls.Add(button_Open2);
            tabPage_Files.Controls.Add(label5);
            tabPage_Files.Controls.Add(button_Del);
            tabPage_Files.Controls.Add(button_AddFile);
            tabPage_Files.Controls.Add(listBox1);
            tabPage_Files.Location = new Point(4, 29);
            tabPage_Files.Name = "tabPage_Files";
            tabPage_Files.Padding = new Padding(3);
            tabPage_Files.Size = new Size(522, 242);
            tabPage_Files.TabIndex = 2;
            tabPage_Files.Text = "Files";
            tabPage_Files.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(317, 27);
            textBox3.TabIndex = 61;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 201);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(223, 27);
            textBox4.TabIndex = 59;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(98, 84);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(317, 27);
            textBox5.TabIndex = 51;
            textBox5.Text = "File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 201);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 60;
            label2.Text = "PassWord:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 120);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 58;
            label3.Text = "Name File:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 150);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 57;
            label4.Text = "Folder in:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(195, 150);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(89, 24);
            radioButton1.TabIndex = 56;
            radioButton1.TabStop = true;
            radioButton1.Text = "Separate";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(98, 150);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 24);
            radioButton2.TabIndex = 55;
            radioButton2.TabStop = true;
            radioButton2.Text = "Common";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button_Open
            // 
            button_Open.Location = new Point(421, 84);
            button_Open.Name = "button_Open";
            button_Open.Size = new Size(89, 27);
            button_Open.TabIndex = 54;
            button_Open.Text = "Open";
            button_Open.UseVisualStyleBackColor = true;
            button_Open.Click += button_Open_Click;
            // 
            // button_Open2
            // 
            button_Open2.Location = new Point(421, 117);
            button_Open2.Name = "button_Open2";
            button_Open2.Size = new Size(89, 27);
            button_Open2.TabIndex = 53;
            button_Open2.Text = "Open";
            button_Open2.UseVisualStyleBackColor = true;
            button_Open2.Click += button_Open2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 87);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 52;
            label5.Text = "From:";
            // 
            // button_Del
            // 
            button_Del.Location = new Point(421, 14);
            button_Del.Name = "button_Del";
            button_Del.Size = new Size(89, 64);
            button_Del.TabIndex = 50;
            button_Del.Text = "Del";
            button_Del.UseVisualStyleBackColor = true;
            button_Del.Click += button_Del_Click;
            // 
            // button_AddFile
            // 
            button_AddFile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_AddFile.Location = new Point(327, 150);
            button_AddFile.Name = "button_AddFile";
            button_AddFile.Size = new Size(183, 78);
            button_AddFile.TabIndex = 49;
            button_AddFile.Text = "Add file";
            button_AddFile.UseVisualStyleBackColor = true;
            button_AddFile.Click += button_AddFile_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(13, 14);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(402, 64);
            listBox1.TabIndex = 48;
            // 
            // tabPage_Data
            // 
            tabPage_Data.Controls.Add(richTextBox_Data);
            tabPage_Data.Location = new Point(4, 29);
            tabPage_Data.Name = "tabPage_Data";
            tabPage_Data.Padding = new Padding(3);
            tabPage_Data.Size = new Size(522, 242);
            tabPage_Data.TabIndex = 1;
            tabPage_Data.Text = "Data";
            tabPage_Data.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Data
            // 
            richTextBox_Data.Location = new Point(6, 6);
            richTextBox_Data.Name = "richTextBox_Data";
            richTextBox_Data.Size = new Size(510, 220);
            richTextBox_Data.TabIndex = 2;
            richTextBox_Data.Text = "";
            // 
            // tabPage_Parametrs
            // 
            tabPage_Parametrs.Controls.Add(label_FileDirectory);
            tabPage_Parametrs.Controls.Add(button_OpenOneFromFile);
            tabPage_Parametrs.Controls.Add(textBox_OneFromFile);
            tabPage_Parametrs.Controls.Add(label_PassWord);
            tabPage_Parametrs.Controls.Add(textBox_PassWord);
            tabPage_Parametrs.Controls.Add(checkBox_AutoBackupSave);
            tabPage_Parametrs.Controls.Add(checkBox_AutoSave);
            tabPage_Parametrs.Location = new Point(4, 29);
            tabPage_Parametrs.Name = "tabPage_Parametrs";
            tabPage_Parametrs.Padding = new Padding(3);
            tabPage_Parametrs.Size = new Size(522, 242);
            tabPage_Parametrs.TabIndex = 0;
            tabPage_Parametrs.Text = "Parametrs";
            tabPage_Parametrs.UseVisualStyleBackColor = true;
            // 
            // label_FileDirectory
            // 
            label_FileDirectory.AutoSize = true;
            label_FileDirectory.Location = new Point(12, 39);
            label_FileDirectory.Name = "label_FileDirectory";
            label_FileDirectory.Size = new Size(96, 20);
            label_FileDirectory.TabIndex = 34;
            label_FileDirectory.Text = "FileDirectory:";
            // 
            // button_OpenOneFromFile
            // 
            button_OpenOneFromFile.Location = new Point(266, 36);
            button_OpenOneFromFile.Name = "button_OpenOneFromFile";
            button_OpenOneFromFile.Size = new Size(71, 27);
            button_OpenOneFromFile.TabIndex = 33;
            button_OpenOneFromFile.Text = "Open";
            button_OpenOneFromFile.UseVisualStyleBackColor = true;
            button_OpenOneFromFile.Click += button_OpenOneFromFile_Click;
            // 
            // textBox_OneFromFile
            // 
            textBox_OneFromFile.Location = new Point(114, 36);
            textBox_OneFromFile.Name = "textBox_OneFromFile";
            textBox_OneFromFile.Size = new Size(146, 27);
            textBox_OneFromFile.TabIndex = 32;
            textBox_OneFromFile.Text = "Directory";
            // 
            // label_PassWord
            // 
            label_PassWord.AutoSize = true;
            label_PassWord.Location = new Point(12, 72);
            label_PassWord.Name = "label_PassWord";
            label_PassWord.Size = new Size(75, 20);
            label_PassWord.TabIndex = 31;
            label_PassWord.Text = "PassWord:";
            // 
            // textBox_PassWord
            // 
            textBox_PassWord.Location = new Point(114, 69);
            textBox_PassWord.Name = "textBox_PassWord";
            textBox_PassWord.Size = new Size(223, 27);
            textBox_PassWord.TabIndex = 30;
            // 
            // checkBox_AutoBackupSave
            // 
            checkBox_AutoBackupSave.AutoSize = true;
            checkBox_AutoBackupSave.Location = new Point(110, 6);
            checkBox_AutoBackupSave.Name = "checkBox_AutoBackupSave";
            checkBox_AutoBackupSave.Size = new Size(150, 24);
            checkBox_AutoBackupSave.TabIndex = 14;
            checkBox_AutoBackupSave.Text = "Auto Backup Save";
            checkBox_AutoBackupSave.UseVisualStyleBackColor = true;
            // 
            // checkBox_AutoSave
            // 
            checkBox_AutoSave.AutoSize = true;
            checkBox_AutoSave.Location = new Point(6, 6);
            checkBox_AutoSave.Name = "checkBox_AutoSave";
            checkBox_AutoSave.Size = new Size(98, 24);
            checkBox_AutoSave.TabIndex = 13;
            checkBox_AutoSave.Text = "Auto Save";
            checkBox_AutoSave.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage_Parametrs);
            tabControl.Controls.Add(tabPage_Data);
            tabControl.Controls.Add(tabPage_Files);
            tabControl.Controls.Add(tabPage_Save);
            tabControl.Location = new Point(12, 12);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(530, 275);
            tabControl.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = ".";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 299);
            Controls.Add(tabControl);
            Name = "Form3";
            Text = "Form3";
            tabPage_Save.ResumeLayout(false);
            tabPage_Save.PerformLayout();
            tabPage_Files.ResumeLayout(false);
            tabPage_Files.PerformLayout();
            tabPage_Data.ResumeLayout(false);
            tabPage_Parametrs.ResumeLayout(false);
            tabPage_Parametrs.PerformLayout();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage_Save;
        private TabPage tabPage_Files;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button_Open;
        private Button button_Open2;
        private Label label5;
        private Button button_Del;
        private ListBox listBox1;
        private TabPage tabPage_Data;
        private TabPage tabPage_Parametrs;
        private CheckBox checkBox_AutoBackupSave;
        private CheckBox checkBox_AutoSave;
        private TabControl tabControl;
        private RichTextBox richTextBox_Data;
        private Label label_FileDirectory;
        private Button button_OpenOneFromFile;
        private TextBox textBox_OneFromFile;
        private Label label_PassWord;
        private TextBox textBox_PassWord;
        private Label label_Information;
        private RichTextBox richTextBox1;
        private Button button_Save;
        private OpenFileDialog openFileDialog;
        private FolderBrowserDialog folderBrowserDialog;
        private Button button_AddFile;
    }
}