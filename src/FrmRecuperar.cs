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
    public partial class FrmRecuperar : Form
    {
        public FrmRecuperar()
        {
            InitializeComponent();
        }

        private void btnEnviarSenha_Click(object sender, EventArgs e)
        {
            FrmEsqueciSenha m = new FrmEsqueciSenha();
            m.ShowDialog();
        }

        private void btnDesativado_Click(object sender, EventArgs e)
        {
            FrmDesativado d = new FrmDesativado();
            d.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
