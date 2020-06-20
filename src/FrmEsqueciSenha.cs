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
using System.Net.Mail;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace Projeto_AppEstudos_TCC
{
    public partial class FrmEsqueciSenha : Form
    {
        private MailMessage Email;
        Stopwatch Stop = new Stopwatch();

        private SqlConnection objCnx = new SqlConnection(); //BANCO DE DADOS
        private SqlCommand objCmd = new SqlCommand(); //BANCO DE DADOS
        private SqlDataReader objDados; //BANCO DE DADOS

        string NovaSenha;

        //GERA UMA SENHA ALEATORIA PARA MANDAR AO USUARIO
        private string GeraSenha()
        {
            string guid = Guid.NewGuid().ToString().Replace("-", "");

            Random clsRan = new Random();
            Int32 tamanhoSenha = clsRan.Next(6, 10);

            string senha = "";
            for (Int32 i = 0; i <= tamanhoSenha; i++)
            {
                senha += guid.Substring(clsRan.Next(1, guid.Length), 1);
            }

            return senha;
        }
        void Limpar()
        {
            txtEmail_EsqueceuSenha.Clear();
            txtUsuario_EsqueceuSenha.Clear();
            txtUsuario_EsqueceuSenha.Focus();
        }
        public FrmEsqueciSenha()
        {
            InitializeComponent();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario_EsqueceuSenha.Text == "")
            {
                txtUsuario_EsqueceuSenha.Text = "Usuário";
                txtUsuario_EsqueceuSenha.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario_EsqueceuSenha.Text == "Usuário")
            {
                txtUsuario_EsqueceuSenha.Text = "";
                txtUsuario_EsqueceuSenha.ForeColor = Color.White;
            }
        }
        private void txtEMail_Leave(object sender, EventArgs e)
        {
            if (txtEmail_EsqueceuSenha.Text == "")
            {
                txtEmail_EsqueceuSenha.Text = "E-Mail";
                txtEmail_EsqueceuSenha.ForeColor = Color.DimGray;
            }
        }

        private void txtEMail_Enter(object sender, EventArgs e)
        {
            if (txtEmail_EsqueceuSenha.Text == "E-Mail")
            {
                txtEmail_EsqueceuSenha.Text = "";
                txtEmail_EsqueceuSenha.ForeColor = Color.White;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FrmSair f = new FrmSair();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ENVIAR EMAIL
        private void btnEnviarSenha_Click_1(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from TB_USUARIO where USER_USUARIO='" + txtUsuario_EsqueceuSenha.Text + "'AND EMAIL_USUARIO='" + txtEmail_EsqueceuSenha.Text + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Usuário e/ou e-mail não encontrados!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpar();
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    strSql = "UPDATE TB_USUARIO SET SENHA_USUARIO='" + NovaSenha + "' where USER_USUARIO='" + txtUsuario_EsqueceuSenha.Text + "'";

                    objCmd.CommandText = strSql;
                    objCmd.Connection = objCnx;
                    objCmd.ExecuteNonQuery();

                    Email = new MailMessage();
                    Email.To.Add(new MailAddress(txtEmail_EsqueceuSenha.Text));
                    Email.From = new MailAddress("laisjulia7@hotmail.com");
                    Email.Subject = "Recuperação de Senha - ClassRoom"; //ASSUNTO
                    Email.IsBodyHtml = true;
                    Email.Body = "Olá, " + txtUsuario_EsqueceuSenha.Text + "!" + "<br></br>" + "Você solicitou a redefinição da senha da sua conta do CLASSROOM." + "<br></br>" + "Sua nova senha é: " + NovaSenha + "<br></br>" + "Para alterar a senha para uma de sua escolha, entre nas configurações da sua conta dentro do aplicativo."; //EMAIL
                    SmtpClient cliente = new SmtpClient("smtp.live.com", 587); // ACESSO AO HOTMAIL
                    using (cliente)
                    {
                        cliente.Credentials = new NetworkCredential("laisjulia7@hotmail.com", "santana"); //CREDENCIAIS DE ACESSO
                        cliente.EnableSsl = true;
                        cliente.Send(Email);
                    }
                        MessageBox.Show("O e-mail de redefinição de senha foi enviado. Confira seu e-mail.", "Recuperação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();             
                }

                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        //CONEXÃO COM O BANCO DE DADOS
        private void FrmEsqueciSenha_Load(object sender, EventArgs e)
        {
            try
            {
                //objCnx.ConnectionString = @"Data Source=LUIZ\SQLEXPRESS;Initial Catalog=Produtos;Integrated Security=true";
                objCnx.ConnectionString = Properties.Settings.Default.ConexaoBDDUsuario;
                objCnx.Open();
                NovaSenha = GeraSenha();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
