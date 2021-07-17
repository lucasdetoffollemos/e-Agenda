using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
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
    public partial class TelaInsereCompromisso : Form
    {
        public readonly ControladorContato controladorContato = new ControladorContato();
        public readonly ControladorCompromisso controlador = new ControladorCompromisso();
        public TelaInsereCompromisso()
        {
            InitializeComponent();

            InicializarComboBoxContatos();
        }

        private void InicializarComboBoxContatos()
        {
            cmbContatos.Items.Clear();

            List<Contato> contatos = controladorContato.SelecionarTodos();

            foreach (var item in contatos)
            {
                cmbContatos.Items.Add(item);
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSim.Checked)
            {
                cmbContatos.Enabled = true;
            }
            else
            {
                cmbContatos.Enabled = false;
            }
        }

        private void rdbPresencial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPresencial.Checked)
            {
                labelLocal.Enabled = true;
                txbLocal.Enabled = true;

                labelLink.Enabled = false;
                txbLink.Enabled = false;
            }
        }

        private void rdbRemoto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRemoto.Checked)
            {
                labelLocal.Enabled = false;
                txbLocal.Enabled = false;

                labelLink.Enabled = true;
                txbLink.Enabled = true;
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            string assunto, local = null, link = null;
            DateTime dataCompromisso;



            assunto = txbAssunto.Text;

            dataCompromisso = dtpDataCompromisso.Value;

            string[] strHoraInicio = maskedtbHoraInicio.Text.Split(':');
            TimeSpan horaInicio = new TimeSpan(int.Parse(strHoraInicio[0]), int.Parse(strHoraInicio[1]), 0);

            string[] strHoraTermino = maskedtbHoraTermino.Text.Split(':');
            TimeSpan horaTermino = new TimeSpan(int.Parse(strHoraTermino[0]), int.Parse(strHoraTermino[1]), 0);

            Contato c = null;

            if (rdbSim.Checked)
            {
                c = (Contato)cmbContatos.SelectedItem;
            }

            if (rdbPresencial.Checked)
            {
                local = txbLocal.Text;
                link = "Presencial";
            }
            else if (rdbRemoto.Checked)
            {

                link = txbLink.Text;
                local = "Remoto";
            }

            if (string.IsNullOrEmpty(assunto) || string.IsNullOrEmpty(local) || string.IsNullOrEmpty(link))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                Compromisso compromisso = new Compromisso(assunto, local, link, dataCompromisso, horaInicio, horaTermino, c);

                string resultado = controlador.InserirNovo(compromisso);

                if (resultado.Equals("ESTA_VALIDO"))
                {
                    MessageBox.Show("Compromisso inserido com sucesso.");
                    this.Close();
                    this.Dispose();
                }

                else
                {
                    MessageBox.Show(resultado);
                }

                txbAssunto.Text = "";
                txbLocal.Text = "";
                txbLink.Text = "";


            }
        }
    }
}
