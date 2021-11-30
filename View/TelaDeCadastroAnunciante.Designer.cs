
namespace Projeto.View
{
    partial class frmTelaDeCadastroAnunciante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaDeCadastroAnunciante));
            this.label1 = new System.Windows.Forms.Label();
            this.ttbNomeAnunciante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ttbEmailAnunciante = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ttbSenhaAnunciante = new System.Windows.Forms.TextBox();
            this.ttbSenhaAnuncianteConfirmacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCadastrarAnunciante = new System.Windows.Forms.Button();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTCAVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe seu Nome / Empresa";
            // 
            // ttbNomeAnunciante
            // 
            this.ttbNomeAnunciante.Location = new System.Drawing.Point(33, 67);
            this.ttbNomeAnunciante.Name = "ttbNomeAnunciante";
            this.ttbNomeAnunciante.Size = new System.Drawing.Size(331, 23);
            this.ttbNomeAnunciante.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informe o CNPJ ou CPF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Informe seu E-mail";
            // 
            // ttbEmailAnunciante
            // 
            this.ttbEmailAnunciante.Location = new System.Drawing.Point(33, 223);
            this.ttbEmailAnunciante.Name = "ttbEmailAnunciante";
            this.ttbEmailAnunciante.Size = new System.Drawing.Size(331, 23);
            this.ttbEmailAnunciante.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Crie uma Senha";
            // 
            // ttbSenhaAnunciante
            // 
            this.ttbSenhaAnunciante.Location = new System.Drawing.Point(33, 287);
            this.ttbSenhaAnunciante.Name = "ttbSenhaAnunciante";
            this.ttbSenhaAnunciante.PasswordChar = '*';
            this.ttbSenhaAnunciante.Size = new System.Drawing.Size(331, 23);
            this.ttbSenhaAnunciante.TabIndex = 21;
            // 
            // ttbSenhaAnuncianteConfirmacao
            // 
            this.ttbSenhaAnuncianteConfirmacao.Location = new System.Drawing.Point(33, 359);
            this.ttbSenhaAnuncianteConfirmacao.Name = "ttbSenhaAnuncianteConfirmacao";
            this.ttbSenhaAnuncianteConfirmacao.PasswordChar = '*';
            this.ttbSenhaAnuncianteConfirmacao.Size = new System.Drawing.Size(331, 23);
            this.ttbSenhaAnuncianteConfirmacao.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Confirme sua Senha";
            // 
            // btnCadastrarAnunciante
            // 
            this.btnCadastrarAnunciante.Location = new System.Drawing.Point(159, 416);
            this.btnCadastrarAnunciante.Name = "btnCadastrarAnunciante";
            this.btnCadastrarAnunciante.Size = new System.Drawing.Size(205, 33);
            this.btnCadastrarAnunciante.TabIndex = 26;
            this.btnCadastrarAnunciante.Text = "CADASTRAR";
            this.btnCadastrarAnunciante.UseVisualStyleBackColor = true;
            this.btnCadastrarAnunciante.Click += new System.EventHandler(this.btnCadastrarAnunciante_Click);
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbCNPJ.Checked = true;
            this.rbCNPJ.Location = new System.Drawing.Point(33, 127);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(52, 19);
            this.rbCNPJ.TabIndex = 27;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            this.rbCNPJ.CheckedChanged += new System.EventHandler(this.rbCNPJ_CheckedChanged);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(33, 157);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(46, 19);
            this.rbCPF.TabIndex = 28;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Location = new System.Drawing.Point(95, 127);
            this.mtbCNPJ.Mask = "000,000,000/000-00";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(209, 23);
            this.mtbCNPJ.TabIndex = 29;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Enabled = false;
            this.mtbCPF.Location = new System.Drawing.Point(95, 156);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(209, 23);
            this.mtbCPF.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnTCAVoltar
            // 
            this.btnTCAVoltar.Location = new System.Drawing.Point(33, 416);
            this.btnTCAVoltar.Name = "btnTCAVoltar";
            this.btnTCAVoltar.Size = new System.Drawing.Size(66, 33);
            this.btnTCAVoltar.TabIndex = 32;
            this.btnTCAVoltar.Text = "VOLTAR";
            this.btnTCAVoltar.UseVisualStyleBackColor = true;
            this.btnTCAVoltar.Click += new System.EventHandler(this.btnTCAVoltar_Click);
            // 
            // frmTelaDeCadastroAnunciante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 471);
            this.Controls.Add(this.btnTCAVoltar);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.mtbCNPJ);
            this.Controls.Add(this.rbCPF);
            this.Controls.Add(this.rbCNPJ);
            this.Controls.Add(this.btnCadastrarAnunciante);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ttbSenhaAnuncianteConfirmacao);
            this.Controls.Add(this.ttbSenhaAnunciante);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ttbEmailAnunciante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttbNomeAnunciante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTelaDeCadastroAnunciante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELA DE CADASTRO ANUNCIANTE";
            this.Load += new System.EventHandler(this.frmTelaDeCadastroAnunciante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbNomeAnunciante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ttbEmailAnunciante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ttbSenhaAnunciante;
        private System.Windows.Forms.TextBox ttbSenhaAnuncianteConfirmacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCadastrarAnunciante;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTCAVoltar;
    }
}