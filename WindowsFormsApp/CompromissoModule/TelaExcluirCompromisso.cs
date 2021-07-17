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
    public partial class TelaExcluirCompromisso : Form
    {
        private readonly ControladorCompromisso controlador = new ControladorCompromisso();
        public TelaExcluirCompromisso()
        {
            InitializeComponent();
            CarregaCompromissos();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void CarregaCompromissos()
        {
            dtCompromissos.Rows.Clear();

            List<Compromisso> compromissos = controlador.SelecionarTodos();

            foreach (var item in compromissos)
            {
                DataRow linha = dtCompromissos.NewRow();

                linha["Id"] = item.Id;
                linha["Assunto"] = item.Assunto;
                linha["Data"] = item.Data;
                linha["Hora Inicio"] = item.HoraInicio;
                linha["Hora Término"] = item.HoraTermino;
                linha["Contato"] = item.Contato;

                dtCompromissos.Rows.Add(linha);
            }
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

                bool foiExcluido = controlador.Excluir(id);

                if (foiExcluido)
                {
                    MessageBox.Show("Compromisso excluido com sucesso");
                    CarregaCompromissos();
                }
                else
                {
                    MessageBox.Show("Problema ao excluir o contato");
                }
            }
        }
    }
}
