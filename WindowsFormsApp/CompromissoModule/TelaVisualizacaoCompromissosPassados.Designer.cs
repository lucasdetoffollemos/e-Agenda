
namespace WindowsFormsApp.CompromissoModule
{
    partial class TelaVisualizacaoCompromissosPassados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaTérminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dtCompromissosPassasdos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompromissosPassasdos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.assuntoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaInicioDataGridViewTextBoxColumn,
            this.horaTérminoDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "dtCompromissosPassasdos";
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(988, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // assuntoDataGridViewTextBoxColumn
            // 
            this.assuntoDataGridViewTextBoxColumn.DataPropertyName = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.HeaderText = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assuntoDataGridViewTextBoxColumn.Name = "assuntoDataGridViewTextBoxColumn";
            this.assuntoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "Hora Inicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "Hora Inicio";
            this.horaInicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // horaTérminoDataGridViewTextBoxColumn
            // 
            this.horaTérminoDataGridViewTextBoxColumn.DataPropertyName = "Hora Término";
            this.horaTérminoDataGridViewTextBoxColumn.HeaderText = "Hora Término";
            this.horaTérminoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaTérminoDataGridViewTextBoxColumn.Name = "horaTérminoDataGridViewTextBoxColumn";
            this.horaTérminoDataGridViewTextBoxColumn.Width = 125;
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            this.contatoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dtCompromissosPassasdos});
            // 
            // dtCompromissosPassasdos
            // 
            this.dtCompromissosPassasdos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dtCompromissosPassasdos.TableName = "dtCompromissosPassasdos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Assunto";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Data";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Hora Inicio";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Hora Término";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Contato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visualizando Compromissos Passados";
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(366, 492);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(201, 55);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // TelaVisualizacaoCompromissosPassados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 582);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TelaVisualizacaoCompromissosPassados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizando compromissos passados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompromissosPassasdos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVoltar;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaTérminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
        private System.Data.DataTable dtCompromissosPassasdos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
    }
}