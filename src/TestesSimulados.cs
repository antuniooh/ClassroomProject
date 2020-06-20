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
    public partial class TestesSimulados : Form
    {
        private SqlConnection objCnx = new SqlConnection(); // BANCO DE DADOS
        private SqlCommand objCmd = new SqlCommand(); // BANCO DE DADOS
        private SqlDataReader objDados; // BANCO DE DADOS

        DateTime data = DateTime.Now; // RECEBE A DATA ATUAL

        string idUsuario;
        int numQuestao = 1;
        int numAcertos = 0;
        int idQuestao;
        int idMateria;
        string Tipo;

        string resposta;

        public TestesSimulados()
        {
            InitializeComponent();
        }

        // RECEBE VARIAVEIS DE OUTROS FORMS
        public TestesSimulados(int idquestao, string tipo, int idmateria)
        {
            idQuestao = idquestao;
            Tipo = tipo;
            idMateria = idmateria;

            InitializeComponent();
        }

        // CARREGA AS QUESTOES DO BANCO DE DADOS
        private void TestesSimulados_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = Properties.Settings.Default.ConexaoBDDUsuario;
                objCnx.Open();

                string strSql = "Select * from TB_PERGUNTAS where ID_PERGUNTA='" + idQuestao + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (objDados.HasRows)
                {
                    if (objDados.Read())
                    {
                        btnProx.Visible = false;
                        btnTerminar.Visible = false;

                        lblNumero.Text = numQuestao.ToString();
                        lblDisciplina.Text = Tipo;
                        lblPergunta.Text = objDados["DESC_PERGUNTA"].ToString();
                        rbAltA.Text = objDados["ALT_A_PERG"].ToString();
                        rbAltB.Text = objDados["ALT_B_PERG"].ToString();
                        rbAltC.Text = objDados["ALT_C_PERG"].ToString();
                        rbAltD.Text = objDados["ALT_D_PERG"].ToString();
                        rbAltE.Text = objDados["ALT_E_PERG"].ToString();
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
                MessageBox.Show("Erro ==> " + erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CONFIRMA A ALTERNATIVA ESCOLHIDA PELO USUARIO
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Tipo == "Geral")
            {
                if (numQuestao == 90)
                {
                    btnProx.Enabled = false;
                    btnTerminar.Visible = true;
                }
            }
            else if(Tipo == "Ciências da Natureza")
            {
                if (numQuestao == 30)
                {
                    btnProx.Enabled = false;
                    btnTerminar.Visible = true;
                }
            }
            else if (Tipo == "Ciências Humanas")
            {
                if (numQuestao == 20)
                {
                    btnProx.Enabled = false;
                    btnTerminar.Visible = true;
                }
            }
            else if (Tipo == "Matemática")
            {
                if (numQuestao == 10)
                {
                    btnProx.Enabled = false;
                    btnTerminar.Visible = true;
                }
            }
            else if (Tipo == "Línguas")
            {
                if (numQuestao == 30)
                {
                    btnProx.Enabled = false;
                    btnTerminar.Visible = true;
                }
            }
            try
            {
                string strSql = "Select * from TB_PERGUNTAS where ID_PERGUNTA='" + idQuestao + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (objDados.HasRows)
                {
                    if (objDados.Read())
                    {
                        if (resposta == objDados[9].ToString())
                        {
                            lblMensagem.Visible = true;
                            lblMensagem.ForeColor = Color.Green;
                            lblMensagem.Text = "Resposta Correta!";
                            numAcertos = numAcertos + 1;
                            btnProx.Visible = true;
                            btnConfirm.Visible = false;
                            panel1.Enabled = false;
                        }
                        else
                        {
                            lblMensagem.Visible = true;
                            lblMensagem.ForeColor = Color.Red;
                            lblMensagem.Text = "Resposta Incorreta!";
                            btnProx.Visible = true;
                            btnConfirm.Visible = false;
                            panel1.Enabled = false;
                        }
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
                lblDisciplina.Text = "Erro";
            }
        }

        // TERMINA O SIMULADO E SALVA O DESEMPENHO
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "Select * from TB_USUARIO where STATUS_USUARIO='" + "Online" + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Usuario nao encontrado!", "Testes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (objDados.Read())
                    {
                        idUsuario = objDados["ID_USUARIO"].ToString();
                    }
                    if (!objDados.IsClosed) { objDados.Close(); }

                    strSql = "Insert into TB_TESTE(ID_USUARIO, ID_MATERIA, DTA_TESTE, QTD_PERG_TESTE, DESEMPENHO_TESTE) values ('" + idUsuario + "','" + idMateria + "','" + data + "','" + numQuestao + "','" + numAcertos + "')";
                    objCmd.CommandText = strSql;
                    objCmd.Connection = objCnx;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Seu número de acertos foi " + numAcertos + " em " + numQuestao + " questões!", "Teste", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
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

        // PROXIMA QUESTAO
        private void btnProx_Click(object sender, EventArgs e)
        {
            idQuestao = idQuestao + 1;
            numQuestao = numQuestao + 1;
            lblNumero.Text = numQuestao.ToString();
            resposta = "";
            try
            {
                string strSql = "Select * from TB_PERGUNTAS where ID_PERGUNTA='" + idQuestao + "'";
                objCmd.CommandText = strSql;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (objDados.HasRows)
                {
                    if (objDados.Read())
                    {
                        btnConfirm.Visible = true;
                        btnProx.Visible = false;
                        panel1.Enabled = true;
                        lblMensagem.Text = "";
                        lblMensagem.Visible = false;
                        rbAltA.Checked = false;
                        rbAltB.Checked = false;
                        rbAltC.Checked = false;
                        rbAltD.Checked = false;
                        rbAltE.Checked = false;

                        lblDisciplina.Text = Tipo;
                        lblPergunta.Text = objDados["DESC_PERGUNTA"].ToString();
                        rbAltA.Text = objDados["ALT_A_PERG"].ToString();
                        rbAltB.Text = objDados["ALT_B_PERG"].ToString();
                        rbAltC.Text = objDados["ALT_C_PERG"].ToString();
                        rbAltD.Text = objDados["ALT_D_PERG"].ToString();
                        rbAltE.Text = objDados["ALT_E_PERG"].ToString();
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
                MessageBox.Show("Erro ==> " + erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rbAltA_CheckedChanged(object sender, EventArgs e)
        {
            resposta = rbAltA.Text;
        }
        private void rbAltB_CheckedChanged(object sender, EventArgs e)
        {
            resposta = rbAltB.Text;
        }
        private void rbAltC_CheckedChanged(object sender, EventArgs e)
        {
            resposta = rbAltC.Text;
        }
        private void rbAltD_CheckedChanged(object sender, EventArgs e)
        {
            resposta = rbAltD.Text;
        }
        private void rbAltE_CheckedChanged(object sender, EventArgs e)
        {
            resposta = rbAltE.Text;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seu desempenho não será salvo. Confirmar?", "Testes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                numAcertos = 0;
                numQuestao = 1;
                this.Close();
            }          
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
