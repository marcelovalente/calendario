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
    public partial class Form10 : Form
    {
        string linha;
        public Form10()
        {
            InitializeComponent();
            if (!File.Exists(Parameters.path.produtos))
            {
                noContain();
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
                    comboBox1.Items.Add(bancoDados[1]);
                    i++;
                }
                if (i == 0)
                {
                    noContain();
                }
                read.Close();
            }
        }
        private void noContain()
        {
            //este metodo serve para indicar que não tem produto cadastrado
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Não existe produto cadastrado");
            comboBox1.SelectedIndex = 0;
            qtdeAdd.Enabled = false;
            cadQtdeProd.Enabled = false;
            comboBox1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader read = new System.IO.StreamReader(Parameters.path.produtos);
            String[] bancoDados = new String[]{};
            int countLine = 0;
            string newLine = "";
            while ((linha = read.ReadLine()) != null)
            {
                bancoDados = linha.Split(';');
                String[] splitLine = new String[] { };
                string line = File.ReadLines(Parameters.path.produtos).Skip(countLine).Take(1).First();
                if (bancoDados[1] == comboBox1.Text)
                {
                    splitLine = line.Split(';');
                    splitLine[3] = (Int32.Parse(splitLine[3]) + Int32.Parse(qtdeAdd.Text)).ToString();
                    line = "";
                    for(int i=0;i<(splitLine.Length);i++){
                        line = line + splitLine[i] + ";";
                    }
                    line = line.Remove(line.Length - 1);
                }
                newLine = newLine + line + "\r\n";
                countLine++;
            }
            read.Close();
            File.WriteAllText(Parameters.path.produtos, newLine);
            MessageBox.Show("Produto atualizado com sucesso");
            comboBox1.Text = String.Empty;
            qtdeAdd.Text = String.Empty;
            comboBox1.Focus();
        }
    }
}