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
            SuspendLayout();
            // 
            // button_StartBackground
            // 
            button_StartBackground.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button_StartBackground.Location = new Point(12, 12);
            button_StartBackground.Name = "button_StartBackground";
            button_StartBackground.Size = new Size(403, 60);
            button_StartBackground.TabIndex = 1;
            button_StartBackground.Text = "Start safety in background";
            button_StartBackground.UseVisualStyleBackColor = true;
            button_StartBackground.Click += button_StartBackground_Click;
            // 
            // button_Stop
            // 
            button_Stop.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_Stop.Location = new Point(421, 12);
            button_Stop.Name = "button_Stop";
            button_Stop.Size = new Size(201, 60);
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
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(480, 50);
            label2.TabIndex = 3;
            label2.Text = "Работа в фоне: ИНЕРТНО";
            // 
            // button_SelectionConfirmation
            // 
            button_SelectionConfirmation.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button_SelectionConfirmation.Location = new Point(195, 78);
            button_SelectionConfirmation.Name = "button_SelectionConfirmation";
            button_SelectionConfirmation.Size = new Size(220, 28);
            button_SelectionConfirmation.TabIndex = 4;
            button_SelectionConfirmation.UseVisualStyleBackColor = true;
            button_SelectionConfirmation.Click += button_SelectionConfirmation_Click;
            // 
            // comboBox_DiskSelection
            // 
            comboBox_DiskSelection.FormattingEnabled = true;
            comboBox_DiskSelection.Location = new Point(12, 78);
            comboBox_DiskSelection.Name = "comboBox_DiskSelection";
            comboBox_DiskSelection.Size = new Size(177, 28);
            comboBox_DiskSelection.TabIndex = 5;
            comboBox_DiskSelection.SelectedIndexChanged += comboBox_DiskSelection_SelectedIndexChanged;
            // 
            // button_TEST
            // 
            button_TEST.Location = new Point(528, 129);
            button_TEST.Name = "button_TEST";
            button_TEST.Size = new Size(94, 29);
            button_TEST.TabIndex = 6;
            button_TEST.Text = "TEST";
            button_TEST.UseVisualStyleBackColor = true;
            button_TEST.Click += button_TEST_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 171);
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
    }
}