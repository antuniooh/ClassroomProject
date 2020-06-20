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
using System.Diagnostics;

namespace Projeto_AppEstudos_TCC
{
    public partial class FrmLogin : Form
    {
        private SqlConnection objCnx = new SqlConnection(); //Banco de dados
        private SqlCommand objCmd = new SqlCommand(); //Banco de dados
        private SqlDataReader objDados; //Banco de dados
        bool mouseClicked;
        Point clickedAt;

        public FrmLogin()
        {
            InitializeComponent();
        }


        // Update no design do formulário
        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        // Update no design do formulário
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        // Update no design do formulário
        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        // Update no design do formulário
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        // Update no design do formulário
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }   
        }

        // Update no design do formulário
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
            } 
        }

        // Update no design do formulário
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Silver;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FrmSairLogin f = new FrmSairLogin();
            f.ShowDialog();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblCriarConta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastro f = new FrmCadastro();
            f.Closed += (s, args) => this.Close();
            f.Show();           
        }

        //Conexão com o Banco de Dados
        private void FrmLogin_Load(object sender, EventArgs e)
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

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {  
            FrmRecuperar f = new FrmRecuperar();
            f.ShowDialog();       
        }

        //Logar na aplicação
        private void btnEntrar_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from TB_USUARIO where USER_USUARIO='" + txtUsername.Text + "'AND SENHA_USUARIO='" + txtSenha.Text + "'AND STATUS_USUARIO !='" + "Desativado" + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Usuário e/ou Senha incorretos!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Clear();
                    txtSenha.Focus();

                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    strSql = "UPDATE TB_USUARIO SET STATUS_USUARIO='" + "Online" + "' where USER_USUARIO='" + txtUsername.Text + "'";

                    objCmd.CommandText = strSql;
                    objCmd.Connection = objCnx;
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Login realizado com sucesso. Seja vem vindo, " + txtUsername.Text + "!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmMain m = new FrmMain();
                    m.Show();

                    this.Hide();
                }

                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        // Tecla ENTER para efetuar o click do botao Entrar
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                this.btnEntrar_Login.PerformClick();
            }
        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {
            Process.Start("file:///G:/Site%20-%20Classroom/index.html");
        }
    }
}