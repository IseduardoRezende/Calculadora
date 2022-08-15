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
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void lbltitulosoma_Click(object sender, EventArgs e)
        {

        }

        private void txtnum2soma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnum1soma_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnefesoma_Click(object sender, EventArgs e)
        {
            lblresultsoma.Text = (int.Parse(txtnum1soma.Text) + int.Parse(txtnum2soma.Text)).ToString();
        }

        private void txtresultsoma_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmSoma_Load(object sender, EventArgs e)
        {

        }

        private void btnlimparsoma_Click(object sender, EventArgs e)
        {
            txtnum1soma.Clear();
            txtnum2soma.Clear();
        }
    }
}
