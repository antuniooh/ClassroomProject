using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace Projeto_AppEstudos_TCC
{
    public partial class UserControlUsuario : UserControl
    {
        private SqlConnection objCnx = new SqlConnection(); // BANCO DE DADOS
        private SqlCommand objCmd = new SqlCommand(); // BANCO DE DADOS
        private SqlDataReader objDados; // BANCO DE DADOS
        string idusuario;
        Bitmap bmp;

        public UserControlUsuario()
        {
            InitializeComponent();
        }

        // CARREGA AS INFORMAÇOES NO FORM
        private void UserControlUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                //objCnx.ConnectionString = @"Data Source=LAB2653-11\SQLEXPRESS;Initial Catalog=Produtos;Integrated Security=true";
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
                        idusuario = objDados["ID_USUARIO"].ToString();
                        lblNome.Text = objDados["NOME_USUARIO"].ToString();
                        lblUsuario.Text = objDados["USER_USUARIO"].ToString();
                        lblEmail.Text = objDados["EMAIL_USUARIO"].ToString();
                        lblCurso.Text = objDados["AREA_USUARIO"].ToString();

                        Image imagem = null;

                        byte[] foto = (byte[])objDados["FOTO_USUARIO"];

                        MemoryStream ms = new MemoryStream(foto);
                        imagem = Image.FromStream(ms);

                        pcbFoto.Image = imagem;            
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

        // INSERE A IMAGEM NO BANCO DE DADOS
        private void btnEnviarFoto_Click(object sender, EventArgs e)
        {
           if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName;
                
                bmp = new Bitmap(nome);

                pcbFoto.Image = bmp;

                MemoryStream memory = new MemoryStream();

                bmp.Save(memory,ImageFormat.Bmp);

                byte[] foto = memory.ToArray();

                const string string_conexao = @"Data Source=LAB2656-07\SQLEXPRESS;Initial Catalog=db_classroom;Integrated Security=True";

                objCnx = new SqlConnection(string_conexao);
            
                objCmd = new SqlCommand("UPDATE TB_USUARIO SET FOTO_USUARIO= @imagem WHERE STATUS_USUARIO='" + "Online" + "'", objCnx);

                SqlParameter imagem = new SqlParameter("@imagem", SqlDbType.Binary);

                imagem.Value = foto;

                objCmd.Parameters.Add(imagem);

                try
                {
                    objCnx.Open();
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Foto de perfil alterada!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    objCnx.Close();
                }
            }
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            FrmDeslogar d = new FrmDeslogar();
            d.ShowDialog();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            FrmExcluir a = new FrmExcluir();
            a.ShowDialog();
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            FrmAlterar a = new FrmAlterar();
            a.ShowDialog();
        }

        private void btnDesempenho_Click(object sender, EventArgs e)
        {
            Desempenho d = new Desempenho(idusuario);
            d.ShowDialog();
        }
    }
}
