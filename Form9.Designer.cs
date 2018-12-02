namespace PIB_EG
{
    partial class Form9
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
            this.codProduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoProduto = new System.Windows.Forms.TextBox();
            this.nomeProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qtdeLimite = new System.Windows.Forms.TextBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codProduto
            // 
            this.codProduto.AutoSize = true;
            this.codProduto.Location = new System.Drawing.Point(27, 29);
            this.codProduto.Name = "codProduto";
            this.codProduto.Size = new System.Drawing.Size(94, 13);
            this.codProduto.TabIndex = 0;
            this.codProduto.Text = "Código do produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do produto";
            // 
            // codigoProduto
            // 
            this.codigoProduto.Location = new System.Drawing.Point(127, 26);
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.Size = new System.Drawing.Size(100, 20);
            this.codigoProduto.TabIndex = 1;
            // 
            // nomeProduto
            // 
            this.nomeProduto.Location = new System.Drawing.Point(127, 53);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(405, 20);
            this.nomeProduto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade limite";
            // 
            // qtdeLimite
            // 
            this.qtdeLimite.Location = new System.Drawing.Point(127, 79);
            this.qtdeLimite.Name = "qtdeLimite";
            this.qtdeLimite.Size = new System.Drawing.Size(49, 20);
            this.qtdeLimite.TabIndex = 4;
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(127, 117);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 8;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.qtdeLimite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomeProduto);
            this.Controls.Add(this.codigoProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codProduto);
            this.Name = "Form9";
            this.Text = "Cadastrar produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoProduto;
        private System.Windows.Forms.TextBox nomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtdeLimite;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button button1;
    }
}