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
    public partial class Desempenho : Form
    {
        private SqlConnection objCnx = new SqlConnection(); // BANCO DE DADOS
        private SqlCommand objCmd = new SqlCommand(); // BANCO DE DADOS
        private SqlDataReader objDados; // BANCO DE DADOS
        string Idusuario;
        int materia;

        public Desempenho(string idusuario)
        {
            InitializeComponent();
            Idusuario = idusuario;
        }

        // CONEXAO COM O BANCO DE DADOS
        private void Desempenho_Load(object sender, EventArgs e)
        {
            dgDesempenho.Visible = false;
            
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

        // CARREGA AS INFORMAÇOES NO DATAGRID
        private void btnExibir_Click(object sender, EventArgs e)
        {
            dgDesempenho.Rows.Clear();
            dgDesempenho.Refresh();

            if(cbMateria.Text == "Geral")
            {
                materia = 12;
            }
            else if(cbMateria.Text == "Matemática")
            {
                materia = 10;
            }
            else if (cbMateria.Text == "Ciências da natureza")
            {
                materia = 13;
            }
            else if (cbMateria.Text == "Ciências humanas")
            {
                materia = 14;
            }
            else if (cbMateria.Text == "Linguagens")
            {
                materia = 15;
            }

            try
            {
                string strSql = "Select * from TB_TESTE WHERE ID_MATERIA='" + materia + "'AND ID_USUARIO='" + Idusuario + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (objDados.HasRows)
                {
                    while (objDados.Read())
                    {
                        dgDesempenho.Rows.Add(cbMateria.Text, objDados["DTA_TESTE"].ToString(), objDados["QTD_PERG_TESTE"].ToString(), objDados["DESEMPENHO_TESTE"].ToString());
                    }
                    dgDesempenho.Visible = true;
                    objDados.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum Simulado dessa matéria foi efetuado!", "Consultar Desempenho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (!objDados.IsClosed)
                {
                    objDados.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ==> " + erro.Message, " ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
