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
    public partial class Form9 : Form
    {
        public struct produto
        {
            public int cod;
            public string nome;
            public int qtdeLimite;
        }

        public Form9()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {

            if (codigoProduto.Text == "" || nomeProduto.Text == "" || qtdeLimite.Text=="")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                if (!File.Exists(Parameters.path.produtos))
                {
                    using (StreamWriter sw = File.CreateText(Parameters.path.produtos));
                }
                TextReader read = new StreamReader(Parameters.path.produtos, true);
                string linha;
                String[] bancoDados = new String[]{};
                while ((linha = read.ReadLine()) != null)
                {
                    bancoDados = linha.Split(';');
                    if (bancoDados[0] == codigoProduto.Text)
                    {
                        MessageBox.Show("Já existe este código cadastrado");
                        read.Close();
                        return;
                    }
                    if (bancoDados[1] == nomeProduto.Text)
                    {
                        MessageBox.Show("Já existe este item, tente novamente");
                        read.Close();
                        return;
                    }
                }
                read.Close();
                //se nao existe o mesmo nome
                produto cadProduto = new produto();
                cadProduto.cod = Int32.Parse(codigoProduto.Text);
                cadProduto.nome = nomeProduto.Text;
                cadProduto.qtdeLimite = Int32.Parse(qtdeLimite.Text);
                TextWriter produto = new StreamWriter(Parameters.path.produtos, true);
                produto.WriteLine(cadProduto.cod + ";" + cadProduto.nome + ";" + cadProduto.qtdeLimite+";"+0);
                produto.Close();
                //zerando os campos
                codigoProduto.Text = String.Empty;
                nomeProduto.Text = String.Empty;
                qtdeLimite.Text = String.Empty;
                codigoProduto.Focus();
                MessageBox.Show("Produto cadastrado com sucesso");
            }
        }

    }
}
