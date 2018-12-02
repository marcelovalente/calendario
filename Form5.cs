using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIB_EG
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            acessoPerfil();
        }

        public void prepareNivel(bool[] nivel){
            //tornando todos os menus ativos
            //menu controle
            alterarSenhaToolStripMenuItem1.Enabled = nivel[0];
            consultaAlteraçãoToolStripMenuItem.Enabled = nivel[1];
            incluirNovoUsuárioToolStripMenuItem.Enabled = nivel[2];
            bloqueioDeUsuárioToolStripMenuItem.Enabled = nivel[3];
            excluirUsuárioToolStripMenuItem.Enabled = nivel[4];
            alterarPerfilDoUsuárioToolStripMenuItem.Enabled = nivel[5];
            materiaisToolStripMenuItem.Enabled = nivel[10];
            //menu calculadora de datas
            abaCalcForm5.Enabled = nivel[6];
            //menu processamentos
            ativosToolStripMenuItem.Enabled = nivel[7];
            arquivoMortoToolStripMenuItem.Enabled = nivel[8];
            //extra
            //extraToolStripMenuItem.Enabled = nivel[9];
        }

        public int valueNivel = Cookie.nivel;

        private void abaCalcForm5_Click(object sender, EventArgs e)
        {
            Form Form6 = new PIB_EG.Form6();
            Form6.ShowDialog();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form7 = new PIB_EG.Form7();
            Form7.ShowDialog();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form8 = new PIB_EG.Form8();
            Form8.ShowDialog();
        }

        public void acessoPerfil()
        {
            bool[] nivel = new bool[11];
            if (valueNivel == 1)
            {
                nivel[0] = true;
                nivel[1] = true;
                nivel[2] = true;
                nivel[3] = true;
                nivel[4] = true;
                nivel[5] = true;
                nivel[6] = true;
                nivel[7] = true;
                nivel[8] = true;
                nivel[9] = true;
                nivel[10] = true;
            }
            else if (valueNivel == 2)
            {
                nivel[0] = true;
                nivel[1] = true;
                nivel[2] = false;
                nivel[3] = false;
                nivel[4] = false;
                nivel[5] = false;
                nivel[6] = true;
                nivel[7] = true;
                nivel[8] = true;
                nivel[9] = true;
                nivel[10] = false;
            }
            else if (valueNivel == 3)
            {
                nivel[0] = true;
                nivel[1] = true;
                nivel[2] = false;
                nivel[3] = false;
                nivel[4] = false;
                nivel[5] = false;
                nivel[6] = true;
                nivel[7] = true;
                nivel[8] = false;
                nivel[9] = false;
                nivel[10] = false;
            }
            prepareNivel(nivel);
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form9 = new PIB_EG.Form9();
            Form9.ShowDialog();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form10 = new PIB_EG.Form10();
            Form10.ShowDialog();
        }

        private void entregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form11 = new PIB_EG.Form11();
            Form11.ShowDialog();
        }

        private void consultaAlteraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form3 = new PIB_EG.Form3();
            Form3.ShowDialog();
        }

        private void bloqueioDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form4 = new PIB_EG.Form4();
            Form4.ShowDialog();
        }

        private void alterarPerfilDoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form12 = new PIB_EG.Form12();
            Form12.ShowDialog();
        }

        private void geraçãoDeSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form14 = new PIB_EG.Form14();
            Form14.ShowDialog();
        }

        private void excluirUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form15 = new PIB_EG.Form15();
            Form15.ShowDialog();
        }
    }
}
