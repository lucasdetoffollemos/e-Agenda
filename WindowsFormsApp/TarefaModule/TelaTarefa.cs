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
    public partial class TelaTarefa : Form
    {
        public TelaTarefa()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInsereTarefa telaSelecionada = new TelaInsereTarefa();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisualizacaoTarefa telaSelecionada = new TelaVisualizacaoTarefa();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarTarefaParaEditar telaSelecionada = new VisualizarTarefaParaEditar();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaExcluirTarefa telaSelecionada = new TelaExcluirTarefa();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
