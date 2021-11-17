using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.View
{
    public partial class frmTelaInicialApp : Form
    {
        public frmTelaInicialApp()
        {
            InitializeComponent();
        }

        private void TelaInicialApp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTelaInicialApp_Shown(object sender, EventArgs e)
        {
            lblStatus.Text = "CARREGANDO O SISTEMA...";
            this.Refresh();

            for (int i = 1; i < 101;  i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(40);
            }
            progressBar1.Value = 99;
            Thread.Sleep(500);

            this.Close();
        }
    }
}
