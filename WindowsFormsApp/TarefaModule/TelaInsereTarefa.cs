using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.Dominio.TarefaModule;
using System.Windows.Forms;
using eAgenda.Controladores.TarefaModule;

namespace WindowsFormsApp
{
    public partial class TelaInsereTarefa : Form
    {
        public readonly ControladorTarefa controlador = new ControladorTarefa();
        public TelaInsereTarefa()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            string titulo = txbTitulo.Text;
            int prioridade = cmbPrioridade.SelectedIndex;

            Tarefa t = new Tarefa(titulo, DateTime.Now.Date, (PrioridadeEnum)prioridade);
            
            string resultado = controlador.InserirNovo(t);

            if (resultado.Equals("ESTA_VALIDO"))
            {
                MessageBox.Show("Tarefa inserida com sucesso.");
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(resultado);
            }

            txbTitulo.Text = "";
            cmbPrioridade.SelectedIndex = 0;

        }
    }
}
