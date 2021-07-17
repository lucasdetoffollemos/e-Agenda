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
    public partial class TelaVisualizacaoContato : Form
    {

        public readonly ControladorContato controlador = new ControladorContato();
        public TelaVisualizacaoContato()
        {
            InitializeComponent();
            CarregaContatos();
        }

        private void CarregaContatos()
        {
            dtContatos.Rows.Clear();

            List<Contato> contatos = controlador.SelecionarTodos();

            foreach (var item in contatos)
            {
                DataRow linha = dtContatos.NewRow();

                linha["Id"] = item.Id;
                linha["Nome"] = item.Nome;
                linha["Email"] = item.Email;
                linha["Telefone"] = item.Telefone;
                linha["Cargo"] = item.Cargo;
                linha["Empresa"] = item.Empresa;

                dtContatos.Rows.Add(linha);
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
