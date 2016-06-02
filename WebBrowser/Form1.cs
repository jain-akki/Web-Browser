using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        int counter;
        public Form1()
        {
            InitializeComponent();
            counter = 1;
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter++;
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Text = "Window " + counter;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Opacity = 50;
            f.Text = "Window " + counter;
            f.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;            
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
