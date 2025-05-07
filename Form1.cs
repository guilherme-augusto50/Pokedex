using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bntPesquisar_Click(object sender, EventArgs e)
        {
            string input = txtID.Text.Trim();

            if (input.StartsWith("#")) {
                input = input.Substring(1);
            }

            if
        }


        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void lblpeso_Click(object sender, EventArgs e)
        {

        }
    }
}
