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
using System.Text.RegularExpressions;

namespace PIB_EG
{
    

    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        
        private void alterarSenha()
        {
            System.IO.StreamReader banco = new System.IO.StreamReader(Parameters.path.bloqueados);

            string linha;
            string user = UserInformation.runUser;
            String[] bancoDados = new String[] { };
            while (!banco.EndOfStream)
            {
                linha = banco.ReadLine();
                bancoDados = linha.Split(';');
                if (bancoDados[0] == user)
                {

                    string senha = txtConfirmPass.Text, txtErro = "";
                    string lastPass = bancoDados[1];
                    if (senha != "")
                    {
                        int erro = 0, chkA = 0, i, x;
                        //Conter no mínimo 6 e no máximo 10 letras e/ou algarismos numéricos.
                        if (senha.Length < 6 || senha.Length > 10)
                        {
                            erro = 1;
                            txtErro = txtErro + "- A senha deve ter entre 6 e 10 caracteres\n";
                        }
                        if (newPassword.Text.Contains(bancoDados[1]))
                        {
                            erro = 1;
                            txtErro = txtErro + "- A senha não deve ser igual a anterior";
                        }
                        if (erro != 1)
                        {
                            //Distinguir letras maiúsculas de minúsculas e não aceitar espaços em branco nem caracteres especiais
                            chkA = chkA + Regex.Match(senha, "[A-Z]").Length;
                            chkA = chkA + Regex.Match(senha, "[A-Z]").Length;
                            if (chkA != 2)
                            {
                                erro = 1;
                                txtErro = txtErro + "- É obrigatório usar letra maiúscula e minúscula\n";
                            }
                            if (Regex.Match(senha, " ").Length != 0)
                            {
                                erro = 1;
                                txtErro = txtErro + "- Não pode usar espaço em branco\n";
                            }
                            if (Regex.Match(senha, "[^a-zA-Z0-9]").Length != 0)
                            {
                                erro = 1;
                                txtErro = txtErro + "- Não pode usar caracteres especiais\n";
                            }
                            //Conter no mínimo 2 letras e no mínimo 2 algarismos numéricos
                            if (Regex.Matches(senha, "[a-zA-Z]").Count < 2)
                            {
                                erro = 1;
                                txtErro = txtErro + "- É necessário ter duas letras na senha\n";
                            }
                            if (Regex.Matches(senha, "[0-9]").Count < 2)
                            {
                                erro = 1;
                                txtErro = txtErro + "- É necessário ter dois números na senha\n";
                            }
                            //Não conter 3 ou mais letras repetidas em sequência.   Ex.: aaa
                            //Não conter 3 ou + algarismos numéricos repetidos em sequência
                            for (i = 0, x = 0; i < senha.Length; i++)
                            {
                                if (x != 2 && i != 0)
                                {
                                    //if (senha.ToLower().ElementAt(i).ToString() == senha.ToLower().ElementAt(i - 1).ToString())
                                    if (senha.ElementAt(i).ToString() == senha.ElementAt(i - 1).ToString())
                                    {
                                        x++;
                                    }
                                    else
                                    {
                                        x = 0;
                                    }
                                }
                            }
                            if (x >= 2)
                            {
                                erro = 1;
                                txtErro = txtErro + "- Você não pode repetir 3 caracteres seguidos\n";
                            }

                            if (txtConfirmPass.Text.Contains(user))
                            {
                                erro = 1;
                                txtErro = txtErro + "- A senha não deve ser igual ao código de usuário\n";
                            }
                        }
                        if (erro != 0)
                        {
                            MessageBox.Show(txtErro);
                            newPassword.Focus();
                        }
                        else
                        {
                            bancoDados [1] = newPassword.Text;
                           
                        }


                    }
                }
             
            }
            banco.Close();

            string novaSenha = UserInformation.runPass;

            if (File.Exists(Parameters.path.senhas))
                            {
                                using (StreamWriter writer = File.AppendText(Parameters.path.senhas))
                                {
                                    writer.WriteLine(bancoDados[0] + ";" + novaSenha + ";" + bancoDados[2] + ";" + bancoDados[3] + ";" + bancoDados[4] + ";" + bancoDados[5]);
                                    MessageBox.Show("Senha alterada com sucesso!");
                                }
                            }

        }
        private void btAlterar_Click(object sender, EventArgs e)
        {
            alterarSenha();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
