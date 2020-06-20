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
    public partial class UserControlVideoAulas : UserControl
    {
        public UserControlVideoAulas()
        {
            InitializeComponent();
        }

        private void btnMatematica_Click(object sender, EventArgs e)
        {
            int tipodematerial = 1;
            Matematica m = new Matematica(tipodematerial);
            m.ShowDialog();
        }

        private void btnPortugues_Click(object sender, EventArgs e)
        {
            int tipodematerial = 1;
            Portugues p = new Portugues(tipodematerial);
            p.ShowDialog();
        }

        private void btnQuimica_Click(object sender, EventArgs e)
        {
            int tipodematerial = 1;
            Quimica q = new Quimica(tipodematerial);
            q.ShowDialog();
        }

        private void btnFisica_Click(object sender, EventArgs e)
        {
            int tipodematerial = 1;
            Fisica f = new Fisica(tipodematerial);
            f.ShowDialog();
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            int tipodematerial = 1;
            Historia h = new Historia(tipodematerial);
            h.ShowDialog();
        }

        private void btnBiologia_Click(object sender, EventArgs e)
        {
            int tipodematerial = 1;
            Biologia b = new Biologia(tipodematerial);
            b.ShowDialog();
        }

        private void btnFilosofia_Click(object sender, EventArgs e)
        {
            int tipodematerial = 1;
            Filosofia s = new Filosofia(tipodematerial);
            s.ShowDialog();
        }

        private void btnIdiomas_Click(object sender, EventArgs e)
        {
            int tipodematerial = 1;
            Estrangeira t = new Estrangeira(tipodematerial);
            t.ShowDialog();
        }
    }
}
