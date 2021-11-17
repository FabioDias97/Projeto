
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
            this.label1 = new System.Windows.Forms.Label();
            this.ttbNomeAnunciante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ttbEmailAnunciante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ttbEmailAnuncianteConfirmacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ttbSenhaAnunciante = new System.Windows.Forms.TextBox();
            this.ttbSenhaAnuncianteConfirmacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCadastrarAnunciante = new System.Windows.Forms.Button();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe seu Nome / Empresa";
            // 
            // ttbNomeAnunciante
            // 
            this.ttbNomeAnunciante.Location = new System.Drawing.Point(33, 50);
            this.ttbNomeAnunciante.Name = "ttbNomeAnunciante";
            this.ttbNomeAnunciante.Size = new System.Drawing.Size(331, 23);
            this.ttbNomeAnunciante.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informe o CNPJ ou CPF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Informe seu E-mail";
            // 
            // ttbEmailAnunciante
            // 
            this.ttbEmailAnunciante.Location = new System.Drawing.Point(33, 202);
            this.ttbEmailAnunciante.Name = "ttbEmailAnunciante";
            this.ttbEmailAnunciante.Size = new System.Drawing.Size(331, 23);
            this.ttbEmailAnunciante.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Confirme seu E-mail";
            // 
            // ttbEmailAnuncianteConfirmacao
            // 
            this.ttbEmailAnuncianteConfirmacao.Location = new System.Drawing.Point(33, 260);
            this.ttbEmailAnuncianteConfirmacao.Name = "ttbEmailAnuncianteConfirmacao";
            this.ttbEmailAnuncianteConfirmacao.Size = new System.Drawing.Size(331, 23);
            this.ttbEmailAnuncianteConfirmacao.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Crie uma Senha";
            // 
            // ttbSenhaAnunciante
            // 
            this.ttbSenhaAnunciante.Location = new System.Drawing.Point(33, 316);
            this.ttbSenhaAnunciante.Name = "ttbSenhaAnunciante";
            this.ttbSenhaAnunciante.Size = new System.Drawing.Size(331, 23);
            this.ttbSenhaAnunciante.TabIndex = 21;
            // 
            // ttbSenhaAnuncianteConfirmacao
            // 
            this.ttbSenhaAnuncianteConfirmacao.Location = new System.Drawing.Point(33, 370);
            this.ttbSenhaAnuncianteConfirmacao.Name = "ttbSenhaAnuncianteConfirmacao";
            this.ttbSenhaAnuncianteConfirmacao.Size = new System.Drawing.Size(331, 23);
            this.ttbSenhaAnuncianteConfirmacao.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Confirme sua Senha";
            // 
            // btnCadastrarAnunciante
            // 
            this.btnCadastrarAnunciante.Location = new System.Drawing.Point(44, 416);
            this.btnCadastrarAnunciante.Name = "btnCadastrarAnunciante";
            this.btnCadastrarAnunciante.Size = new System.Drawing.Size(278, 33);
            this.btnCadastrarAnunciante.TabIndex = 26;
            this.btnCadastrarAnunciante.Text = "CADASTRAR";
            this.btnCadastrarAnunciante.UseVisualStyleBackColor = true;
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Checked = true;
            this.rbCNPJ.Location = new System.Drawing.Point(33, 112);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(52, 19);
            this.rbCNPJ.TabIndex = 27;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(33, 141);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(46, 19);
            this.rbCPF.TabIndex = 28;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Location = new System.Drawing.Point(91, 108);
            this.mtbCNPJ.Mask = "00,000,000/0000-00";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.ReadOnly = true;
            this.mtbCNPJ.Size = new System.Drawing.Size(198, 23);
            this.mtbCNPJ.TabIndex = 29;
            this.mtbCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCnpj_MaskInputRejected);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(91, 137);
            this.mtbCPF.Mask = "000.000.000.00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.ReadOnly = true;
            this.mtbCPF.Size = new System.Drawing.Size(198, 23);
            this.mtbCPF.TabIndex = 30;
            // 
            // frmTelaDeCadastroAnunciante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 471);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.mtbCNPJ);
            this.Controls.Add(this.rbCPF);
            this.Controls.Add(this.rbCNPJ);
            this.Controls.Add(this.btnCadastrarAnunciante);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ttbSenhaAnuncianteConfirmacao);
            this.Controls.Add(this.ttbSenhaAnunciante);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ttbEmailAnuncianteConfirmacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ttbEmailAnunciante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttbNomeAnunciante);
            this.Controls.Add(this.label1);
            this.Name = "frmTelaDeCadastroAnunciante";
            this.Text = "TELA DE CADASTRO ANUNCIANTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbNomeAnunciante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ttbEmailAnunciante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ttbEmailAnuncianteConfirmacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ttbSenhaAnunciante;
        private System.Windows.Forms.TextBox ttbSenhaAnuncianteConfirmacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCadastrarAnunciante;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
    }
}