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
    public partial class Resumo : Form
    {
        private SqlConnection objCnx = new SqlConnection(); // BANCO DE DADOS
        private SqlCommand objCmd = new SqlCommand(); // BANCO DE DADOS
        private SqlDataReader objDados; // BANCO DE DADOS

        int Idmateria;
        string textomat;

        public Resumo()
        {
            InitializeComponent();
        }

        // RECEBE VARIAVEL DE OUTRO FORM
        public Resumo(int idmateria)
        {
            InitializeComponent();
            Idmateria = idmateria;
        }

        // CARREGA OS RESUMOS DO BANCO DE DADOS
        private void Resumo_Load(object sender, EventArgs e)
        {
            if(Idmateria == 1)
            {
                textomat = "Biomas Brasileiros";
            }
            else if( Idmateria == 2)
            {
                textomat = "Citologia";
            }
            else if (Idmateria == 3)
            {
                textomat = "Estequiometria";
            }
            else if( Idmateria == 4)
            {
                textomat = "Química Orgânica";
            }
            else if (Idmateria == 5)
            {
                textomat = "As Leis de Newton";
            }
            else if (Idmateria == 6)
            {
                textomat = "Óptica";
            }
            else if (Idmateria == 7)
            {
                textomat = "Ética e Moral";
            }
            else if (Idmateria == 8)
            {
                textomat = "Citologia";
            }
            else if (Idmateria == 9)
            {
                textomat = "Citologia";
            }
            else if (Idmateria == 10)
            {
                textomat = "Citologia";
            }
            else if (Idmateria == 11)
            {
                textomat = "O Romantismo";
            }
            else if (Idmateria == 12)
            {
                textomat = "O Gênero Lírico";
            }
            else if (Idmateria == 13)
            {
                textomat = "Citologia";
            }
            else if (Idmateria == 14)
            {
                textomat = "Citologia";
            }
            else if (Idmateria == 15)
            {
                textomat = "Citologia";
            }
            else if (Idmateria == 16)
            {
                textomat = "Citologia";
            }
            else if (Idmateria == 17)
            {
                textomat = "Equação de 1° e 2° grau";
            }
            else if (Idmateria == 18)
            {
                textomat = "Porcentagem";
            }
            try
            {
                //objCnx.ConnectionString = @"Data Source=LAB2653-11\SQLEXPRESS;Initial Catalog=Produtos;Integrated Security=true";
                objCnx.ConnectionString = Properties.Settings.Default.ConexaoBDDUsuario;
                objCnx.Open();

                string strSql = "Select * from TB_RESUMO where ID_RESUMO='" + Idmateria + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (objDados.HasRows)
                {
                    if (objDados.Read())
                    {
                        lblTitulo.Text = textomat;
                        lblRedacao.Text = objDados["DESC_RESUMO"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Erro ao carregar formulário", "Load de Formulário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (!objDados.IsClosed)
                {
                    objDados.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
