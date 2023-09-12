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
            Show,
            Close
        }
        public IconTreyControl(ClickButton click, TypeEvent[] types)
        {
            icon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            icon.ContextMenuStrip = new ContextMenuStrip();

            foreach (TypeEvent typeEvent in types) new Button(ref icon, typeEvent, click);

            icon.Visible = true;
        }
        public void Visual_ON()
        {
            icon.Visible = true;
        }
        public void Visual_OFF()
        {
            icon.Visible = false;
        }
        private class Button
        {
            private TypeEvent typeEvent;
            private event ClickButton Click;
            public Button(ref NotifyIcon icon, TypeEvent typeEvent, ClickButton click)
            {
                this.typeEvent = typeEvent;
                ToolStripItem stripItem;
                switch (typeEvent)
                {
                    case TypeEvent.Show:
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
