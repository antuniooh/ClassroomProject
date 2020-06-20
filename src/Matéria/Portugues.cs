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
    public partial class Portugues : Form
    {
        int idquestao = 0;
        int idmateria = 0;
        int Tipodematerial;

        public Portugues()
        {
            InitializeComponent();
        }
        public Portugues(int tipodematerial)
        {
            Tipodematerial = tipodematerial;

            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            idquestao = 51;
            idmateria = 11;
            string link = "www.youtube.com/watch?v=bb6d54mQkL0&index=1&list=PLiL18SRGu1Cb4MHE8HSRkK843hJFZV7nO";

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

        private void button1_Click(object sender, EventArgs e)
        {
            idquestao = 56;
            idmateria = 12;
            string link = "www.youtube.com/watch?v=9I2wMm6ZFe4";

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
