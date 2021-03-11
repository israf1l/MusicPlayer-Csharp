using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        private void MusicPlayerApp_Load(object sender, EventArgs e)
        {

        }

        // Create Arrays to save tracks' names and paths
        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // Code to select songs
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for( int i=0; i<files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Close the app

            this.Close();
        }
    }
}
