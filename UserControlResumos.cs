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
    public partial class UserControlResumos : UserControl
    {
        int tipodematerial;

        public UserControlResumos()
        {
            InitializeComponent();
        }

        private void btnMatematica_Click(object sender, EventArgs e)
        {
            tipodematerial = 3;
            Matematica m = new Matematica(tipodematerial);
            m.Show();
        }

        private void btnPortugues_Click(object sender, EventArgs e)
        {
            tipodematerial = 3;
            Portugues p = new Portugues(tipodematerial);
            p.Show();
        }

        private void btnQuimica_Click(object sender, EventArgs e)
        {
            tipodematerial = 3;
            Quimica q = new Quimica(tipodematerial);
            q.Show();
        }

        private void btnFisica_Click(object sender, EventArgs e)
        {
            tipodematerial = 3;
            Fisica f = new Fisica(tipodematerial);
            f.Show();
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            tipodematerial = 3;
            Historia h = new Historia(tipodematerial);
            h.Show();
        }

        private void btnBiologia_Click(object sender, EventArgs e)
        {
            tipodematerial = 3;
            Biologia b = new Biologia(tipodematerial);
            b.Show();
        }

        private void btnFilosofia_Click(object sender, EventArgs e)
        {
            tipodematerial = 3;
            Filosofia s = new Filosofia(tipodematerial);
            s.Show();
        }

        private void btnIdiomas_Click(object sender, EventArgs e)
        {
            tipodematerial = 3;
            Estrangeira t = new Estrangeira(tipodematerial);
            t.Show();
        }
    }
}
