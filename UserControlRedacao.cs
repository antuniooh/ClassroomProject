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
    public partial class UserControlRedacao : UserControl
    {
        int vestibular;
        public UserControlRedacao()
        {
            InitializeComponent();
        }

        private void btnEnem_Click(object sender, EventArgs e)
        {
            vestibular = 1;
            Redacao r = new Redacao(vestibular);
            r.Show();
        }

        private void btnFuvest_Click(object sender, EventArgs e)
        {
            vestibular = 2;
            Redacao r = new Redacao(vestibular);
            r.Show();
        }

        private void btnUnicamp_Click(object sender, EventArgs e)
        {
            vestibular = 3;
            Redacao r = new Redacao(vestibular);
            r.Show();
        }

        private void btnUnesp_Click(object sender, EventArgs e)
        {
            vestibular = 4;
            Redacao r = new Redacao(vestibular);
            r.Show();
        }

        private void UserControlRedacao_Load(object sender, EventArgs e)
        {

        }
    }
}
