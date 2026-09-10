using System.Diagnostics;

namespace pomodoro
{
    public partial class Form1 : Form
    {

        int second = 0;
        bool isRunning = false;
        private object lblT;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            int menit = second / 60;
            int detik = second % 60;
            lbl1.Text = menit.ToString() + " : " + detik.ToString();

        }

        private void btnstart1_Click(object sender, EventArgs e)
        {
            second = 1500;
            timer1.Start();
            lbltext1.Text = "Waktu dimulai!";
        }

        private void btnstop1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lbltext1.Text = "Waktu dijeda";
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            second = 1500;
            lbl1.Text = "25 : 00";
            lbltext1.Text = "Waktu berhasil direset";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnstart2_Click(object sender, EventArgs e)
        {
            second = 300;
            timer2.Start();
            lbltext2.Text = "Waktu dimulai!";
        }

        private void btnstop2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            lbltext2.Text = "Waktu dijeda";
        }

        private void btnreset2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            second = 300;
            lbl2.Text = "05 : 00";
            lbltext2.Text = "Waktu berhasil direset";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            second--;
            int menit = second / 60;
            int detik = second % 60;
            lbl2.Text = menit.ToString() + " : " + detik.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            second--;
            int menit = second / 60;
            int detik = second % 60;
            lbl3.Text = menit.ToString() + " : " + detik.ToString();
        }

        private void btnstart3_Click(object sender, EventArgs e)
        {
            second = 900;
            timer3.Start();
            lbltext3.Text = "Waktu dimulai!";
        }

        private void btnstop3_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            lbltext3.Text = "Waktu dijeda";
        }

        private void btnreset3_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            second = 900;
            lbl3.Text = "15 : 00";
            lbltext3.Text = "Waktu berhasil direset";
        }

        private void lbltext1_Click(object sender, EventArgs e)
        {

        }
    }
}
