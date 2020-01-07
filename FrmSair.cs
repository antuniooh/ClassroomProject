using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_AppEstudos_TCC
{
    public partial class FrmSair : Form
    {
        private SqlConnection objCnx = new SqlConnection();
        private SqlCommand objCmd = new SqlCommand();
        private SqlDataReader objDados;
        public FrmSair()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();// Fecha toda Aplicação

        }

        private void btnSairSim_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from TB_USUARIO where STATUS_USUARIO='" + "Online" + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Erro!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    strSql = "UPDATE TB_USUARIO SET STATUS_USUARIO ='" + "Offline" + "' where STATUS_USUARIO='" + "Online" + "'";

                    objCmd.CommandText = strSql;
                    objCmd.Connection = objCnx;
                    objCmd.ExecuteNonQuery();

                    this.Hide();

                    FrmLogin l = new FrmLogin();
                    l.Show();
                }

                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
            Application.Exit();
        }

        private void btnSairNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSair_Load(object sender, EventArgs e)
        {
            try
            {
                //objCnx.ConnectionString = @"Data Source=LUIZ\SQLEXPRESS;Initial Catalog=Produtos;Integrated Security=true";
                objCnx.ConnectionString = Properties.Settings.Default.ConexaoBDDUsuario;
                objCnx.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
