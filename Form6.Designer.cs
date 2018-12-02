namespace PIB_EG
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.menuCalc = new System.Windows.Forms.MenuStrip();
            this.calcularIdadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abaCalculo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abaCalculo2 = new System.Windows.Forms.ToolStripMenuItem();
            this.abaDatasFuturas = new System.Windows.Forms.ToolStripMenuItem();
            this.abaDatasPassadas = new System.Windows.Forms.ToolStripMenuItem();
            this.abaPesquisarData = new System.Windows.Forms.ToolStripMenuItem();
            this.abaOutros = new System.Windows.Forms.ToolStripMenuItem();
            this.abaSairForm6 = new System.Windows.Forms.ToolStripMenuItem();
            this.gpBoxCal1 = new System.Windows.Forms.GroupBox();
            this.btLimpar5 = new System.Windows.Forms.Button();
            this.labDataNasc = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.gpBoxCalc2 = new System.Windows.Forms.GroupBox();
            this.btLimpar4 = new System.Windows.Forms.Button();
            this.segData = new System.Windows.Forms.Label();
            this.primData = new System.Windows.Forms.Label();
            this.btCalcular2 = new System.Windows.Forms.Button();
            this.txtData3 = new System.Windows.Forms.MaskedTextBox();
            this.txtData2 = new System.Windows.Forms.MaskedTextBox();
            this.checkDias = new System.Windows.Forms.CheckBox();
            this.checkSem = new System.Windows.Forms.CheckBox();
            this.checkMeses = new System.Windows.Forms.CheckBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtSemanas = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.dataDePart = new System.Windows.Forms.Label();
            this.txtData4 = new System.Windows.Forms.MaskedTextBox();
            this.btCalcular3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpBoxCalc3 = new System.Windows.Forms.GroupBox();
            this.btLimpar3 = new System.Windows.Forms.Button();
            this.gpBoxCalc4 = new System.Windows.Forms.GroupBox();
            this.btLimpar2 = new System.Windows.Forms.Button();
            this.checkDias2 = new System.Windows.Forms.CheckBox();
            this.labSubtrair = new System.Windows.Forms.Label();
            this.checkSem2 = new System.Windows.Forms.CheckBox();
            this.btCalcular4 = new System.Windows.Forms.Button();
            this.checkMeses2 = new System.Windows.Forms.CheckBox();
            this.txtData5 = new System.Windows.Forms.MaskedTextBox();
            this.txtDias2 = new System.Windows.Forms.TextBox();
            this.dataPart2 = new System.Windows.Forms.Label();
            this.txtSemanas2 = new System.Windows.Forms.TextBox();
            this.txtMeses2 = new System.Windows.Forms.TextBox();
            this.gpBoxCalc5 = new System.Windows.Forms.GroupBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.labDataPesq = new System.Windows.Forms.Label();
            this.txtData6 = new System.Windows.Forms.MaskedTextBox();
            this.btCalcular5 = new System.Windows.Forms.Button();
            this.cbBoxDatas = new System.Windows.Forms.ComboBox();
            this.lstBoxCalen = new System.Windows.Forms.ListBox();
            this.gpBoxCalc6 = new System.Windows.Forms.GroupBox();
            this.menuCalc.SuspendLayout();
            this.gpBoxCal1.SuspendLayout();
            this.gpBoxCalc2.SuspendLayout();
            this.gpBoxCalc3.SuspendLayout();
            this.gpBoxCalc4.SuspendLayout();
            this.gpBoxCalc5.SuspendLayout();
            this.gpBoxCalc6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuCalc
            // 
            this.menuCalc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularIdadeToolStripMenuItem,
            this.abaSairForm6});
            this.menuCalc.Location = new System.Drawing.Point(0, 0);
            this.menuCalc.Name = "menuCalc";
            this.menuCalc.Size = new System.Drawing.Size(296, 24);
            this.menuCalc.TabIndex = 1;
            this.menuCalc.Text = "menuStrip1";
            // 
            // calcularIdadeToolStripMenuItem
            // 
            this.calcularIdadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abaCalculo1,
            this.abaCalculo2,
            this.abaDatasFuturas,
            this.abaDatasPassadas,
            this.abaPesquisarData,
            this.abaOutros});
            this.calcularIdadeToolStripMenuItem.Name = "calcularIdadeToolStripMenuItem";
            this.calcularIdadeToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.calcularIdadeToolStripMenuItem.Text = "Calculos";
            // 
            // abaCalculo1
            // 
            this.abaCalculo1.Name = "abaCalculo1";
            this.abaCalculo1.Size = new System.Drawing.Size(175, 22);
            this.abaCalculo1.Text = "Idade Exata";
            this.abaCalculo1.Click += new System.EventHandler(this.abaCalculo1_Click);
            // 
            // abaCalculo2
            // 
            this.abaCalculo2.Name = "abaCalculo2";
            this.abaCalculo2.Size = new System.Drawing.Size(175, 22);
            this.abaCalculo2.Text = "Diferença de datas";
            this.abaCalculo2.Click += new System.EventHandler(this.abaCalculo2_Click);
            // 
            // abaDatasFuturas
            // 
            this.abaDatasFuturas.Name = "abaDatasFuturas";
            this.abaDatasFuturas.Size = new System.Drawing.Size(175, 22);
            this.abaDatasFuturas.Text = "Datas Futuras";
            this.abaDatasFuturas.Click += new System.EventHandler(this.abaDatasFuturas_Click);
            // 
            // abaDatasPassadas
            // 
            this.abaDatasPassadas.Name = "abaDatasPassadas";
            this.abaDatasPassadas.Size = new System.Drawing.Size(175, 22);
            this.abaDatasPassadas.Text = "Datas Passadas";
            this.abaDatasPassadas.Click += new System.EventHandler(this.abaDatasPassadas_Click);
            // 
            // abaPesquisarData
            // 
            this.abaPesquisarData.Name = "abaPesquisarData";
            this.abaPesquisarData.Size = new System.Drawing.Size(175, 22);
            this.abaPesquisarData.Text = "Pesquisar dados";
            this.abaPesquisarData.Click += new System.EventHandler(this.abaPesquisarData_Click);
            // 
            // abaOutros
            // 
            this.abaOutros.Name = "abaOutros";
            this.abaOutros.Size = new System.Drawing.Size(175, 22);
            this.abaOutros.Text = "Outros Calendários";
            this.abaOutros.Click += new System.EventHandler(this.abaOutros_Click);
            // 
            // abaSairForm6
            // 
            this.abaSairForm6.Name = "abaSairForm6";
            this.abaSairForm6.Size = new System.Drawing.Size(38, 20);
            this.abaSairForm6.Text = "Sair";
            this.abaSairForm6.Click += new System.EventHandler(this.abaSairForm6_Click);
            // 
            // gpBoxCal1
            // 
            this.gpBoxCal1.Controls.Add(this.btLimpar5);
            this.gpBoxCal1.Controls.Add(this.labDataNasc);
            this.gpBoxCal1.Controls.Add(this.txtData);
            this.gpBoxCal1.Controls.Add(this.btCalcular);
            this.gpBoxCal1.Location = new System.Drawing.Point(13, 27);
            this.gpBoxCal1.Name = "gpBoxCal1";
            this.gpBoxCal1.Size = new System.Drawing.Size(267, 76);
            this.gpBoxCal1.TabIndex = 2;
            this.gpBoxCal1.TabStop = false;
            this.gpBoxCal1.Text = "Idade Exata";
            this.gpBoxCal1.Visible = false;
            this.gpBoxCal1.Enter += new System.EventHandler(this.gpBoxCal1_Enter);
            // 
            // btLimpar5
            // 
            this.btLimpar5.Location = new System.Drawing.Point(105, 47);
            this.btLimpar5.Name = "btLimpar5";
            this.btLimpar5.Size = new System.Drawing.Size(75, 23);
            this.btLimpar5.TabIndex = 5;
            this.btLimpar5.Text = "Limpar";
            this.btLimpar5.UseVisualStyleBackColor = true;
            this.btLimpar5.Click += new System.EventHandler(this.btLimpar5_Click);
            // 
            // labDataNasc
            // 
            this.labDataNasc.AutoSize = true;
            this.labDataNasc.Location = new System.Drawing.Point(7, 25);
            this.labDataNasc.Name = "labDataNasc";
            this.labDataNasc.Size = new System.Drawing.Size(104, 13);
            this.labDataNasc.TabIndex = 2;
            this.labDataNasc.Text = "Data de Nascimento";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(117, 19);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 0;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(186, 47);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 1;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // gpBoxCalc2
            // 
            this.gpBoxCalc2.Controls.Add(this.btLimpar4);
            this.gpBoxCalc2.Controls.Add(this.segData);
            this.gpBoxCalc2.Controls.Add(this.primData);
            this.gpBoxCalc2.Controls.Add(this.btCalcular2);
            this.gpBoxCalc2.Controls.Add(this.txtData3);
            this.gpBoxCalc2.Controls.Add(this.txtData2);
            this.gpBoxCalc2.Location = new System.Drawing.Point(7, 27);
            this.gpBoxCalc2.Name = "gpBoxCalc2";
            this.gpBoxCalc2.Size = new System.Drawing.Size(273, 100);
            this.gpBoxCalc2.TabIndex = 3;
            this.gpBoxCalc2.TabStop = false;
            this.gpBoxCalc2.Text = "Diferença entre datas";
            this.gpBoxCalc2.Visible = false;
            // 
            // btLimpar4
            // 
            this.btLimpar4.Location = new System.Drawing.Point(105, 71);
            this.btLimpar4.Name = "btLimpar4";
            this.btLimpar4.Size = new System.Drawing.Size(75, 23);
            this.btLimpar4.TabIndex = 4;
            this.btLimpar4.Text = "Limpar";
            this.btLimpar4.UseVisualStyleBackColor = true;
            this.btLimpar4.Click += new System.EventHandler(this.btLimpar4_Click);
            // 
            // segData
            // 
            this.segData.AutoSize = true;
            this.segData.Location = new System.Drawing.Point(6, 48);
            this.segData.Name = "segData";
            this.segData.Size = new System.Drawing.Size(74, 13);
            this.segData.TabIndex = 4;
            this.segData.Text = "Segunda data";
            // 
            // primData
            // 
            this.primData.AutoSize = true;
            this.primData.Location = new System.Drawing.Point(7, 22);
            this.primData.Name = "primData";
            this.primData.Size = new System.Drawing.Size(68, 13);
            this.primData.TabIndex = 3;
            this.primData.Text = "Primeira data";
            // 
            // btCalcular2
            // 
            this.btCalcular2.Location = new System.Drawing.Point(186, 71);
            this.btCalcular2.Name = "btCalcular2";
            this.btCalcular2.Size = new System.Drawing.Size(75, 23);
            this.btCalcular2.TabIndex = 2;
            this.btCalcular2.Text = "Calcular";
            this.btCalcular2.UseVisualStyleBackColor = true;
            this.btCalcular2.Click += new System.EventHandler(this.btCalcular2_Click);
            // 
            // txtData3
            // 
            this.txtData3.Location = new System.Drawing.Point(81, 45);
            this.txtData3.Mask = "00/00/0000";
            this.txtData3.Name = "txtData3";
            this.txtData3.Size = new System.Drawing.Size(100, 20);
            this.txtData3.TabIndex = 1;
            // 
            // txtData2
            // 
            this.txtData2.Location = new System.Drawing.Point(81, 19);
            this.txtData2.Mask = "00/00/0000";
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(100, 20);
            this.txtData2.TabIndex = 0;
            // 
            // checkDias
            // 
            this.checkDias.AutoSize = true;
            this.checkDias.Location = new System.Drawing.Point(21, 74);
            this.checkDias.Name = "checkDias";
            this.checkDias.Size = new System.Drawing.Size(47, 17);
            this.checkDias.TabIndex = 4;
            this.checkDias.Text = "Dias";
            this.checkDias.UseVisualStyleBackColor = true;
            // 
            // checkSem
            // 
            this.checkSem.AutoSize = true;
            this.checkSem.Location = new System.Drawing.Point(21, 101);
            this.checkSem.Name = "checkSem";
            this.checkSem.Size = new System.Drawing.Size(70, 17);
            this.checkSem.TabIndex = 5;
            this.checkSem.Text = "Semanas";
            this.checkSem.UseVisualStyleBackColor = true;
            // 
            // checkMeses
            // 
            this.checkMeses.AutoSize = true;
            this.checkMeses.Location = new System.Drawing.Point(21, 128);
            this.checkMeses.Name = "checkMeses";
            this.checkMeses.Size = new System.Drawing.Size(57, 17);
            this.checkMeses.TabIndex = 6;
            this.checkMeses.Text = "Meses";
            this.checkMeses.UseVisualStyleBackColor = true;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(108, 72);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(40, 20);
            this.txtDias.TabIndex = 7;
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumeric);
            // 
            // txtSemanas
            // 
            this.txtSemanas.Location = new System.Drawing.Point(108, 99);
            this.txtSemanas.Name = "txtSemanas";
            this.txtSemanas.Size = new System.Drawing.Size(40, 20);
            this.txtSemanas.TabIndex = 8;
            this.txtSemanas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumeric);
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(108, 126);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(40, 20);
            this.txtMeses.TabIndex = 9;
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumeric);
            // 
            // dataDePart
            // 
            this.dataDePart.AutoSize = true;
            this.dataDePart.Location = new System.Drawing.Point(8, 24);
            this.dataDePart.Name = "dataDePart";
            this.dataDePart.Size = new System.Drawing.Size(83, 13);
            this.dataDePart.TabIndex = 10;
            this.dataDePart.Text = "Data de partida ";
            // 
            // txtData4
            // 
            this.txtData4.Location = new System.Drawing.Point(117, 19);
            this.txtData4.Mask = "00/00/0000";
            this.txtData4.Name = "txtData4";
            this.txtData4.Size = new System.Drawing.Size(100, 20);
            this.txtData4.TabIndex = 3;
            // 
            // btCalcular3
            // 
            this.btCalcular3.Location = new System.Drawing.Point(192, 155);
            this.btCalcular3.Name = "btCalcular3";
            this.btCalcular3.Size = new System.Drawing.Size(75, 23);
            this.btCalcular3.TabIndex = 3;
            this.btCalcular3.Text = "Calcular";
            this.btCalcular3.UseVisualStyleBackColor = true;
            this.btCalcular3.Click += new System.EventHandler(this.btCalcular3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Acrescentar:";
            // 
            // gpBoxCalc3
            // 
            this.gpBoxCalc3.Controls.Add(this.btLimpar3);
            this.gpBoxCalc3.Controls.Add(this.checkDias);
            this.gpBoxCalc3.Controls.Add(this.label1);
            this.gpBoxCalc3.Controls.Add(this.checkSem);
            this.gpBoxCalc3.Controls.Add(this.btCalcular3);
            this.gpBoxCalc3.Controls.Add(this.checkMeses);
            this.gpBoxCalc3.Controls.Add(this.txtData4);
            this.gpBoxCalc3.Controls.Add(this.txtDias);
            this.gpBoxCalc3.Controls.Add(this.dataDePart);
            this.gpBoxCalc3.Controls.Add(this.txtSemanas);
            this.gpBoxCalc3.Controls.Add(this.txtMeses);
            this.gpBoxCalc3.Location = new System.Drawing.Point(7, 27);
            this.gpBoxCalc3.Name = "gpBoxCalc3";
            this.gpBoxCalc3.Size = new System.Drawing.Size(279, 195);
            this.gpBoxCalc3.TabIndex = 12;
            this.gpBoxCalc3.TabStop = false;
            this.gpBoxCalc3.Text = "Datas Futuras";
            this.gpBoxCalc3.Visible = false;
            this.gpBoxCalc3.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btLimpar3
            // 
            this.btLimpar3.Location = new System.Drawing.Point(111, 155);
            this.btLimpar3.Name = "btLimpar3";
            this.btLimpar3.Size = new System.Drawing.Size(75, 23);
            this.btLimpar3.TabIndex = 12;
            this.btLimpar3.Text = "Limpar";
            this.btLimpar3.UseVisualStyleBackColor = true;
            this.btLimpar3.Click += new System.EventHandler(this.btLimpar3_Click);
            // 
            // gpBoxCalc4
            // 
            this.gpBoxCalc4.Controls.Add(this.btLimpar2);
            this.gpBoxCalc4.Controls.Add(this.checkDias2);
            this.gpBoxCalc4.Controls.Add(this.labSubtrair);
            this.gpBoxCalc4.Controls.Add(this.checkSem2);
            this.gpBoxCalc4.Controls.Add(this.btCalcular4);
            this.gpBoxCalc4.Controls.Add(this.checkMeses2);
            this.gpBoxCalc4.Controls.Add(this.txtData5);
            this.gpBoxCalc4.Controls.Add(this.txtDias2);
            this.gpBoxCalc4.Controls.Add(this.dataPart2);
            this.gpBoxCalc4.Controls.Add(this.txtSemanas2);
            this.gpBoxCalc4.Controls.Add(this.txtMeses2);
            this.gpBoxCalc4.Location = new System.Drawing.Point(7, 27);
            this.gpBoxCalc4.Name = "gpBoxCalc4";
            this.gpBoxCalc4.Size = new System.Drawing.Size(279, 195);
            this.gpBoxCalc4.TabIndex = 13;
            this.gpBoxCalc4.TabStop = false;
            this.gpBoxCalc4.Text = "Datas Passadas";
            this.gpBoxCalc4.Visible = false;
            // 
            // btLimpar2
            // 
            this.btLimpar2.Location = new System.Drawing.Point(112, 155);
            this.btLimpar2.Name = "btLimpar2";
            this.btLimpar2.Size = new System.Drawing.Size(75, 23);
            this.btLimpar2.TabIndex = 4;
            this.btLimpar2.Text = "Limpar";
            this.btLimpar2.UseVisualStyleBackColor = true;
            this.btLimpar2.Click += new System.EventHandler(this.btLimpar2_Click);
            // 
            // checkDias2
            // 
            this.checkDias2.AutoSize = true;
            this.checkDias2.Location = new System.Drawing.Point(21, 74);
            this.checkDias2.Name = "checkDias2";
            this.checkDias2.Size = new System.Drawing.Size(47, 17);
            this.checkDias2.TabIndex = 4;
            this.checkDias2.Text = "Dias";
            this.checkDias2.UseVisualStyleBackColor = true;
            // 
            // labSubtrair
            // 
            this.labSubtrair.AutoSize = true;
            this.labSubtrair.Location = new System.Drawing.Point(8, 49);
            this.labSubtrair.Name = "labSubtrair";
            this.labSubtrair.Size = new System.Drawing.Size(46, 13);
            this.labSubtrair.TabIndex = 11;
            this.labSubtrair.Text = "Subtrair:";
            // 
            // checkSem2
            // 
            this.checkSem2.AutoSize = true;
            this.checkSem2.Location = new System.Drawing.Point(21, 101);
            this.checkSem2.Name = "checkSem2";
            this.checkSem2.Size = new System.Drawing.Size(70, 17);
            this.checkSem2.TabIndex = 5;
            this.checkSem2.Text = "Semanas";
            this.checkSem2.UseVisualStyleBackColor = true;
            // 
            // btCalcular4
            // 
            this.btCalcular4.Location = new System.Drawing.Point(193, 155);
            this.btCalcular4.Name = "btCalcular4";
            this.btCalcular4.Size = new System.Drawing.Size(75, 23);
            this.btCalcular4.TabIndex = 3;
            this.btCalcular4.Text = "Calcular";
            this.btCalcular4.UseVisualStyleBackColor = true;
            this.btCalcular4.Click += new System.EventHandler(this.btCalcular4_Click);
            // 
            // checkMeses2
            // 
            this.checkMeses2.AutoSize = true;
            this.checkMeses2.Location = new System.Drawing.Point(21, 128);
            this.checkMeses2.Name = "checkMeses2";
            this.checkMeses2.Size = new System.Drawing.Size(57, 17);
            this.checkMeses2.TabIndex = 6;
            this.checkMeses2.Text = "Meses";
            this.checkMeses2.UseVisualStyleBackColor = true;
            // 
            // txtData5
            // 
            this.txtData5.Location = new System.Drawing.Point(117, 19);
            this.txtData5.Mask = "00/00/0000";
            this.txtData5.Name = "txtData5";
            this.txtData5.Size = new System.Drawing.Size(100, 20);
            this.txtData5.TabIndex = 3;
            // 
            // txtDias2
            // 
            this.txtDias2.Location = new System.Drawing.Point(108, 72);
            this.txtDias2.Name = "txtDias2";
            this.txtDias2.Size = new System.Drawing.Size(40, 20);
            this.txtDias2.TabIndex = 7;
            this.txtDias2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumeric);
            // 
            // dataPart2
            // 
            this.dataPart2.AutoSize = true;
            this.dataPart2.Location = new System.Drawing.Point(8, 24);
            this.dataPart2.Name = "dataPart2";
            this.dataPart2.Size = new System.Drawing.Size(83, 13);
            this.dataPart2.TabIndex = 10;
            this.dataPart2.Text = "Data de partida ";
            // 
            // txtSemanas2
            // 
            this.txtSemanas2.Location = new System.Drawing.Point(108, 99);
            this.txtSemanas2.Name = "txtSemanas2";
            this.txtSemanas2.Size = new System.Drawing.Size(40, 20);
            this.txtSemanas2.TabIndex = 8;
            this.txtSemanas2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumeric);
            // 
            // txtMeses2
            // 
            this.txtMeses2.Location = new System.Drawing.Point(108, 126);
            this.txtMeses2.Name = "txtMeses2";
            this.txtMeses2.Size = new System.Drawing.Size(40, 20);
            this.txtMeses2.TabIndex = 9;
            this.txtMeses2.TextChanged += new System.EventHandler(this.txtMeses2_TextChanged);
            this.txtMeses2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumeric);
            // 
            // gpBoxCalc5
            // 
            this.gpBoxCalc5.Controls.Add(this.btLimpar);
            this.gpBoxCalc5.Controls.Add(this.labDataPesq);
            this.gpBoxCalc5.Controls.Add(this.txtData6);
            this.gpBoxCalc5.Controls.Add(this.btCalcular5);
            this.gpBoxCalc5.Location = new System.Drawing.Point(12, 21);
            this.gpBoxCalc5.Name = "gpBoxCalc5";
            this.gpBoxCalc5.Size = new System.Drawing.Size(274, 76);
            this.gpBoxCalc5.TabIndex = 14;
            this.gpBoxCalc5.TabStop = false;
            this.gpBoxCalc5.Text = "Pesquisar informações de data";
            this.gpBoxCalc5.Visible = false;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(105, 47);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 3;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // labDataPesq
            // 
            this.labDataPesq.AutoSize = true;
            this.labDataPesq.Location = new System.Drawing.Point(7, 25);
            this.labDataPesq.Name = "labDataPesq";
            this.labDataPesq.Size = new System.Drawing.Size(90, 13);
            this.labDataPesq.TabIndex = 2;
            this.labDataPesq.Text = "Data de interesse";
            // 
            // txtData6
            // 
            this.txtData6.Location = new System.Drawing.Point(117, 22);
            this.txtData6.Mask = "00/00/0000";
            this.txtData6.Name = "txtData6";
            this.txtData6.Size = new System.Drawing.Size(100, 20);
            this.txtData6.TabIndex = 0;
            // 
            // btCalcular5
            // 
            this.btCalcular5.Location = new System.Drawing.Point(186, 47);
            this.btCalcular5.Name = "btCalcular5";
            this.btCalcular5.Size = new System.Drawing.Size(75, 23);
            this.btCalcular5.TabIndex = 1;
            this.btCalcular5.Text = "Calcular";
            this.btCalcular5.UseVisualStyleBackColor = true;
            this.btCalcular5.Click += new System.EventHandler(this.btCalcular5_Click);
            // 
            // cbBoxDatas
            // 
            this.cbBoxDatas.FormattingEnabled = true;
            this.cbBoxDatas.Items.AddRange(new object[] {
            "30/04/1993",
            "17/08/1998",
            "01/02/2022",
            "01/01/2011",
            "12/12/2012",
            "23/10/1994",
            "05/07/2018"});
            this.cbBoxDatas.Location = new System.Drawing.Point(6, 15);
            this.cbBoxDatas.Name = "cbBoxDatas";
            this.cbBoxDatas.Size = new System.Drawing.Size(167, 21);
            this.cbBoxDatas.TabIndex = 15;
            this.cbBoxDatas.SelectedIndexChanged += new System.EventHandler(this.cbBoxDatas_SelectedIndexChanged);
            // 
            // lstBoxCalen
            // 
            this.lstBoxCalen.FormattingEnabled = true;
            this.lstBoxCalen.Location = new System.Drawing.Point(6, 42);
            this.lstBoxCalen.Name = "lstBoxCalen";
            this.lstBoxCalen.Size = new System.Drawing.Size(167, 69);
            this.lstBoxCalen.TabIndex = 16;
            // 
            // gpBoxCalc6
            // 
            this.gpBoxCalc6.Controls.Add(this.lstBoxCalen);
            this.gpBoxCalc6.Controls.Add(this.cbBoxDatas);
            this.gpBoxCalc6.Location = new System.Drawing.Point(8, 26);
            this.gpBoxCalc6.Name = "gpBoxCalc6";
            this.gpBoxCalc6.Size = new System.Drawing.Size(185, 119);
            this.gpBoxCalc6.TabIndex = 17;
            this.gpBoxCalc6.TabStop = false;
            this.gpBoxCalc6.Text = "Outros Calendarios";
            this.gpBoxCalc6.Visible = false;
            this.gpBoxCalc6.Enter += new System.EventHandler(this.gpBoxCalc6_Enter);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 236);
            this.Controls.Add(this.gpBoxCalc5);
            this.Controls.Add(this.gpBoxCalc3);
            this.Controls.Add(this.gpBoxCalc2);
            this.Controls.Add(this.gpBoxCal1);
            this.Controls.Add(this.menuCalc);
            this.Controls.Add(this.gpBoxCalc6);
            this.Controls.Add(this.gpBoxCalc4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuCalc;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculadora de datas";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuCalc.ResumeLayout(false);
            this.menuCalc.PerformLayout();
            this.gpBoxCal1.ResumeLayout(false);
            this.gpBoxCal1.PerformLayout();
            this.gpBoxCalc2.ResumeLayout(false);
            this.gpBoxCalc2.PerformLayout();
            this.gpBoxCalc3.ResumeLayout(false);
            this.gpBoxCalc3.PerformLayout();
            this.gpBoxCalc4.ResumeLayout(false);
            this.gpBoxCalc4.PerformLayout();
            this.gpBoxCalc5.ResumeLayout(false);
            this.gpBoxCalc5.PerformLayout();
            this.gpBoxCalc6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuCalc;
        private System.Windows.Forms.ToolStripMenuItem abaSairForm6;
        private System.Windows.Forms.GroupBox gpBoxCal1;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.ToolStripMenuItem calcularIdadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abaCalculo1;
        private System.Windows.Forms.Label labDataNasc;
        private System.Windows.Forms.ToolStripMenuItem abaCalculo2;
        private System.Windows.Forms.GroupBox gpBoxCalc2;
        private System.Windows.Forms.Button btCalcular2;
        private System.Windows.Forms.MaskedTextBox txtData3;
        private System.Windows.Forms.MaskedTextBox txtData2;
        private System.Windows.Forms.Label segData;
        private System.Windows.Forms.Label primData;
        private System.Windows.Forms.CheckBox checkDias;
        private System.Windows.Forms.CheckBox checkSem;
        private System.Windows.Forms.CheckBox checkMeses;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtSemanas;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label dataDePart;
        private System.Windows.Forms.MaskedTextBox txtData4;
        private System.Windows.Forms.Button btCalcular3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpBoxCalc3;
        private System.Windows.Forms.GroupBox gpBoxCalc4;
        private System.Windows.Forms.CheckBox checkDias2;
        private System.Windows.Forms.Label labSubtrair;
        private System.Windows.Forms.CheckBox checkSem2;
        private System.Windows.Forms.Button btCalcular4;
        private System.Windows.Forms.CheckBox checkMeses2;
        private System.Windows.Forms.MaskedTextBox txtData5;
        private System.Windows.Forms.TextBox txtDias2;
        private System.Windows.Forms.Label dataPart2;
        private System.Windows.Forms.TextBox txtSemanas2;
        private System.Windows.Forms.TextBox txtMeses2;
        private System.Windows.Forms.GroupBox gpBoxCalc5;
        private System.Windows.Forms.Label labDataPesq;
        private System.Windows.Forms.MaskedTextBox txtData6;
        private System.Windows.Forms.Button btCalcular5;
        private System.Windows.Forms.ToolStripMenuItem abaDatasFuturas;
        private System.Windows.Forms.ToolStripMenuItem abaDatasPassadas;
        private System.Windows.Forms.ToolStripMenuItem abaPesquisarData;
        private System.Windows.Forms.ComboBox cbBoxDatas;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btLimpar2;
        private System.Windows.Forms.Button btLimpar3;
        private System.Windows.Forms.Button btLimpar4;
        private System.Windows.Forms.Button btLimpar5;
        private System.Windows.Forms.ListBox lstBoxCalen;
        private System.Windows.Forms.GroupBox gpBoxCalc6;
        private System.Windows.Forms.ToolStripMenuItem abaOutros;
    }
}