namespace SecurityFlashDrive
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        /*
        static public DiologForm diologForm = new DiologForm();
        
        static public void TTT()
        {
            Action action = () =>
            {
                diologForm.Show();
                diologForm.T();
            };
            if (diologForm.InvokeRequired)
                diologForm.Invoke(action);
            else
                action();
        }*/
    }
}