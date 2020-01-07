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
    public partial class Filosofia : Form
    {
        int idquestao = 0;
        int idmateria = 0;
        int Tipodematerial;

        public Filosofia()
        {
            InitializeComponent();
        }
        public Filosofia(int tipodematerial)
        {
            Tipodematerial = tipodematerial;

            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            idquestao = 31;
            idmateria = 7;
            string link = "www.youtube.com/watch?v=T0ZdMP3DVos&t=0s&list=PLiL18SRGu1CaEWRLIB0SpbCJpiyOT9QOD&index=3";

            if (Tipodematerial == 1)
            {
                if (MessageBox.Show("A video aula vai começar. Pronto?", "Testes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Video v = new Video(link);
                    v.ShowDialog();
                }
            }

            if (Tipodematerial == 2)
            {
                if (MessageBox.Show("Os testes serão iniciados. Confirmar?", "Testes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Teste b = new Teste(idquestao, idmateria);
                    b.ShowDialog();
                }
            }

            if (Tipodematerial == 3)
            {
                if (MessageBox.Show("O resumo será exibido. Confirmar?", "Resumos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Resumo b = new Resumo(idmateria);
                    b.ShowDialog();
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            idquestao = 36;
            idmateria = 8;
            string link = "www.youtube.com/watch?v=wJEhiUVMa4M&list=PLiL18SRGu1CaEWRLIB0SpbCJpiyOT9QOD&index=4";

            if (Tipodematerial == 1)
            {
                if (MessageBox.Show("A video aula vai começar. Pronto?", "Testes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Video v = new Video(link);
                    v.ShowDialog();
                }
            }

            if (Tipodematerial == 2)
            {
                if (MessageBox.Show("Os testes serão iniciados. Confirmar?", "Testes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Teste b = new Teste(idquestao, idmateria);
                    b.ShowDialog();
                }
            }

            if (Tipodematerial == 3)
            {
                if (MessageBox.Show("O resumo será exibido. Confirmar?", "Resumos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Resumo b = new Resumo(idmateria);
                    b.ShowDialog();
                }
            }
        }
    }
}
