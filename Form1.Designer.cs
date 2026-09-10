namespace pomodoro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lbltext1 = new Label();
            pictureBox1 = new PictureBox();
            btnstop = new Button();
            btnstop1 = new Button();
            btnstart1 = new Button();
            lbl1 = new Label();
            tabPage2 = new TabPage();
            lbltext2 = new Label();
            pictureBox2 = new PictureBox();
            btnreset2 = new Button();
            btnstop2 = new Button();
            btnstart2 = new Button();
            lbl2 = new Label();
            tabPage3 = new TabPage();
            lbltext3 = new Label();
            pictureBox3 = new PictureBox();
            btnreset3 = new Button();
            btnstop3 = new Button();
            btnstart3 = new Button();
            lbl3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            tabPage4 = new TabPage();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(-1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(653, 489);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.IndianRed;
            tabPage1.Controls.Add(lbltext1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(btnstop);
            tabPage1.Controls.Add(btnstop1);
            tabPage1.Controls.Add(btnstart1);
            tabPage1.Controls.Add(lbl1);
            tabPage1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = SystemColors.ActiveCaption;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(645, 461);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pomodoro";
            // 
            // lbltext1
            // 
            lbltext1.Anchor = AnchorStyles.None;
            lbltext1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltext1.ForeColor = SystemColors.ButtonHighlight;
            lbltext1.Location = new Point(134, 243);
            lbltext1.Margin = new Padding(0);
            lbltext1.Name = "lbltext1";
            lbltext1.Size = new Size(385, 27);
            lbltext1.TabIndex = 10;
            lbltext1.Text = "Waktu untuk Focus!";
            lbltext1.TextAlign = ContentAlignment.MiddleCenter;
            lbltext1.Click += lbltext1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnstop
            // 
            btnstop.BackColor = Color.DodgerBlue;
            btnstop.FlatStyle = FlatStyle.Popup;
            btnstop.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnstop.ForeColor = SystemColors.ActiveCaptionText;
            btnstop.Location = new Point(401, 299);
            btnstop.Name = "btnstop";
            btnstop.Size = new Size(137, 61);
            btnstop.TabIndex = 3;
            btnstop.Text = "RESET";
            btnstop.UseVisualStyleBackColor = false;
            btnstop.Click += btnstop_Click;
            // 
            // btnstop1
            // 
            btnstop1.BackColor = Color.Red;
            btnstop1.FlatStyle = FlatStyle.Popup;
            btnstop1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btnstop1.ForeColor = SystemColors.ActiveCaptionText;
            btnstop1.Location = new Point(258, 299);
            btnstop1.Name = "btnstop1";
            btnstop1.Size = new Size(137, 61);
            btnstop1.TabIndex = 2;
            btnstop1.Text = "STOP";
            btnstop1.UseVisualStyleBackColor = false;
            btnstop1.Click += btnstop1_Click;
            // 
            // btnstart1
            // 
            btnstart1.BackColor = Color.PaleGreen;
            btnstart1.BackgroundImageLayout = ImageLayout.Center;
            btnstart1.FlatStyle = FlatStyle.Popup;
            btnstart1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstart1.ForeColor = SystemColors.ActiveCaptionText;
            btnstart1.Location = new Point(115, 299);
            btnstart1.Name = "btnstart1";
            btnstart1.Size = new Size(137, 61);
            btnstart1.TabIndex = 1;
            btnstart1.Text = "START";
            btnstart1.UseVisualStyleBackColor = false;
            btnstart1.Click += btnstart1_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = SystemColors.HighlightText;
            lbl1.Location = new Point(167, 120);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(319, 109);
            lbl1.TabIndex = 0;
            lbl1.Text = "25 : 00";
            lbl1.Click += lbl1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightSeaGreen;
            tabPage2.Controls.Add(lbltext2);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(btnreset2);
            tabPage2.Controls.Add(btnstop2);
            tabPage2.Controls.Add(btnstart2);
            tabPage2.Controls.Add(lbl2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(645, 461);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Short Break";
            // 
            // lbltext2
            // 
            lbltext2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltext2.ForeColor = SystemColors.ButtonHighlight;
            lbltext2.Location = new Point(124, 243);
            lbltext2.Margin = new Padding(0);
            lbltext2.Name = "lbltext2";
            lbltext2.Size = new Size(405, 27);
            lbltext2.TabIndex = 9;
            lbltext2.Text = "Waktu untuk istirahat sebentar";
            lbltext2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnreset2
            // 
            btnreset2.BackColor = Color.DodgerBlue;
            btnreset2.FlatStyle = FlatStyle.Popup;
            btnreset2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreset2.ForeColor = SystemColors.ActiveCaptionText;
            btnreset2.Location = new Point(401, 299);
            btnreset2.Name = "btnreset2";
            btnreset2.Size = new Size(137, 61);
            btnreset2.TabIndex = 7;
            btnreset2.Text = "RESET";
            btnreset2.UseVisualStyleBackColor = false;
            btnreset2.Click += btnreset2_Click;
            // 
            // btnstop2
            // 
            btnstop2.BackColor = Color.Red;
            btnstop2.FlatStyle = FlatStyle.Popup;
            btnstop2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstop2.ForeColor = SystemColors.ActiveCaptionText;
            btnstop2.Location = new Point(258, 299);
            btnstop2.Name = "btnstop2";
            btnstop2.Size = new Size(137, 61);
            btnstop2.TabIndex = 6;
            btnstop2.Text = "STOP";
            btnstop2.UseVisualStyleBackColor = false;
            btnstop2.Click += btnstop2_Click;
            // 
            // btnstart2
            // 
            btnstart2.BackColor = Color.PaleGreen;
            btnstart2.BackgroundImageLayout = ImageLayout.Center;
            btnstart2.FlatStyle = FlatStyle.Popup;
            btnstart2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstart2.ForeColor = SystemColors.ActiveCaptionText;
            btnstart2.Location = new Point(115, 299);
            btnstart2.Name = "btnstart2";
            btnstart2.Size = new Size(137, 61);
            btnstart2.TabIndex = 5;
            btnstart2.Text = "START";
            btnstart2.UseVisualStyleBackColor = false;
            btnstart2.Click += btnstart2_Click;
            // 
            // lbl2
            // 
            lbl2.Font = new Font("Times New Roman", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.ForeColor = SystemColors.HighlightText;
            lbl2.Location = new Point(167, 120);
            lbl2.Margin = new Padding(5, 0, 3, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(319, 109);
            lbl2.TabIndex = 4;
            lbl2.Text = "05 : 00";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.MediumSeaGreen;
            tabPage3.Controls.Add(lbltext3);
            tabPage3.Controls.Add(pictureBox3);
            tabPage3.Controls.Add(btnreset3);
            tabPage3.Controls.Add(btnstop3);
            tabPage3.Controls.Add(btnstart3);
            tabPage3.Controls.Add(lbl3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(645, 461);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Long Break";
            // 
            // lbltext3
            // 
            lbltext3.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltext3.ForeColor = SystemColors.ButtonHighlight;
            lbltext3.Location = new Point(97, 243);
            lbltext3.Margin = new Padding(0);
            lbltext3.Name = "lbltext3";
            lbltext3.Size = new Size(459, 27);
            lbltext3.TabIndex = 10;
            lbltext3.Text = "Waktu untuk istirahat lebih lama :D";
            lbltext3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // btnreset3
            // 
            btnreset3.BackColor = Color.DodgerBlue;
            btnreset3.FlatStyle = FlatStyle.Popup;
            btnreset3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreset3.ForeColor = SystemColors.ActiveCaptionText;
            btnreset3.Location = new Point(401, 299);
            btnreset3.Name = "btnreset3";
            btnreset3.Size = new Size(137, 61);
            btnreset3.TabIndex = 7;
            btnreset3.Text = "RESET";
            btnreset3.UseVisualStyleBackColor = false;
            btnreset3.Click += btnreset3_Click;
            // 
            // btnstop3
            // 
            btnstop3.BackColor = Color.Red;
            btnstop3.FlatStyle = FlatStyle.Popup;
            btnstop3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstop3.ForeColor = SystemColors.ActiveCaptionText;
            btnstop3.Location = new Point(258, 299);
            btnstop3.Name = "btnstop3";
            btnstop3.Size = new Size(137, 61);
            btnstop3.TabIndex = 6;
            btnstop3.Text = "STOP";
            btnstop3.UseVisualStyleBackColor = false;
            btnstop3.Click += btnstop3_Click;
            // 
            // btnstart3
            // 
            btnstart3.BackColor = Color.PaleGreen;
            btnstart3.BackgroundImageLayout = ImageLayout.Center;
            btnstart3.FlatStyle = FlatStyle.Popup;
            btnstart3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstart3.ForeColor = SystemColors.ActiveCaptionText;
            btnstart3.Location = new Point(115, 299);
            btnstart3.Name = "btnstart3";
            btnstart3.Size = new Size(137, 61);
            btnstart3.TabIndex = 5;
            btnstart3.Text = "START";
            btnstart3.UseVisualStyleBackColor = false;
            btnstart3.Click += btnstart3_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Times New Roman", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.ForeColor = SystemColors.HighlightText;
            lbl3.Location = new Point(167, 120);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(319, 109);
            lbl3.TabIndex = 4;
            lbl3.Text = "15 : 00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.LavenderBlush;
            tabPage4.Controls.Add(label1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(645, 461);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Credits";
            // 
            // label1
            // 
            label1.Font = new Font("Swis721 Hv BT", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 147);
            label1.Name = "label1";
            label1.Size = new Size(614, 162);
            label1.TabIndex = 0;
            label1.Text = "Nama : Akbar Fadhilah Syarief\r\nNPM : 40622100057";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(652, 499);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Pomodoro Focus";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnstop;
        private Button btnstop1;
        private Button btnstart1;
        private Label lbl1;
        private System.Windows.Forms.Timer timer1;
        private Button btnreset2;
        private Button btnstop2;
        private Button btnstart2;
        private Label lbl2;
        private Button btnreset3;
        private Button btnstop3;
        private Button btnstart3;
        private Label lbl3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbltext1;
        private Label lbltext2;
        private Label lbltext3;
        private TabPage tabPage4;
        private Label label1;
    }
}
