
namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btdDesc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.szabalyLeiras = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelInfoTerem = new System.Windows.Forms.Panel();
            this.pnlUsb = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.rbOpt4 = new System.Windows.Forms.RadioButton();
            this.rbOpt3 = new System.Windows.Forms.RadioButton();
            this.rbopt2 = new System.Windows.Forms.RadioButton();
            this.rbOpt1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnExitCode = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnFiok = new System.Windows.Forms.Button();
            this.lblFolyosó = new System.Windows.Forms.Label();
            this.btnNoteExit = new System.Windows.Forms.Button();
            this.btnNoteBack = new System.Windows.Forms.Button();
            this.btnNoteForward = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNote2 = new System.Windows.Forms.TextBox();
            this.txtNote1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelInfoTerem.SuspendLayout();
            this.pnlUsb.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üdvözlünk a programban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(121, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Játék Kezdése";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(123, 229);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(642, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Leírás";
            // 
            // btdDesc
            // 
            this.btdDesc.Location = new System.Drawing.Point(623, 229);
            this.btdDesc.Name = "btdDesc";
            this.btdDesc.Size = new System.Drawing.Size(85, 23);
            this.btdDesc.TabIndex = 4;
            this.btdDesc.Text = "Játékszabály";
            this.btdDesc.UseVisualStyleBackColor = true;
            this.btdDesc.Click += new System.EventHandler(this.btdDesc_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(763, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 21);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(370, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Játék neve";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(354, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Játékszabály:";
            this.label5.Visible = false;
            // 
            // szabalyLeiras
            // 
            this.szabalyLeiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szabalyLeiras.Location = new System.Drawing.Point(256, 122);
            this.szabalyLeiras.Multiline = true;
            this.szabalyLeiras.Name = "szabalyLeiras";
            this.szabalyLeiras.ReadOnly = true;
            this.szabalyLeiras.Size = new System.Drawing.Size(307, 293);
            this.szabalyLeiras.TabIndex = 8;
            this.szabalyLeiras.Text = resources.GetString("szabalyLeiras.Text");
            this.szabalyLeiras.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(124, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Vissza";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelInfoTerem
            // 
            this.panelInfoTerem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInfoTerem.BackgroundImage")));
            this.panelInfoTerem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInfoTerem.Controls.Add(this.btnExitCode);
            this.panelInfoTerem.Controls.Add(this.btnOpen);
            this.panelInfoTerem.Controls.Add(this.txtCode);
            this.panelInfoTerem.Controls.Add(this.lblCode);
            this.panelInfoTerem.Controls.Add(this.btnFiok);
            this.panelInfoTerem.Controls.Add(this.lblFolyosó);
            this.panelInfoTerem.Controls.Add(this.btnNoteExit);
            this.panelInfoTerem.Controls.Add(this.btnNoteBack);
            this.panelInfoTerem.Controls.Add(this.btnNoteForward);
            this.panelInfoTerem.Controls.Add(this.panel2);
            this.panelInfoTerem.Controls.Add(this.pictureBox1);
            this.panelInfoTerem.Controls.Add(this.lblNotes);
            this.panelInfoTerem.Controls.Add(this.btnNext);
            this.panelInfoTerem.Controls.Add(this.textBox1);
            this.panelInfoTerem.Controls.Add(this.label6);
            this.panelInfoTerem.Location = new System.Drawing.Point(0, 0);
            this.panelInfoTerem.Margin = new System.Windows.Forms.Padding(0);
            this.panelInfoTerem.Name = "panelInfoTerem";
            this.panelInfoTerem.Size = new System.Drawing.Size(800, 460);
            this.panelInfoTerem.TabIndex = 10;
            // 
            // pnlUsb
            // 
            this.pnlUsb.Controls.Add(this.btnSelect);
            this.pnlUsb.Controls.Add(this.rbOpt4);
            this.pnlUsb.Controls.Add(this.rbOpt3);
            this.pnlUsb.Controls.Add(this.rbopt2);
            this.pnlUsb.Controls.Add(this.rbOpt1);
            this.pnlUsb.Controls.Add(this.textBox2);
            this.pnlUsb.Location = new System.Drawing.Point(0, 0);
            this.pnlUsb.Name = "pnlUsb";
            this.pnlUsb.Size = new System.Drawing.Size(127, 273);
            this.pnlUsb.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(26, 236);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Kiválaszt";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // rbOpt4
            // 
            this.rbOpt4.AutoSize = true;
            this.rbOpt4.Location = new System.Drawing.Point(13, 204);
            this.rbOpt4.Name = "rbOpt4";
            this.rbOpt4.Size = new System.Drawing.Size(100, 17);
            this.rbOpt4.TabIndex = 4;
            this.rbOpt4.TabStop = true;
            this.rbOpt4.Text = "jatek_setup.exe";
            this.rbOpt4.UseVisualStyleBackColor = true;
            // 
            // rbOpt3
            // 
            this.rbOpt3.AutoSize = true;
            this.rbOpt3.Location = new System.Drawing.Point(13, 181);
            this.rbOpt3.Name = "rbOpt3";
            this.rbOpt3.Size = new System.Drawing.Size(100, 17);
            this.rbOpt3.TabIndex = 3;
            this.rbOpt3.TabStop = true;
            this.rbOpt3.Text = "jegyzo_kulcs.inf";
            this.rbOpt3.UseVisualStyleBackColor = true;
            // 
            // rbopt2
            // 
            this.rbopt2.AutoSize = true;
            this.rbopt2.Location = new System.Drawing.Point(13, 158);
            this.rbopt2.Name = "rbopt2";
            this.rbopt2.Size = new System.Drawing.Size(67, 17);
            this.rbopt2.TabIndex = 2;
            this.rbopt2.TabStop = true;
            this.rbopt2.Text = "virus.exe";
            this.rbopt2.UseVisualStyleBackColor = true;
            // 
            // rbOpt1
            // 
            this.rbOpt1.AutoSize = true;
            this.rbOpt1.Location = new System.Drawing.Point(13, 135);
            this.rbOpt1.Name = "rbOpt1";
            this.rbOpt1.Size = new System.Drawing.Size(98, 17);
            this.rbOpt1.TabIndex = 1;
            this.rbOpt1.TabStop = true;
            this.rbOpt1.Text = "film_matek.mp4";
            this.rbOpt1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 128);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Találtál néhány PenDriveot, és egy cetlit mellette, amelyre rá van írva: \"Az igaz" +
    "i kulcsot soha nem nevezem annak, aminek látszik.\". Választ ki azt a pendriveot " +
    "amelyet be szeretnél dugni a gépbe:";
            // 
            // btnExitCode
            // 
            this.btnExitCode.Location = new System.Drawing.Point(161, 414);
            this.btnExitCode.Name = "btnExitCode";
            this.btnExitCode.Size = new System.Drawing.Size(75, 23);
            this.btnExitCode.TabIndex = 15;
            this.btnExitCode.Text = "Vissza";
            this.btnExitCode.UseVisualStyleBackColor = true;
            this.btnExitCode.Visible = false;
            this.btnExitCode.Click += new System.EventHandler(this.btnExitCode_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(544, 414);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Nyitás";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Visible = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(335, 417);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 13;
            this.txtCode.Visible = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(370, 392);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(29, 13);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Kód:";
            this.lblCode.Visible = false;
            // 
            // btnFiok
            // 
            this.btnFiok.Location = new System.Drawing.Point(348, 415);
            this.btnFiok.Name = "btnFiok";
            this.btnFiok.Size = new System.Drawing.Size(75, 23);
            this.btnFiok.TabIndex = 12;
            this.btnFiok.Text = "Fiók";
            this.btnFiok.UseVisualStyleBackColor = true;
            this.btnFiok.Visible = false;
            this.btnFiok.Click += new System.EventHandler(this.btnFiok_Click);
            // 
            // lblFolyosó
            // 
            this.lblFolyosó.AutoSize = true;
            this.lblFolyosó.Location = new System.Drawing.Point(482, 149);
            this.lblFolyosó.Name = "lblFolyosó";
            this.lblFolyosó.Size = new System.Drawing.Size(43, 13);
            this.lblFolyosó.TabIndex = 11;
            this.lblFolyosó.Text = "Folyosó";
            this.lblFolyosó.Visible = false;
            this.lblFolyosó.Click += new System.EventHandler(this.lblFolyosó_Click);
            // 
            // btnNoteExit
            // 
            this.btnNoteExit.Location = new System.Drawing.Point(161, 415);
            this.btnNoteExit.Name = "btnNoteExit";
            this.btnNoteExit.Size = new System.Drawing.Size(75, 23);
            this.btnNoteExit.TabIndex = 10;
            this.btnNoteExit.Text = "Kilép";
            this.btnNoteExit.UseVisualStyleBackColor = true;
            this.btnNoteExit.Visible = false;
            this.btnNoteExit.Click += new System.EventHandler(this.btnNoteExit_Click);
            // 
            // btnNoteBack
            // 
            this.btnNoteBack.Location = new System.Drawing.Point(161, 415);
            this.btnNoteBack.Name = "btnNoteBack";
            this.btnNoteBack.Size = new System.Drawing.Size(75, 23);
            this.btnNoteBack.TabIndex = 9;
            this.btnNoteBack.Text = "Vissza";
            this.btnNoteBack.UseVisualStyleBackColor = true;
            this.btnNoteBack.Visible = false;
            this.btnNoteBack.Click += new System.EventHandler(this.btnNoteBack_Click);
            // 
            // btnNoteForward
            // 
            this.btnNoteForward.Location = new System.Drawing.Point(544, 415);
            this.btnNoteForward.Name = "btnNoteForward";
            this.btnNoteForward.Size = new System.Drawing.Size(75, 23);
            this.btnNoteForward.TabIndex = 8;
            this.btnNoteForward.Text = "Tovább";
            this.btnNoteForward.UseVisualStyleBackColor = true;
            this.btnNoteForward.Visible = false;
            this.btnNoteForward.Click += new System.EventHandler(this.btnNoteForward_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pnlUsb);
            this.panel2.Controls.Add(this.txtNote2);
            this.panel2.Controls.Add(this.txtNote1);
            this.panel2.Location = new System.Drawing.Point(322, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 273);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // txtNote2
            // 
            this.txtNote2.BackColor = System.Drawing.Color.White;
            this.txtNote2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote2.Location = new System.Drawing.Point(0, 0);
            this.txtNote2.Multiline = true;
            this.txtNote2.Name = "txtNote2";
            this.txtNote2.ReadOnly = true;
            this.txtNote2.Size = new System.Drawing.Size(127, 273);
            this.txtNote2.TabIndex = 1;
            this.txtNote2.Text = resources.GetString("txtNote2.Text");
            this.txtNote2.Visible = false;
            // 
            // txtNote1
            // 
            this.txtNote1.BackColor = System.Drawing.Color.White;
            this.txtNote1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote1.Location = new System.Drawing.Point(0, 0);
            this.txtNote1.Multiline = true;
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.ReadOnly = true;
            this.txtNote1.Size = new System.Drawing.Size(127, 273);
            this.txtNote1.TabIndex = 0;
            this.txtNote1.Text = resources.GetString("txtNote1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(242, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 372);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(163, 171);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(55, 13);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Jegyzetek";
            this.lblNotes.Visible = false;
            this.lblNotes.Click += new System.EventHandler(this.lblNotes_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(544, 415);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Tovább";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(242, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(296, 372);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(269, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kiinduló helyzet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInfoTerem);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.szabalyLeiras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btdDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInfoTerem.ResumeLayout(false);
            this.panelInfoTerem.PerformLayout();
            this.pnlUsb.ResumeLayout(false);
            this.pnlUsb.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btdDesc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox szabalyLeiras;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelInfoTerem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNote1;
        private System.Windows.Forms.Button btnNoteBack;
        private System.Windows.Forms.Button btnNoteForward;
        private System.Windows.Forms.TextBox txtNote2;
        private System.Windows.Forms.Button btnNoteExit;
        private System.Windows.Forms.Label lblFolyosó;
        private System.Windows.Forms.Button btnFiok;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnExitCode;
        private System.Windows.Forms.Panel pnlUsb;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.RadioButton rbOpt4;
        private System.Windows.Forms.RadioButton rbOpt3;
        private System.Windows.Forms.RadioButton rbopt2;
        private System.Windows.Forms.RadioButton rbOpt1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

