using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;           //for emguCV
using Emgu.CV.Structure; //for Bgr


namespace HW5t05902128
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog1.FileName);
              

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap ima = (Bitmap)pictureBox1.Image;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ima.Save(sfd.FileName);
            }
        }

       
      
    }
}
