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
    public partial class TelaEditaTarefa : Form
    {
        public readonly ControladorTarefa controlador = new ControladorTarefa();
        private Tarefa tarefa;

        public TelaEditaTarefa(Tarefa t)
        {
            InitializeComponent();
            tarefa = t;
            
            InicializaCamposTarefa();
        }

        private void InicializaCamposTarefa()
        {
            txbTitulo.Text = tarefa.Titulo;
            txbPercentual.Text = Convert.ToString(tarefa.Percentual);

            carregaPrioridade();
        }

        private void carregaPrioridade()
        {
            foreach(var item in cmbPrioridade.Items)
            {
                if (item.ToString().Equals(tarefa.Prioridade.ToString()))
                {
                    cmbPrioridade.SelectedItem = item;
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            tarefa.Titulo = txbTitulo.Text;
            int prioridadeInt = cmbPrioridade.SelectedIndex;

            if (prioridadeInt == 0 || prioridadeInt == 1 || prioridadeInt == 2)
            {
                    PrioridadeEnum prioridade = (PrioridadeEnum)prioridadeInt;

                    tarefa.Prioridade = new Prioridade(prioridade);


                    tarefa.Percentual = Convert.ToInt32(txbPercentual.Text);

                    string resultado = controlador.Editar(tarefa.Id, tarefa);

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
            else
            {
                MessageBox.Show("Por favor preencha a prioridade");
            }

            

            
        }
    }
}
