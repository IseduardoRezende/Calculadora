using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            frmSoma soma = new frmSoma();
            soma.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            frmSubtracao subtracao = new frmSubtracao();
            subtracao.ShowDialog();
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            frmMultiplicacao multiplicacao = new frmMultiplicacao();
            multiplicacao.ShowDialog();
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            frmDivisao divisao = new frmDivisao();
            divisao.ShowDialog();
        }
    }
}
