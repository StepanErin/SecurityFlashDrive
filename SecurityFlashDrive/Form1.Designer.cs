namespace SecurityFlashDrive
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_StartBackground = new Button();
            button_Stop = new Button();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            button_SelectionConfirmation = new Button();
            comboBox_DiskSelection = new ComboBox();
            button_TEST = new Button();
            checkBox_AUTOmod = new CheckBox();
            button_Run = new Button();
            listBox_Devases = new ListBox();
            button_Add = new Button();
            button_Del = new Button();
            button_Sliv = new Button();
            SuspendLayout();
            // 
            // button_StartBackground
            // 
            button_StartBackground.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button_StartBackground.Location = new Point(12, 12);
            button_StartBackground.Name = "button_StartBackground";
            button_StartBackground.Size = new Size(426, 60);
            button_StartBackground.TabIndex = 1;
            button_StartBackground.Text = "Start safety in background";
            button_StartBackground.UseVisualStyleBackColor = true;
            button_StartBackground.Click += button_StartBackground_Click;
            // 
            // button_Stop
            // 
            button_Stop.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_Stop.Location = new Point(456, 12);
            button_Stop.Name = "button_Stop";
            button_Stop.Size = new Size(136, 60);
            button_Stop.TabIndex = 2;
            button_Stop.Text = "Stop";
            button_Stop.UseVisualStyleBackColor = true;
            button_Stop.Click += button_Stop_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(12, 179);
            label2.Name = "label2";
            label2.Size = new Size(480, 50);
            label2.TabIndex = 3;
            label2.Text = "Работа в фоне: ИНЕРТНО";
            // 
            // button_SelectionConfirmation
            // 
            button_SelectionConfirmation.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button_SelectionConfirmation.Location = new Point(218, 77);
            button_SelectionConfirmation.Name = "button_SelectionConfirmation";
            button_SelectionConfirmation.Size = new Size(158, 28);
            button_SelectionConfirmation.TabIndex = 4;
            button_SelectionConfirmation.UseVisualStyleBackColor = true;
            button_SelectionConfirmation.Click += button_SelectionConfirmation_Click;
            // 
            // comboBox_DiskSelection
            // 
            comboBox_DiskSelection.FormattingEnabled = true;
            comboBox_DiskSelection.Location = new Point(12, 78);
            comboBox_DiskSelection.Name = "comboBox_DiskSelection";
            comboBox_DiskSelection.Size = new Size(200, 28);
            comboBox_DiskSelection.TabIndex = 5;
            comboBox_DiskSelection.SelectedIndexChanged += comboBox_DiskSelection_SelectedIndexChanged;
            // 
            // button_TEST
            // 
            button_TEST.Location = new Point(498, 196);
            button_TEST.Name = "button_TEST";
            button_TEST.Size = new Size(94, 29);
            button_TEST.TabIndex = 6;
            button_TEST.Text = "TEST";
            button_TEST.UseVisualStyleBackColor = true;
            button_TEST.Click += button_TEST_Click;
            // 
            // checkBox_AUTOmod
            // 
            checkBox_AUTOmod.AutoSize = true;
            checkBox_AUTOmod.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox_AUTOmod.Location = new Point(456, 78);
            checkBox_AUTOmod.Name = "checkBox_AUTOmod";
            checkBox_AUTOmod.Size = new Size(136, 32);
            checkBox_AUTOmod.TabIndex = 7;
            checkBox_AUTOmod.Text = "AUTO mod";
            checkBox_AUTOmod.UseVisualStyleBackColor = true;
            checkBox_AUTOmod.CheckedChanged += checkBox_AUTOmod_CheckedChanged;
            // 
            // button_Run
            // 
            button_Run.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button_Run.Location = new Point(382, 77);
            button_Run.Name = "button_Run";
            button_Run.Size = new Size(56, 28);
            button_Run.TabIndex = 8;
            button_Run.Text = "Run";
            button_Run.UseVisualStyleBackColor = true;
            button_Run.Click += button_Run_Click;
            // 
            // listBox_Devases
            // 
            listBox_Devases.FormattingEnabled = true;
            listBox_Devases.ItemHeight = 20;
            listBox_Devases.Location = new Point(12, 112);
            listBox_Devases.Name = "listBox_Devases";
            listBox_Devases.Size = new Size(364, 64);
            listBox_Devases.TabIndex = 9;
            // 
            // button_Add
            // 
            button_Add.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button_Add.Location = new Point(382, 112);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(56, 28);
            button_Add.TabIndex = 10;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Del
            // 
            button_Del.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button_Del.Location = new Point(382, 148);
            button_Del.Name = "button_Del";
            button_Del.Size = new Size(56, 28);
            button_Del.TabIndex = 11;
            button_Del.Text = "Del";
            button_Del.UseVisualStyleBackColor = true;
            button_Del.Click += button_Del_Click;
            // 
            // button_Sliv
            // 
            button_Sliv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_Sliv.Location = new Point(456, 116);
            button_Sliv.Name = "button_Sliv";
            button_Sliv.Size = new Size(136, 60);
            button_Sliv.TabIndex = 12;
            button_Sliv.Text = "Свернуть";
            button_Sliv.UseVisualStyleBackColor = true;
            button_Sliv.Click += button_Sliv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 237);
            Controls.Add(button_Sliv);
            Controls.Add(button_Del);
            Controls.Add(button_Add);
            Controls.Add(listBox_Devases);
            Controls.Add(button_Run);
            Controls.Add(checkBox_AUTOmod);
            Controls.Add(button_TEST);
            Controls.Add(comboBox_DiskSelection);
            Controls.Add(button_SelectionConfirmation);
            Controls.Add(label2);
            Controls.Add(button_Stop);
            Controls.Add(button_StartBackground);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_StartBackground;
        private Button button_Stop;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private Button button_SelectionConfirmation;
        private ComboBox comboBox_DiskSelection;
        private Button button_TEST;
        private CheckBox checkBox_AUTOmod;
        private Button button_Run;
        private ListBox listBox_Devases;
        private Button button_Add;
        private Button button_Del;
        private Button button_Sliv;
    }
}