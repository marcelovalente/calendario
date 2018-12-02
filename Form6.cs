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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            acessoPerfil();
        }
        public int valueNivel = Cookie.nivel;

        public void prepareNivel(bool[] nivel)
        {
            //tornando todos os menus ativos
            //menu controle
            abaCalculo1.Enabled = nivel[0];
            abaCalculo2.Enabled = nivel[1];
            abaDatasFuturas.Enabled = nivel[2];
            abaDatasPassadas.Enabled = nivel[3];
            abaPesquisarData.Enabled = nivel[4];
            abaOutros.Enabled = nivel[5];
        }

        public void acessoPerfil()
        {
            bool[] nivel = new bool[10];
            if (valueNivel == 1 || valueNivel==2)
            {
                nivel[0] = true;
                nivel[1] = true;
                nivel[2] = true;
                nivel[3] = true;
                nivel[4] = true;
                nivel[5] = true;
            }
            else
            {
                nivel[0] = true;
                nivel[1] = true;
                nivel[2] = true;
                nivel[3] = true;
                nivel[4] = false;
                nivel[5] = false;
            }
            prepareNivel(nivel);
        }

        private void CalculoIdadeExata()
        {
           
            DateTime resultado = DateTime.MinValue;
            if (DateTime.TryParse(this.txtData.Text.Trim(), out resultado))
            {
                if (txtData.Text =="")
                {
                    MessageBox.Show("Insira uma data.");
                }

                else 
                
                {
                DateTime entrada = Convert.ToDateTime(txtData.Text);
                    
                DateTime dataHoje = System.DateTime.Today;
                   
                TimeSpan diferenca = dataHoje - entrada;
                
                int anos = 0, meses = 0;
               
                if (dataHoje.Month < entrada.Month)
                {
                    anos = (dataHoje.Year - entrada.Year) - 1;
                    int mesesTot = entrada.Month - dataHoje.Month;
                    meses = (12 - mesesTot) + (anos * 12);
                    
                }
                else 
                {
                    anos = dataHoje.Year - entrada.Year;
                    
                    int mesesTot = (entrada.Month - dataHoje.Month) * (-1);
                    meses = mesesTot + (anos * 12);

                }
                
                int dias = Convert.ToInt32(diferenca.TotalDays);
                int horas = Convert.ToInt32(diferenca.TotalHours);
               
                MessageBox.Show("A idade exata correspondente a data forcencida é: " + anos.ToString()+ " anos, " + meses.ToString() + " meses, " 
                + dias.ToString() + " dias, " + horas.ToString() + " horas.", "Resultado:");
               
            }
                
            }
               

            else
            {
                
                MessageBox.Show("Data Inválida.");
            }
        }

        private void CalculoDiferencaDatas()
        {
             DateTime resultado = DateTime.MinValue;
             if (DateTime.TryParse(this.txtData2.Text.Trim(), out resultado))
             { 
                 if (DateTime.TryParse(this.txtData3.Text.Trim(), out resultado))
                 {
                     if (txtData2.Text == "" || txtData3.Text =="")
                     {
                         MessageBox.Show("Preencha todos os campos.");
                     }

                     else
                     {
                         DateTime dT1 = Convert.ToDateTime(txtData2.Text);
                         DateTime dT2 = Convert.ToDateTime(txtData3.Text);

                         TimeSpan diferenca = dT1 - dT2;

                         int dias = Convert.ToInt32(diferenca.TotalDays);
                         int horas = Convert.ToInt32(diferenca.TotalHours);
                         int anos = dT1.Year - dT2.Year;
                         int meses = anos * 12;
                         int semanas = dias / 7;

                         if (dT1.Year < dT2.Year)
                         {
                             MessageBox.Show("A diferença entre as datas fornecidas é de: " + (horas * (-1)).ToString() + " horas, " + (dias * (-1)).ToString()
                             + " dias, " + (semanas * (-1)).ToString() + " semanas, " + (meses * (-1)).ToString() + " meses e " +
                             (anos * (-1)).ToString() + " anos.", "Resultado:");
                         }
                         else if (dT1.Year == dT2.Year && dT2.Month > dT1.Month)
                         {
                             int diferencaMeses = (dT2.Month - dT1.Month) + 1;

                             MessageBox.Show("A diferença entre as datas fornecidas é de: " + horas.ToString() + " horas, " + dias.ToString()
                             + " dias, " + (semanas * (-1)).ToString() + " semanas, " + diferencaMeses.ToString() + " meses e " +
                             (anos * (-1)).ToString() + " anos.", "Resultado:");
                         }
                         else if (dT1.Year == dT2.Year && dT2.Month < dT1.Month)
                         {
                             int diferencaMeses = (dT2.Month - dT1.Month);

                             MessageBox.Show("A diferença entre as datas fornecidas é de: " + horas.ToString() + " horas, " + dias.ToString()
                             + " dias, " + semanas.ToString() + " semanas, " + (diferencaMeses * (-1)).ToString() + " meses e " +
                             anos.ToString() + " anos.", "Resultado:");
                         }

                         else if (dT1.Year == dT2.Year && dT2.Month == dT1.Month && dT2.Day > dT1.Day)
                         {
                                 MessageBox.Show("A diferença entre as datas fornecidas é de: " + (horas*(-1)).ToString() + " horas, " + (dias*(-1)).ToString()
                                 + " dias, " + (semanas * (-1)).ToString() + " semanas, " + "0 meses e " +
                                 (anos * (-1)).ToString() + " anos.", "Resultado:");
                                                         
                         }

                             
                         
                         else
                         {
                             MessageBox.Show("A diferença entre as datas fornecidas é de: " + horas.ToString() + " horas, " + dias.ToString()
                             + " dias, " + semanas.ToString() + " semanas, " + meses.ToString() + " meses e " +
                             anos.ToString() + " anos.", "Resultado:");
                         }


                     }

                
                 }
                    

                 else
                 {
                     MessageBox.Show("Data Inválida");
                 }

             }

             else
             {
                 MessageBox.Show("Data Inválida");
             }
        }

        private void CalculoDatasFuturas()
        {
            DateTime resultado = DateTime.MinValue;
            if (DateTime.TryParse(this.txtData4.Text.Trim(), out resultado))
            {
                
                    DateTime dataPartida = Convert.ToDateTime(txtData4.Text);
                    DateTime dataFutura = resultado;

                    if (checkDias.Checked)
                    {
                        if (txtDias.Text == "")
                        {
                            MessageBox.Show("Preencha o campo selecionado.");
                        }
                        else
                        {
                            int addDias = Convert.ToInt32(txtDias.Text);
                            dataFutura = dataPartida.AddDays(addDias);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData futura: " + dataFutura.ToString());
                        }

                    }

                    else if (checkMeses.Checked)
                    {
                        if (txtMeses.Text == "")
                        {
                            MessageBox.Show("Preencha o campo selecionado.");
                        }
                        else
                        {
                            int addMeses = Convert.ToInt32(txtMeses.Text);
                            dataFutura = dataPartida.AddMonths(addMeses);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData futura: " + dataFutura.ToString());
                        }
                    }

                    else if (checkSem.Checked)
                    {
                        if (txtSemanas.Text == "")
                        {
                            MessageBox.Show("Preencha o campo selecionado.");
                        }
                        else
                        {
                            int addSem = Convert.ToInt32(txtSemanas.Text) * 7;
                            dataFutura = dataPartida.AddDays(addSem);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData futura: " + dataFutura.ToString());
                        }
                    }

                    else if (checkDias.Checked && checkMeses.Checked)
                    {
                        if (txtDias.Text == "" && txtMeses.Text == "")
                        {
                            MessageBox.Show("Preencha os campos selecionados.");
                        }
                        else
                        {
                            int addDias = Convert.ToInt32(txtDias.Text);
                            int addMeses = Convert.ToInt32(txtMeses.Text);
                            DateTime adicionaDias = dataPartida.AddDays(addDias);
                            dataFutura = adicionaDias.AddMonths(addMeses);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData futura: " + dataFutura.ToString());
                        }
                    }

                    else if (checkDias.Checked && checkSem.Checked)
                    {
                        if (txtDias.Text == "" && txtSemanas.Text == "")
                        {
                            MessageBox.Show("Preencha os campos selecionados.");
                        }
                        else
                        {
                            int addDias = Convert.ToInt32(txtDias.Text);
                            int addSem = Convert.ToInt32(txtSemanas.Text) * 7;
                            DateTime adicionaDias = dataPartida.AddDays(addDias);
                            dataFutura = adicionaDias.AddDays(addSem);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData futura: " + dataFutura.ToString());
                        }
                    }

                    else if (checkMeses.Checked && checkSem.Checked)
                    {
                        if (txtMeses.Text == "" && txtSemanas.Text == "")
                        {
                            MessageBox.Show("Preencha os campos selecionados.");
                        }
                        else
                        {
                            int addMeses = Convert.ToInt32(txtMeses.Text);
                            int addSem = Convert.ToInt32(txtSemanas.Text) * 7;
                            DateTime adicionaDias = dataPartida.AddDays(addSem);
                            dataFutura = adicionaDias.AddMonths(addMeses);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData futura: " + dataFutura.ToString());
                        }
                    }

                    else if (checkMeses.Checked && checkSem.Checked && checkDias.Checked)
                    {
                        if (txtDias.Text == "" && txtSemanas.Text == "" && txtMeses.Text == "")
                        {
                            MessageBox.Show("Preencha os campos selecionados.");
                        }
                        else
                        {
                            int addDias = Convert.ToInt32(txtDias.Text);
                            int addSem = Convert.ToInt32(txtSemanas.Text) * 7;
                            int addMeses = Convert.ToInt32(txtMeses.Text);
                            DateTime adicionaDias = dataPartida.AddDays(addDias);
                            DateTime adicionaSema = adicionaDias.AddDays(addSem);
                            dataFutura = adicionaSema.AddMonths(addMeses);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData futura: " + dataFutura.ToString());
                        }


                    }
                       

                    else
                    {
                        MessageBox.Show("Selecione algum campo para adicionar na data.");
                    }


                }

            else
            {
                MessageBox.Show("Data Inválida");
            }

        }


        private void CalculoDatasPassadas()
        { 
            DateTime resultado = DateTime.MinValue;
            if (DateTime.TryParse(this.txtData5.Text.Trim(), out resultado))
            {
                DateTime dataPartida = Convert.ToDateTime(txtData5.Text);
                DateTime dataPassada = resultado;
                if (checkDias2.Checked)
                    { 
                        if (txtDias2.Text == "")
                        {
                            MessageBox.Show("Preencha o campo selecionado.");
                        }
                      
                        else
                        {
                            int addDias = Convert.ToInt32(txtDias2.Text);
                            dataPassada = dataPartida.AddDays(-addDias);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData passada: " + dataPassada.ToString());
                        }

                    }

                    else if (checkMeses2.Checked)
                    {
                        if (txtMeses2.Text == "")
                        {
                            MessageBox.Show("Preencha o campo selecionado.");
                        }
                        else
                        {
                            int addMeses = Convert.ToInt32(txtMeses2.Text);
                            dataPassada = dataPartida.AddMonths(-addMeses);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData passada: " + dataPassada.ToString());
                        }
                    }

                    else if (checkSem2.Checked)
                    {
                        if (txtSemanas2.Text == "")
                        {
                            MessageBox.Show("Preencha o campo selecionado.");
                        }
                        else
                        {
                            int addSem = Convert.ToInt32(txtSemanas2.Text) * 7;
                            dataPassada = dataPartida.AddDays(-addSem);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData passada: " + dataPassada.ToString());
                        }
                    }

                    else if (checkDias2.Checked && checkMeses2.Checked)
                    {
                        if (txtDias2.Text == "" && txtMeses2.Text == "")
                        {
                            MessageBox.Show("Preencha os campos selecionados.");
                        }
                        else
                        {
                            int addDias = Convert.ToInt32(txtDias2.Text);
                            int addMeses = Convert.ToInt32(txtMeses2.Text);
                            DateTime adicionaDias = dataPartida.AddDays(-addDias);
                            dataPassada = adicionaDias.AddMonths(-addMeses);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData passada: " + dataPassada.ToString());
                        }
                    }

                    else if (checkDias2.Checked && checkSem2.Checked)
                    {
                        if (txtDias2.Text == "" && txtSemanas2.Text == "")
                        {
                            MessageBox.Show("Preencha os campos selecionados.");
                        }
                        else
                        {
                            int addDias = Convert.ToInt32(txtDias2.Text);
                            int addSem = Convert.ToInt32(txtSemanas2.Text) * 7;
                            DateTime adicionaDias = dataPartida.AddDays(-addDias);
                            dataPassada = adicionaDias.AddDays(-addSem);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData passada: " + dataPassada.ToString());
                        }
                    }

                    else if (checkMeses2.Checked && checkSem2.Checked)
                    {
                        if (txtMeses2.Text == "" && txtSemanas2.Text == "")
                        {
                            MessageBox.Show("Preencha os campos selecionados.");
                        }
                        else
                        {
                            int addMeses = Convert.ToInt32(txtMeses2.Text);
                            int addSem = Convert.ToInt32(txtSemanas2.Text) * 7;
                            DateTime adicionaDias = dataPartida.AddDays(-addSem);
                            dataPassada = adicionaDias.AddMonths(-addMeses);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData passada: " + dataPassada.ToString());
                        }
                    }

                    else if (checkMeses2.Checked && checkSem2.Checked && checkDias2.Checked)
                    {
                        if (txtDias2.Text == "" && txtSemanas2.Text == "" && txtMeses2.Text == "")
                        {
                            MessageBox.Show("Preencha os campos selecionados.");
                        }
                        else
                        {
                            int addDias = Convert.ToInt32(txtDias2.Text);
                            int addSem = Convert.ToInt32(txtSemanas2.Text) * 7;
                            int addMeses = Convert.ToInt32(txtMeses2.Text);
                            DateTime adicionaDias = dataPartida.AddDays(-addDias);
                            DateTime adicionaSema = adicionaDias.AddDays(-addSem);
                            dataPassada = adicionaSema.AddMonths(-addMeses);
                            MessageBox.Show("Data de partida: " + dataPartida.ToString() + "\nData passada: " + dataPassada.ToString());
                        }

                       

                    }

                    else
                    {
                        MessageBox.Show("Selecione algum campo para subtrair na data.");
                    }


                }

            else
            {
                MessageBox.Show("Data Inválida");
            }

        }
       

        private void DadosDaData()
        {
            DateTime resultado = DateTime.MinValue;
            if (DateTime.TryParse(this.txtData6.Text.Trim(), out resultado))
            {
                DateTime buscarData = Convert.ToDateTime(txtData6.Text);
                string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(buscarData.Month).ToLower();
                DateTime dataFixa = Convert.ToDateTime("01/01/" + buscarData.Year);
                TimeSpan diferenca = buscarData - dataFixa;
                int totalDias = Convert.ToInt32(diferenca.TotalDays) + 1;
                int anoBissexto = Convert.ToInt32(buscarData.Year) % 4;
                if (anoBissexto == 0)
                {
                    MessageBox.Show("\nDia da semana equivalente: " + buscarData.ToString("dddd\n") +"Mês equivalente: " + mesExtenso + "\nDia juliano: " + totalDias.ToString() + "\nAno bissexto: Sim", "Dados encontrados:");
                }
                
                else
                {
                    MessageBox.Show("\nDia da semana equivalente: " + buscarData.ToString("dddd\n") + "Mês equivalente: " + mesExtenso + "\nDia juliano: " + totalDias.ToString() + "\nAno bissexto: Não", "Dados encontrados:");
                }

            }
            else
            {
                MessageBox.Show("Data Inválida");
            }

        }

        private void OutrosCalendarios()
        {
            if (cbBoxDatas.SelectedItem == "30/04/1993")
            {
                lstBoxCalen.Items.Clear();
                lstBoxCalen.Items.Add("Judaico: 9 Iyar, 5753*");
                lstBoxCalen.Items.Add("8 Dhul-Qa`da, 1413");
                lstBoxCalen.Items.Add("Chines: 4691, ano do galo");
            }
            else if (cbBoxDatas.SelectedItem == "01/02/2022")
            {
                lstBoxCalen.Items.Clear();
                lstBoxCalen.Items.Add("Judaico: 28 Tevet, 5782*");
                lstBoxCalen.Items.Add("Islamico: 28 Jumada t-Tania, 1443");
                lstBoxCalen.Items.Add("Chines: 4720, ano do tigre");
            }
            else if (cbBoxDatas.SelectedItem == "17/08/1998")
            {
                lstBoxCalen.Items.Clear();
                lstBoxCalen.Items.Add("Judaico: 25 Av, 5758*");
                lstBoxCalen.Items.Add("Islamico: 23 Rabi`ath-Thani, 1419");
                lstBoxCalen.Items.Add("Chines: 4696, ano do tigre");
            }

            else if (cbBoxDatas.SelectedItem == "01/01/2011")
            {
                lstBoxCalen.Items.Clear();
                lstBoxCalen.Items.Add("Judaico: 25 Tevet, 5771*");
                lstBoxCalen.Items.Add("Islamico: 25 Muharram, 1432");
                lstBoxCalen.Items.Add("Chines: 4709, ano do coelho");
            }

            else if (cbBoxDatas.SelectedItem == "12/12/2012")
            {
                lstBoxCalen.Items.Clear();
                lstBoxCalen.Items.Add("Judaico: 28 Kislev, 5773*");
                lstBoxCalen.Items.Add("Islamico: 28 Muharram, 1434");
                lstBoxCalen.Items.Add("Chines: 4710, ano do dragão");
            }

            else if (cbBoxDatas.SelectedItem == "12/12/2012")
            {
                lstBoxCalen.Items.Clear();
                lstBoxCalen.Items.Add("Judaico: 28 Kislev, 5773*");
                lstBoxCalen.Items.Add("Islamico: 28 Muharram, 1434");
                lstBoxCalen.Items.Add("Chines: 4710, ano do dragão");
            }

            else if (cbBoxDatas.SelectedItem == "23/10/1994")
            {
                lstBoxCalen.Items.Clear();
                lstBoxCalen.Items.Add("Judaico: 18 Cheshvan, 5755*");
                lstBoxCalen.Items.Add("Islamico: 18 Jumada l-Ula, 1415");
                lstBoxCalen.Items.Add("Chines: 4692, ano do cachorro");
            }

            else if (cbBoxDatas.SelectedItem == "05/07/2018")
            {
                lstBoxCalen.Items.Clear();
                lstBoxCalen.Items.Add("Judaico: 22 Tamuz, 5778*");
                lstBoxCalen.Items.Add("Islamico: 21 Shawwal, 1439");
                lstBoxCalen.Items.Add("Chines: 4716, ano do cachorro");
            }
        }


        private void abaSairForm6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void btCalcular_Click(object sender, EventArgs e)
        {
            CalculoIdadeExata();
        }

        private void abaCalculo1_Click(object sender, EventArgs e)
        {
            if (gpBoxCalc2.Visible == true)
            {
                gpBoxCalc2.Visible = false;
            }

            else if (gpBoxCalc3.Visible == true)
            {
                gpBoxCalc3.Visible = false;
            }

            else if (gpBoxCalc4.Visible == true)
            {
                gpBoxCalc4.Visible = false;
            }

            else if (gpBoxCalc5.Visible == true)
            {
                gpBoxCalc5.Visible = false;
            }

            else if (gpBoxCalc6.Visible == true)
            {
                gpBoxCalc6.Visible = false;
            }
            gpBoxCal1.Visible = true;
           
        }

        private void btCalcular2_Click(object sender, EventArgs e)
        {
            CalculoDiferencaDatas();
        }

        private void abaCalculo2_Click(object sender, EventArgs e)
        {
            if (gpBoxCal1.Visible == true)
            {
                gpBoxCal1.Visible = false;
            }

            else if (gpBoxCalc4.Visible == true)
            {
                gpBoxCalc4.Visible = false;
            }
            else if (gpBoxCalc6.Visible == true)
            {
                gpBoxCalc6.Visible = false;
            }

            else if (gpBoxCalc3.Visible == true)
            {
                gpBoxCalc3.Visible = false;
            }

            else if (gpBoxCalc5.Visible == true)
            {
                gpBoxCalc5.Visible = false;
            }

            gpBoxCalc2.Visible = true;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btCalcular3_Click(object sender, EventArgs e)
        {
            CalculoDatasFuturas();
        }

        private void btCalcular4_Click(object sender, EventArgs e)
        {
            CalculoDatasPassadas();
        }

        private void gpBoxCal1_Enter(object sender, EventArgs e)
        {

        }

        private void btCalcular5_Click(object sender, EventArgs e)
        {
            DadosDaData();
        }

        private void abaDatasFuturas_Click(object sender, EventArgs e)
        {
            if (gpBoxCal1.Visible == true)
            {
                gpBoxCal1.Visible = false;
            }
            else if (gpBoxCalc6.Visible == true)
            {
                gpBoxCalc6.Visible = false;
            }

            else if (gpBoxCalc2.Visible == true)
            {
                gpBoxCalc2.Visible = false;
            }
            
            else if (gpBoxCalc4.Visible == true)
            {
                gpBoxCalc4.Visible = false;
            }

            else if (gpBoxCalc5.Visible == true)
            {
                gpBoxCalc5.Visible = false;
            }
            
            gpBoxCalc3.Visible = true;


        }

        private void abaDatasPassadas_Click(object sender, EventArgs e)
        {
            if (gpBoxCal1.Visible == true)
            {
                gpBoxCal1.Visible = false;
            }

            else if (gpBoxCalc2.Visible == true)
            {
                gpBoxCalc2.Visible = false;
            }
            else if (gpBoxCalc6.Visible == true)
            {
                gpBoxCalc6.Visible = false;
            }

            else if (gpBoxCalc3.Visible == true)
            {
                gpBoxCalc3.Visible = false;
            }

            else if (gpBoxCalc5.Visible == true)
            {
                gpBoxCalc5.Visible = false;
            }

            gpBoxCalc4.Visible = true;
        }

        private void abaPesquisarData_Click(object sender, EventArgs e)
        {
            if (gpBoxCal1.Visible == true)
            {
                gpBoxCal1.Visible = false;
            }

            else if (gpBoxCalc6.Visible == true)
            {
                gpBoxCalc6.Visible = false;
            }

            else if (gpBoxCalc2.Visible == true)
            {
                gpBoxCalc2.Visible = false;
            }

            else if (gpBoxCalc3.Visible == true)
            {
                gpBoxCalc3.Visible = false;
            }

            else if (gpBoxCalc4.Visible == true)
            {
                gpBoxCalc4.Visible = false;
            }

            gpBoxCalc5.Visible = true;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtData6.Clear();
        }

        private void txtMeses2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLimpar2_Click(object sender, EventArgs e)
        {
            txtData5.Clear();
            txtDias2.Clear();
            txtMeses2.Clear();
            txtSemanas2.Clear();
            checkDias2.Checked = false;
            checkMeses2.Checked = false;
            checkSem2.Checked = false;
        }

        private void btLimpar3_Click(object sender, EventArgs e)
        {
            txtData4.Clear();
            txtDias.Clear();
            txtMeses.Clear();
            txtSemanas.Clear();
            checkDias.Checked = false;
            checkMeses.Checked = false;
            checkSem.Checked = false;
        }

        private void btLimpar4_Click(object sender, EventArgs e)
        {
            txtData2.Clear();
            txtData3.Clear();
        }

        private void btLimpar5_Click(object sender, EventArgs e)
        {
            txtData.Clear();
        }

        private void cbBoxDatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutrosCalendarios();
        }

        private void abaOutros_Click(object sender, EventArgs e)
        {
            if (gpBoxCal1.Visible == true)
            {
                gpBoxCal1.Visible = false;
            }

            else if (gpBoxCalc2.Visible == true)
            {
                gpBoxCalc2.Visible = false;
            }

            else if (gpBoxCalc3.Visible == true)
            {
                gpBoxCalc3.Visible = false;
            }

            else if (gpBoxCalc4.Visible == true)
            {
                gpBoxCalc4.Visible = false;
            }

            else if (gpBoxCalc5.Visible == true)
            {
                gpBoxCalc5.Visible = false;
            }

            gpBoxCalc6.Visible = true;
        }

        private void gpBoxCalc6_Enter(object sender, EventArgs e)
        {

        }
        private void validateNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
             
        
            
    }


}