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
            panelInfoTerem.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelInfoTerem.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label6.Text = "Informatika terem";
            btnNext.Visible = false;
            lblNotes.Visible = true;
            lblFolyosó.Visible = true;
        }

        private void lblNotes_Click(object sender, EventArgs e)
        {
            label6.Text = "Jegyzetek";
            pictureBox1.Image = Image.FromFile("notepad.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = true;
            panel2.Visible = true;
            panel2.BringToFront();
            btnNoteForward.Visible = true;
            btnNoteExit.Visible = true;
            lblFolyosó.Visible = false;
            btnFiok.Visible = true;
            btnFiok.BringToFront();
        }

        private void btnNoteForward_Click(object sender, EventArgs e)
        {
            btnNoteExit.Visible = false;
            btnNoteBack.Visible = true;
            btnNoteForward.Visible = false;
            txtNote1.Visible = false;
            txtNote2.Visible = true;
        }

        private void btnNoteBack_Click(object sender, EventArgs e)
        {
            btnNoteBack.Visible = false;
            btnNoteExit.Visible = true;
            btnNoteForward.Visible = true;
            txtNote1.Visible = true;
            txtNote2.Visible = false;
        }

        private void btnNoteExit_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pictureBox1.Visible = false;
            btnNoteForward.Visible = false;
            btnNoteExit.Visible = false;
            label6.Text = "Informatika Terem";
            lblFolyosó.Visible = true;
            btnFiok.Visible = false;
        }

        private void lblFolyosó_Click(object sender, EventArgs e)
        {
            panelInfoTerem.Visible = false;
        }

        private void btnFiok_Click(object sender, EventArgs e)
        {
            btnFiok.Visible = false;
            lblCode.Visible = true;
            lblCode.BringToFront();
            txtCode.Visible = true;
            txtCode.BringToFront();
            btnOpen.Visible = true;
            btnOpen.BringToFront();
            btnNext.Visible = false;
            btnClose.Visible = false;
            btnBack.Visible = false;
            btnExitCode.Visible = true;
            btnExitCode.BringToFront();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (txtCode.Text=="")
            {
                MessageBox.Show("Ne hagyd üresen a kód mezőt!");
            }

            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            int day = DateTime.Today.Day;

            string code=Convert.ToString(year)+Convert.ToString(month)+Convert.ToString(day)+Convert.ToString(206);

            if (txtCode.Text==code)
            {
                MessageBox.Show("Sikeresen kinyitottad a fiókot","Siker", MessageBoxButtons.OK);
                CloseAll();
                OpenDialogBox();
            }
            else
            {
                MessageBox.Show("Helytelen kód!");
            }
        }

        private void OpenDialogBox()
        {
            pnlUsb.Visible = true;
            textBox2.Visible = true;
            textBox2.BringToFront();
            btnSelect.Visible = true;
            btnSelect.BringToFront();
        }
        
        private void CloseAll()
        {
            label6.Text = "Informatika Terem";
            pictureBox1.Visible = false;
            panel2.Visible = false;

            btnFiok.Visible = false;
            lblCode.Visible = false;
            lblCode.SendToBack();
            txtCode.Visible = false;
            txtCode.SendToBack();
            btnOpen.Visible = false;
            btnOpen.SendToBack();
            btnNext.Visible = false;
            btnNoteForward.Visible = false;
            btnNoteBack.Visible = false;
            btnNoteExit.Visible = false;
            btnClose.Visible = false;
            btnBack.Visible = false;
            btnExitCode.Visible = false;
            btnExitCode.SendToBack();
        }
        private void btnExitCode_Click(object sender, EventArgs e)
        {
            btnFiok.Visible = true;
            lblCode.Visible = false;
            lblCode.SendToBack();
            txtCode.Visible = false;
            txtCode.SendToBack();
            btnOpen.Visible = false;
            btnOpen.SendToBack();
            btnNext.Visible = true;
            btnClose.Visible = true;
            btnBack.Visible = true;
            btnExitCode.Visible = false;
            btnExitCode.SendToBack();
        }
    }
}
