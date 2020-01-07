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
    public partial class UserControlCronograma : UserControl
    {
        public UserControlCronograma()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Enem n = new Enem();
            n.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Fuvest f = new Fuvest();
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Unicamp u = new Unicamp();
            u.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UNESP p = new UNESP();
            p.Show();
        }
    }
}
