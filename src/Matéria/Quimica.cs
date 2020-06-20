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
    public partial class Quimica : Form
    {
        int idquestao = 0;
        int idmateria = 0;
        int Tipodematerial;

        public Quimica()
        {
            InitializeComponent();
        }
        public Quimica(int tipodematerial)
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
            idquestao = 11;
            idmateria = 3;
            string link = "www.youtube.com/watch?v=_-B9a30j-oU&list=PLiL18SRGu1CahSLe2lC1YbbAAc8Mb9YBT&index=3&t=1s";

            if (Tipodematerial == 1)
            {
                if (MessageBox.Show("A video aula vai começar. Pronto?", "Video Aula", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            idquestao = 16;
            idmateria = 4;
            string link = "www.youtube.com/watch?v=gcF4VhSgElg&list=PLiL18SRGu1CahSLe2lC1YbbAAc8Mb9YBT&index=4";

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
