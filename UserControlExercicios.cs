using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_AppEstudos_TCC
{
    public partial class UserControlExercicios : UserControl
    {
        public UserControlExercicios()
        {
            InitializeComponent();
        }

        private void btnMatematica_Click(object sender, EventArgs e)
        {
            int tipodematerial = 2;
            Matematica m = new Matematica(tipodematerial);
            m.Show();
        }

        private void btnBiologia_Click(object sender, EventArgs e)
        {
            int tipodematerial = 2;
            Biologia b = new Biologia(tipodematerial);
            b.ShowDialog();
        }

        private void btnPortugues_Click(object sender, EventArgs e)
        {
            int tipodematerial = 2;
            Portugues p = new Portugues(tipodematerial);
            p.Show();
        }

        private void btnQuimica_Click(object sender, EventArgs e)
        {
            int tipodematerial = 2;
            Quimica q = new Quimica(tipodematerial);
            q.Show();
        }

        private void btnFisica_Click(object sender, EventArgs e)
        {
            int tipodematerial = 2;
            Fisica f = new Fisica(tipodematerial);
            f.Show();
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            int tipodematerial = 2;
            Historia h = new Historia(tipodematerial);
            h.Show();
        }

        private void btnFilosofia_Click(object sender, EventArgs e)
        {
            int tipodematerial = 2;
            Filosofia s = new Filosofia(tipodematerial);
            s.Show();
        }

        private void btnIdiomas_Click(object sender, EventArgs e)
        {
            int tipodematerial = 2;
            Estrangeira r = new Estrangeira(tipodematerial);
            r.Show();
        }

        private void btnSimulado_Click(object sender, EventArgs e)
        {
            Simulados si = new Simulados();
            si.Show();
        }
    }
}
