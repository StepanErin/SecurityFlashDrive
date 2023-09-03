using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityFlashDrive
{
    public class IconTreyControl
    {
        private bool visual = true;
        private NotifyIcon icon = new NotifyIcon();


        public delegate void ClickButton(TypeEvent typeEvent);


        public enum TypeEvent
        {
            Open,
            Close
        }
        public IconTreyControl(ClickButton click)
        {
            icon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            icon.ContextMenuStrip = new ContextMenuStrip();
            
            //var t = icon.ContextMenuStrip.Items.Add("Test", Bitmap.FromFile("C:\\Users\\ПК\\Desktop 2\\qwerty.bmp"));
            //t.Click += T_Click;


            new Button(ref icon, TypeEvent.Open, click);
            new Button(ref icon, TypeEvent.Close, click);


            icon.Visible = true;
        }

        private void IconTreyControl_Click(Button button)
        {

        }

        public void Visual_ON()
        {
            icon.Visible = true;
        }

        public void Visual_OFF()
        {
            icon.Visible = false;
        }
        private void T_Click(object? sender, EventArgs e)
        {
        }
        private class Button
        {
            private TypeEvent typeEvent;
            private event ClickButton Click;
            public Button(ref NotifyIcon icon, TypeEvent typeEvent, ClickButton click)//  string txt, string pachBitmapFile)
            {
                this.typeEvent = typeEvent;
                ToolStripItem stripItem;
                switch (typeEvent)
                {
                    case TypeEvent.Open:
                        stripItem = icon.ContextMenuStrip.Items.Add("Show", Bitmap.FromFile("C:\\Users\\ПК\\Desktop 2\\qwerty.bmp"));
                        break;
                    case TypeEvent.Close:
                        stripItem = icon.ContextMenuStrip.Items.Add("Clouse", Bitmap.FromFile("C:\\Users\\ПК\\Desktop 2\\qwerty.bmp"));
                        break;
                    default:
                        return; 
                }
                stripItem.Click += Button_Click;
                Click = click;
            }
            private void Button_Click(object? sender, EventArgs e)
            {
                Click?.Invoke(typeEvent);
            }
        }
    }
}
