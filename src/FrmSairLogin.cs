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
    public partial class FrmSairLogin : Form
    {
        public FrmSairLogin()
        {
            InitializeComponent();
        }

        private void FrmSairLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSairLoginSim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSairLoginNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
