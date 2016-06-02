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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //webBrowser1.Document.BackColor = Color.FromArgb(100, 10, 10, 10);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text); 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if (e.KeyChar == (char)Keys.ControlKey)
        //    {
        //            textBox1.AppendText(".com"); 
        //    }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == (char)Keys.ControlKey)
            {
                    textBox1.AppendText(".com");
            }
        }
    }
}
