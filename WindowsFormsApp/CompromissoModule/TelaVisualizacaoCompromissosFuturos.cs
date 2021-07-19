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
    public partial class TelaVisualizacaoCompromissosFuturos : Form
    {
        private readonly ControladorCompromisso controlador = new ControladorCompromisso();
        public TelaVisualizacaoCompromissosFuturos()
        {
            InitializeComponent();

            setaDataMinimaDateTimePicker();
        }

        private void setaDataMinimaDateTimePicker()
        {
            dtpDataInicio.MinDate = DateTime.Now;
            dtpDataFim.MinDate = DateTime.Now;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if(dtpDataInicio.Value.Date > dtpDataFim.Value.Date)
            {
                MessageBox.Show("Data inicial nao pode ser maior que a data final.");
            }

            else
            {
                CarregarCompromissosFuturos();
            } 
        }

        private void CarregarCompromissosFuturos()
        {
            DateTime dataInicio, dataFim;
            dataInicio = dtpDataInicio.Value.Date;
            dataFim = dtpDataFim.Value;

            dtCompromissosFuturos.Rows.Clear();

            List<Compromisso> compromissosFuturos = controlador.SelecionarCompromissosFuturos(dataInicio, dataFim);

            if(compromissosFuturos.Count == 0)
            {
                MessageBox.Show("Nenhum compromisso encontrado.");
            }
            else
            {
                foreach (var item in compromissosFuturos)
                {
                    DataRow linha = dtCompromissosFuturos.NewRow();

                    linha["Id"] = item.Id;
                    linha["Assunto"] = item.Assunto;
                    linha["Data"] = item.Data.ToString("dd/MM/yyyy");
                    linha["Hora Inicio"] = item.HoraInicio;
                    linha["Hora Término"] = item.HoraTermino;
                    linha["Contato"] = item.Contato;

                    dtCompromissosFuturos.Rows.Add(linha);
                }
            }


            
        }
    }
}
