
namespace WindowsFormsApp.CompromissoModule
{
    partial class TelaCompromisso
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
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btVisualizarPassados = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btVisualizarFuturo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(134, 768);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(265, 54);
            this.btVoltar.TabIndex = 17;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(134, 631);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(265, 99);
            this.btExcluir.TabIndex = 16;
            this.btExcluir.Text = "Excluir Compromisso";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(134, 498);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(265, 99);
            this.btEditar.TabIndex = 15;
            this.btEditar.Text = "Editar Compromisso";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btVisualizarPassados
            // 
            this.btVisualizarPassados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVisualizarPassados.Location = new System.Drawing.Point(134, 238);
            this.btVisualizarPassados.Name = "btVisualizarPassados";
            this.btVisualizarPassados.Size = new System.Drawing.Size(265, 99);
            this.btVisualizarPassados.TabIndex = 14;
            this.btVisualizarPassados.Text = "Visualizar Compromissos Passados";
            this.btVisualizarPassados.UseVisualStyleBackColor = true;
            this.btVisualizarPassados.Click += new System.EventHandler(this.btVisualizarPassados_Click);
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Location = new System.Drawing.Point(134, 110);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(265, 99);
            this.btInserir.TabIndex = 13;
            this.btInserir.Text = "Inserir Compromisso";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de Compromissos";
            // 
            // btVisualizarFuturo
            // 
            this.btVisualizarFuturo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVisualizarFuturo.Location = new System.Drawing.Point(134, 367);
            this.btVisualizarFuturo.Name = "btVisualizarFuturo";
            this.btVisualizarFuturo.Size = new System.Drawing.Size(265, 99);
            this.btVisualizarFuturo.TabIndex = 18;
            this.btVisualizarFuturo.Text = "Visualizar Compromissos Futuros";
            this.btVisualizarFuturo.UseVisualStyleBackColor = true;
            this.btVisualizarFuturo.Click += new System.EventHandler(this.btVisualizarFuturo_Click);
            // 
            // TelaCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 864);
            this.Controls.Add(this.btVisualizarFuturo);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btVisualizarPassados);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.label1);
            this.Name = "TelaCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Compromissos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btVisualizarPassados;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVisualizarFuturo;
    }
}