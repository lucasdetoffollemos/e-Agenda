
namespace WindowsFormsApp.CompromissoModule
{
    partial class TelaEditaCompromisso
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
            this.maskedtbHoraTermino = new System.Windows.Forms.MaskedTextBox();
            this.maskedtbHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.labe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataCompromisso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbContatos = new System.Windows.Forms.ComboBox();
            this.gbLocal = new System.Windows.Forms.GroupBox();
            this.rdbPresencial = new System.Windows.Forms.RadioButton();
            this.rdbRemoto = new System.Windows.Forms.RadioButton();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.txbLocal = new System.Windows.Forms.TextBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.txbLink = new System.Windows.Forms.TextBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.gbLocal.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedtbHoraTermino
            // 
            this.maskedtbHoraTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedtbHoraTermino.Location = new System.Drawing.Point(416, 295);
            this.maskedtbHoraTermino.Mask = "00:00";
            this.maskedtbHoraTermino.Name = "maskedtbHoraTermino";
            this.maskedtbHoraTermino.Size = new System.Drawing.Size(85, 30);
            this.maskedtbHoraTermino.TabIndex = 39;
            this.maskedtbHoraTermino.ValidatingType = typeof(System.DateTime);
            // 
            // maskedtbHoraInicio
            // 
            this.maskedtbHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedtbHoraInicio.Location = new System.Drawing.Point(416, 247);
            this.maskedtbHoraInicio.Mask = "00:00";
            this.maskedtbHoraInicio.Name = "maskedtbHoraInicio";
            this.maskedtbHoraInicio.Size = new System.Drawing.Size(85, 30);
            this.maskedtbHoraInicio.TabIndex = 38;
            this.maskedtbHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(850, 14);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(194, 61);
            this.btVoltar.TabIndex = 37;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(279, 300);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(131, 25);
            this.labe.TabIndex = 36;
            this.labe.Text = "Hora Término";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Hora Inicio";
            // 
            // dtpDataCompromisso
            // 
            this.dtpDataCompromisso.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dtpDataCompromisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCompromisso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompromisso.Location = new System.Drawing.Point(494, 175);
            this.dtpDataCompromisso.Name = "dtpDataCompromisso";
            this.dtpDataCompromisso.Size = new System.Drawing.Size(236, 30);
            this.dtpDataCompromisso.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Data Compromisso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Edita Compromisso";
            // 
            // txbAssunto
            // 
            this.txbAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAssunto.Location = new System.Drawing.Point(370, 115);
            this.txbAssunto.Name = "txbAssunto";
            this.txbAssunto.Size = new System.Drawing.Size(378, 30);
            this.txbAssunto.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Assunto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Contatos";
            // 
            // cmbContatos
            // 
            this.cmbContatos.Enabled = false;
            this.cmbContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContatos.FormattingEnabled = true;
            this.cmbContatos.Location = new System.Drawing.Point(379, 491);
            this.cmbContatos.Name = "cmbContatos";
            this.cmbContatos.Size = new System.Drawing.Size(216, 33);
            this.cmbContatos.TabIndex = 44;
            // 
            // gbLocal
            // 
            this.gbLocal.Controls.Add(this.rdbPresencial);
            this.gbLocal.Controls.Add(this.rdbRemoto);
            this.gbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocal.Location = new System.Drawing.Point(319, 562);
            this.gbLocal.Name = "gbLocal";
            this.gbLocal.Size = new System.Drawing.Size(445, 100);
            this.gbLocal.TabIndex = 43;
            this.gbLocal.TabStop = false;
            this.gbLocal.Text = "De qual forma será o compromisso?";
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
            // gbContato
            // 
            this.gbContato.Controls.Add(this.rdbNao);
            this.gbContato.Controls.Add(this.rdbSim);
            this.gbContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContato.Location = new System.Drawing.Point(346, 344);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(332, 91);
            this.gbContato.TabIndex = 42;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Deseja marcar um contato?";
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(177, 42);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(69, 29);
            this.rdbNao.TabIndex = 14;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
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
            // txbLocal
            // 
            this.txbLocal.Enabled = false;
            this.txbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLocal.Location = new System.Drawing.Point(428, 706);
            this.txbLocal.Name = "txbLocal";
            this.txbLocal.Size = new System.Drawing.Size(250, 30);
            this.txbLocal.TabIndex = 41;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Enabled = false;
            this.labelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocal.Location = new System.Drawing.Point(363, 706);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(59, 25);
            this.labelLocal.TabIndex = 40;
            this.labelLocal.Text = "Local";
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(379, 858);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(307, 80);
            this.btEditar.TabIndex = 48;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // txbLink
            // 
            this.txbLink.Enabled = false;
            this.txbLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLink.Location = new System.Drawing.Point(428, 768);
            this.txbLink.Name = "txbLink";
            this.txbLink.Size = new System.Drawing.Size(250, 30);
            this.txbLink.TabIndex = 47;
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Enabled = false;
            this.labelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLink.Location = new System.Drawing.Point(363, 771);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(48, 25);
            this.labelLink.TabIndex = 46;
            this.labelLink.Text = "Link";
            // 
            // TelaEditaCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1057, 1008);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.txbLink);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbContatos);
            this.Controls.Add(this.gbLocal);
            this.Controls.Add(this.gbContato);
            this.Controls.Add(this.txbLocal);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.maskedtbHoraTermino);
            this.Controls.Add(this.maskedtbHoraInicio);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataCompromisso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAssunto);
            this.Controls.Add(this.label2);
            this.Name = "TelaEditaCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEditaCompromisso";
            this.gbLocal.ResumeLayout(false);
            this.gbLocal.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedtbHoraTermino;
        private System.Windows.Forms.MaskedTextBox maskedtbHoraInicio;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataCompromisso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbContatos;
        private System.Windows.Forms.GroupBox gbLocal;
        private System.Windows.Forms.RadioButton rdbPresencial;
        private System.Windows.Forms.RadioButton rdbRemoto;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.TextBox txbLocal;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox txbLink;
        private System.Windows.Forms.Label labelLink;
    }
}