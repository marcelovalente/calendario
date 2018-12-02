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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            StreamReader banco = new StreamReader(Parameters.path.usuarios);
            string linha;
            string userName = txtUserName.Text;
            String[] bancoDados = new String[] { };
            while (!banco.EndOfStream)
            {
                linha = banco.ReadLine();
                bancoDados = linha.Split(';');

                if (bancoDados[0] == userName)
                {
                    bancoDados[2] = comboBox1.SelectedItem.ToString();

                    UserInformation.nivelUser = Convert.ToInt32(bancoDados[2]);
                }

            }

            banco.Close();

            using (StreamWriter writer = File.AppendText(Parameters.path.nivel))
            {
                writer.WriteLine(bancoDados[0] + ";" + bancoDados[1] + ";" + UserInformation.nivelUser + ";" + bancoDados[3] + ";" + bancoDados[4] + ";" + bancoDados[5]);
            }

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
