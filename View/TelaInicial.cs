using Projeto.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            if (rbSOU_ANUNCIANTE.Checked)
            {
                frmTelaDeCadastroAnunciante tela = new frmTelaDeCadastroAnunciante();
                tela.Show();
            }
            else
            {
                frmTelaDeCadastroConvidado tela = new frmTelaDeCadastroConvidado();
                tela.Show();
            }
        }

        private void btnJaPossuoCadastro_Click(object sender, EventArgs e)
        {
            if (rbSOU_CONVIDADO.Checked)
            {
                frmTelaDeLogin tela = new frmTelaDeLogin();
                tela.Show();
            }
            else
            {
                frmTelaDeLogin tela = new frmTelaDeLogin();
                tela.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmInicial_Shown(object sender, EventArgs e)
        {
            frmTelaInicialApp tela = new frmTelaInicialApp();
            tela.ShowDialog();
        }

        private void rbSOU_CONVIDADO_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
