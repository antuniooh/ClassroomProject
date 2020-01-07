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
    public partial class Redacao : Form
    {
        int Vestibular;
        public Redacao()
        {
            InitializeComponent();
        }

        // RECEBE VARIAVEL DE OUTRO FORM
        public Redacao(int vestibular)
        {
            InitializeComponent();
            Vestibular = vestibular;
        }

        // CARREGA AS INFORMAÇOES
        private void Redacao_Load(object sender, EventArgs e)
        {
            if (Vestibular == 1)
            {
                pbLogo.Image = Properties.Resources.enem;
                lblTitulo.Text = "Redação ENEM";
                lblTexto.Text = "A correção das redações do Enem é feita com um modelo padronizado de critérios. Cada um desses critérios é avaliado de 0 a 200 pontos, em 6 níveis diferentes de adequação. Ou seja, o aluno pode tirar 200, 160, 120, 80, 40 ou 0 pontos.Cada um desses níveis tem características pré - definidas para evitar que as opiniões pessoais do examinador interfiram na nota do estudante.";
            }
            else if (Vestibular == 2)
            {
                pbLogo.Image = Properties.Resources.fuvest;
                lblTitulo.Text = "Redação FUVEST";
                lblTexto.Text = "O candidato deve mostrar que sabefundamentar sua tese com seu repertório pessoal de informações, ou seja, que consegue sair do senso comum e do que é apresentado nos textos da coletânea, apresentando um conhecimento construído ao longo da vida e em tudo o que absorveu de seus estudos.";
            }
            else if (Vestibular == 3)
            {
                pbLogo.Image = Properties.Resources.unicamp;
                lblTitulo.Text = "Redação UNICAMP";
                lblTexto.Text = "Para a Unicamp, deve-se desconsiderar quase tudo em relação às provas dos vestibulares que exigem tipo dissertativo, porque a correção passa a levar em conta elementos específicos que compõem cada gênero pedido.Por causa dessa grande variedade de gêneros textuais possíveis, é comum que o estudante fique com medo de não saber desenvolver o texto que for pedido. A prova de redação consiste emdois textos de gêneros completamente distintos.";
            }
            else if (Vestibular == 4)
            {
                pbLogo.Image = Properties.Resources.unesp;
                lblTitulo.Text = "Redação UNESP";
                lblTexto.Text = "A instituição exige o tipodissertativo de texto, mais comum nos vestibulares. Isso significa que se trata de um texto argumentativo, que pede que o autor desenvolva uma ideia, um problema ou um questionamento com uma consideração final que deve estar de acordo com os argumentos expostos.É importante, também, que o estudante saiba colocar ideias favoráveis e contrárias à sua própria opinião.";                
            }
        }

        private void btnPossiveis_Click(object sender, EventArgs e)
        {
            PossTemas f = new PossTemas(Vestibular);
            f.Show();
        }

        private void btnUltimos_Click(object sender, EventArgs e)
        {
            UltTemas u = new UltTemas(Vestibular);
            u.Show();
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            Avaliacao a = new Avaliacao(Vestibular);
            a.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
