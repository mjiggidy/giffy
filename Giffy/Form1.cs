using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giffy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1(object sender, EventArgs e)
        {
            if(openFD.ShowDialog() != DialogResult.OK)
                return;

            string userFile = openFD.FileName;
    
            try
            {
                Image newImage = Image.FromFile(userFile);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("This file cannot be opened.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Image userImage = Image.FromFile(userFile);
            this.Width = userImage.Width + 16;
            this.Height = userImage.Height + 38;
            this.Text = userFile + " (" + userImage.Width + "x" + userImage.Height + ")";
            pictureBox1.Image = userImage;
        }

        private void originalSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = pictureBox1.Image.Width + 16;
            this.Height = pictureBox1.Image.Height + 38;
        }
    }
}
