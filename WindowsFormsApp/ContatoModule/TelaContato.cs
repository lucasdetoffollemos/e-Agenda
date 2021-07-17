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
    public partial class TelaContato : Form
    {
        public TelaContato()
        {
            InitializeComponent();
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisualizacaoContato telaSelecionada = new TelaVisualizacaoContato();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInsereContato telaSelecionada = new TelaInsereContato();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizarContatoParaEditar telaSelecionada = new VisualizarContatoParaEditar();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaExcluirContato telaSelecionada = new TelaExcluirContato();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();

        }
    }
}
