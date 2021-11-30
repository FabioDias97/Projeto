
namespace Projeto.View
{
    partial class frmTelaDeEventosCadastrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaDeEventosCadastrado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttbCodigoEvento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbListaDeEventos = new System.Windows.Forms.ComboBox();
            this.btnConvirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ttbCodigoEvento
            // 
            this.ttbCodigoEvento.Location = new System.Drawing.Point(55, 170);
            this.ttbCodigoEvento.Multiline = true;
            this.ttbCodigoEvento.Name = "ttbCodigoEvento";
            this.ttbCodigoEvento.Size = new System.Drawing.Size(310, 33);
            this.ttbCodigoEvento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira o Código do Evento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "COMPROVANTE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insira o Comprovante de Vacinação ( Ciclo Completo )";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "VOLTAR AO MENU";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Informe o Evento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbbListaDeEventos
            // 
            this.cbbListaDeEventos.FormattingEnabled = true;
            this.cbbListaDeEventos.Location = new System.Drawing.Point(55, 85);
            this.cbbListaDeEventos.Name = "cbbListaDeEventos";
            this.cbbListaDeEventos.Size = new System.Drawing.Size(310, 23);
            this.cbbListaDeEventos.TabIndex = 13;
            // 
            // btnConvirmar
            // 
            this.btnConvirmar.Location = new System.Drawing.Point(128, 325);
            this.btnConvirmar.Name = "btnConvirmar";
            this.btnConvirmar.Size = new System.Drawing.Size(151, 33);
            this.btnConvirmar.TabIndex = 14;
            this.btnConvirmar.Text = "CONFIRMAR";
            this.btnConvirmar.UseVisualStyleBackColor = true;
            // 
            // frmTelaDeEventosCadastrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.btnConvirmar);
            this.Controls.Add(this.cbbListaDeEventos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttbCodigoEvento);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTelaDeEventosCadastrado";
            this.Text = "TELA DE EVENTOS CADASTRADOS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ttbCodigoEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbListaDeEventos;
        private System.Windows.Forms.Button btnConvirmar;
    }
}