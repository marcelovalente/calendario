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
    public partial class Form2 : Form
    {
        public Form2()

        {
            InitializeComponent();
        }
      
        private void butEntrar_Click(object sender, EventArgs e)
        {

            string dataSenha = txtSenha.Text;
            string dataUsuario = txtUsuario.Text;

            if (dataSenha == "" || dataUsuario == "")
            {
                MessageBox.Show("Digite usuário e senha.");
            }
            else
            {
                if (checar_senha(dataUsuario, dataSenha) == 1)
                {
                    MessageBox.Show("Usuário bloqueado pelo administrador, acesso negado.");
                }
                else if (checar_senha(dataUsuario, dataSenha) == 2)
                {
                    txtSenha.Text = "";
                    MessageBox.Show("Usuário ou senha incorreta, verifique novamente.");
                }

                else if (checar_senha(dataUsuario, dataSenha) == 3)
                {
                    
                    Form Form5 = new PIB_EG.Form5();
                    Form5.ShowDialog();
                    UserInformation.runUser = dataUsuario;
                    this.Hide();
                }
            }

        }
        private int checar_senha(string user, string senha)
        {

            System.IO.StreamReader banco = new System.IO.StreamReader(Parameters.path.bloqueados);

            string linha;
            String[] bancoDados = new String[] { };
            while ((linha = banco.ReadLine()) != null)
            {
                bancoDados = linha.Split(';');
                if (bancoDados[0] == user)
                {

                    if (senha == bancoDados[1])
                    {
                        Cookie.nivel = Int32.Parse(bancoDados[2]);
                        banco.Close();
                        return 1;
                    }
                }

            }
            banco.Close();

            System.IO.StreamReader bancoNivel = new System.IO.StreamReader(Parameters.path.nivel);

            string linhaNivel;
            String[] bancoPerfil = new String[] { };
            while ((linhaNivel = bancoNivel.ReadLine()) != null)
            {
                bancoPerfil = linhaNivel.Split(';');
                if (bancoPerfil[0] == user)
                {

                    if (senha == bancoPerfil[1])
                    {
                        Cookie.nivel = Int32.Parse(bancoPerfil[2]);
                        banco.Close();
                        return 3;
                    }
                }

            }
            bancoNivel.Close();

            System.IO.StreamReader bancoUsuarios = new System.IO.StreamReader(Parameters.path.usuarios);

            string linhaUser;
            String[] bancoUsers = new String[] { };
            while ((linhaUser = bancoUsuarios.ReadLine()) != null)
            {
                bancoUsers = linhaUser.Split(';');
                if (bancoUsers[0] == user)
                {

                    if (senha == bancoUsers[1])
                    {
                        Cookie.nivel = Int32.Parse(bancoUsers[2]);
                        banco.Close();
                        return 3;
                    }
                }

            }

            bancoUsuarios.Close();

            return 2;
        }
       

        private void abaVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                butEntrar_Click(sender, e);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtSenha.Focus();
            }
        }

    }
}
