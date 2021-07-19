
namespace WindowsFormsApp
{
    partial class TelaVisualizacaoTarefa
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConclusãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dtTarefasPendentes = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dtTarefasConcluidas = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriaçãoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentualDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConclusãoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btVoltar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefasPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefasConcluidas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualizando Tarefas";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 155);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1091, 352);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1083, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.dataCriaçãoDataGridViewTextBoxColumn,
            this.percentualDataGridViewTextBoxColumn,
            this.prioridadeDataGridViewTextBoxColumn1,
            this.dataConclusãoDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "dtTarefasPendentes";
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataCriaçãoDataGridViewTextBoxColumn
            // 
            this.dataCriaçãoDataGridViewTextBoxColumn.DataPropertyName = "Data criação";
            this.dataCriaçãoDataGridViewTextBoxColumn.HeaderText = "Data criação";
            this.dataCriaçãoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCriaçãoDataGridViewTextBoxColumn.Name = "dataCriaçãoDataGridViewTextBoxColumn";
            this.dataCriaçãoDataGridViewTextBoxColumn.Width = 125;
            // 
            // percentualDataGridViewTextBoxColumn
            // 
            this.percentualDataGridViewTextBoxColumn.DataPropertyName = "Percentual";
            this.percentualDataGridViewTextBoxColumn.HeaderText = "Percentual";
            this.percentualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.percentualDataGridViewTextBoxColumn.Name = "percentualDataGridViewTextBoxColumn";
            this.percentualDataGridViewTextBoxColumn.Width = 125;
            // 
            // prioridadeDataGridViewTextBoxColumn1
            // 
            this.prioridadeDataGridViewTextBoxColumn1.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn1.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prioridadeDataGridViewTextBoxColumn1.Name = "prioridadeDataGridViewTextBoxColumn1";
            this.prioridadeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataConclusãoDataGridViewTextBoxColumn
            // 
            this.dataConclusãoDataGridViewTextBoxColumn.DataPropertyName = "Data conclusão";
            this.dataConclusãoDataGridViewTextBoxColumn.HeaderText = "Data conclusão";
            this.dataConclusãoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataConclusãoDataGridViewTextBoxColumn.Name = "dataConclusãoDataGridViewTextBoxColumn";
            this.dataConclusãoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTarefasPendentes,
            this.dtTarefasConcluidas});
            // 
            // dtTarefasPendentes
            // 
            this.dtTarefasPendentes.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn11});
            this.dtTarefasPendentes.TableName = "dtTarefasPendentes";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Id";
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Titulo";
            this.dataColumn2.ColumnName = "Titulo";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Data criação";
            this.dataColumn3.ColumnName = "Data criação";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Percentual";
            this.dataColumn4.ColumnName = "Percentual";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Prioridade";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Data conclusão";
            // 
            // dtTarefasConcluidas
            // 
            this.dtTarefasConcluidas.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn12});
            this.dtTarefasConcluidas.TableName = "dtTarefasConcluidas";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Id";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Titulo";
            this.dataColumn7.ColumnName = "Titulo";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Data criação";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Percentual";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Prioridade";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "Data conclusão";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1083, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Concluidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.tituloDataGridViewTextBoxColumn1,
            this.dataCriaçãoDataGridViewTextBoxColumn1,
            this.percentualDataGridViewTextBoxColumn1,
            this.prioridadeDataGridViewTextBoxColumn,
            this.dataConclusãoDataGridViewTextBoxColumn1});
            this.dataGridView2.DataMember = "dtTarefasConcluidas";
            this.dataGridView2.DataSource = this.dataSet1;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1058, 262);
            this.dataGridView2.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn1
            // 
            this.tituloDataGridViewTextBoxColumn1.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn1.Name = "tituloDataGridViewTextBoxColumn1";
            this.tituloDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataCriaçãoDataGridViewTextBoxColumn1
            // 
            this.dataCriaçãoDataGridViewTextBoxColumn1.DataPropertyName = "Data criação";
            this.dataCriaçãoDataGridViewTextBoxColumn1.HeaderText = "Data criação";
            this.dataCriaçãoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataCriaçãoDataGridViewTextBoxColumn1.Name = "dataCriaçãoDataGridViewTextBoxColumn1";
            this.dataCriaçãoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // percentualDataGridViewTextBoxColumn1
            // 
            this.percentualDataGridViewTextBoxColumn1.DataPropertyName = "Percentual";
            this.percentualDataGridViewTextBoxColumn1.HeaderText = "Percentual";
            this.percentualDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.percentualDataGridViewTextBoxColumn1.Name = "percentualDataGridViewTextBoxColumn1";
            this.percentualDataGridViewTextBoxColumn1.Width = 125;
            // 
            // prioridadeDataGridViewTextBoxColumn
            // 
            this.prioridadeDataGridViewTextBoxColumn.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prioridadeDataGridViewTextBoxColumn.Name = "prioridadeDataGridViewTextBoxColumn";
            this.prioridadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataConclusãoDataGridViewTextBoxColumn1
            // 
            this.dataConclusãoDataGridViewTextBoxColumn1.DataPropertyName = "Data conclusão";
            this.dataConclusãoDataGridViewTextBoxColumn1.HeaderText = "Data conclusão";
            this.dataConclusãoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataConclusãoDataGridViewTextBoxColumn1.Name = "dataConclusãoDataGridViewTextBoxColumn1";
            this.dataConclusãoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(840, 24);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(201, 55);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaVisualizacaoTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1089, 504);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TelaVisualizacaoTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizando Tarefas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefasPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefasConcluidas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dtTarefasPendentes;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataTable dtTarefasConcluidas;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn12;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConclusãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriaçãoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentualDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConclusãoDataGridViewTextBoxColumn1;
    }
}