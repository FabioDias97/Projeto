
namespace Projeto
{
    partial class frmInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.rbSOU_ANUNCIANTE = new System.Windows.Forms.RadioButton();
            this.rbSOU_CONVIDADO = new System.Windows.Forms.RadioButton();
            this.btnCadastreSe = new System.Windows.Forms.Button();
            this.btnJaPossuoCadastro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbSOU_ANUNCIANTE
            // 
            this.rbSOU_ANUNCIANTE.AutoSize = true;
            this.rbSOU_ANUNCIANTE.Location = new System.Drawing.Point(62, 210);
            this.rbSOU_ANUNCIANTE.Name = "rbSOU_ANUNCIANTE";
            this.rbSOU_ANUNCIANTE.Size = new System.Drawing.Size(125, 19);
            this.rbSOU_ANUNCIANTE.TabIndex = 8;
            this.rbSOU_ANUNCIANTE.Text = "SOU ANUNCIANTE";
            this.rbSOU_ANUNCIANTE.UseVisualStyleBackColor = true;
            // 
            // rbSOU_CONVIDADO
            // 
            this.rbSOU_CONVIDADO.AutoSize = true;
            this.rbSOU_CONVIDADO.Location = new System.Drawing.Point(221, 210);
            this.rbSOU_CONVIDADO.Name = "rbSOU_CONVIDADO";
            this.rbSOU_CONVIDADO.Size = new System.Drawing.Size(120, 19);
            this.rbSOU_CONVIDADO.TabIndex = 9;
            this.rbSOU_CONVIDADO.Text = "SOU CONVIDADO";
            this.rbSOU_CONVIDADO.UseVisualStyleBackColor = true;
            this.rbSOU_CONVIDADO.CheckedChanged += new System.EventHandler(this.rbSOU_CONVIDADO_CheckedChanged);
            // 
            // btnCadastreSe
            // 
            this.btnCadastreSe.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastreSe.ForeColor = System.Drawing.Color.White;
            this.btnCadastreSe.Location = new System.Drawing.Point(62, 295);
            this.btnCadastreSe.Name = "btnCadastreSe";
            this.btnCadastreSe.Size = new System.Drawing.Size(279, 35);
            this.btnCadastreSe.TabIndex = 10;
            this.btnCadastreSe.Text = "CADASTRE - SE";
            this.btnCadastreSe.UseVisualStyleBackColor = false;
            this.btnCadastreSe.Click += new System.EventHandler(this.btnCadastreSe_Click);
            // 
            // btnJaPossuoCadastro
            // 
            this.btnJaPossuoCadastro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnJaPossuoCadastro.ForeColor = System.Drawing.Color.White;
            this.btnJaPossuoCadastro.Location = new System.Drawing.Point(62, 376);
            this.btnJaPossuoCadastro.Name = "btnJaPossuoCadastro";
            this.btnJaPossuoCadastro.Size = new System.Drawing.Size(279, 36);
            this.btnJaPossuoCadastro.TabIndex = 11;
            this.btnJaPossuoCadastro.Text = "JÁ POSSUO CADASTRO";
            this.btnJaPossuoCadastro.UseVisualStyleBackColor = false;
            this.btnJaPossuoCadastro.Click += new System.EventHandler(this.btnJaPossuoCadastro_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(370, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 26);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ainda não possui conta?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(430, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnJaPossuoCadastro);
            this.Controls.Add(this.btnCadastreSe);
            this.Controls.Add(this.rbSOU_CONVIDADO);
            this.Controls.Add(this.rbSOU_ANUNCIANTE);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELA INICIAL";
            this.Shown += new System.EventHandler(this.frmInicial_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbSOU_ANUNCIANTE;
        private System.Windows.Forms.RadioButton rbSOU_CONVIDADO;
        private System.Windows.Forms.Button btnCadastreSe;
        private System.Windows.Forms.Button btnJaPossuoCadastro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

