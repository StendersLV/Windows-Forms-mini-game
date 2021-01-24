using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void START_Click(object sender, EventArgs e)
        {
            SHUFFLE openForm = new SHUFFLE();
            openForm.Show();
            Visible = false;
        }
        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
