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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1)
            {
                this.Opacity += 0.1;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                FrmLogin f = new FrmLogin();
                f.ShowDialog();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.Opacity = 2;
        }
    }
}
