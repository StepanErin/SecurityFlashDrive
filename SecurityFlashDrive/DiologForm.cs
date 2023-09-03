using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static SecurityFlashDrive.Safety_2;

namespace SecurityFlashDrive
{
    public partial class DiologForm_2 : Form
    {
        private Form parentForm;
        public delegate void AnsverHandler(Ansver ansver);
        public event AnsverHandler AnsverEvent;
        public struct Ansver
        {
            public Ansver(string txt, Button selectedButton)
            {
                TXT = txt;
                SelectedButton = selectedButton;
                Closing = false;
            }
            string TXT { get; } = "";
            Button SelectedButton { get; } = Button.Null;
            bool Closing { get; } = true;
        }
        public enum TypeForm
        {
            /// <summary>
            /// Поле ввода
            /// </summary>
            EntryField,
            /// <summary>
            /// Поле ввода и текст
            /// </summary>
            EntryField_TXT,
            /// <summary>
            /// Текст
            /// </summary>
            TXT
        }
        public enum Button
        {
            Null,
            Ok,
            YesNo,
            OkCansel,
            Confirm
        }
        public DiologForm_2(Form parentForm)
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
            this.parentForm = parentForm;
        }
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            AnsverEvent?.Invoke(new Ansver());
            Hide();
        }
        public void Show(string msg, string msgClue, Button[] buttons)
        {
            HashSet<Button> set = new HashSet<Button>(buttons);
            Button[] result = new Button[set.Count];
            set.CopyTo(result);

            Action action = new Action(() =>
            {
                Show();
            });
            if (parentForm.InvokeRequired) parentForm.Invoke(action);
            else action();
        }
        public void T()
        {
            MessageBox.Show("111");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
