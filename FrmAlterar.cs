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

namespace Projeto_AppEstudos_TCC
{
    public partial class FrmAlterar : Form
    {
        private SqlConnection objCnx = new SqlConnection(); // BANCO DE DADOS
        private SqlCommand objCmd = new SqlCommand(); // BANCO DE DADOS
        private SqlDataReader objDados; // BANCO DE DADOS

        public FrmAlterar()
        {
            InitializeComponent();
        }

        // ALTERA OS DADOS DOS CAMPOS MUDADOS
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os dados serão alterados. Confirmar?", "Alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string strSql = "Select * from TB_USUARIO where SENHA_USUARIO='" + txtSenhaAtual_Alterar.Text + "' AND STATUS_USUARIO='" + "Online" + "'";
                    objCmd.CommandText = strSql;
                    objCmd.Connection = objCnx;
                    objDados = objCmd.ExecuteReader();

                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Senha atual incorreta", "Alteração de Dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSenhaAtual_Alterar.Focus();
                        objDados.Close();
                    }
                    else
                    {
                        if (txtSenha_Alterar.Text == txtConfSenha_Alterar.Text)
                        {
                            if (!objDados.IsClosed) { objDados.Close(); }
                            strSql = "UPDATE TB_USUARIO SET NOME_USUARIO ='" + txtNome_Alterar.Text + "',USER_USUARIO='" + txtUsuario_Alterar.Text + "',SENHA_USUARIO='" + txtSenha_Alterar.Text + "',AREA_USUARIO='" + cbCurso_Alterar.Text + "',STATUS_USUARIO='" + "Deslogado" + "' where STATUS_USUARIO='" + "Online" + "'";

                            objCmd.CommandText = strSql;
                            objCmd.Connection = objCnx;
                            objCmd.ExecuteNonQuery();

                            MessageBox.Show("Dados alterados com sucesso! Para realizar as alterações, você sera direcionado ao login.", "Alteração de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Application.Restart();

                        }
                        else
                        {
                            MessageBox.Show("Senhas não coincidem", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtConfSenha_Alterar.Clear();
                            txtConfSenha_Alterar.Focus();
                            if (!objDados.IsClosed) { objDados.Close(); }
                        }                     
                    }
                    if (!objDados.IsClosed)
                    {
                        objDados.Close();
                    }
                }
                catch (SqlException Erro)
                {
                    MessageBox.Show("Erro ao alterar os dados" + Erro.Message, "Alteração de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // CARREGA OS DADOS DO USUARIO NA TXTS
        private void FrmAlterar_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = Properties.Settings.Default.ConexaoBDDUsuario;
                objCnx.Open();

                string strSql = "Select * from TB_USUARIO where STATUS_USUARIO='" + "Online" + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (objDados.HasRows)
                {
                    while (objDados.Read())
                    {
                        txtNome_Alterar.Text = objDados["NOME_USUARIO"].ToString();
                        txtUsuario_Alterar.Text = objDados["USER_USUARIO"].ToString();
                        txtEmail_Alterar.Text = objDados["EMAIL_USUARIO"].ToString();
                        cbCurso_Alterar.Text = objDados["AREA_USUARIO"].ToString();                       
                    }    
                }
                else
                {
                    MessageBox.Show("Vai tomar no cu", "Load de Formulário", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnNome_Click(object sender, EventArgs e)
        {
            txtNome_Alterar.Focus();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            txtSenhaAtual_Alterar.Focus();
        }

        private void btnNovaSenha_Click(object sender, EventArgs e)
        {
            txtSenha_Alterar.Focus();
        }

        private void btnConfSenha_Click(object sender, EventArgs e)
        {
            txtConfSenha_Alterar.Focus();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario_Alterar.Focus();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            txtEmail_Alterar.Focus();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            cbCurso_Alterar.Focus();
        }
    }
}
