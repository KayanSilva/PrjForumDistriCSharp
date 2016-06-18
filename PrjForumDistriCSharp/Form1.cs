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
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            rdbCivel.Checked = true;
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
            string strcon = "Server=tcp:kaysoft.database.windows.net,1433;Data Source=kaysoft.database.windows.net;Initial Catalog=DistribuidorGuaruja;Persist Security Info=False;User ID=kayanfds;Password=Kayas190393;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            SqlConnection conexao = new SqlConnection(strcon);          
            SqlCommand cmdsql = new SqlCommand("Select nm_requerido as \"Requerido\", nm_requerente as \"Requerente\", dt_distribuicao as \"Data de Distribuição\", nm_natureza as \"Natureza\", nm_oficio as \"Oficio\", vl_valor as \"Valor\", nm_observacao as \"Observação\" from dbo.FichaCivel where nm_requerido = '"+txtnome.Text+"'", conexao);           

            try
            {
                conexao.Open();
                cmdsql.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmdsql;
                da.Fill(ds);
                datagridconsulta.DataSource = ds;
                datagridconsulta.DataMember = ds.Tables[0].TableName;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
