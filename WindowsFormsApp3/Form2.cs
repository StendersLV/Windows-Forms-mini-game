using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class SHUFFLE : Form
    {
        public SHUFFLE()
        {
            InitializeComponent();
        }
        int moves = 0; int count = 0;
        private void Shuffle()
        {
            List<int> labeList = new List<int>();
            Random rnd = new Random();
            foreach (Button btn in this.panel1.Controls)
            {
                while (labeList.Contains(count))
                    count = rnd.Next(16);
                btn.Text = (count == 0) ? "" : count + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                labeList.Add(count);
            }
            moves = 0;
            Moves.Text = "Number of moves : " + moves;

        }
        private void Swap(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "")
                return;
            Button whitebtn = null;
            foreach (Button bt in this.panel1.Controls)
            {
                if (bt.Text == "")
                {
                    whitebtn = bt;
                    break;
                }
            }
            if (btn.TabIndex == (whitebtn.TabIndex - 1) ||
                 btn.TabIndex == (whitebtn.TabIndex - 4) ||
                  btn.TabIndex == (whitebtn.TabIndex + 1) ||
                     btn.TabIndex == (whitebtn.TabIndex + 4))
            {
                whitebtn.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                btn.BackColor = Color.White;
                whitebtn.Text = btn.Text;
                btn.Text = "";
                moves++;
                Moves.Text = "Number of moves : " + moves;
                if (moves > 10)
                {
                    const string msg = "You made more than 300 moves! Try again?";
                    const string caption = "GAME OVER!";
                    var result = MessageBox.Show(msg, caption,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        Shuffle();
                    }
                    if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }
            CheckOrder();
        }
        private void CheckOrder()
        {
            int index = 0;
            foreach (Button btn in this.panel1.Controls)
            {
                if (btn.Text != "" && Convert.ToInt16(btn.Text) != index)
                {
                    return;
                }
                index++;
            }
            win();
        }
        private void SHUFFLE_Load(object sender, EventArgs e)
        {
            const string msg = "You have 300 moves to complete this game!";
            const string caption = "BE AWARE!";
            var result = MessageBox.Show(msg, caption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Shuffle();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void win()
        {
            const string message = "Congrats, you completed first level! Do you want to continue?";
            const string caption = "LEVEL 1";
            var result = MessageBox.Show(message, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Form3 openForm = new Form3();
                openForm.Show();
                Visible = false;
            }
            if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            win();
        }
    }
}
