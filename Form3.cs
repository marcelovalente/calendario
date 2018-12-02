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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader banco = new System.IO.StreamReader(Parameters.path.usuarios);

            string linha;
            string userName = txtUserName.Text;
            String[] bancoDados = new String[]{};

            while ((linha = banco.ReadLine()) != null)
            {
                bancoDados = linha.Split(';');
                if (bancoDados[0] == userName)
                {
                    txtNomeUser.Text = bancoDados[3];
                    txtDataUser.Text = bancoDados[4];

                }
            }
            

            txtDataUser.Visible = true;
            txtNomeUser.Visible = true;
            btBuscar.Enabled = false;
            labelUsuario.Visible = true;
            labeolData.Visible = true;
            UserInformation.usercode = txtUserName.Text;
            
        }

       

    }
}
