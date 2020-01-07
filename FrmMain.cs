using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Projeto_AppEstudos_TCC
{
    public partial class FrmMain : Form
    {
        private SqlConnection objCnx = new SqlConnection(); //BANCO DE DADOS
        private SqlCommand objCmd = new SqlCommand(); //BANCO DE DADOS
        private SqlDataReader objDados; //BANCO DE DADOS

        public FrmMain()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height; //PAINEL DESIGN
            SidePanel.Top = btnHome.Top;
            userControlHome1.BringToFront();
        }

        //CONEXÃO E LE DADOS DO BANCO DE DADOS
        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //objCnx.ConnectionString = @"Data Source=LUIZ\SQLEXPRESS;Initial Catalog=Produtos;Integrated Security=true";
                objCnx.ConnectionString = Properties.Settings.Default.ConexaoBDDUsuario;
                objCnx.Open();

                string strSql = "Select * from TB_USUARIO where STATUS_USUARIO='" + "Online" + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (objDados.HasRows)
                {
                    if (objDados.Read())
                    {
                        lblMensagem.Text = objDados["USER_USUARIO"].ToString() + " !";
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
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //DESIGN
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            userControlHome1.BringToFront();
        }

        //DESIGN
        private void btnResumos_Click_1(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Height = btnResumos.Height;
            SidePanel.Top = btnResumos.Top;
            userControlResumos1.BringToFront();
        }

        //DESIGN
        private void btnExercicios_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Height = btnExercicios.Height;
            SidePanel.Top = btnExercicios.Top;
            userControlExercicios1.BringToFront();
        }

        //DESIGN
        private void btnVideoAulas_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Height = btnVideoAulas.Height;
            SidePanel.Top = btnVideoAulas.Top;
            userControlVideoAulas1.BringToFront();
        }

        //DESIGN
        private void btnCronogramas_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Height = btnCronograma.Height;
            SidePanel.Top = btnCronograma.Top;
            userControlCronograma1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmSair f = new FrmSair();
            f.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //ACESSO AO USUARIO
        private void btnUser_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = false;
            userControlUsuario2.BringToFront();
        }

        //ACESSO AO SITE
        private void pcbLogo_Click(object sender, EventArgs e)
        {
            Process.Start("file:///G:/Site%20-%20Classroom/index.html");
        }

        //DESIGN
        private void btnRedacao_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Height = btnRedacao.Height;
            SidePanel.Top = btnRedacao.Top;
            userControlRedacao1.BringToFront();
        }
    }
}
