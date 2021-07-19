using eAgenda.Controladores.CompromissoModule;
using eAgenda.Dominio.CompromissoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.CompromissoModule
{
    public partial class VisualizarCompromissoParaEditar : Form
    {

       

        private readonly ControladorCompromisso controlador = new ControladorCompromisso();
        public VisualizarCompromissoParaEditar()
        {
            InitializeComponent();
            CarregaCompromissos();
        }

        private void CarregaCompromissos()
        {
            dtCompromissos.Rows.Clear();

            List<Compromisso> compromissos = controlador.SelecionarTodos();

            if(compromissos.Count == 0)
            {
                MessageBox.Show("Nenhum compromisso encontrado.");
            }
            else
            {
                foreach (var item in compromissos)
                {
                    DataRow linha = dtCompromissos.NewRow();

                    linha["Id"] = item.Id;
                    linha["Assunto"] = item.Assunto;
                    linha["Data"] = item.Data.ToString("dd/MM/yyyy");
                    linha["Hora Inicio"] = item.HoraInicio;
                    linha["Hora Término"] = item.HoraTermino;
                    linha["Contato"] = item.Contato;

                    dtCompromissos.Rows.Add(linha);
                }
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
                Compromisso c = pegarOCompromissoASerEditado(id);

                this.Hide();
                TelaEditaCompromisso telaSelecionada = new TelaEditaCompromisso(c);
                telaSelecionada.Closed += (s, args) => this.Show();
                telaSelecionada.Closed += (s, args) => CarregaCompromissos();
                telaSelecionada.Show();


            }
        }

        private Compromisso pegarOCompromissoASerEditado(int id)
        {
            Compromisso c = controlador.SelecionarPorId(id);

            return c;
        }
    }
}
