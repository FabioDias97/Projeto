using Projeto.Controller;
using Projeto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.View
{
    public partial class frmTelaDeCadastroAnunciante : Form
    {
        public frmTelaDeCadastroAnunciante()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mtbCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void btnCadastrarAnunciante_Click(object sender, EventArgs e)
        {
            List<string> listaErros = new List<string>();
            string nomeAnunciante = "";
            string cpf = "";
            //string cnpj = "";
            string email = "";

            if(ttbNomeAnunciante.Text.Length>10)
                nomeAnunciante = ttbNomeAnunciante.Text;
            else
                listaErros.Add("\nPreencha seu Nome!");

            if(mtbCPF.Text!="   .   .   -")
                cpf = mtbCPF.Text;
            else
                listaErros.Add("\nInforme seu CPF!");

            /*if(mtbCNPJ.Text != "   ,   ,   /   -");
                cnpj = mtbCNPJ.Text;
            else
                listaErros.Add("\nInsira o CNPJ");*/

            if(ValidarEmail.IsvalidEmail(ttbEmailAnunciante.Text))
                email = ttbEmailAnunciante.Text;
            else
                MessageBox.Show("Por favor, insira um E-mail Válido!");
            if (listaErros.Count > 0)
            {
                string erros = "";
                for (int i = 0; i < listaErros.Count; i++)
                    erros = erros + listaErros[i].ToString();
                MessageBox.Show("Erros: \n" + erros);

            }
            else
            {
                PessoaEntity pessoa = new PessoaEntity(1, ttbNomeAnunciante.Text, mtbCPF.Text, mtbCNPJ.Text, 
                                    ttbEmailAnunciante.Text, ttbSenhaAnunciante.Text, ttbSenhaAnuncianteConfirmacao.Text);
                Controle controle = new Controle();
                bool cadastrou = controle.Cadastrar(pessoa);
                if (cadastrou)
                    MessageBox.Show("Anunciante Cadastrado com Sucesso!");
                else
                    MessageBox.Show("Erro, Não foi possivel Cadastrar-lo.");
            }       
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCNPJ.Checked)
            {
                mtbCNPJ.Enabled = true;
                mtbCPF.Enabled = false;
                mtbCPF.Clear();
                
            }
           
        }

        private void frmTelaDeCadastroAnunciante_Load(object sender, EventArgs e)
        {

        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPF.Checked) 
            {
                mtbCPF.Enabled = true;
                mtbCNPJ.Enabled = false;
                mtbCNPJ.Clear();
            }
        }

        private void btnTCAVoltar_Click(object sender, EventArgs e)
        {
            frmInicial tela = new frmInicial();
            tela.Show();
        }
    }
}
