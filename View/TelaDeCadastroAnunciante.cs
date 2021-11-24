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

        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCNPJ.Checked)
            {
                mtbCNPJ.ReadOnly = false;
                mtbCPF.ReadOnly = true;
                rbCPF.Enabled = true;
            }
            else
            {
                mtbCNPJ.ReadOnly = true;
                mtbCPF.ReadOnly = false;
                rbCPF.Checked = false;
                rbCPF.Enabled = false;
            }
        }

        private void frmTelaDeCadastroAnunciante_Load(object sender, EventArgs e)
        {

        }
    }
}
