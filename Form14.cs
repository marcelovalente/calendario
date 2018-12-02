using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PIB_EG
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            string linha;
            InitializeComponent();
            if (!File.Exists(Parameters.path.produtos))
            {
                //checando se tem arquivo usuario
                noContain("produto");
            }
            else
            {
                //verificar se tem produto, se tiver inclue no combobox
                System.IO.StreamReader read = new System.IO.StreamReader(Parameters.path.produtos);
                String[] bancoDados = new String[] { };
                int i = 0;
                while ((linha = read.ReadLine()) != null)
                {
                    bancoDados = linha.Split(';');
                    comboProduto.Items.Add(bancoDados[1]);
                    i++;
                }
                read.Close();
                if (i == 0)
                {
                    noContain("produto");
                }
                else
                {
                    if (!File.Exists(Parameters.path.usuarios))
                    {
                        //checando se tem arquivo usuario
                        noContain("usuário");
                    }
                    System.IO.StreamReader read2 = new System.IO.StreamReader(Parameters.path.usuarios);
                    String[] bancoDados2 = new String[] { };
                    int j = 0;
                    while ((linha = read2.ReadLine()) != null)
                    {
                        bancoDados2 = linha.Split(';');
                        if (bancoDados2[3] != "admin")
                        {
                            comboFuncionario.Items.Add(bancoDados2[3]);
                            j++;
                        }
                    }
                    read2.Close();
                    if (j == 0)
                    {
                        noContain("usuário");
                    }
                }
            }
        }
        private void noContain(string item)
        {
            //este metodo serve para indicar que não tem produto cadastrado
            comboProduto.Items.Clear();
            comboProduto.Items.Add("Não existe " + item + " cadastrado");
            comboProduto.SelectedIndex = 0;
            //este metodo serve para indicar que não tem funcionario cadastrado
            comboFuncionario.Items.Clear();
            comboFuncionario.Items.Add("Não existe " + item + " cadastrado");
            comboFuncionario.SelectedIndex = 0;
            //bloquear itens
            comboFuncionario.Enabled = false;
            comboProduto.Enabled = false;
            buttonSave.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string linha, codUser="", codProduto="";
            report.Text = String.Empty;
            //pesquisar o codigo do usuario
            System.IO.StreamReader codFunc = new System.IO.StreamReader(Parameters.path.usuarios);
            String[] numCodUsuario = new String[] { };
            while ((linha = codFunc.ReadLine()) != null)
            {
                numCodUsuario = linha.Split(';');
                if (numCodUsuario[3] == comboFuncionario.Text)
                {
                    codUser = numCodUsuario[0];
                }
            }
            codFunc.Close();
            //pesquisar o codigo do produto
            System.IO.StreamReader codProd = new System.IO.StreamReader(Parameters.path.produtos);
            String[] numCodProd = new String[] { };
            while ((linha = codProd.ReadLine()) != null)
            {
                numCodProd = linha.Split(';');
                if (numCodProd[1] == comboProduto.Text)
                {
                    codProduto = numCodProd[0];
                }
            }
            codProd.Close();
            //fazendo consulta
            System.IO.StreamReader consult = new System.IO.StreamReader(Parameters.path.entrega);
            String[] listaConsult = new String[] { };
            string linhaConsult;
            int countRep = 0;
            report.Text = "      Data         -    Qtde\n";
            while ((linhaConsult = consult.ReadLine()) != null)
            {
                listaConsult = linhaConsult.Split(';');
                if (listaConsult[1] == codUser)
                {
                    if (listaConsult[2] == codProduto)
                    {
                        report.Text = report.Text + listaConsult[4] + "     -     " + listaConsult[3] + "\n";
                        countRep++;
                    }
                }
            }
            if (countRep == 0)
            {
                report.Text = "Não foi localizado nenhuma informação";
            }
            consult.Close();
        }
    }
}
