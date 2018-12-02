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
    public partial class Form11 : Form
    {
        public Form11()
        {
            string linha;
            InitializeComponent();
            date.Text = DateTime.Today.ToString("dd/MM/yyyy");
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
                    System.IO.StreamReader read2= new System.IO.StreamReader(Parameters.path.usuarios);
                    String[] bancoDados2 = new String[] { };
                    int j = 0;
                    while ((linha = read2.ReadLine()) != null)
                    {
                        bancoDados2 = linha.Split(';');
                        if (bancoDados2[3] != "admin")
                        {
                            comboFuncionario.Items.Add(Convert.ToString(bancoDados2[3]));
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
            comboFuncionario.Items.Add("Não existe "+item+" cadastrado");
            comboFuncionario.SelectedIndex = 0;
            //bloquear itens
            comboFuncionario.Enabled = false;
            comboProduto.Enabled = false;
            date.Enabled = false;
            qtde.Enabled = false;
            buttonSave.Enabled = false;
        }
        public void buttonSave_Click(object sender, EventArgs e)
        {
            string linha;
            String[] bancoDados = new String[] { };
            //checando se tem arquivo entrega, caso contrario cria
            if (!File.Exists(Parameters.path.entrega))
            {
                using (StreamWriter sw = File.CreateText(Parameters.path.entrega));
            }
            //checa se esta tudo preenchido
            if (comboFuncionario.Text == "" || comboProduto.Text == "" || date.Text == "" || qtde.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //consulta se a quantidade está disponível
                System.IO.StreamReader readProd = new System.IO.StreamReader(Parameters.path.produtos);
                String[] read1 = new String[] { };
                while ((linha = readProd.ReadLine()) != null)
                {
                    bancoDados = linha.Split(';');
                    if (bancoDados[1] == comboProduto.Text)
                    {
                        if (Int32.Parse(bancoDados[3]) < Int32.Parse(qtde.Text))
                        {
                            MessageBox.Show("Não é possível entregar esta quantidade, existe(m) somente " + bancoDados[3] + " unidade(s)");
                        }
                        else
                        {
                            //verifica se existe lançamento, se nao existir cria codigo 1, caso contrario aumento 1 no codigo existente

                            System.IO.StreamReader countEntrega = new System.IO.StreamReader(Parameters.path.entrega);
                            int k = 0, codEntrega=0;
                            while ((linha = countEntrega.ReadLine()) != null)
                            {
                                k++;
                                break;
                            }
                            if (k == 0)
                            {
                                codEntrega=1;
                            }
                            else
                            {
                                String[] splitCodEntrega = new String[] { };
                                string lastLine = File.ReadLines(Parameters.path.entrega).Last();
                                splitCodEntrega = lastLine.Split(';');
                                codEntrega = Int32.Parse(splitCodEntrega[0]) + 1;
                            }
                            countEntrega.Close();
                            //pesquisar o codigo do usuario
                            string codUser="";
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
                            string codProduto="";
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
                            //insere no arquivo de entrega
                            string appendText = codEntrega.ToString() + ";" + codUser + ";" + codProduto + ";" + qtde.Text + ";" + date.Text + "\r\n";
                            File.AppendAllText(Parameters.path.entrega, appendText);
                            //desconto do estoque

                            System.IO.StreamReader read = new System.IO.StreamReader(Parameters.path.produtos);
                            String[] descontaEstoque = new String[] { };
                            int countLine = 0;
                            string newLine = "", linhaDesconta;
                            while ((linhaDesconta = read.ReadLine()) != null)
                            {
                                descontaEstoque = linhaDesconta.Split(';');
                                String[] splitLine = new String[] { };
                                string line = File.ReadLines(Parameters.path.produtos).Skip(countLine).Take(1).First();
                                if (descontaEstoque[1] == comboProduto.Text)
                                {
                                    splitLine = line.Split(';');
                                    splitLine[3] = (Int32.Parse(splitLine[3]) - Int32.Parse(qtde.Text)).ToString();
                                    line = "";
                                    for (int i = 0; i < (splitLine.Length); i++)
                                    {
                                        line = line + splitLine[i] + ";";
                                    }
                                    line = line.Remove(line.Length - 1);
                                }
                                newLine = newLine + line + "\r\n";
                                countLine++;
                            }
                            readProd.Close();
                            read.Close();
                            File.WriteAllText(Parameters.path.produtos, newLine);
                            //verifica se entrou no limite do estoque
                            if ((Int32.Parse(bancoDados[3]) - Int32.Parse(qtde.Text))<Int32.Parse(bancoDados[2]))
                            {
                                MessageBox.Show("Ao entregar este produto, seu estoque entrará no limite de alerta.  Faça uma nova requisição para não correr o risco de ficar sem este produto.");
                            }
                            MessageBox.Show("Produto baixado com sucesso");
                            comboFuncionario.Text = String.Empty;
                            comboProduto.Text = String.Empty;
                            qtde.Text = String.Empty;
                            date.Text = DateTime.Today.ToString("dd/MM/yyyy");
                            break;
                        }
                    }
                }
            }
        }
    }
}

