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
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
           if (!File.Exists(Parameters.path.usuarios))
           {
               using (StreamWriter sw = File.CreateText(Parameters.path.usuarios));
               using (StreamWriter writer = File.AppendText(Parameters.path.usuarios))
               {
                   writer.WriteLine("1;admin;1;admin;00000000;admin@admin.com");
               }
           }
        }

        //Instancia form2 
        Form Form2 = new PIB_EG.Form2();

        private void abaLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2.ShowDialog();
            Form2.Location = new Point(200, 100);
            
        }

        private void abaSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alignImg();
        }

        private void alignImg()
        {
            pictureBox1.Left = (this.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (this.Height - pictureBox1.Height) / 2;
        }

        private void abaSobre_Click(object sender, EventArgs e)
        {
            string txtSobre="";
            if (sender.ToString() == "Objetivos")
            {
                txtSobre = "Desenvolver um sistema administrativo de controle de uma empresa";
            }
            else if (sender.ToString() == "Funcionalidades")
            {
                txtSobre = "Calculadora de datas";
            }
            else if (sender.ToString() == "Desenvolvedores")
            {
                txtSobre = "Bruna Carolina de Oliveira\nJoice Franciele Alves Rodrigues\nMarcelo Monteiro da Silva Valente";
            }
            else if (sender.ToString() == "Plataforma")
            {
                txtSobre = "Windows";
            }
            else if(sender.ToString()=="Versão")
            {
                txtSobre = "2.1";
            }
            MessageBox.Show(txtSobre);
        }
    }
}
