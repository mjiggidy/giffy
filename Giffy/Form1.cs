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
            openFD.ShowDialog();
            string userFile = openFD.FileName;
            pictureBox1.Image = Image.FromFile(userFile);
        }

        private void originalSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }
    }
}
