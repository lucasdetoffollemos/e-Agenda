using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.TarefaModule;
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
    public partial class VisualizarContatoParaEditar : Form
    {
        public readonly ControladorContato controlador = new ControladorContato();

        public VisualizarContatoParaEditar()
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

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbId.Text))
            {
                MessageBox.Show("Preencha o campo de Id");
            }
            else
            {
                string idStr = txbId.Text;
                int id = Convert.ToInt32(idStr);
                Contato c = pegarOContatoASerEditado(id);

                this.Hide();
                TelaEditaContato telaSelecionada = new TelaEditaContato(c);
                telaSelecionada.Closed += (s, args) => this.Show();
                telaSelecionada.Closed += (s, args) => CarregaContatos();
                telaSelecionada.Show();


            }
        }

        private Contato pegarOContatoASerEditado(int id)
        {
            Contato c = controlador.SelecionarPorId(id);

            return c;
        }
    }
}
