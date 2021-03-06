using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PrjForumDistriCSharp
{
    public partial class FrmConsulta : Form
    {
        string selectnobanco;

        public void BancoConsulta()
        {
            SqlConnection conexao = new SqlConnection(strcon);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            if(rdbcivel.Checked && rdbnome.Checked)
            {
                selectnobanco = "Select nm_requerido as \"Requerido\", nm_requerente as \"Requerente\", dt_distribuicao as \"Data de Distribuição\", nm_natureza as \"Natureza\", nm_oficio as \"Oficio\", vl_valor as \"Valor\", nm_observacao as \"Observação\" from dbo.FichaCivel where nm_requerido = '" + txtnome.Text + "'";
            }
            if (rdbcivel.Checked && rdbdatadistri.Checked)
            {
                selectnobanco = "Select nm_requerido as \"Requerido\", nm_requerente as \"Requerente\", dt_distribuicao as \"Data de Distribuição\", nm_natureza as \"Natureza\", nm_oficio as \"Oficio\", vl_valor as \"Valor\", nm_observacao as \"Observação\" from dbo.FichaCivel where dt_distribuicao = '" + dtpDistribuicao.Value.ToString("yyyyMMdd") + "'";
            }
            if(rdbcriminal.Checked && rdbnome.Checked)
            {
                selectnobanco = "Select nm_requerido as \"Requerido\", nm_requerente as \"Requerente\", dt_distribuicao as \"Data de Distribuição\", nm_natureza as \"Natureza\", nm_oficio as \"Oficio\", vl_valor as \"Valor\", nm_observacao as \"Observação\" from dbo.FichaCivel where nm_requerido = '" + txtnome.Text + "'";
            }
            if(rdbcriminal.Checked && rdbdatadistri.Checked)
            {
                selectnobanco = "";
            }

            SqlCommand cmdsql = new SqlCommand(selectnobanco, conexao);
            conexao.Open();
            cmdsql.ExecuteNonQuery();
            da.SelectCommand = cmdsql;
            da.Fill(ds);
            datagridconsulta.DataSource = ds;
            datagridconsulta.DataMember = ds.Tables[0].TableName;
            conexao.Close();
            if (datagridconsulta.RowCount <= 1)
                MessageBox.Show("Nenhum registro foi encontrado.");

        }

        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            rdbcivel.Checked = true;
            rdbnome.Checked = true;
            lblcheck.Text = "Digite o nome:";
            txtnome.Focus();
            dtpDistribuicao.Visible = false;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            datagridconsulta.DataSource = null;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BancoConsulta();
        }

        private void rdbnome_CheckedChanged(object sender, EventArgs e)
        {
            lblcheck.Text = "Digite o nome:";
            txtnome.Visible = true;
            dtpDistribuicao.Visible = false;
        }

        private void rdbdatadistri_CheckedChanged(object sender, EventArgs e)
        {
            lblcheck.Text = "Digite a data de Distribuição:";
            txtnome.Visible = false;
            dtpDistribuicao.Visible = true;
        }
    }
}
