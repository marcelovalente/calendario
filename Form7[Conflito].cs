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

    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
           
        }

        private void btn_NewPass_Click(object sender, EventArgs e)
        {
            checkPass();
        }

        private void novaSenha_TextChanged(object sender, EventArgs e)
        {
            qualidade_senha();
        }

        private void checkPass()
        {
            string usuario = txtUsuario.Text;
            string cpf = maskedTxt_CPF.Text;
            string RG = maskedTxt_RG.Text;
            string email = txtEmail.Text;

            string senha = novaSenha.Text, txtErro = "";
            if (senha != "")
            {
                int erro = 0, chkA = 0, i, x;
                //Conter no mínimo 6 e no máximo 10 letras e/ou algarismos numéricos.
                if (senha.Length < 6 || senha.Length > 10)
                {
                    erro = 1;
                    txtErro = txtErro + "- A senha deve ter entre 6 e 10 caracteres\n";
                }
                if (erro != 1)
                {
                    //Distinguir letras maiúsculas de minúsculas e não aceitar espaços em branco nem caracteres especiais
                    chkA = chkA + Regex.Match(senha, "[a-z]").Length;
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
                    if (Regex.Matches(senha, "[a-zA-z]").Count < 2)
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
                            if (senha.ToLower().ElementAt(i).ToString() == senha.ToLower().ElementAt(i - 1).ToString())
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
                        txtErro = txtErro + "- Você não pode repetir 3 caracteres seguidos()\n";
                    }

                    if (novaSenha.Text.Contains(usuario))
                    {
                        erro = 1;
                        txtErro = txtErro + "- A senha não deve ser igual ao código de usuário\n";
                    }

                    //resultado
                    if (erro != 0)
                    {
                        MessageBox.Show(txtErro);
                    }
                    else
                    {
                        MessageBox.Show("tudo certo com a senha");
                        string senhaNova = novaSenha.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Digite uma senha");
                }
            }
        }

            
        private void qualidade_senha()
        {
            string senha = novaSenha.Text;
            string nome = txtNome.Text;
            string usuario = txtUsuario.Text;

            //Requisitos para saber força da senha
            int pontuacao = 10, i;

                        if (Regex.Matches(senha, "[a-zA-z]").Count == 2)
            {
                pontuacao = pontuacao - 1;
            }
            if (Regex.Matches(senha, "[0-9]").Count == 2)
            {
                pontuacao = pontuacao - 1;
            }
            string nome1 = nome.Substring(0, nome.IndexOf("")); //até o primeiro espaço,ou seja o primeiro nome


            //se conter código do usuario
            if (senha.Contains(usuario))
            {
                pontuacao = pontuacao - 2;
            }

            //Se conter o primeiro nome
            else if (senha.Contains(nome1))
            {
                pontuacao = pontuacao - 2;
            }

            string[] n = nome.Split(' ');
            string iniciais = "";

            for (i = 0; i < n.Length; i++)
            {
                //Dispenso a palavras menores que 3 caracteres
                if (n[i].Length > 3)
                    //Pego somente a primeira letra das palavras
                    iniciais = iniciais + n[i].Substring(0, 1);
            }

            //se conter as iniciais do nome
            if (novaSenha.Text.Contains(iniciais))
            {
                pontuacao = pontuacao - 2;
            }

            //aqui é retirada a mascara da dataNasc
            maskedTxt_DataNasc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string dataNasc = maskedTxt_DataNasc.Text;

            //Se conter parte da dataNasc
            if (senha.Contains(dataNasc))
            {
                pontuacao = pontuacao - 3;
            }

            //aqui se inverte a dataNasc
            int qtd = dataNasc.Length;
            string invertido = "";
            for (i = dataNasc.Length - 1; i >= 0; i--)
            {
                invertido += dataNasc[i];
            }

            //se conter a dataNasc invertida na senha
            if (senha.Contains(invertido))
            {
                pontuacao = pontuacao - 3;
            }

            if (pontuacao >= 9)
            {
                lblQualidade.Text = "Muito Forte";
                lblQualidade.ForeColor = System.Drawing.Color.DarkBlue;
                lblQualidade.Refresh();

            }
            else if (pontuacao == 7 || pontuacao == 8)
            {
                lblQualidade.Text = "Forte";
                lblQualidade.ForeColor = System.Drawing.Color.DarkGreen;
                lblQualidade.Refresh();
            }
            else if (pontuacao == 5 || pontuacao == 6)
            {
                lblQualidade.Text = "Razoável";
                lblQualidade.ForeColor = System.Drawing.Color.BlueViolet;
                lblQualidade.Refresh();

            }
            else if (pontuacao == 3 || pontuacao == 4)
            {
                lblQualidade.Text = "Fraca";
                lblQualidade.ForeColor = System.Drawing.Color.DarkOrange;
                lblQualidade.Refresh();

            }
            else if (pontuacao < 3)
            {
                lblQualidade.Text = "Muito Fraca";
                lblQualidade.ForeColor = System.Drawing.Color.Red;
                lblQualidade.Refresh();
            }
            else
            {
                pontuacao = 10;
            }
        }
    }

        
}

    
