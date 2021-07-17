using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.ContatoModule
{
    public partial class TelaInsereContato : Form
    {
        public readonly ControladorContato controlador = new ControladorContato();
        public TelaInsereContato()
        {
            InitializeComponent();
        }

        private void TelaInsereContato_Load(object sender, EventArgs e)
        {

        }

        private void btInsere_Click(object sender, EventArgs e)
        {
            string nome, email, telefone, cargo, empresa;

            nome = txbNome.Text;
            email = txbEmail.Text;
            telefone = txbTelefone.Text;
            cargo = txbCargo.Text;
            empresa = txbEmpresa.Text;


            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(empresa))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                Contato c = new Contato(nome, email, telefone, empresa, cargo);

                string resultado = controlador.InserirNovo(c);

                if (resultado.Equals("ESTA_VALIDO"))
                {
                    MessageBox.Show("Contato inserido com sucesso.");
                    this.Close();
                    this.Dispose();
                }

                else
                {
                    MessageBox.Show(resultado);
                }

                txbNome.Text = "";
                txbTelefone.Text = "";
                txbEmail.Text = "";
                txbCargo.Text = "";
                txbEmpresa.Text = "";

            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txbEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txbCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txbTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
