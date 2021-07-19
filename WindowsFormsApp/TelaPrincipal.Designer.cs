
namespace WindowsFormsApp
{
    partial class TelaPrincipal
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
            this.btTarefas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btContatos = new System.Windows.Forms.Button();
            this.btCompromissos = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTarefas
            // 
            this.btTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btTarefas.Location = new System.Drawing.Point(142, 152);
            this.btTarefas.Name = "btTarefas";
            this.btTarefas.Size = new System.Drawing.Size(265, 99);
            this.btTarefas.TabIndex = 0;
            this.btTarefas.Text = "Controle de Tarefas";
            this.btTarefas.UseVisualStyleBackColor = true;
            this.btTarefas.Click += new System.EventHandler(this.btTarefas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(166, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-AGENDA";
            // 
            // btContatos
            // 
            this.btContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btContatos.Location = new System.Drawing.Point(142, 281);
            this.btContatos.Name = "btContatos";
            this.btContatos.Size = new System.Drawing.Size(265, 99);
            this.btContatos.TabIndex = 2;
            this.btContatos.Text = "Controle de Contatos";
            this.btContatos.UseVisualStyleBackColor = true;
            this.btContatos.Click += new System.EventHandler(this.btContatos_Click);
            // 
            // btCompromissos
            // 
            this.btCompromissos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCompromissos.Location = new System.Drawing.Point(142, 412);
            this.btCompromissos.Name = "btCompromissos";
            this.btCompromissos.Size = new System.Drawing.Size(265, 99);
            this.btCompromissos.TabIndex = 3;
            this.btCompromissos.Text = "Controle de Compromissos";
            this.btCompromissos.UseVisualStyleBackColor = true;
            this.btCompromissos.Click += new System.EventHandler(this.btCompromissos_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSair.Location = new System.Drawing.Point(142, 572);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(265, 47);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 702);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCompromissos);
            this.Controls.Add(this.btContatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTarefas);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-AGENDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTarefas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btContatos;
        private System.Windows.Forms.Button btCompromissos;
        private System.Windows.Forms.Button btSair;
    }
}

