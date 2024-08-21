namespace SeboBoaLeitura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuAplicacao = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarLivrosToolStripMenuItem = new ToolStripMenuItem();
            MenuAplicacao.SuspendLayout();
            SuspendLayout();
            // 
            // MenuAplicacao
            // 
            MenuAplicacao.ImageScalingSize = new Size(20, 20);
            MenuAplicacao.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            MenuAplicacao.Location = new Point(0, 0);
            MenuAplicacao.Name = "MenuAplicacao";
            MenuAplicacao.Size = new Size(800, 28);
            MenuAplicacao.TabIndex = 1;
            MenuAplicacao.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarLivrosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarLivrosToolStripMenuItem
            // 
            cadastrarLivrosToolStripMenuItem.Name = "cadastrarLivrosToolStripMenuItem";
            cadastrarLivrosToolStripMenuItem.Size = new Size(224, 26);
            cadastrarLivrosToolStripMenuItem.Text = "Cadastrar Livros";
            cadastrarLivrosToolStripMenuItem.Click += cadastrarLivrosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuAplicacao);
            IsMdiContainer = true;
            MainMenuStrip = MenuAplicacao;
            Name = "Form1";
            Text = "Sebo Boa Leitura";
            WindowState = FormWindowState.Maximized;
            MenuAplicacao.ResumeLayout(false);
            MenuAplicacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuAplicacao;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastrarLivrosToolStripMenuItem;
    }
}
