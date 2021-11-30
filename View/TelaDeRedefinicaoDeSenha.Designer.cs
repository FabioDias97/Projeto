
namespace Projeto.View
{
    partial class TelaDeRedefinicaoDeSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeRedefinicaoDeSenha));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttbEmailCadastrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbNovaSenha = new System.Windows.Forms.TextBox();
            this.ttbConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRedefinirSenha = new System.Windows.Forms.Button();
            this.btnVoltarAoLogin = new System.Windows.Forms.Button();
            this.btnSairApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ttbEmailCadastrado
            // 
            this.ttbEmailCadastrado.Location = new System.Drawing.Point(44, 91);
            this.ttbEmailCadastrado.Multiline = true;
            this.ttbEmailCadastrado.Name = "ttbEmailCadastrado";
            this.ttbEmailCadastrado.Size = new System.Drawing.Size(286, 29);
            this.ttbEmailCadastrado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe Seu E-mail Cadastrado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inserir Nova Senha";
            // 
            // ttbNovaSenha
            // 
            this.ttbNovaSenha.Location = new System.Drawing.Point(44, 183);
            this.ttbNovaSenha.Multiline = true;
            this.ttbNovaSenha.Name = "ttbNovaSenha";
            this.ttbNovaSenha.Size = new System.Drawing.Size(286, 29);
            this.ttbNovaSenha.TabIndex = 4;
            // 
            // ttbConfirmacaoSenha
            // 
            this.ttbConfirmacaoSenha.Location = new System.Drawing.Point(44, 262);
            this.ttbConfirmacaoSenha.Multiline = true;
            this.ttbConfirmacaoSenha.Name = "ttbConfirmacaoSenha";
            this.ttbConfirmacaoSenha.Size = new System.Drawing.Size(286, 29);
            this.ttbConfirmacaoSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar Senha";
            // 
            // btnRedefinirSenha
            // 
            this.btnRedefinirSenha.Location = new System.Drawing.Point(105, 331);
            this.btnRedefinirSenha.Name = "btnRedefinirSenha";
            this.btnRedefinirSenha.Size = new System.Drawing.Size(176, 33);
            this.btnRedefinirSenha.TabIndex = 7;
            this.btnRedefinirSenha.Text = "REDEFINIR";
            this.btnRedefinirSenha.UseVisualStyleBackColor = true;
            // 
            // btnVoltarAoLogin
            // 
            this.btnVoltarAoLogin.Location = new System.Drawing.Point(32, 402);
            this.btnVoltarAoLogin.Name = "btnVoltarAoLogin";
            this.btnVoltarAoLogin.Size = new System.Drawing.Size(94, 23);
            this.btnVoltarAoLogin.TabIndex = 8;
            this.btnVoltarAoLogin.Text = "VOLTAR";
            this.btnVoltarAoLogin.UseVisualStyleBackColor = true;
            // 
            // btnSairApp
            // 
            this.btnSairApp.Location = new System.Drawing.Point(298, 402);
            this.btnSairApp.Name = "btnSairApp";
            this.btnSairApp.Size = new System.Drawing.Size(66, 23);
            this.btnSairApp.TabIndex = 9;
            this.btnSairApp.Text = "SAIR";
            this.btnSairApp.UseVisualStyleBackColor = true;
            // 
            // TelaDeRedefinicaoDeSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 447);
            this.Controls.Add(this.btnSairApp);
            this.Controls.Add(this.btnVoltarAoLogin);
            this.Controls.Add(this.btnRedefinirSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttbConfirmacaoSenha);
            this.Controls.Add(this.ttbNovaSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttbEmailCadastrado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaDeRedefinicaoDeSenha";
            this.Text = "TelaDeRedefinicaoDeSenha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ttbEmailCadastrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbNovaSenha;
        private System.Windows.Forms.TextBox ttbConfirmacaoSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRedefinirSenha;
        private System.Windows.Forms.Button btnVoltarAoLogin;
        private System.Windows.Forms.Button btnSairApp;
    }
}