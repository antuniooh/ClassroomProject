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
    public partial class FrmExcluir : Form
    {
        private SqlConnection objCnx = new SqlConnection(); // BANCO DE DADOS
        private SqlCommand objCmd = new SqlCommand(); // BANCO DE DADOS
        private SqlDataReader objDados; // BANCO DE DADOS

        public FrmExcluir()
        {
            InitializeComponent();
        }

        // CONEXAO COM O BANCO DE DADOS
        private void Excluir_Load(object sender, EventArgs e)
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

        // DESATIVA O USUARIO
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("O usuário será excluído. Confirmar?", "Exclusão de Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string strSql = "Select * from TB_USUARIO where SENHA_USUARIO='" + txtSenha_Excluir.Text + "' AND STATUS_USUARIO='" + "Online" + "'";
                    objCmd.CommandText = strSql;
                    objCmd.Connection = objCnx;
                    objDados = objCmd.ExecuteReader();

                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Senha Incorreta!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha_Excluir.Clear();
                        txtSenha_Excluir.Focus();
                    }
                    else
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                        strSql = "UPDATE TB_USUARIO SET STATUS_USUARIO='" + "Desativado" + "' where STATUS_USUARIO='" + "Online" + "'";

                        objCmd.CommandText = strSql;
                        objCmd.Connection = objCnx;
                        objCmd.ExecuteNonQuery();

                        MessageBox.Show("Usuário desativado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Application.Restart();
                    }

                    if (!objDados.IsClosed) { objDados.Close(); }
                }
                catch (Exception Erro)
                {
                    MessageBox.Show(Erro.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // DESIGN
        private void txtSenha_Excluir_Enter(object sender, EventArgs e)
        {
            if (txtSenha_Excluir.Text == "Senha")
            {
                txtSenha_Excluir.Text = "";
                txtSenha_Excluir.ForeColor = Color.White;
            }
        }

        //DESIGN
        private void txtSenha_Excluir_Leave(object sender, EventArgs e)
        {
            if (txtSenha_Excluir.Text == "")
            {
                txtSenha_Excluir.Text = "Senha";
                txtSenha_Excluir.ForeColor = Color.DimGray;
            }
        }

        //DESIGN
        private void txtMensagem_Excluir_Enter(object sender, EventArgs e)
        {
            if (txtMensagem_Excluir.Text == "Escreva aqui...")
            {
                txtMensagem_Excluir.Text = "";
                txtMensagem_Excluir.ForeColor = Color.White;
            }
        }

        //DESIGN
        private void txtMensagem_Excluir_Leave(object sender, EventArgs e)
        {
            if (txtMensagem_Excluir.Text == "")
            {
                txtMensagem_Excluir.Text = "Escreva aqui...";
                txtMensagem_Excluir.ForeColor = Color.DimGray;
            }
        }
    }
}
