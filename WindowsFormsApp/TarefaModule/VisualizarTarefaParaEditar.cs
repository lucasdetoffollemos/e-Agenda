using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class VisualizarTarefaParaEditar : Form
    {
        public readonly ControladorTarefa controlador = new ControladorTarefa();
        public VisualizarTarefaParaEditar()
        {
            InitializeComponent();
            CarregarTarefasPendentes();
        }

        private void CarregarTarefasPendentes()
        {
            dtTarefas.Rows.Clear();

            List<Tarefa> tarefasPendentes = controlador.SelecionarTodasTarefasPendentes();
            
            foreach(var item in tarefasPendentes)
            {
                DataRow linha = dtTarefas.NewRow();

                linha["Id"] = item.Id;
                linha["Titulo"] = item.Titulo;
                linha["Data Criação"] = item.DataCriacao.ToString("dd/MM/yyyy"); ;
                linha["Percentual %"] = item.Percentual;
                linha["Prioridade"] = item.Prioridade;
                linha["Data Conclusão"] = item.DataConclusao;

                dtTarefas.Rows.Add(linha);

            }

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            
            
            if(string.IsNullOrEmpty(txbId.Text))
            {
                MessageBox.Show("Preencha o campo de Id");
            }
            else
            {
                string idStr = txbId.Text;
                int id = Convert.ToInt32(idStr);
                bool existeId = controlador.Existe(id);

                if (existeId)
                {
                    Tarefa t = pegarATarefaASerEditada(id);

                    this.Hide();
                    TelaEditaTarefa telaSelecionada = new TelaEditaTarefa(t);
                    telaSelecionada.Closed += (s, args) => this.Show();
                    telaSelecionada.Closed += (s, args) => CarregarTarefasPendentes();
                    telaSelecionada.Show();
                }
                else
                {
                    MessageBox.Show("Id não encontrado, tente novamente.");
                }

                txbId.Text = "";

            }
        }

        private Tarefa pegarATarefaASerEditada(int id)
        {
            Tarefa t = controlador.SelecionarPorId(id);

            return t;
        }

        private void txbId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
