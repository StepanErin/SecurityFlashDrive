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
            richTextBox_Info = new RichTextBox();
            tabPage_Files = new TabPage();
            label_Directory = new Label();
            button_OpenDirectory = new Button();
            textBox_Directory = new TextBox();
            textBox_FilePach = new TextBox();
            textBox_PassWord_File = new TextBox();
            label2 = new Label();
            label_FilePach = new Label();
            button_Open2 = new Button();
            button_Del = new Button();
            button_AddFile = new Button();
            listBox_Files = new ListBox();
            tabPage_Data = new TabPage();
            richTextBox_Data = new RichTextBox();
            tabPage_Parametrs = new TabPage();
            radioButton_Saving_NoAsk = new RadioButton();
            radioButton_Saving_YesAsk = new RadioButton();
            label_GlobalFile = new Label();
            button_OpenGlobalFile = new Button();
            textBox_GlobalFile = new TextBox();
            label_PassWord = new Label();
            textBox_PassWord = new TextBox();
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
            tabPage_Save.Controls.Add(richTextBox_Info);
            tabPage_Save.Location = new Point(4, 29);
            tabPage_Save.Name = "tabPage_Save";
            tabPage_Save.Padding = new Padding(3);
            tabPage_Save.Size = new Size(522, 339);
            tabPage_Save.TabIndex = 3;
            tabPage_Save.Text = "Save";
            tabPage_Save.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            button_Save.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Save.Location = new Point(352, 121);
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
            // richTextBox_Info
            // 
            richTextBox_Info.Location = new Point(6, 26);
            richTextBox_Info.Name = "richTextBox_Info";
            richTextBox_Info.Size = new Size(510, 89);
            richTextBox_Info.TabIndex = 2;
            richTextBox_Info.Text = "";
            // 
            // tabPage_Files
            // 
            tabPage_Files.Controls.Add(label_Directory);
            tabPage_Files.Controls.Add(button_OpenDirectory);
            tabPage_Files.Controls.Add(textBox_Directory);
            tabPage_Files.Controls.Add(textBox_FilePach);
            tabPage_Files.Controls.Add(textBox_PassWord_File);
            tabPage_Files.Controls.Add(label2);
            tabPage_Files.Controls.Add(label_FilePach);
            tabPage_Files.Controls.Add(button_Open2);
            tabPage_Files.Controls.Add(button_Del);
            tabPage_Files.Controls.Add(button_AddFile);
            tabPage_Files.Controls.Add(listBox_Files);
            tabPage_Files.Location = new Point(4, 29);
            tabPage_Files.Name = "tabPage_Files";
            tabPage_Files.Padding = new Padding(3);
            tabPage_Files.Size = new Size(522, 198);
            tabPage_Files.TabIndex = 2;
            tabPage_Files.Text = "Files";
            tabPage_Files.UseVisualStyleBackColor = true;
            // 
            // label_Directory
            // 
            label_Directory.AutoSize = true;
            label_Directory.Location = new Point(13, 120);
            label_Directory.Name = "label_Directory";
            label_Directory.Size = new Size(73, 20);
            label_Directory.TabIndex = 64;
            label_Directory.Text = "Directory:";
            // 
            // button_OpenDirectory
            // 
            button_OpenDirectory.Location = new Point(326, 117);
            button_OpenDirectory.Name = "button_OpenDirectory";
            button_OpenDirectory.Size = new Size(89, 27);
            button_OpenDirectory.TabIndex = 63;
            button_OpenDirectory.Text = "Open";
            button_OpenDirectory.UseVisualStyleBackColor = true;
            button_OpenDirectory.Click += button_OpenDirectory_Click;
            // 
            // textBox_Directory
            // 
            textBox_Directory.Location = new Point(98, 117);
            textBox_Directory.Name = "textBox_Directory";
            textBox_Directory.Size = new Size(222, 27);
            textBox_Directory.TabIndex = 62;
            textBox_Directory.Text = "Directory";
            // 
            // textBox_FilePach
            // 
            textBox_FilePach.Location = new Point(98, 84);
            textBox_FilePach.Name = "textBox_FilePach";
            textBox_FilePach.Size = new Size(222, 27);
            textBox_FilePach.TabIndex = 61;
            textBox_FilePach.Text = "FilePach";
            // 
            // textBox_PassWord_File
            // 
            textBox_PassWord_File.Location = new Point(98, 150);
            textBox_PassWord_File.Name = "textBox_PassWord_File";
            textBox_PassWord_File.Size = new Size(222, 27);
            textBox_PassWord_File.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 153);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 60;
            label2.Text = "PassWord:";
            // 
            // label_FilePach
            // 
            label_FilePach.AutoSize = true;
            label_FilePach.Location = new Point(13, 87);
            label_FilePach.Name = "label_FilePach";
            label_FilePach.Size = new Size(69, 20);
            label_FilePach.TabIndex = 58;
            label_FilePach.Text = "File Pach:";
            // 
            // button_Open2
            // 
            button_Open2.Location = new Point(326, 84);
            button_Open2.Name = "button_Open2";
            button_Open2.Size = new Size(89, 27);
            button_Open2.TabIndex = 53;
            button_Open2.Text = "Open";
            button_Open2.UseVisualStyleBackColor = true;
            button_Open2.Click += button_Open_Click;
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
            button_AddFile.Location = new Point(421, 81);
            button_AddFile.Name = "button_AddFile";
            button_AddFile.Size = new Size(89, 63);
            button_AddFile.TabIndex = 49;
            button_AddFile.Text = "Add";
            button_AddFile.UseVisualStyleBackColor = true;
            button_AddFile.Click += button_AddFile_Click;
            // 
            // listBox_Files
            // 
            listBox_Files.FormattingEnabled = true;
            listBox_Files.ItemHeight = 20;
            listBox_Files.Location = new Point(13, 14);
            listBox_Files.Name = "listBox_Files";
            listBox_Files.Size = new Size(402, 64);
            listBox_Files.TabIndex = 48;
            // 
            // tabPage_Data
            // 
            tabPage_Data.Controls.Add(richTextBox_Data);
            tabPage_Data.Location = new Point(4, 29);
            tabPage_Data.Name = "tabPage_Data";
            tabPage_Data.Padding = new Padding(3);
            tabPage_Data.Size = new Size(522, 339);
            tabPage_Data.TabIndex = 1;
            tabPage_Data.Text = "Data";
            tabPage_Data.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Data
            // 
            richTextBox_Data.Location = new Point(6, 6);
            richTextBox_Data.Name = "richTextBox_Data";
            richTextBox_Data.Size = new Size(510, 158);
            richTextBox_Data.TabIndex = 2;
            richTextBox_Data.Text = "";
            // 
            // tabPage_Parametrs
            // 
            tabPage_Parametrs.Controls.Add(radioButton_Saving_NoAsk);
            tabPage_Parametrs.Controls.Add(radioButton_Saving_YesAsk);
            tabPage_Parametrs.Controls.Add(label_GlobalFile);
            tabPage_Parametrs.Controls.Add(button_OpenGlobalFile);
            tabPage_Parametrs.Controls.Add(textBox_GlobalFile);
            tabPage_Parametrs.Controls.Add(label_PassWord);
            tabPage_Parametrs.Controls.Add(textBox_PassWord);
            tabPage_Parametrs.Location = new Point(4, 29);
            tabPage_Parametrs.Name = "tabPage_Parametrs";
            tabPage_Parametrs.Padding = new Padding(3);
            tabPage_Parametrs.Size = new Size(522, 339);
            tabPage_Parametrs.TabIndex = 0;
            tabPage_Parametrs.Text = "Parametrs";
            tabPage_Parametrs.UseVisualStyleBackColor = true;
            // 
            // radioButton_Saving_NoAsk
            // 
            radioButton_Saving_NoAsk.AutoSize = true;
            radioButton_Saving_NoAsk.Location = new Point(160, 6);
            radioButton_Saving_NoAsk.Name = "radioButton_Saving_NoAsk";
            radioButton_Saving_NoAsk.Size = new Size(95, 24);
            radioButton_Saving_NoAsk.TabIndex = 36;
            radioButton_Saving_NoAsk.TabStop = true;
            radioButton_Saving_NoAsk.Text = "Save auto";
            radioButton_Saving_NoAsk.UseVisualStyleBackColor = true;
            // 
            // radioButton_Saving_YesAsk
            // 
            radioButton_Saving_YesAsk.AutoSize = true;
            radioButton_Saving_YesAsk.Location = new Point(12, 6);
            radioButton_Saving_YesAsk.Name = "radioButton_Saving_YesAsk";
            radioButton_Saving_YesAsk.Size = new Size(142, 24);
            radioButton_Saving_YesAsk.TabIndex = 35;
            radioButton_Saving_YesAsk.TabStop = true;
            radioButton_Saving_YesAsk.Text = "Ask about saving";
            radioButton_Saving_YesAsk.UseVisualStyleBackColor = true;
            // 
            // label_GlobalFile
            // 
            label_GlobalFile.AutoSize = true;
            label_GlobalFile.Location = new Point(12, 39);
            label_GlobalFile.Name = "label_GlobalFile";
            label_GlobalFile.Size = new Size(35, 20);
            label_GlobalFile.TabIndex = 34;
            label_GlobalFile.Text = "File:";
            // 
            // button_OpenGlobalFile
            // 
            button_OpenGlobalFile.Location = new Point(266, 36);
            button_OpenGlobalFile.Name = "button_OpenGlobalFile";
            button_OpenGlobalFile.Size = new Size(71, 27);
            button_OpenGlobalFile.TabIndex = 33;
            button_OpenGlobalFile.Text = "Open";
            button_OpenGlobalFile.UseVisualStyleBackColor = true;
            button_OpenGlobalFile.Click += button_OpenOneFromFile_Click;
            // 
            // textBox_GlobalFile
            // 
            textBox_GlobalFile.Location = new Point(114, 36);
            textBox_GlobalFile.Name = "textBox_GlobalFile";
            textBox_GlobalFile.Size = new Size(146, 27);
            textBox_GlobalFile.TabIndex = 32;
            textBox_GlobalFile.Text = "Directory";
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
            tabControl.Size = new Size(530, 231);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = ".";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 256);
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
        private TextBox textBox_FilePach;
        private TextBox textBox_PassWord_File;
        private Label label2;
        private Label label_FilePach;
        private Button button_Open2;
        private Button button_Del;
        private ListBox listBox_Files;
        private TabPage tabPage_Data;
        private TabPage tabPage_Parametrs;
        private TabControl tabControl;
        private RichTextBox richTextBox_Data;
        private Label label_GlobalFile;
        private Button button_OpenGlobalFile;
        private TextBox textBox_GlobalFile;
        private Label label_PassWord;
        private TextBox textBox_PassWord;
        private Label label_Information;
        private RichTextBox richTextBox_Info;
        private Button button_Save;
        private OpenFileDialog openFileDialog;
        private FolderBrowserDialog folderBrowserDialog;
        private Button button_AddFile;
        private RadioButton radioButton_Saving_NoAsk;
        private RadioButton radioButton_Saving_YesAsk;
        private Label label_Directory;
        private Button button_OpenDirectory;
        private TextBox textBox_Directory;
    }
}