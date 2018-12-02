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
    public partial class Form4 : Form
    {
        public Form4()
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
                    using (StreamWriter writer = File.AppendText(Parameters.path.bloqueados))
                    {
                        writer.WriteLine(linha);
                    }
                }

            }

        }
    }
}
