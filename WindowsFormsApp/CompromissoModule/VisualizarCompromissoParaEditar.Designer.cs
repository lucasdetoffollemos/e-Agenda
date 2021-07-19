
namespace WindowsFormsApp.CompromissoModule
{
    partial class VisualizarCompromissoParaEditar
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
            this.btVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaTérminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dtCompromissos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.btEditar = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompromissos)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(957, 23);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(201, 55);
            this.btVoltar.TabIndex = 6;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Todos os Compromissos";
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
            this.dataGridView1.DataMember = "dtCompromissos";
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 350);
            this.dataGridView1.TabIndex = 7;
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
            this.dtCompromissos});
            // 
            // dtCompromissos
            // 
            this.dtCompromissos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dtCompromissos.TableName = "dtCompromissos";
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
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(498, 636);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(171, 46);
            this.btEditar.TabIndex = 11;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(607, 571);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 30);
            this.txbId.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite o ID do compromisso que deseja editar";
            // 
            // VisualizarCompromissoParaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1176, 709);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.label1);
            this.Name = "VisualizarCompromissoParaEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizando para editar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompromissos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaTérminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dtCompromissos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
    }
}