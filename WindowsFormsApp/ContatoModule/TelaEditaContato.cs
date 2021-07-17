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
    public partial class TelaEditaContato : Form
    {
        public readonly ControladorContato controlador = new ControladorContato();
        private Contato contato;

        public TelaEditaContato(Contato c)
        {
            InitializeComponent();
            contato = c;

            InicializaCamposContatos();
        }

        private void InicializaCamposContatos()
        {
            txbNome.Text = contato.Nome;
            txbTelefone.Text = contato.Telefone;
            txbEmail.Text = contato.Email;
            txbCargo.Text = contato.Cargo;
            txbEmpresa.Text = contato.Empresa;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            contato.Nome = txbNome.Text;
            contato.Email = txbEmail.Text;
            contato.Telefone = txbTelefone.Text;
            contato.Cargo = txbCargo.Text;
            contato.Empresa = txbEmpresa.Text;

            string resultado = controlador.Editar(contato.Id, contato);

            if (resultado.Equals("ESTA_VALIDO"))
            {
                MessageBox.Show("Tarefa editada com sucesso.");

                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }
    }
}
