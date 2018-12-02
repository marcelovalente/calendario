namespace PIB_EG
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abaLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.abaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plataformaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abaSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abaLogin,
            this.abaSobre,
            this.abaSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abaLogin
            // 
            this.abaLogin.Name = "abaLogin";
            this.abaLogin.Size = new System.Drawing.Size(49, 20);
            this.abaLogin.Text = "Login";
            this.abaLogin.Click += new System.EventHandler(this.abaLogin_Click);
            // 
            // abaSobre
            // 
            this.abaSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objetivosToolStripMenuItem,
            this.funcionalidadesToolStripMenuItem,
            this.desenvolvedoresToolStripMenuItem,
            this.plataformaToolStripMenuItem,
            this.versãoToolStripMenuItem});
            this.abaSobre.Name = "abaSobre";
            this.abaSobre.Size = new System.Drawing.Size(49, 20);
            this.abaSobre.Text = "Sobre";
            // 
            // objetivosToolStripMenuItem
            // 
            this.objetivosToolStripMenuItem.Name = "objetivosToolStripMenuItem";
            this.objetivosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.objetivosToolStripMenuItem.Text = "Objetivos";
            this.objetivosToolStripMenuItem.Click += new System.EventHandler(this.abaSobre_Click);
            // 
            // funcionalidadesToolStripMenuItem
            // 
            this.funcionalidadesToolStripMenuItem.Name = "funcionalidadesToolStripMenuItem";
            this.funcionalidadesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.funcionalidadesToolStripMenuItem.Text = "Funcionalidades";
            this.funcionalidadesToolStripMenuItem.Click += new System.EventHandler(this.abaSobre_Click);
            // 
            // desenvolvedoresToolStripMenuItem
            // 
            this.desenvolvedoresToolStripMenuItem.Name = "desenvolvedoresToolStripMenuItem";
            this.desenvolvedoresToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.desenvolvedoresToolStripMenuItem.Text = "Desenvolvedores";
            this.desenvolvedoresToolStripMenuItem.Click += new System.EventHandler(this.abaSobre_Click);
            // 
            // plataformaToolStripMenuItem
            // 
            this.plataformaToolStripMenuItem.Name = "plataformaToolStripMenuItem";
            this.plataformaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.plataformaToolStripMenuItem.Text = "Plataforma";
            this.plataformaToolStripMenuItem.Click += new System.EventHandler(this.abaSobre_Click);
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            this.versãoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.versãoToolStripMenuItem.Text = "Versão";
            this.versãoToolStripMenuItem.Click += new System.EventHandler(this.abaSobre_Click);
            // 
            // abaSair
            // 
            this.abaSair.Name = "abaSair";
            this.abaSair.Size = new System.Drawing.Size(38, 20);
            this.abaSair.Text = "Sair";
            this.abaSair.Click += new System.EventHandler(this.abaSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(608, 355);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Painel principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abaLogin;
        private System.Windows.Forms.ToolStripMenuItem abaSobre;
        private System.Windows.Forms.ToolStripMenuItem abaSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem objetivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plataformaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
    }
}

