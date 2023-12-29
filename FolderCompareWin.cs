namespace FolderCompareWinForms
{
    public partial class FolderCompareWin : Form
    {
        private static FolderCompareWin instance;
        public FolderCompareWin()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            folderA.ShowDialog();
            if(folderA.SelectedPath != null)
            {
                FolderCompare.FolderA = folderA.SelectedPath;
                textBoxA.Text = folderA.SelectedPath;
                UpdateLogMessage("Folder A: " + folderA.SelectedPath);
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            folderB.ShowDialog();
            if (folderB.SelectedPath != null)
            {
                FolderCompare.FolderB = folderB.SelectedPath;
                textBoxB.Text = folderB.SelectedPath;
                UpdateLogMessage("Folder B: " + folderB.SelectedPath);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            folderExport.ShowDialog();
            if (folderExport.SelectedPath != null)
            {
                FolderCompare.FolderExport = folderExport.SelectedPath;
                textBoxExport.Text = folderExport.SelectedPath;
                UpdateLogMessage("Folder Export: " + folderExport.SelectedPath);
            }
        }

        private void checkFolderA_CheckedChanged(object sender, EventArgs e)
        {
            if(checkFolderA.Checked == true)
            {
                FolderCompare.CheckFolderA = true;
                UpdateLogMessage("Check Folder A: " + FolderCompare.CheckFolderA);
            }
            else
            {
                FolderCompare.CheckFolderA = false;
                UpdateLogMessage("Check Folder A: " + FolderCompare.CheckFolderA);
            }
        }

        private void checkFolderB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFolderB.Checked == true)
            {
                FolderCompare.CheckFolderB = true;
                UpdateLogMessage("Check Folder B: " + FolderCompare.CheckFolderB);
            }
            else
            {
                FolderCompare.CheckFolderB = false;
                UpdateLogMessage("Check Folder B: " + FolderCompare.CheckFolderB);
            }
        }

        private void checkExisting_CheckedChanged(object sender, EventArgs e)
        {
            if (checkExisting.Checked == true)
            {
                FolderCompare.checkExisting = true;
                UpdateLogMessage("Check Existing: " + FolderCompare.checkExisting);
            }
            else
            {
                FolderCompare.checkExisting = false;
                UpdateLogMessage("Check Existing: " + FolderCompare.checkExisting);
            }
        }

        private async void buttonConfirm_Click(object sender, EventArgs e)
        {
            UpdateLogMessage("Comparing and copying Init!");
            await FolderCompare.CompareAsync();
            UpdateLogMessage("Comparing and copying Finished!");
        }

        public void UpdateLogMessage(string message)
        {
            // This method ensures that the update is performed on the UI thread
            ThreadSafeUpdate(() => textBox1.AppendText(message + Environment.NewLine));
        }

        private void ThreadSafeUpdate(Action updateAction)
        {
            if (this.InvokeRequired)
            {
                // If we're not on the UI thread, use Invoke to execute the updateAction on the UI thread
                this.Invoke(updateAction);
            }
            else
            {
                // If we're on the UI thread, execute the updateAction directly
                updateAction();
            }
        }

        public static FolderCompareWin GetInstance()
        {
            return instance;
        }

        public static void SetInstance(FolderCompareWin instance)
        {
            FolderCompareWin.instance = instance;
        }

    }
}
