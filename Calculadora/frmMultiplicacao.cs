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
    public partial class frmMultiplicacao : Form
    {
        public frmMultiplicacao()
        {
            InitializeComponent();
        }

        private void lbllinhasub1_Click(object sender, EventArgs e)
        {

        }

        private void btnefemult_Click(object sender, EventArgs e)
        {
            lblresultmult.Text = (float.Parse(txtnum1mult.Text) * float.Parse(txtnum2mult.Text)).ToString();
        }

        private void btnvoltarmult_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimparmult_Click(object sender, EventArgs e)
        {
            txtnum1mult.Clear();
            txtnum2mult.Clear();
        }
    }
}
