using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_AppEstudos_TCC
{
    public partial class Simulados : Form
    {
        int idquestao = 0;
        string tipo;
        int idmateria;

        public Simulados()
        {
            InitializeComponent();
        }

        // CARREGA INFORMAÇOES
        private void button8_Click(object sender, EventArgs e)
        {
            idquestao = 1;
            tipo = "Geral";
            idmateria = 12;

            if (MessageBox.Show("Os testes serão iniciados. Confirmar?", "Testes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TestesSimulados b = new TestesSimulados(idquestao, tipo, idmateria);
                b.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            idquestao = 1;
            tipo = "Ciências da Natureza";
            idmateria = 13;

            if (MessageBox.Show("Os testes serão iniciados. Confirmar?", "Testes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TestesSimulados b = new TestesSimulados(idquestao, tipo, idmateria);
                b.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idquestao = 31;
            tipo = "Ciências Humanas";
            idmateria = 14;

            if (MessageBox.Show("Os testes serão iniciados. Confirmar?", "Testes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TestesSimulados b = new TestesSimulados(idquestao, tipo, idmateria);
                b.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            idquestao = 81;
            tipo = "Matemática";
            idmateria = 10;

            if (MessageBox.Show("Os testes serão iniciados. Confirmar?", "Testes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TestesSimulados b = new TestesSimulados(idquestao, tipo, 10);
                b.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idquestao = 51;
            tipo = "Línguas";
            idmateria = 15;

            if (MessageBox.Show("Os testes serão iniciados. Confirmar?", "Testes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TestesSimulados b = new TestesSimulados(idquestao, tipo, idmateria);
                b.ShowDialog();
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
