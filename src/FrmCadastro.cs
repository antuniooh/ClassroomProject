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
using System.Drawing.Imaging;
using System.IO;

namespace Projeto_AppEstudos_TCC
{
    public partial class FrmCadastro : Form
    {
        private SqlConnection objCnx = new SqlConnection(); //Banco de dados
        private SqlCommand objCmd = new SqlCommand(); //Banco de dados
        private SqlDataReader objDados; //Banco de dados
        DateTime data = DateTime.Now;
        String genero = "";

        public FrmCadastro()
        {
            InitializeComponent();
        }
        //UPDATE NO DESIGN
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername_Cadastro.Text == "")
            {
                txtUsername_Cadastro.Text = "Ex: naruto7";
                txtUsername_Cadastro.ForeColor = Color.Silver;
            }
        }
        //UPDATE NO DESIGN
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername_Cadastro.Text == "Ex: naruto7")
            {
                txtUsername_Cadastro.Text = "";
                txtUsername_Cadastro.ForeColor = Color.Black;
            }
        }
        //UPDATE NO DESIGN
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail_Cadastro.Text == "")
            {
                txtEmail_Cadastro.Text = "Ex: example@live.com";
                txtEmail_Cadastro.ForeColor = Color.Silver;
            }
        }
        //UPDATE NO DESIGN
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail_Cadastro.Text == "Ex: example@live.com")
            {
                txtEmail_Cadastro.Text = "";
                txtEmail_Cadastro.ForeColor = Color.Black;
            }
        }
        //UPDATE NO DESIGN
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword_Cadastro.Text == "")
            {
                txtPassword_Cadastro.Text = "Senha";
                txtPassword_Cadastro.ForeColor = Color.Silver;
            }
        }
        //UPDATE NO DESIGN
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword_Cadastro.Text == "Senha")
            {
                txtPassword_Cadastro.Text = "";
                txtPassword_Cadastro.ForeColor = Color.Black;
            }
        }
        //UPDATE NO DESIGN
        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword_Cadastro.Text == "Senha")
            {
                txtConfirmPassword_Cadastro.Text = "";
                txtConfirmPassword_Cadastro.ForeColor = Color.Black;
            }
        }
        //UPDATE NO DESIGN
        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword_Cadastro.Text == "")
            {
                txtConfirmPassword_Cadastro.Text = "Senha";
                txtConfirmPassword_Cadastro.ForeColor = Color.Silver;
            }
        }
        //UPDATE NO DESIGN
        private void txtCPF_Cadastro_Leave(object sender, EventArgs e)
        {
            if (txtCPF_Cadastro.Text == "")
            {
                txtCPF_Cadastro.ForeColor = Color.Silver;
            }
        }
        //UPDATE NO DESIGN
        private void txtCPF_Cadastro_Enter(object sender, EventArgs e)
        {
            txtCPF_Cadastro.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin f = new FrmLogin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
        // Conexão com o banco de dados
        private void FrmCadastro_Load(object sender, EventArgs e)
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FrmSairLogin f = new FrmSairLogin();
            f.ShowDialog();
        }
        //UPDATE NO DESIGN
        private void txtNome_Cadastro_Leave(object sender, EventArgs e)
        {
            if (txtNome_Cadastro.Text == "")
            {
                txtNome_Cadastro.Text = "Ex: Naruto Uzumaki";
                txtNome_Cadastro.ForeColor = Color.Silver;
            }
        }
        //UPDATE NO DESIGN
        private void txtNome_Cadastro_Enter(object sender, EventArgs e)
        {
            if (txtNome_Cadastro.Text == "Ex: Naruto Uzumaki")
            {
                txtNome_Cadastro.Text = "";
                txtNome_Cadastro.ForeColor = Color.Black;
            }
        }
        //UPDATE NO DESIGN
        private void txtData_Nasc_Cadastro_Leave(object sender, EventArgs e)
        {
            if (txtData_Nasc_Cadastro.Text == "  /  /")
            {
                txtData_Nasc_Cadastro.ForeColor = Color.Silver;
            }
        }
        //UPDATE NO DESIGN
        private void txtData_Nasc_Cadastro_Enter(object sender, EventArgs e)
        {
                txtData_Nasc_Cadastro.ForeColor = Color.Black;         
        }
        // Efetua o cadastro do usuário, inserindo dados no banco
        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from TB_USUARIO where CPF_USUARIO='" + txtCPF_Cadastro.Text + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (objDados.HasRows)
                {
                    MessageBox.Show("CPF já cadastrado!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCPF_Cadastro.Clear();
                    txtCPF_Cadastro.Focus();
                }
                else
                {
                    if (txtPassword_Cadastro.Text == txtConfirmPassword_Cadastro.Text)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }

                        strSql = "Insert into TB_USUARIO(CPF_USUARIO, NOME_USUARIO, USER_USUARIO, SENHA_USUARIO, EMAIL_USUARIO, DATA_NASC_USUARIO, DATA_CAD_USUARIO, SEXO_USUARIO, AREA_USUARIO, STATUS_USUARIO) values ('" + txtCPF_Cadastro.Text + "','" + txtNome_Cadastro.Text + "','" + txtUsername_Cadastro.Text + "','" + txtPassword_Cadastro.Text + "','" + txtEmail_Cadastro.Text + "','" + txtData_Nasc_Cadastro.Text + "','" + data + "','" + genero.ToString() + "','" + cbCurso.Text + "','" + "Offline" + "')";
                        objCmd.CommandText = strSql;
                        objCmd.Connection = objCnx;
                        objCmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro Realizado com Sucesso!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmLogin f = new FrmLogin();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Senhas não coincidem", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtConfirmPassword_Cadastro.Clear();
                        txtConfirmPassword_Cadastro.Focus();
                    }
                }
                if (!objDados.IsClosed)
                {
                    objDados.Close();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados" + Erro.Message, "", MessageBoxButtons.OK);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            genero = "M";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            genero = "F";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCPF_Cadastro.Text = "   .   .   -";
            txtCPF_Cadastro.ForeColor = Color.Silver;
            txtUsername_Cadastro.Text = "Ex: naruto7";
            txtUsername_Cadastro.ForeColor = Color.Silver;
            txtEmail_Cadastro.Text = "Ex: example@live.com";
            txtEmail_Cadastro.ForeColor = Color.Silver;
            txtPassword_Cadastro.Text = "Senha";
            txtPassword_Cadastro.ForeColor = Color.Silver;
            txtConfirmPassword_Cadastro.Text = "Senha";
            txtConfirmPassword_Cadastro.ForeColor = Color.Silver;
            txtNome_Cadastro.Text = "Ex: Naruto Uzumaki";
            txtNome_Cadastro.ForeColor = Color.Silver;
            txtData_Nasc_Cadastro.Text = "  /  /";
            txtData_Nasc_Cadastro.ForeColor = Color.Silver;
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
            cbCurso.Text = "Escolha o Curso Desejado";
        }
        private void FrmCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btnCriarConta.PerformClick();
            }
        }
    }
}
