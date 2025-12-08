using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btdDesc_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btdDesc.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            label5.Visible = true;
            szabalyLeiras.Visible = true;
            btnBack.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            btdDesc.Visible =  true;
            label1.Visible =   true;
            label2.Visible =   true;
            label3.Visible =   true;
            label4.Visible = true;

            label5.Visible = false;
            szabalyLeiras.Visible = false;
            btnBack.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btdDesc.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            //label4.Visible = false;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
