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

        public int lastPass(string pass)
        {
            string lastPass = "lastPass135";
            if (pass == lastPass)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void checkPass()
        {
            
            string usuario = txtUsuario.Text;
            string nomeUsuario = txtNome.Text;
            string dtNasc = maskedTxt_DataNasc.Text;
            string email = txtEmail.Text;
            string nivel = comboNivel.Text;
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
                if (lastPass(senha) == 1)
                {
                    erro = 1;
                    txtErro = txtErro + "- Você não pode cadastrar uma senha que já foi utilizada";
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

                    if (novaSenha.Text.Contains(usuario))
                    {
                        erro = 1;
                        txtErro = txtErro + "- A senha não deve ser igual ao código de usuário\n";
                    }
                }
                if (erro != 0)
                {
                    MessageBox.Show(txtErro);
                    novaSenha.Focus();
                }
                else
                {
                    if (File.Exists(Parameters.path.usuarios))
                    {
                        using (StreamWriter writer = File.AppendText(Parameters.path.usuarios))
                        {
                            writer.WriteLine(usuario + ";" + senha + ";" + nivel + ";" + nomeUsuario + ";" + dtNasc + ";" + email);
                        }
                    }

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    txtNome.Clear();
                    txtUsuario.Clear();
                    txtEmail.Clear();
                    maskedTxt_DataNasc.Clear();
                    novaSenha.Clear();
                    redigitSenha.Clear();
                    
                }
            }
            else
            {
                MessageBox.Show("Digite uma senha");
            }
        }


        private void qualidade_senha()
        {
            string senha = novaSenha.Text, nome = txtNome.Text, usuario = txtUsuario.Text;
            int pontuacao = 10, i,x;
            if (senha.Length >= 6)
            {
                //Requisitos para saber força da senha
                if (Regex.Matches(senha, "[a-z]").Count <= 2)
                {
                    pontuacao = pontuacao - 1;
                }
                if (Regex.Matches(senha, "[A-Z]").Count <= 2)
                {
                    pontuacao = pontuacao - 1;
                }
                if (Regex.Matches(senha, "[0-9]").Count <= 2)
                {
                    pontuacao = pontuacao - 1;
                }

                //Números sequenciais com 4 ou mais algarismos
                for (i = 0, x = 0; i < senha.Length; i++)
                {
                    if (x != 3 && i != 0 && Regex.Matches(senha.ElementAt(i).ToString(), "[0-9]").Count == 1 && Regex.Matches(senha.ElementAt(i-1).ToString(), "[0-9]").Count == 1)
                    {

                        int y = Int32.Parse(senha.ElementAt(i).ToString());
                        int w = Int32.Parse(senha.ElementAt(i-1).ToString());
                        if (y - w==1)
                        {
                            x++;
                        }
                        else
                        {
                            x = 0;
                        }
                        //MessageBox.Show(senha.ToString());
                    }
                }
                if (x >= 3)
                {
                    pontuacao = pontuacao - 1;
                }
                //se conter código do usuario
                if (senha.Contains(usuario) && usuario != "")
                {
                    pontuacao = pontuacao - 2;
                }
                //Se conter o primeiro nome
                if (nome != "")
                {
                    string nome1 = nome.Substring(0, nome.IndexOf(" "));
                    if (senha.Contains(nome1))
                    {
                        pontuacao = pontuacao - 2;
                    }
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
                string dataNasc = maskedTxt_DataNasc.Text, partDate = dataNasc.Substring(0, 4);
                //Se conter parte da dataNasc
                if (senha.Contains(dataNasc) || senha.Contains(partDate))
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
                string partDateInvert = invertido.Substring(4, 4);
                //se conter a dataNasc invertida na senha
                if (senha.Contains(invertido) || senha.Contains(partDateInvert))
                {
                    pontuacao = pontuacao - 3;
                }
                calculaPonto(pontuacao);
            }
        }
        private void calculaPonto(int pontuacao)
        {
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
                MessageBox.Show("Senha muito fraca. Digite outra senha.");
            }
        }

        public void confSenha(object sender, EventArgs e)
        {
            string senha = novaSenha.Text, repeatSenha = redigitSenha.Text;
            if (senha == repeatSenha)
            {
                btn_NewPass.Enabled = true;
            }
            else
            {
                btn_NewPass.Enabled = false;
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void maskedTxt_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTxt_RG_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
}

    
