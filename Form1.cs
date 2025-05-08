using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Pokemon
{
    public partial class pokedex : Form
    {
        public pokedex()
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

        private void bntPesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!txtID.Text.Equals(""))
                {
                    Pokemon pokemon = buscar_pesonagem.Buscar_pokemon(txtID.Text);
                    lblID.Text = pokemon.Id.ToString();
                    lblPokemon.Text = pokemon.Name.ToString();
                    lblAltura.Text = pokemon.Height.ToString();
                    lblPeso.Text = pokemon.Weight.ToString();
                    try
                    {
                        picIconPokemon.ImageLocation = pokemon.imagem;
                    }
                    catch
                    {
                        MessageBox.Show("Imagem do Pokémon não pôde ser carregada.");
                    }

                }
                else
                {
                    MessageBox.Show("Digite um ID ou nome de Pokemon");
                    txtID.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {



        }

        private void picIconPokemon_Click(object sender, EventArgs e)
        {

        }
    }
}
