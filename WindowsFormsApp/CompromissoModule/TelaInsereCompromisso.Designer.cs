
namespace WindowsFormsApp.CompromissoModule
{
    partial class TelaInsereCompromisso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataCompromisso = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.dataSet1 = new System.Data.DataSet();
            this.dtContatos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.btVoltar = new System.Windows.Forms.Button();
            this.rdbRemoto = new System.Windows.Forms.RadioButton();
            this.rdbPresencial = new System.Windows.Forms.RadioButton();
            this.labelLocal = new System.Windows.Forms.Label();
            this.txbLocal = new System.Windows.Forms.TextBox();
            this.txbLink = new System.Windows.Forms.TextBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.gbLocal = new System.Windows.Forms.GroupBox();
            this.maskedtbHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedtbHoraTermino = new System.Windows.Forms.MaskedTextBox();
            this.cmbContatos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtContatos)).BeginInit();
            this.gbContato.SuspendLayout();
            this.gbLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbAssunto
            // 
            this.txbAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAssunto.Location = new System.Drawing.Point(421, 98);
            this.txbAssunto.Name = "txbAssunto";
            this.txbAssunto.Size = new System.Drawing.Size(378, 30);
            this.txbAssunto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Assunto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insere Compromisso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Compromisso";
            // 
            // dtpDataCompromisso
            // 
            this.dtpDataCompromisso.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dtpDataCompromisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCompromisso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompromisso.Location = new System.Drawing.Point(545, 158);
            this.dtpDataCompromisso.Name = "dtpDataCompromisso";
            this.dtpDataCompromisso.Size = new System.Drawing.Size(236, 30);
            this.dtpDataCompromisso.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora Inicio";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(330, 283);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(131, 25);
            this.labe.TabIndex = 10;
            this.labe.Text = "Hora Término";
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(15, 42);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(67, 29);
            this.rdbSim.TabIndex = 13;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            this.rdbSim.CheckedChanged += new System.EventHandler(this.rdbSim_CheckedChanged);
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(139, 42);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(69, 29);
            this.rdbNao.TabIndex = 14;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dtContatos});
            // 
            // dtContatos
            // 
            this.dtContatos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dtContatos.TableName = "dtContatos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Nome";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Email";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Telefone";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Cargo";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Empresa";
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(923, 12);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(194, 61);
            this.btVoltar.TabIndex = 16;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // rdbRemoto
            // 
            this.rdbRemoto.AutoSize = true;
            this.rdbRemoto.Location = new System.Drawing.Point(225, 47);
            this.rdbRemoto.Name = "rdbRemoto";
            this.rdbRemoto.Size = new System.Drawing.Size(100, 29);
            this.rdbRemoto.TabIndex = 19;
            this.rdbRemoto.TabStop = true;
            this.rdbRemoto.Text = "Remoto";
            this.rdbRemoto.UseVisualStyleBackColor = true;
            this.rdbRemoto.CheckedChanged += new System.EventHandler(this.rdbRemoto_CheckedChanged);
            // 
            // rdbPresencial
            // 
            this.rdbPresencial.AutoSize = true;
            this.rdbPresencial.Location = new System.Drawing.Point(40, 47);
            this.rdbPresencial.Name = "rdbPresencial";
            this.rdbPresencial.Size = new System.Drawing.Size(124, 29);
            this.rdbPresencial.TabIndex = 18;
            this.rdbPresencial.TabStop = true;
            this.rdbPresencial.Text = "Presencial";
            this.rdbPresencial.UseVisualStyleBackColor = true;
            this.rdbPresencial.CheckedChanged += new System.EventHandler(this.rdbPresencial_CheckedChanged);
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Enabled = false;
            this.labelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocal.Location = new System.Drawing.Point(356, 701);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(59, 25);
            this.labelLocal.TabIndex = 20;
            this.labelLocal.Text = "Local";
            // 
            // txbLocal
            // 
            this.txbLocal.Enabled = false;
            this.txbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLocal.Location = new System.Drawing.Point(421, 701);
            this.txbLocal.Name = "txbLocal";
            this.txbLocal.Size = new System.Drawing.Size(250, 30);
            this.txbLocal.TabIndex = 21;
            // 
            // txbLink
            // 
            this.txbLink.Enabled = false;
            this.txbLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLink.Location = new System.Drawing.Point(421, 759);
            this.txbLink.Name = "txbLink";
            this.txbLink.Size = new System.Drawing.Size(250, 30);
            this.txbLink.TabIndex = 23;
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Enabled = false;
            this.labelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLink.Location = new System.Drawing.Point(356, 762);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(48, 25);
            this.labelLink.TabIndex = 22;
            this.labelLink.Text = "Link";
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.rdbNao);
            this.gbContato.Controls.Add(this.rdbSim);
            this.gbContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContato.Location = new System.Drawing.Point(391, 325);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(332, 91);
            this.gbContato.TabIndex = 26;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Deseja marcar um contato?";
            // 
            // gbLocal
            // 
            this.gbLocal.Controls.Add(this.rdbPresencial);
            this.gbLocal.Controls.Add(this.rdbRemoto);
            this.gbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocal.Location = new System.Drawing.Point(321, 571);
            this.gbLocal.Name = "gbLocal";
            this.gbLocal.Size = new System.Drawing.Size(445, 100);
            this.gbLocal.TabIndex = 27;
            this.gbLocal.TabStop = false;
            this.gbLocal.Text = "De qual forma será o compromisso?";
            // 
            // maskedtbHoraInicio
            // 
            this.maskedtbHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedtbHoraInicio.Location = new System.Drawing.Point(467, 230);
            this.maskedtbHoraInicio.Mask = "00:00";
            this.maskedtbHoraInicio.Name = "maskedtbHoraInicio";
            this.maskedtbHoraInicio.Size = new System.Drawing.Size(85, 30);
            this.maskedtbHoraInicio.TabIndex = 28;
            this.maskedtbHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedtbHoraTermino
            // 
            this.maskedtbHoraTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedtbHoraTermino.Location = new System.Drawing.Point(467, 278);
            this.maskedtbHoraTermino.Mask = "00:00";
            this.maskedtbHoraTermino.Name = "maskedtbHoraTermino";
            this.maskedtbHoraTermino.Size = new System.Drawing.Size(85, 30);
            this.maskedtbHoraTermino.TabIndex = 29;
            this.maskedtbHoraTermino.ValidatingType = typeof(System.DateTime);
            // 
            // cmbContatos
            // 
            this.cmbContatos.Enabled = false;
            this.cmbContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContatos.FormattingEnabled = true;
            this.cmbContatos.Location = new System.Drawing.Point(421, 491);
            this.cmbContatos.Name = "cmbContatos";
            this.cmbContatos.Size = new System.Drawing.Size(216, 33);
            this.cmbContatos.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Contatos";
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Location = new System.Drawing.Point(379, 818);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(307, 80);
            this.btInserir.TabIndex = 32;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // TelaInsereCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1129, 925);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbContatos);
            this.Controls.Add(this.maskedtbHoraTermino);
            this.Controls.Add(this.maskedtbHoraInicio);
            this.Controls.Add(this.gbLocal);
            this.Controls.Add(this.gbContato);
            this.Controls.Add(this.txbLink);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.txbLocal);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataCompromisso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAssunto);
            this.Controls.Add(this.label2);
            this.Name = "TelaInsereCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInseirCompromisso";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtContatos)).EndInit();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.gbLocal.ResumeLayout(false);
            this.gbLocal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataCompromisso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dtContatos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.RadioButton rdbRemoto;
        private System.Windows.Forms.RadioButton rdbPresencial;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.TextBox txbLocal;
        private System.Windows.Forms.TextBox txbLink;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.GroupBox gbLocal;
        private System.Windows.Forms.MaskedTextBox maskedtbHoraInicio;
        private System.Windows.Forms.MaskedTextBox maskedtbHoraTermino;
        private System.Windows.Forms.ComboBox cmbContatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btInserir;
    }
}