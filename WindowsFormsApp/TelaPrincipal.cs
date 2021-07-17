using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.CompromissoModule;
using WindowsFormsApp.ContatoModule;

namespace WindowsFormsApp
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }



        private void btTarefas_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaTarefa telaSelecionada = new TelaTarefa();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
          
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btContatos_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaContato telaSelecionada = new TelaContato();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();

        }

        private void btCompromissos_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCompromisso telaSelecionada = new TelaCompromisso();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }
    }
}
