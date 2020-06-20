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
    public partial class UltTemas : Form
    {
        int vestibular;

        public UltTemas()
        {
            InitializeComponent();
        }

        // RECEBE VARIAVEL DE OUTRO FORM
        public UltTemas(int Vestibular)
        {
            InitializeComponent();
            vestibular = Vestibular;
        }

        // CARREGA AS INFORMAÇÕES 
        private void UltTemas_Load(object sender, EventArgs e)
        {
            if(vestibular == 1)
            {
                lblTitulo.Text = "Últimos Temas - ENEM";
                lbl1.Text = "2017 - Desafios para a formação educacional de surdos no Brasil";
                lbl2.Text = "2016 - Caminhos para combater a intolerância religiosa no Brasil";
                lbl3.Text = "2015 - A persistência da violência contra a mulher na sociedade brasileira";
                lbl4.Text = "2014 - Publicidade infantil em questão no Brasil";
                lbl5.Text = "2013 - Efeitos da implantação da Lei Seca no Brasil";
                lbl6.Text = "2012 - Movimento imigratório para o Brasil no século 21";
            }
            else if(vestibular == 2)
            {
                lblTitulo.Text = "Últimos Temas - FUVEST";
                lbl1.Text = "2017 – O homem saiu de sua menoridade?";
                lbl2.Text = "2016 – As utopias: indispensáveis, inúteis ou nocivas?";
                lbl3.Text = "2015 – “Camarotização” da sociedade brasileira: a segregação das classes sociais e a democracia";
                lbl4.Text = "2014 – Envelhecimento da população";
                lbl5.Text = "2013 – Consumismo";
                lbl6.Text = "2012 – Participação política: indispensável ou superada?";
            }
            else if(vestibular == 3)
            {
                lblTitulo.Text = "Últimos Temas - UNICAMP";
                lbl1.Text = "2017 – Uma carta argumentativa sobre a imigração no Brasil; artigo sobre uma campanha publicitária";
                lbl2.Text = "2016 – Resenha de uma fábula de La Fontaine; artigo de divulgação de um texto científico sobre indução de emoções";
                lbl3.Text = "2015 – Carta para convocar pais de alunos a um debate sobre violência nas escolas; síntese sobre recursos tecnológicos para humanizar atendimento na área da saúde";
                lbl4.Text = "2014 – Relatório sobre oficina cultural em uma escola; Carta aberta de uma associação, dirigida a autoridades, sobre problemas no trânsito";
                lbl5.Text = "2013 – Resumo de um texto sobre pessimismo; carta a redatores de um jornal sobre alcoolismo";
                lbl6.Text = "2012 – Comentário de internet sobre a profissão de cientista; manifesto de estudantes de uma escola sobre monitoramento online; verbete explicando o conceito de computação em nuvem";
            }
            else if (vestibular == 4)
            {
                lblTitulo.Text = "Últimos Temas - UNESP";
                lbl1.Text = "2017 – A riqueza de poucos beneficia a sociedade inteira?";
                lbl2.Text = "2016 – Publicação de imagens trágicas: banalização do sofrimento ou forma de sensibilização?";
                lbl3.Text = "2015 – O legado da escravidão e o preconceito contra negros no Brasil";
                lbl4.Text = "2014 – Corrupção no Congresso Nacional: reflexo da sociedade brasileira?";
                lbl5.Text = "2013 – Escrever: o trabalho e a inspiração";
                lbl6.Text = "2012 – A bajulação: virtude ou defeito?";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
