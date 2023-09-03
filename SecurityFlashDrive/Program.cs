using System.Management;
using static SecurityFlashDrive.DeviceTracking;

namespace SecurityFlashDrive
{
    internal static class Program
    {
        static internal event System.EventHandler DDD_E_T;
        static internal event IconTreyControl.ClickButton Click;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {/*
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Click += IconTreyControl_Click;
            var iconTreyControl = new IconTreyControl(Click);

            Application.Run(new Form1());
            iconTreyControl.Visual_OFF();
            /*
            using (NotifyIcon icon = new NotifyIcon())
            {
                icon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                icon.ContextMenuStrip = new ContextMenuStrip();
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                Image image = Bitmap.FromFile("C:\\Users\\ой\\Desktop 2\\qwerty.bmp");
                //icon.ContextMenuStrip.Items.Add(new ToolStripMenuItem("Test", image, DDD_E_T));
                var t = icon.ContextMenuStrip.Items.Add("Test", image, DDD_E_T);
                t.Click += T_Click;
                //contextMenu.Items.Add(new ToolStripMenuItem("AAA", image, DDD_E_T));

                /*
                        new ToolStripMenuItem("Show form", (s, e) => form.Show()),
                new ToolStripMenuItem("Hide form", (s, e) => form.Hide()),
                new ToolStripMenuItem("Exit", (s, e) => Application.Exit())
                 */
            /*
            icon.ContextMenu = new ContextMenu(
                new[]
                {
            new MenuItem("Show form", (s, e) => form.Show()),
            new MenuItem("Hide form", (s, e) => form.Hide()),
            new MenuItem("Exit", (s, e) => Application.Exit()),
                });
            *//*
            icon.Visible = true;
        Application.Run(new Form1());
        icon.Visible = false;
        }*/
        }

        private static void IconTreyControl_Click(IconTreyControl.TypeEvent typeEvent)
        {
            MessageBox.Show("TEST2: " + typeEvent.ToString());
        }
    }
}