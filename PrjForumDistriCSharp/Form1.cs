using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjForumDistriCSharp
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            rdbCivel.Checked = true;
            txtnome.Clear();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
