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
    public partial class frmTelaDeCadastroConvidado : Form
    {
        public frmTelaDeCadastroConvidado()
        {
            InitializeComponent();
            cbbUF.Items.Add("Selecione"); cbbUF.Items.Add("AC"); cbbUF.Items.Add("AL"); cbbUF.Items.Add("AP"); cbbUF.Items.Add("AM");
            cbbUF.Items.Add("BA"); cbbUF.Items.Add("CE"); cbbUF.Items.Add("DF"); cbbUF.Items.Add("ES"); cbbUF.Items.Add("GO");
            cbbUF.Items.Add("MA"); cbbUF.Items.Add("MT"); cbbUF.Items.Add("MS"); cbbUF.Items.Add("MG"); cbbUF.Items.Add("PA"); cbbUF.Items.Add("PB");
            cbbUF.Items.Add("PR"); cbbUF.Items.Add("PE"); cbbUF.Items.Add("PI"); cbbUF.Items.Add("RJ"); cbbUF.Items.Add("RN"); cbbUF.Items.Add("SR");
            cbbUF.Items.Add("RO"); cbbUF.Items.Add("SC"); cbbUF.Items.Add("BA"); cbbUF.Items.Add("SP"); cbbUF.Items.Add("SE"); cbbUF.Items.Add("TO");

            cbbUF.SelectedIndex = cbbUF.FindStringExact("Selecione");

            cbbUF.DropDownStyle = ComboBoxStyle.DropDownList;

            
            cbbSexo.Items.Add("Selecione"); cbbSexo.Items.Add("Masculino"); cbbSexo.Items.Add("Feminino");

            cbbSexo.SelectedIndex = cbbSexo.FindStringExact("Selecione");

            cbbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ttbNumeroCasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTelaDeCadastroConvidado_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cbbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
    }
}
