namespace PIB_EG
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.maskedTxt_DataNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btn_NewPass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.novaSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblQualidade = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.redigitSenha = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboNivel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTxt_DataNasc
            // 
            this.maskedTxt_DataNasc.Location = new System.Drawing.Point(122, 78);
            this.maskedTxt_DataNasc.Mask = "00/00/0000";
            this.maskedTxt_DataNasc.Name = "maskedTxt_DataNasc";
            this.maskedTxt_DataNasc.Size = new System.Drawing.Size(75, 20);
            this.maskedTxt_DataNasc.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btn_NewPass
            // 
            this.btn_NewPass.Enabled = false;
            this.btn_NewPass.Location = new System.Drawing.Point(125, 221);
            this.btn_NewPass.Name = "btn_NewPass";
            this.btn_NewPass.Size = new System.Drawing.Size(75, 23);
            this.btn_NewPass.TabIndex = 9;
            this.btn_NewPass.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.btn_NewPass, "Digite todos os dados");
            this.btn_NewPass.UseVisualStyleBackColor = true;
            this.btn_NewPass.Click += new System.EventHandler(this.btn_NewPass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data de Nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código do usuário:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 104);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(338, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(122, 26);
            this.txtUsuario.MaxLength = 6;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(91, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Senha:";
            // 
            // novaSenha
            // 
            this.novaSenha.Location = new System.Drawing.Point(122, 164);
            this.novaSenha.MaxLength = 999;
            this.novaSenha.Name = "novaSenha";
            this.novaSenha.PasswordChar = '*';
            this.novaSenha.Size = new System.Drawing.Size(105, 20);
            this.novaSenha.TabIndex = 8;
            this.novaSenha.TextChanged += new System.EventHandler(this.novaSenha_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Nome do usuário:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 52);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(91, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Location = new System.Drawing.Point(244, 167);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(81, 13);
            this.lblQualidade.TabIndex = 35;
            this.lblQualidade.Text = "Força da senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Confirmar senha:";
            // 
            // redigitSenha
            // 
            this.redigitSenha.Location = new System.Drawing.Point(122, 190);
            this.redigitSenha.MaxLength = 999;
            this.redigitSenha.Name = "redigitSenha";
            this.redigitSenha.PasswordChar = '*';
            this.redigitSenha.Size = new System.Drawing.Size(105, 20);
            this.redigitSenha.TabIndex = 9;
            this.redigitSenha.TextChanged += new System.EventHandler(this.confSenha);
            // 
            // comboNivel
            // 
            this.comboNivel.FormattingEnabled = true;
            this.comboNivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboNivel.Location = new System.Drawing.Point(122, 133);
            this.comboNivel.Name = "comboNivel";
            this.comboNivel.Size = new System.Drawing.Size(39, 21);
            this.comboNivel.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nível de acesso:";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 261);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboNivel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.redigitSenha);
            this.Controls.Add(this.lblQualidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.novaSenha);
            this.Controls.Add(this.maskedTxt_DataNasc);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btn_NewPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTxt_DataNasc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btn_NewPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox novaSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblQualidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox redigitSenha;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboNivel;
        private System.Windows.Forms.Label label9;
    }
}