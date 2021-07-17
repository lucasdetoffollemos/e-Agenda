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
    public partial class TelaCompromisso : Form
    {
        public TelaCompromisso()
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
            TelaInsereCompromisso telaSelecionada = new TelaInsereCompromisso();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btVisualizarPassados_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisualizacaoCompromissosPassados telaSelecionada = new TelaVisualizacaoCompromissosPassados();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btVisualizarFuturo_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisualizacaoCompromissosFuturos telaSelecionada = new TelaVisualizacaoCompromissosFuturos();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarCompromissoParaEditar telaSelecionada = new VisualizarCompromissoParaEditar();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaExcluirCompromisso telaSelecionada = new TelaExcluirCompromisso();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }
    }
}
