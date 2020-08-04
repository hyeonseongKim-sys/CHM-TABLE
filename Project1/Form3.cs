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
    public partial class Form3 : Form
    {
        MainForm mf;
        int DT;

        public Form3(MainForm mainform, int determinant)
        {
            InitializeComponent();
            mf = mainform;
            DT = determinant;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AddName = textBox1.Text;
            if (DT==1)
            {
                mf.최상위노드추가(AddName);
            }
            else if (DT==2)
            {
                mf.하위노드추가(AddName);
            }
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string AddName = textBox1.Text;
                if (DT == 1)
                {
                    mf.최상위노드추가(AddName);
                }
                else if (DT == 2)
                {
                    mf.하위노드추가(AddName);
                }
            }
            else
            {
                return;
            }
        }
    }
}
