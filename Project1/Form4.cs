using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form4 : Form
    {
        MainForm mf;

        public Form4(MainForm mainform, string initialText)
        {
            InitializeComponent();
            mf = mainform;
            textBox1.Text = initialText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EditName = textBox1.Text;
            mf.수정(EditName);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string EditName = textBox1.Text;
                mf.수정(EditName);
            }
            else
            {
                return;
            }
        }
    }


}
