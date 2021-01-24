using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public int timeleft;
        public int a; // starpiba un summa
        public int b; // starpiba un summa
        public int c; // Rezultats
        public Form3()
        {
            InitializeComponent();
        }

        private void Dialog()
        {
            timer1.Stop();
            const string msg = "Wrong answer! Try again?";
            const string caption = "GAME OVER!";
            var result = MessageBox.Show(msg, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                DONE.Enabled = false;
                START.Enabled = true;
                START.PerformClick();
                textBox1.Text = "";
            }
            if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void START_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            a = rand.Next(150) + 1;
            b = rand.Next(150) + 1;
            plus.Text = " +";
            timeleft = 4;
            number1.Text = a.ToString();
            number2.Text = b.ToString();
            timer1.Start();
            START.Enabled = false;
            DONE.Enabled = true;
            c = a + b;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                timer.Text = timeleft.ToString();
            }
            if (timeleft == 0)
            {
                DONE.Enabled = false;
                START.Enabled = true;
                timer1.Stop();
                timer.Text = "";
                const string msg = "You ran out of time! Try again?";
                const string caption = "GAME OVER!";
                var result = MessageBox.Show(msg, caption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    DONE.Enabled = false;
                    START.Enabled = true;
                    START.PerformClick();
                    textBox1.Text = "";
                }
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
        private void DONE_Click(object sender, EventArgs e)
        {
            DONE.Enabled = true;
            START.Enabled = false;
            timer1.Stop();

            if (textBox1.Text == c.ToString())
            {
                const string msg = "Congrats, You have completed level!";
                const string caption = "LEVEL 2";
                var result = MessageBox.Show(msg, caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Form4 openForm = new Form4();
                    openForm.Show();
                    Visible = false;
                }
            }
            else
            {
                Dialog();
            }
        }
    }
}
