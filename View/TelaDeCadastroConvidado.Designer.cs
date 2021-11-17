
namespace Projeto
{
    partial class frmTelaDeCadastroConvidado
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
            this.ttbNomeCovidado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbEnderecoConvidado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbNumeroCasa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbTelefoneConvidado = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbTelefonePessoaConfiavel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.ttbEmailConvidado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ttbConfirmacaoEmailConvidado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ttbSenhaConvidado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ttbConfirmacaoSenhaConvidado = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbUf = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe seu Nome Completo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ttbNomeCovidado
            // 
            this.ttbNomeCovidado.Location = new System.Drawing.Point(12, 37);
            this.ttbNomeCovidado.Name = "ttbNomeCovidado";
            this.ttbNomeCovidado.Size = new System.Drawing.Size(382, 23);
            this.ttbNomeCovidado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe seu Endereço";
            // 
            // ttbEnderecoConvidado
            // 
            this.ttbEnderecoConvidado.Location = new System.Drawing.Point(12, 96);
            this.ttbEnderecoConvidado.Name = "ttbEnderecoConvidado";
            this.ttbEnderecoConvidado.Size = new System.Drawing.Size(278, 23);
            this.ttbEnderecoConvidado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nº da Casa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ttbNumeroCasa
            // 
            this.ttbNumeroCasa.Location = new System.Drawing.Point(315, 96);
            this.ttbNumeroCasa.Name = "ttbNumeroCasa";
            this.ttbNumeroCasa.Size = new System.Drawing.Size(79, 23);
            this.ttbNumeroCasa.TabIndex = 5;
            this.ttbNumeroCasa.TextChanged += new System.EventHandler(this.ttbNumeroCasa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Informe seu Telefone";
            // 
            // mtbTelefoneConvidado
            // 
            this.mtbTelefoneConvidado.Location = new System.Drawing.Point(13, 154);
            this.mtbTelefoneConvidado.Mask = "(00)00000-0000";
            this.mtbTelefoneConvidado.Name = "mtbTelefoneConvidado";
            this.mtbTelefoneConvidado.Size = new System.Drawing.Size(161, 23);
            this.mtbTelefoneConvidado.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone (Pessoa Confiável)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // mtbTelefonePessoaConfiavel
            // 
            this.mtbTelefonePessoaConfiavel.Location = new System.Drawing.Point(230, 153);
            this.mtbTelefonePessoaConfiavel.Mask = "(00)00000-0000";
            this.mtbTelefonePessoaConfiavel.Name = "mtbTelefonePessoaConfiavel";
            this.mtbTelefonePessoaConfiavel.Size = new System.Drawing.Size(164, 23);
            this.mtbTelefonePessoaConfiavel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Informe seu Sexo";
            // 
            // cbbSexo
            // 
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Location = new System.Drawing.Point(422, 154);
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(199, 23);
            this.cbbSexo.TabIndex = 12;
            // 
            // ttbEmailConvidado
            // 
            this.ttbEmailConvidado.Location = new System.Drawing.Point(12, 209);
            this.ttbEmailConvidado.Name = "ttbEmailConvidado";
            this.ttbEmailConvidado.Size = new System.Drawing.Size(278, 23);
            this.ttbEmailConvidado.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Informe seu E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Confirme seu E-mail";
            // 
            // ttbConfirmacaoEmailConvidado
            // 
            this.ttbConfirmacaoEmailConvidado.Location = new System.Drawing.Point(343, 209);
            this.ttbConfirmacaoEmailConvidado.Name = "ttbConfirmacaoEmailConvidado";
            this.ttbConfirmacaoEmailConvidado.Size = new System.Drawing.Size(278, 23);
            this.ttbConfirmacaoEmailConvidado.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Informe seu CPF";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(422, 37);
            this.mtbCPF.Mask = "000,000,000,00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(199, 23);
            this.mtbCPF.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Crie uma Senha";
            // 
            // ttbSenhaConvidado
            // 
            this.ttbSenhaConvidado.Location = new System.Drawing.Point(12, 268);
            this.ttbSenhaConvidado.Name = "ttbSenhaConvidado";
            this.ttbSenhaConvidado.Size = new System.Drawing.Size(278, 23);
            this.ttbSenhaConvidado.TabIndex = 20;
            this.ttbSenhaConvidado.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(343, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Confirme sua Senha";
            // 
            // ttbConfirmacaoSenhaConvidado
            // 
            this.ttbConfirmacaoSenhaConvidado.Location = new System.Drawing.Point(343, 268);
            this.ttbConfirmacaoSenhaConvidado.Name = "ttbConfirmacaoSenhaConvidado";
            this.ttbConfirmacaoSenhaConvidado.Size = new System.Drawing.Size(278, 23);
            this.ttbConfirmacaoSenhaConvidado.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(422, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(120, 23);
            this.textBox5.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Bairro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(560, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "UF";
            // 
            // cbbUf
            // 
            this.cbbUf.FormattingEnabled = true;
            this.cbbUf.Location = new System.Drawing.Point(560, 96);
            this.cbbUf.Name = "cbbUf";
            this.cbbUf.Size = new System.Drawing.Size(61, 23);
            this.cbbUf.TabIndex = 27;
            // 
            // frmTelaDeCadastroConvidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 353);
            this.Controls.Add(this.cbbUf);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.ttbConfirmacaoSenhaConvidado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ttbSenhaConvidado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ttbConfirmacaoEmailConvidado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ttbEmailConvidado);
            this.Controls.Add(this.cbbSexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbTelefonePessoaConfiavel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbTelefoneConvidado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ttbNumeroCasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttbEnderecoConvidado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttbNomeCovidado);
            this.Controls.Add(this.label1);
            this.Name = "frmTelaDeCadastroConvidado";
            this.Text = "TELA DE CADASTRO CONVIDADO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbNomeCovidado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbEnderecoConvidado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbNumeroCasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneConvidado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbTelefonePessoaConfiavel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbSexo;
        private System.Windows.Forms.TextBox ttbEmailConvidado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ttbConfirmacaoEmailConvidado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ttbSenhaConvidado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ttbConfirmacaoSenhaConvidado;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbUf;
    }
}