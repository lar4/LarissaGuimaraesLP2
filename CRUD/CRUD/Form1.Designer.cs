namespace CRUD
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
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPÇÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPÇÃOToolStripMenuItem,
            this.sAIRToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPÇÃOToolStripMenuItem
            // 
            this.oPÇÃOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFunToolStripMenuItem});
            this.oPÇÃOToolStripMenuItem.Name = "oPÇÃOToolStripMenuItem";
            this.oPÇÃOToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.oPÇÃOToolStripMenuItem.Text = "OPÇÃO";
            // 
            // addFunToolStripMenuItem
            // 
            this.addFunToolStripMenuItem.Name = "addFunToolStripMenuItem";
            this.addFunToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addFunToolStripMenuItem.Text = "Add Funcionario";
            this.addFunToolStripMenuItem.Click += new System.EventHandler(this.addFunToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem1
            // 
            this.sAIRToolStripMenuItem1.Name = "sAIRToolStripMenuItem1";
            this.sAIRToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.sAIRToolStripMenuItem1.Text = "SAIR";
            this.sAIRToolStripMenuItem1.Click += new System.EventHandler(this.sAIRToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPÇÃOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem1;
    }
}

