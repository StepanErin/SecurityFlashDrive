namespace SecurityFlashDrive
{
    partial class DiologForm
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
            label_Data = new Label();
            richTextBox_Data = new RichTextBox();
            label_Files = new Label();
            checkBox_AutoSave = new CheckBox();
            listBox_Files = new ListBox();
            textBox_InFile = new TextBox();
            button_AddFile = new Button();
            button_Del = new Button();
            label_Parametrs = new Label();
            checkBox_AutoBackupSave = new CheckBox();
            label_InDisk = new Label();
            label_FromFile = new Label();
            textBox_FromFile = new TextBox();
            button_OpenFromFile = new Button();
            button_OpenInFile = new Button();
            radioButton_Start = new RadioButton();
            radioButton_End = new RadioButton();
            textBox_NameFolder = new TextBox();
            label_FolderIn = new Label();
            label_NameFolder = new Label();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            button_Save = new Button();
            label_PassWord = new Label();
            textBox_PassWord = new TextBox();
            checkBox_OneFile = new CheckBox();
            textBox_OneFromFile = new TextBox();
            button_OpenOneFromFile = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // label_Data
            // 
            label_Data.AutoSize = true;
            label_Data.Location = new Point(12, 9);
            label_Data.Name = "label_Data";
            label_Data.Size = new Size(44, 20);
            label_Data.TabIndex = 0;
            label_Data.Text = "Data:";
            // 
            // richTextBox_Data
            // 
            richTextBox_Data.Location = new Point(12, 32);
            richTextBox_Data.Name = "richTextBox_Data";
            richTextBox_Data.Size = new Size(250, 128);
            richTextBox_Data.TabIndex = 1;
            richTextBox_Data.Text = "";
            // 
            // label_Files
            // 
            label_Files.AutoSize = true;
            label_Files.Location = new Point(12, 173);
            label_Files.Name = "label_Files";
            label_Files.Size = new Size(41, 20);
            label_Files.TabIndex = 4;
            label_Files.Text = "Files:";
            // 
            // checkBox_AutoSave
            // 
            checkBox_AutoSave.AutoSize = true;
            checkBox_AutoSave.Location = new Point(285, 32);
            checkBox_AutoSave.Name = "checkBox_AutoSave";
            checkBox_AutoSave.Size = new Size(98, 24);
            checkBox_AutoSave.TabIndex = 5;
            checkBox_AutoSave.Text = "Auto Save";
            checkBox_AutoSave.UseVisualStyleBackColor = true;
            // 
            // listBox_Files
            // 
            listBox_Files.FormattingEnabled = true;
            listBox_Files.ItemHeight = 20;
            listBox_Files.Location = new Point(12, 196);
            listBox_Files.Name = "listBox_Files";
            listBox_Files.Size = new Size(402, 64);
            listBox_Files.TabIndex = 6;
            // 
            // textBox_InFile
            // 
            textBox_InFile.Location = new Point(105, 299);
            textBox_InFile.Name = "textBox_InFile";
            textBox_InFile.Size = new Size(232, 27);
            textBox_InFile.TabIndex = 8;
            textBox_InFile.Text = "Directory";
            // 
            // button_AddFile
            // 
            button_AddFile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_AddFile.Location = new Point(420, 266);
            button_AddFile.Name = "button_AddFile";
            button_AddFile.Size = new Size(89, 90);
            button_AddFile.TabIndex = 9;
            button_AddFile.Text = "Add file";
            button_AddFile.UseVisualStyleBackColor = true;
            button_AddFile.Click += button_AddFile_Click;
            // 
            // button_Del
            // 
            button_Del.Location = new Point(420, 196);
            button_Del.Name = "button_Del";
            button_Del.Size = new Size(89, 64);
            button_Del.TabIndex = 10;
            button_Del.Text = "Del";
            button_Del.UseVisualStyleBackColor = true;
            // 
            // label_Parametrs
            // 
            label_Parametrs.AutoSize = true;
            label_Parametrs.Location = new Point(285, 9);
            label_Parametrs.Name = "label_Parametrs";
            label_Parametrs.Size = new Size(77, 20);
            label_Parametrs.TabIndex = 11;
            label_Parametrs.Text = "Parametrs:";
            // 
            // checkBox_AutoBackupSave
            // 
            checkBox_AutoBackupSave.AutoSize = true;
            checkBox_AutoBackupSave.Location = new Point(285, 72);
            checkBox_AutoBackupSave.Name = "checkBox_AutoBackupSave";
            checkBox_AutoBackupSave.Size = new Size(150, 24);
            checkBox_AutoBackupSave.TabIndex = 12;
            checkBox_AutoBackupSave.Text = "Auto Backup Save";
            checkBox_AutoBackupSave.UseVisualStyleBackColor = true;
            // 
            // label_InDisk
            // 
            label_InDisk.AutoSize = true;
            label_InDisk.Location = new Point(16, 306);
            label_InDisk.Name = "label_InDisk";
            label_InDisk.Size = new Size(71, 20);
            label_InDisk.TabIndex = 13;
            label_InDisk.Text = "IN (disk ):";
            // 
            // label_FromFile
            // 
            label_FromFile.AutoSize = true;
            label_FromFile.Location = new Point(14, 269);
            label_FromFile.Name = "label_FromFile";
            label_FromFile.Size = new Size(46, 20);
            label_FromFile.TabIndex = 15;
            label_FromFile.Text = "From:";
            // 
            // textBox_FromFile
            // 
            textBox_FromFile.Location = new Point(66, 266);
            textBox_FromFile.Name = "textBox_FromFile";
            textBox_FromFile.Size = new Size(271, 27);
            textBox_FromFile.TabIndex = 14;
            textBox_FromFile.Text = "File";
            // 
            // button_OpenFromFile
            // 
            button_OpenFromFile.Location = new Point(343, 266);
            button_OpenFromFile.Name = "button_OpenFromFile";
            button_OpenFromFile.Size = new Size(71, 27);
            button_OpenFromFile.TabIndex = 16;
            button_OpenFromFile.Text = "open";
            button_OpenFromFile.UseVisualStyleBackColor = true;
            button_OpenFromFile.Click += button_OpenFromFile_Click;
            // 
            // button_OpenInFile
            // 
            button_OpenInFile.Location = new Point(343, 299);
            button_OpenInFile.Name = "button_OpenInFile";
            button_OpenInFile.Size = new Size(71, 27);
            button_OpenInFile.TabIndex = 17;
            button_OpenInFile.Text = "open";
            button_OpenInFile.UseVisualStyleBackColor = true;
            button_OpenInFile.Click += button_OpenInFile_Click;
            // 
            // radioButton_Start
            // 
            radioButton_Start.AutoSize = true;
            radioButton_Start.Location = new Point(387, 105);
            radioButton_Start.Name = "radioButton_Start";
            radioButton_Start.Size = new Size(61, 24);
            radioButton_Start.TabIndex = 18;
            radioButton_Start.TabStop = true;
            radioButton_Start.Text = "Start";
            radioButton_Start.UseVisualStyleBackColor = true;
            // 
            // radioButton_End
            // 
            radioButton_End.AutoSize = true;
            radioButton_End.Location = new Point(454, 105);
            radioButton_End.Name = "radioButton_End";
            radioButton_End.Size = new Size(55, 24);
            radioButton_End.TabIndex = 19;
            radioButton_End.TabStop = true;
            radioButton_End.Text = "End";
            radioButton_End.UseVisualStyleBackColor = true;
            // 
            // textBox_NameFolder
            // 
            textBox_NameFolder.Location = new Point(387, 133);
            textBox_NameFolder.Name = "textBox_NameFolder";
            textBox_NameFolder.Size = new Size(122, 27);
            textBox_NameFolder.TabIndex = 20;
            // 
            // label_FolderIn
            // 
            label_FolderIn.AutoSize = true;
            label_FolderIn.Location = new Point(285, 105);
            label_FolderIn.Name = "label_FolderIn";
            label_FolderIn.Size = new Size(70, 20);
            label_FolderIn.TabIndex = 21;
            label_FolderIn.Text = "Folder in:";
            // 
            // label_NameFolder
            // 
            label_NameFolder.AutoSize = true;
            label_NameFolder.Location = new Point(285, 137);
            label_NameFolder.Name = "label_NameFolder";
            label_NameFolder.Size = new Size(96, 20);
            label_NameFolder.TabIndex = 22;
            label_NameFolder.Text = "Name folder:";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // button_Save
            // 
            button_Save.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Save.Location = new Point(343, 362);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(166, 50);
            button_Save.TabIndex = 23;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // label_PassWord
            // 
            label_PassWord.AutoSize = true;
            label_PassWord.Location = new Point(14, 362);
            label_PassWord.Name = "label_PassWord";
            label_PassWord.Size = new Size(75, 20);
            label_PassWord.TabIndex = 25;
            label_PassWord.Text = "PassWord:";
            // 
            // textBox_PassWord
            // 
            textBox_PassWord.Location = new Point(12, 385);
            textBox_PassWord.Name = "textBox_PassWord";
            textBox_PassWord.Size = new Size(325, 27);
            textBox_PassWord.TabIndex = 24;
            textBox_PassWord.TextChanged += textBox_PassWord_TextChanged;
            // 
            // checkBox_OneFile
            // 
            checkBox_OneFile.AutoSize = true;
            checkBox_OneFile.Location = new Point(16, 335);
            checkBox_OneFile.Name = "checkBox_OneFile";
            checkBox_OneFile.Size = new Size(85, 24);
            checkBox_OneFile.TabIndex = 26;
            checkBox_OneFile.Text = "One File";
            checkBox_OneFile.UseVisualStyleBackColor = true;
            // 
            // textBox_OneFromFile
            // 
            textBox_OneFromFile.Location = new Point(105, 333);
            textBox_OneFromFile.Name = "textBox_OneFromFile";
            textBox_OneFromFile.Size = new Size(232, 27);
            textBox_OneFromFile.TabIndex = 27;
            textBox_OneFromFile.Text = "Directory";
            // 
            // button_OpenOneFromFile
            // 
            button_OpenOneFromFile.Location = new Point(343, 332);
            button_OpenOneFromFile.Name = "button_OpenOneFromFile";
            button_OpenOneFromFile.Size = new Size(71, 27);
            button_OpenOneFromFile.TabIndex = 28;
            button_OpenOneFromFile.Text = "open";
            button_OpenOneFromFile.UseVisualStyleBackColor = true;
            button_OpenOneFromFile.Click += button_OpenOneFromFile_Click;
            // 
            // DiologForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 430);
            Controls.Add(button_OpenOneFromFile);
            Controls.Add(textBox_OneFromFile);
            Controls.Add(checkBox_OneFile);
            Controls.Add(label_PassWord);
            Controls.Add(textBox_PassWord);
            Controls.Add(button_Save);
            Controls.Add(label_NameFolder);
            Controls.Add(label_FolderIn);
            Controls.Add(textBox_NameFolder);
            Controls.Add(radioButton_End);
            Controls.Add(radioButton_Start);
            Controls.Add(button_OpenInFile);
            Controls.Add(button_OpenFromFile);
            Controls.Add(label_FromFile);
            Controls.Add(textBox_FromFile);
            Controls.Add(label_InDisk);
            Controls.Add(checkBox_AutoBackupSave);
            Controls.Add(label_Parametrs);
            Controls.Add(button_Del);
            Controls.Add(button_AddFile);
            Controls.Add(textBox_InFile);
            Controls.Add(listBox_Files);
            Controls.Add(checkBox_AutoSave);
            Controls.Add(label_Files);
            Controls.Add(richTextBox_Data);
            Controls.Add(label_Data);
            Name = "DiologForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Data;
        private RichTextBox richTextBox_Data;
        private Label label_Files;
        private CheckBox checkBox_AutoSave;
        private ListBox listBox_Files;
        private TextBox textBox_InFile;
        private Button button_AddFile;
        private Button button_Del;
        private Label label_Parametrs;
        private CheckBox checkBox_AutoBackupSave;
        private Label label_InDisk;
        private Label label_FromFile;
        private TextBox textBox_FromFile;
        private Button button_OpenFromFile;
        private Button button_OpenInFile;
        private RadioButton radioButton_Start;
        private RadioButton radioButton_End;
        private TextBox textBox_NameFolder;
        private Label label_FolderIn;
        private Label label_NameFolder;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button button_Save;
        private Label label_PassWord;
        private TextBox textBox_PassWord;
        private CheckBox checkBox_OneFile;
        private TextBox textBox_OneFromFile;
        private Button button_OpenOneFromFile;
        private FolderBrowserDialog folderBrowserDialog;
    }
}