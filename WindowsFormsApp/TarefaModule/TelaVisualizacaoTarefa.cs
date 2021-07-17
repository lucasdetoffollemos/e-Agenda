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
    public partial class TelaVisualizacaoTarefa : Form
    {
        public readonly ControladorTarefa controlador = new ControladorTarefa();

        public TelaVisualizacaoTarefa()
        {
            InitializeComponent();
            CarregaTarefasPendentes();
            CarregaTarefasConcluidas();
        }

        private void CarregaTarefasConcluidas()
        {

            dtTarefasConcluidas.Rows.Clear();
            List<Tarefa> tarefasConcluidas = controlador.SelecionarTodasTarefasConcluidas();

            foreach (var item in tarefasConcluidas)
            {
                DataRow tarefa = dtTarefasConcluidas.NewRow();

                tarefa["Id"] = item.Id;
                tarefa["Titulo"] = item.Titulo;
                tarefa["Data criação"] = item.DataCriacao;
                tarefa["Percentual"] = item.Percentual;
                tarefa["Prioridade"] = item.Prioridade;
                tarefa["Data conclusão"] = item.DataConclusao;

                dtTarefasConcluidas.Rows.Add(tarefa);
            }
        }

        private void CarregaTarefasPendentes()
        {
            dtTarefasPendentes.Rows.Clear();
            List<Tarefa> tarefasPendentes = controlador.SelecionarTodasTarefasPendentes();

            foreach(var item in tarefasPendentes)
            {
                DataRow tarefa = dtTarefasPendentes.NewRow();

                tarefa["Id"] = item.Id;
                tarefa["Titulo"] = item.Titulo;
                tarefa["Data criação"] = item.DataCriacao;
                tarefa["Percentual"] = item.Percentual;
                tarefa["Prioridade"] = item.Prioridade;
                tarefa["Data conclusão"] = item.DataConclusao;

                dtTarefasPendentes.Rows.Add(tarefa);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
