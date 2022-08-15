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
    public partial class frmSubtracao : Form
    {
        public frmSubtracao()
        {
            InitializeComponent();
        }

        private void btnvoltarsub_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnefesubtracao_Click(object sender, EventArgs e)
        {
           lblresultsub.Text = (float.Parse(txtnum1sub.Text) - float.Parse(txtnum2sub.Text)).ToString();
        }

        private void btnlimparsub_Click(object sender, EventArgs e)
        {
            txtnum1sub.Clear();
            txtnum2sub.Clear();
        }

        private void lblresultsub_Click(object sender, EventArgs e)
        {
         
        }
    }
}
