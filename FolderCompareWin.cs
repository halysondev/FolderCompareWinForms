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
            }
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            folderB.ShowDialog();
            if (folderB.SelectedPath != null)
            {
                FolderCompare.FolderB = folderB.SelectedPath;
                textBoxB.Text = folderB.SelectedPath;
            }
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            folderExport.ShowDialog();
            if (folderExport.SelectedPath != null)
            {
                FolderCompare.FolderExport = folderExport.SelectedPath;
                textBoxExport.Text = folderExport.SelectedPath;
            }
        }

        private void textBoxExport_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkFolderA_CheckedChanged(object sender, EventArgs e)
        {
            if(checkFolderA.Checked == true)
            {
                FolderCompare.CheckFolderA = true;
            }
            else
            {
                FolderCompare.CheckFolderA = false;
            }
        }

        private void checkFolderB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFolderB.Checked == true)
            {
                FolderCompare.CheckFolderB = true;
            }
            else
            {
                FolderCompare.CheckFolderB = false;
            }
        }

        private void checkExisting_CheckedChanged(object sender, EventArgs e)
        {
            if (checkExisting.Checked == true)
            {
                FolderCompare.checkExisting = true;
            }
            else
            {
                FolderCompare.checkExisting = false;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            FolderCompare.Compare();
        }

        private void logsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void folderA_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderB_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderExport_HelpRequest(object sender, EventArgs e)
        {

        }

        public ListBox LogsBox
        {
            get { return logsBox; } // Assuming logsBox is the name of your ListBox control
        }

        public static FolderCompareWin GetInstance()
        {
            // If the instance doesn't exist, create it
            if (instance == null)
            {
                instance = new FolderCompareWin();
            }

            // Return the instance
            return instance;
        }
    }
}
