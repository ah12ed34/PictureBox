using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxTest
{
    public partial class Form1 : Form
    {
        int imgNum =-1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            imgNum = (imgNum + 1) % 3;
            pictureBox1.Image = (Image)(Properties.Resources.ResourceManager.GetObject(string.Format("IMG{0}",imgNum)));
            
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)(Properties.Resources.ResourceManager.GetObject(string.Format("IMG1")));

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
        }
    }
}
