
namespace Projeto.View
{
    partial class TelaDeMenuAnunciante
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
            this.btnCadastroDoEvento = new System.Windows.Forms.Button();
            this.btnEventoCadastrado = new System.Windows.Forms.Button();
            this.btnConfiguracoesAnunciante = new System.Windows.Forms.Button();
            this.btnSairMenuAnunciante = new System.Windows.Forms.Button();
            this.btnReagendarEvento = new System.Windows.Forms.Button();
            this.btnCancelarEvento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroDoEvento
            // 
            this.btnCadastroDoEvento.Location = new System.Drawing.Point(12, 28);
            this.btnCadastroDoEvento.Name = "btnCadastroDoEvento";
            this.btnCadastroDoEvento.Size = new System.Drawing.Size(167, 23);
            this.btnCadastroDoEvento.TabIndex = 0;
            this.btnCadastroDoEvento.Text = "CADASTRAR EVENTOS";
            this.btnCadastroDoEvento.UseVisualStyleBackColor = true;
            // 
            // btnEventoCadastrado
            // 
            this.btnEventoCadastrado.Location = new System.Drawing.Point(210, 28);
            this.btnEventoCadastrado.Name = "btnEventoCadastrado";
            this.btnEventoCadastrado.Size = new System.Drawing.Size(157, 23);
            this.btnEventoCadastrado.TabIndex = 1;
            this.btnEventoCadastrado.Text = "EVENTOS CADASTRADOS";
            this.btnEventoCadastrado.UseVisualStyleBackColor = true;
            this.btnEventoCadastrado.Click += new System.EventHandler(this.btnCadastrarEvento_Click);
            // 
            // btnConfiguracoesAnunciante
            // 
            this.btnConfiguracoesAnunciante.Location = new System.Drawing.Point(210, 83);
            this.btnConfiguracoesAnunciante.Name = "btnConfiguracoesAnunciante";
            this.btnConfiguracoesAnunciante.Size = new System.Drawing.Size(167, 23);
            this.btnConfiguracoesAnunciante.TabIndex = 2;
            this.btnConfiguracoesAnunciante.Text = "CONFIGURAÇÕES";
            this.btnConfiguracoesAnunciante.UseVisualStyleBackColor = true;
            // 
            // btnSairMenuAnunciante
            // 
            this.btnSairMenuAnunciante.Location = new System.Drawing.Point(210, 137);
            this.btnSairMenuAnunciante.Name = "btnSairMenuAnunciante";
            this.btnSairMenuAnunciante.Size = new System.Drawing.Size(68, 23);
            this.btnSairMenuAnunciante.TabIndex = 3;
            this.btnSairMenuAnunciante.Text = "SAIR";
            this.btnSairMenuAnunciante.UseVisualStyleBackColor = true;
            // 
            // btnReagendarEvento
            // 
            this.btnReagendarEvento.Location = new System.Drawing.Point(12, 83);
            this.btnReagendarEvento.Name = "btnReagendarEvento";
            this.btnReagendarEvento.Size = new System.Drawing.Size(167, 23);
            this.btnReagendarEvento.TabIndex = 4;
            this.btnReagendarEvento.Text = "REAGENDAR EVENTO";
            this.btnReagendarEvento.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEvento
            // 
            this.btnCancelarEvento.Location = new System.Drawing.Point(12, 137);
            this.btnCancelarEvento.Name = "btnCancelarEvento";
            this.btnCancelarEvento.Size = new System.Drawing.Size(167, 23);
            this.btnCancelarEvento.TabIndex = 5;
            this.btnCancelarEvento.Text = "CANCELAR EVENTO";
            this.btnCancelarEvento.UseVisualStyleBackColor = true;
            // 
            // TelaDeMenuAnunciante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 200);
            this.Controls.Add(this.btnCancelarEvento);
            this.Controls.Add(this.btnReagendarEvento);
            this.Controls.Add(this.btnSairMenuAnunciante);
            this.Controls.Add(this.btnConfiguracoesAnunciante);
            this.Controls.Add(this.btnEventoCadastrado);
            this.Controls.Add(this.btnCadastroDoEvento);
            this.Name = "TelaDeMenuAnunciante";
            this.Text = "TelaDeMenuAnunciante";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroDoEvento;
        private System.Windows.Forms.Button btnEventoCadastrado;
        private System.Windows.Forms.Button btnConfiguracoesAnunciante;
        private System.Windows.Forms.Button btnSairMenuAnunciante;
        private System.Windows.Forms.Button btnReagendarEvento;
        private System.Windows.Forms.Button btnCancelarEvento;
    }
}