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
    public partial class PossTemas : Form
    {
        int vestibular;

        public PossTemas()
        {
            InitializeComponent();
        }

        // VARIAVEL RECEBIDA DE OUTRO FORM
        public PossTemas(int Vestibular)
        {
            InitializeComponent();
            vestibular = Vestibular;
        }

        // CARREGA AS INFORMAÇOES NAS LBLS
        private void PossTemas_Load(object sender, EventArgs e)
        {
            if (vestibular == 1)
            {
                lblTitulo.Text = "Possíveis Temas - ENEM";
                lbl1.Text = "Os Perigos das Fake News na Era da Informação";
                lbl2.Text = "Conceito de Família no Século XXI";
                lbl3.Text = "O Aumento da Depressão nos Jovens Brasileiros";
                lbl4.Text = "Sistema Carcerário Brasileiro";
                lbl5.Text = "Doenças Epidêmicas";
                lbl6.Text = "Mobilidade Urbana";
            }
            else if (vestibular == 2)
            {
                lblTitulo.Text = "Possíveis Temas - FUVEST";
                lbl1.Text = "As reformas políticas e o impacto na população brasileira";
                lbl2.Text = "O Aumento da Depressão nos Jovens Brasileiros";
                lbl3.Text = "Luta por igualdade de direitos";
                lbl4.Text = "O problema dos refugiados no Brasil";
                lbl5.Text = "O pensamento conservador no Brasil e no mundo";
                lbl6.Text = "O retorno das doenças erradicadas";
            }
            else if (vestibular == 3)
            {
                lblTitulo.Text = "Possíveis Temas - UNICAMP";
                lbl1.Text = "Luta por igualdade de direitos";
                lbl2.Text = "O retorno das doenças erradicadas";
                lbl3.Text = "O Aumento da Depressão nos Jovens Brasileiros";
                lbl4.Text = "Conceito de Família no Século XXI";
                lbl5.Text = "Sistema Carcerário Brasileiro";
                lbl6.Text = "As reformas políticas e o impacto na população brasileira";
            }
            else if (vestibular == 4)
            {
                lblTitulo.Text = "Possíveis Temas - UNESP";
                lbl1.Text = "Os Perigos das Fake News na Era da Informação";
                lbl2.Text = "Sistema Carcerário Brasileiro";
                lbl3.Text = "O problema dos refugiados no Brasil";
                lbl4.Text = "As reformas políticas e o impacto na população brasileira";
                lbl5.Text = "Luta por igualdade de direitos";
                lbl6.Text = "O retorno das doenças erradicadas";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
