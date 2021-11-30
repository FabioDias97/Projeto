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
    public partial class frmTelaDeMenuAnunciante : Form
    {
        public frmTelaDeMenuAnunciante()
        {
            InitializeComponent();
        }

        private void btnCadastrarEvento_Click(object sender, EventArgs e)
        {

        }

        private void btnReagendarEvento_Click(object sender, EventArgs e)
        {
            frmTelaDeReagendamento tela = new frmTelaDeReagendamento();
            tela.Show();
        }

        private void btnCadastroDoEvento_Click(object sender, EventArgs e)
        {
            frmTelaDeCadastroEventos tela = new frmTelaDeCadastroEventos();
            tela.Show();
        }
    }
}
