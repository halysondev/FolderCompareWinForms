namespace FolderCompareWinForms
{
    public partial class FolderCompareWin : Form
    {
        public FolderCompareWin()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            folderA.ShowDialog();
            if(folderA.SelectedPath != null)
            {
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
                textBoxExport.Text = folderExport.SelectedPath;
            }
        }

        private void textBoxExport_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkFolderA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkFolderB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkExisting_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

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
    }
}
