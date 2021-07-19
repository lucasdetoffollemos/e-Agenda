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
    public partial class TelaExcluirTarefa : Form
    {

        public readonly ControladorTarefa controlador = new ControladorTarefa();

        public TelaExcluirTarefa()
        {
            InitializeComponent();
            CarregarTodasAsTarefas();

        }

        private void CarregarTodasAsTarefas()
        {
            dtTarefas.Rows.Clear();

            List<Tarefa> tarefas = controlador.SelecionarTodos();

            foreach (var item in tarefas)
            {
                DataRow linha = dtTarefas.NewRow();

                linha["Id"] = item.Id;
                linha["Titulo"] = item.Titulo;
                linha["Data Criação"] = item.DataCriacao.ToString("dd/MM/yyyy");
                linha["Percentual %"] = item.Percentual;
                linha["Prioridade"] = item.Prioridade;
                linha["Data Conclusão"] = item.DataConclusao;

                dtTarefas.Rows.Add(linha);

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbId.Text))
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
                    bool foiExcluido = controlador.Excluir(id);

                    if (foiExcluido)
                    {
                        MessageBox.Show("Tarefa excluida com sucesso");
                        CarregarTodasAsTarefas();
                    }
                    else
                    {
                        MessageBox.Show("Problema ao excluir a tarefa");
                    }
                }
                else
                {
                    MessageBox.Show("Id não encontrado, tente novamente.");
                }

                txbId.Text = "";



            }
        }

        private void txbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
