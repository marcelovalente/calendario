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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            string linha;
            //verificar se tem usuario, se tiver inclue no combobox
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
        private void noContain(string item)
        {
            //este metodo serve para indicar que não tem funcionario cadastrado
            comboFuncionario.Items.Clear();
            comboFuncionario.Items.Add("Não existe " + item + " cadastrado");
            comboFuncionario.SelectedIndex = 0;
            //bloquear itens
            comboFuncionario.Enabled = false;
            btnDelUser.Enabled = false;
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            //pesquisar o codigo do usuario
            string codUser = "", linha;
            System.IO.StreamReader codFunc = new System.IO.StreamReader(Parameters.path.usuarios);
            String[] numCodUsuario = new String[] { };
            while ((linha = codFunc.ReadLine()) != null)
            {
                numCodUsuario = linha.Split(';');
                if (numCodUsuario[3] == comboFuncionario.Text)
                {
                    codUser = numCodUsuario[0];
                    break;
                }
            }
            numCodUsuario = null;
            //posicionar no topo e ler usuario
            codFunc.BaseStream.Position = 0;
            codFunc.DiscardBufferedData();
            //se tiver o usuario jogar no arquivo morto e apagar a linha
            string copia, newLine = "", userClear = comboFuncionario.Text;
            comboFuncionario.Items.Clear();
            comboFuncionario.Text = String.Empty;
            while ((linha = codFunc.ReadLine()) != null)
            {
                numCodUsuario = linha.Split(';');
                if (numCodUsuario[0] == codUser)
                {
                    File.AppendAllText(Parameters.path.usuariosMorto, linha + "\r\n");
                    MessageBox.Show("Usuario " + userClear + " foi removido com sucesso!");
                }
                else
                {
                    newLine = newLine + linha + "\r\n";
                    if (numCodUsuario[3] != "admin")
                    {
                        comboFuncionario.Items.Add(Convert.ToString(numCodUsuario[3]));
                    }
                }
            }
            codFunc.Close();
            File.WriteAllText(Parameters.path.usuarios, newLine);

        }
    }
    }
