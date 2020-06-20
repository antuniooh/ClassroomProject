using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
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
    public partial class FrmDesativado : Form
    {
        private MailMessage Email;
        Stopwatch Stop = new Stopwatch();

        private SqlConnection objCnx = new SqlConnection(); //BANCO DE DADOS
        private SqlCommand objCmd = new SqlCommand(); //BANCO DE DADOS
        private SqlDataReader objDados; //BANCO DE DADOS

        string NovaSenha;
        public FrmDesativado()
        {
            InitializeComponent();
        }

        //GERA UMA NOVA SENHA PARA O USUARIO
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ENVIA UM NOVO USUARIO E NOVA SENHA PARA O EMAIL DO USUARIO
        private void btnEnviarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from TB_USUARIO where CPF_USUARIO='" + txtCPF.Text + "' AND STATUS_USUARIO='" + "Desativado" + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();  

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Usuário ainda ativo!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF.Clear();
                    txtEmail.Clear();
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    strSql = "UPDATE TB_USUARIO SET SENHA_USUARIO='" + NovaSenha + "', USER_USUARIO='" + "novouser" + "',STATUS_USUARIO='" + "Deslogado" + "'where CPF_USUARIO='" + txtCPF.Text + "'";

                    objCmd.CommandText = strSql;
                    objCmd.Connection = objCnx;
                    objCmd.ExecuteNonQuery();

                    Email = new MailMessage();
                    Email.To.Add(new MailAddress(txtEmail.Text));
                    Email.From = new MailAddress("laisjulia7@hotmail.com"); //ENDEREÇO DE EMAIL
                    Email.Subject = "Recuperação de Usuário Desativado - CLASSROOM"; //ASSUNTO
                    Email.IsBodyHtml = true;
                    Email.Body = "Olá, usuário!" + "<br></br>" + "Você solicitou a reativação da sua conta do CLASSROOM." + "<br></br>" + "Seu usuário é: " + "novouser" + "<br></br>" + "Sua nova senha é: " + NovaSenha + "<br></br>" + "Para alterar a senha para uma de sua escolha, entre nas configurações da sua conta dentro do aplicativo."; //EMAIL
                    SmtpClient cliente = new SmtpClient("smtp.live.com", 587); // ACESSO AO HOTMAIL
                    using (cliente)
                    {
                        cliente.Credentials = new NetworkCredential("laisjulia7@hotmail.com", "santana"); // CREDENCIAIS DE ACESSO AO EMAIL
                        cliente.EnableSsl = true;
                        cliente.Send(Email);
                    }
                    MessageBox.Show("O e-mail de reativação de usuário foi enviado. Confira seu e-mail.", "Recuperação de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        //CONEXAO COM O BANCO DE DADOS
        private void FrmDesativado_Load(object sender, EventArgs e)
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
        //UPDATE NO DESIGN
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Ex: example@live.com";
                txtEmail.ForeColor = Color.DimGray;
            }
        }
        //UPDATE NO DESIGN
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Ex: example@live.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.White;
            }
        }
        //UPDATE NO DESIGN
        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtCPF.ForeColor = Color.DimGray;
            }
        }

        //UPDATE NO DESIGN
        private void txtCPF_Enter(object sender, EventArgs e)
        {
                txtCPF.ForeColor = Color.White;
        }
    }
}
