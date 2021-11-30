
namespace Projeto.View
{
    partial class frmTelaDeMenuAnunciante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaDeMenuAnunciante));
            this.btnCadastroDoEvento = new System.Windows.Forms.Button();
            this.btnEventoCadastrado = new System.Windows.Forms.Button();
            this.btnConfiguracoesAnunciante = new System.Windows.Forms.Button();
            this.btnSairMenuAnunciante = new System.Windows.Forms.Button();
            this.btnReagendarEvento = new System.Windows.Forms.Button();
            this.btnCancelarEvento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastroDoEvento
            // 
            this.btnCadastroDoEvento.Location = new System.Drawing.Point(57, 54);
            this.btnCadastroDoEvento.Name = "btnCadastroDoEvento";
            this.btnCadastroDoEvento.Size = new System.Drawing.Size(272, 37);
            this.btnCadastroDoEvento.TabIndex = 0;
            this.btnCadastroDoEvento.Text = "CADASTRAR EVENTOS";
            this.btnCadastroDoEvento.UseVisualStyleBackColor = true;
            this.btnCadastroDoEvento.Click += new System.EventHandler(this.btnCadastroDoEvento_Click);
            // 
            // btnEventoCadastrado
            // 
            this.btnEventoCadastrado.Location = new System.Drawing.Point(57, 132);
            this.btnEventoCadastrado.Name = "btnEventoCadastrado";
            this.btnEventoCadastrado.Size = new System.Drawing.Size(272, 37);
            this.btnEventoCadastrado.TabIndex = 1;
            this.btnEventoCadastrado.Text = "EVENTOS CADASTRADOS";
            this.btnEventoCadastrado.UseVisualStyleBackColor = true;
            this.btnEventoCadastrado.Click += new System.EventHandler(this.btnCadastrarEvento_Click);
            // 
            // btnConfiguracoesAnunciante
            // 
            this.btnConfiguracoesAnunciante.Location = new System.Drawing.Point(22, 397);
            this.btnConfiguracoesAnunciante.Name = "btnConfiguracoesAnunciante";
            this.btnConfiguracoesAnunciante.Size = new System.Drawing.Size(128, 30);
            this.btnConfiguracoesAnunciante.TabIndex = 2;
            this.btnConfiguracoesAnunciante.Text = "CONFIGURAÇÕES";
            this.btnConfiguracoesAnunciante.UseVisualStyleBackColor = true;
            // 
            // btnSairMenuAnunciante
            // 
            this.btnSairMenuAnunciante.Location = new System.Drawing.Point(285, 397);
            this.btnSairMenuAnunciante.Name = "btnSairMenuAnunciante";
            this.btnSairMenuAnunciante.Size = new System.Drawing.Size(72, 28);
            this.btnSairMenuAnunciante.TabIndex = 3;
            this.btnSairMenuAnunciante.Text = "VOLTAR";
            this.btnSairMenuAnunciante.UseVisualStyleBackColor = true;
            // 
            // btnReagendarEvento
            // 
            this.btnReagendarEvento.Location = new System.Drawing.Point(57, 214);
            this.btnReagendarEvento.Name = "btnReagendarEvento";
            this.btnReagendarEvento.Size = new System.Drawing.Size(272, 36);
            this.btnReagendarEvento.TabIndex = 4;
            this.btnReagendarEvento.Text = "REAGENDAR EVENTO";
            this.btnReagendarEvento.UseVisualStyleBackColor = true;
            this.btnReagendarEvento.Click += new System.EventHandler(this.btnReagendarEvento_Click);
            // 
            // btnCancelarEvento
            // 
            this.btnCancelarEvento.Location = new System.Drawing.Point(57, 296);
            this.btnCancelarEvento.Name = "btnCancelarEvento";
            this.btnCancelarEvento.Size = new System.Drawing.Size(272, 36);
            this.btnCancelarEvento.TabIndex = 5;
            this.btnCancelarEvento.Text = "CANCELAR EVENTO";
            this.btnCancelarEvento.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 447);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmTelaDeMenuAnunciante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 443);
            this.Controls.Add(this.btnCancelarEvento);
            this.Controls.Add(this.btnReagendarEvento);
            this.Controls.Add(this.btnSairMenuAnunciante);
            this.Controls.Add(this.btnConfiguracoesAnunciante);
            this.Controls.Add(this.btnEventoCadastrado);
            this.Controls.Add(this.btnCadastroDoEvento);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTelaDeMenuAnunciante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaDeMenuAnunciante";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroDoEvento;
        private System.Windows.Forms.Button btnEventoCadastrado;
        private System.Windows.Forms.Button btnConfiguracoesAnunciante;
        private System.Windows.Forms.Button btnSairMenuAnunciante;
        private System.Windows.Forms.Button btnReagendarEvento;
        private System.Windows.Forms.Button btnCancelarEvento;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}