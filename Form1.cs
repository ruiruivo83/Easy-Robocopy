using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace EasyRobocopy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

       

    

        private void frmMain_Load(object sender, EventArgs e)
        {

        }


        private void btnGetSource_Click(object sender, EventArgs e)
        {
            // Get source folder to copy from
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBoxSource.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnGetDestination_Click(object sender, EventArgs e)
        {
            // Get the destination folder to copy to
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBoxDestination.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnExecuteCommand_Click(object sender, EventArgs e)
        {
            // Execute the command line with command: Robocopy "source" "destination" /MIR /E /Z /NP /ETA /R:0 /W:1

            // :D WORKS GREATH :D
            String strSource = (@"""") + txtBoxSource.Text + (@"""");
            String strDestination = (@"""") + txtBoxDestination.Text + (@"""");

            // :D WORKS GREATH :D
            string commandToExecute = (@"Robocopy ") + strSource + " " + strDestination + (" /MIR /E /Z /NP /ETA /R:0 /W:1");
            MessageBox.Show(commandToExecute);
            Process.Start(@"cmd", @"/c " + commandToExecute);
        }
    }
}
