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
    public partial class Avaliacao : Form
    {
        int vestibular;

        public Avaliacao()
        {
            InitializeComponent();
        }

        //RECEBE UMA VARIAVEL 
        public Avaliacao(int Vestibular)
        {
            InitializeComponent();
            vestibular = Vestibular;
        }

        //CARREGA AS INFORMAÇÕES DO FORM
        private void Avaliacao_Load(object sender, EventArgs e)
        {
            if (vestibular == 1)
            {
                lblTitulo.Text = "Avaliação - ENEM";
                lbl1.Text = "Competência 1 - Demonstrar domínio da modalidade escrita formal da Língua Portuguesa" + "                                                            " + "Competência 2 - Selecionar, relacionar, organizar e interpretar informações, fatos, opiniões e argumentos em defesa de um ponto de vista";
                lbl2.Text = "Competência 3 - Compreender a proposta de redação e aplicar conceitos das várias áreas de conhecimento para desenvolver o tema.";
                lbl3.Text = "Competência 4 - Demonstrar conhecimento dos mecanismos linguísticos necessários para a construção da argumentação" + "                                                                                                  " + "Competência 5 - Elaborar proposta de intervenção para o problema abordado, respeitando os direitos humanos";
            }
            else if (vestibular == 2)
            {
                lblTitulo.Text = "Avaliação - FUVEST";
                lbl1.Text = "Tipo de texto e interlocução: Avalia se o texto corresponde ao gênero pedido, e se os interlocutores (ou seja, a quem você se dirige durante o desenvolvimento do texto) estão sendo considerados.";
                lbl2.Text = "Articulação escrita: Os dois textos devem apresentar uma escrita fluida, coerente, e bem fundamentada. O candidato também deve mostrar que sabe adequar a linguagem a cada um dos gêneros solicitados.";
                lbl3.Text = "Propósito: Verifica se a tarefa solicitada na proposta é cumprida e se o tema e as instruções de elaboração do texto são levados em conta.";
            }
            else if (vestibular == 3)
            {
                lblTitulo.Text = "Avaliação - UNICAMP";
                lbl1.Text = "2017 – Uma carta argumentativa sobre a imigração no Brasil; artigo sobre uma campanha publicitária";
                lbl2.Text = "2016 – Resenha de uma fábula de La Fontaine; artigo de divulgação de um texto científico sobre indução de emoções";
                lbl3.Text = "2015 – Carta para convocar pais de alunos a um debate sobre violência nas escolas; síntese sobre recursos tecnológicos para humanizar atendimento na área da saúde";
            }
            else if (vestibular == 4)
            {
                lblTitulo.Text = "Avaliação - UNESP";
                lbl1.Text = "Abordagem da proposta e do tema: A banca avalia como você leu a proposta e como ela será articulada, no texto, em relação à coletânea de textos. Analisa, também, o seu ponto de vista e a reflexão feita por você ao longo do texto.";
                lbl2.Text = "Desenvolvimento: Avalia como você construiu sua argumentação ao longo da introdução, do desenvolvimento e na conclusão, e se está de acordo com o tipo dissertativo-argumentativo.";
                lbl3.Text = "Domínio da escrita: No último ponto, os corretores analisam se você utilizou a norma culta da língua, além dos elementos de coesão.";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
