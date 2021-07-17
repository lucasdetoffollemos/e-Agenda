using eAgenda.Controladores.CompromissoModule;
using eAgenda.Dominio.CompromissoModule;
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
    public partial class TelaVisualizacaoCompromissosPassados : Form
    {
        private readonly ControladorCompromisso controlador = new ControladorCompromisso();
        public TelaVisualizacaoCompromissosPassados()
        {
            InitializeComponent();
            CarregaCompromissosPassados();
        }

        private void CarregaCompromissosPassados()
        {
            dtCompromissosPassasdos.Rows.Clear();

            List<Compromisso> compromissosPassados = controlador.SelecionarCompromissosPassados(DateTime.Now.Date);

            foreach (var item in compromissosPassados){

                DataRow linha = dtCompromissosPassasdos.NewRow();

                linha["Id"] = item.Id;
                linha["Assunto"] = item.Assunto;
                linha["Data"] = item.Data;
                linha["Hora Inicio"] = item.HoraInicio;
                linha["Hora Término"] = item.HoraTermino;
                linha["Contato"] = item.Contato;

                dtCompromissosPassasdos.Rows.Add(linha);

            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
