namespace FolderCompareWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            FolderCompareWin mainForm = new FolderCompareWin();
            FolderCompareWin.SetInstance(mainForm); // Set the instance before the form is shown
            Application.Run(mainForm);
        }
    }
}