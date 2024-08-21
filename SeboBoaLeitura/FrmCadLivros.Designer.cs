namespace SeboBoaLeitura
{
    partial class FrmCadLivros
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
            BarraFerramentasLivros = new ToolStrip();
            TSBtnNovo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TSBtnSalvar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TSBtnListar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            LblTitulo = new Label();
            TxtTitulo = new TextBox();
            TxtAutor = new TextBox();
            LblAutor = new Label();
            TxtEditora = new TextBox();
            LblEditora = new Label();
            LblCategoria = new Label();
            CmbCategoria = new ComboBox();
            GrpbTipoLivro = new GroupBox();
            RdUsado = new RadioButton();
            RdNovo = new RadioButton();
            TxtAno = new TextBox();
            LblAno = new Label();
            TxtPreco = new TextBox();
            LblPreco = new Label();
            GrpbAvarias = new GroupBox();
            ChkRasgos = new CheckBox();
            ChkAnotacoes = new CheckBox();
            ChkGrifos = new CheckBox();
            ChkPaginas = new CheckBox();
            ChkCapa = new CheckBox();
            BarraFerramentasLivros.SuspendLayout();
            GrpbTipoLivro.SuspendLayout();
            GrpbAvarias.SuspendLayout();
            SuspendLayout();
            // 
            // BarraFerramentasLivros
            // 
            BarraFerramentasLivros.ImageScalingSize = new Size(20, 20);
            BarraFerramentasLivros.Items.AddRange(new ToolStripItem[] { TSBtnNovo, toolStripSeparator1, TSBtnSalvar, toolStripSeparator2, TSBtnListar, toolStripSeparator3, toolStripButton4 });
            BarraFerramentasLivros.Location = new Point(0, 0);
            BarraFerramentasLivros.Name = "BarraFerramentasLivros";
            BarraFerramentasLivros.Size = new Size(800, 71);
            BarraFerramentasLivros.TabIndex = 0;
            BarraFerramentasLivros.Text = "toolStrip1";
            // 
            // TSBtnNovo
            // 
            TSBtnNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBtnNovo.Image = Properties.Resources.novo;
            TSBtnNovo.ImageScaling = ToolStripItemImageScaling.None;
            TSBtnNovo.ImageTransparentColor = Color.Magenta;
            TSBtnNovo.Name = "TSBtnNovo";
            TSBtnNovo.Size = new Size(68, 68);
            TSBtnNovo.Text = "Novo";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 71);
            // 
            // TSBtnSalvar
            // 
            TSBtnSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBtnSalvar.Image = Properties.Resources.salva;
            TSBtnSalvar.ImageScaling = ToolStripItemImageScaling.None;
            TSBtnSalvar.ImageTransparentColor = Color.Magenta;
            TSBtnSalvar.Name = "TSBtnSalvar";
            TSBtnSalvar.Size = new Size(68, 68);
            TSBtnSalvar.Text = "Salvar";
            TSBtnSalvar.Click += TSBtnSalvar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 71);
            // 
            // TSBtnListar
            // 
            TSBtnListar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSBtnListar.Image = Properties.Resources.listar;
            TSBtnListar.ImageScaling = ToolStripItemImageScaling.None;
            TSBtnListar.ImageTransparentColor = Color.Magenta;
            TSBtnListar.Name = "TSBtnListar";
            TSBtnListar.Size = new Size(68, 68);
            TSBtnListar.Text = "Listar";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 71);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.apagar;
            toolStripButton4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(68, 68);
            toolStripButton4.Text = "Apagar";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(12, 93);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(88, 32);
            LblTitulo.TabIndex = 1;
            LblTitulo.Text = "Titulo:";
            // 
            // TxtTitulo
            // 
            TxtTitulo.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTitulo.Location = new Point(106, 91);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(623, 34);
            TxtTitulo.TabIndex = 2;
            // 
            // TxtAutor
            // 
            TxtAutor.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAutor.Location = new Point(106, 143);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(623, 34);
            TxtAutor.TabIndex = 4;
            // 
            // LblAutor
            // 
            LblAutor.AutoSize = true;
            LblAutor.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAutor.Location = new Point(12, 145);
            LblAutor.Name = "LblAutor";
            LblAutor.Size = new Size(89, 32);
            LblAutor.TabIndex = 3;
            LblAutor.Text = "Autor:";
            // 
            // TxtEditora
            // 
            TxtEditora.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEditora.Location = new Point(128, 196);
            TxtEditora.Name = "TxtEditora";
            TxtEditora.Size = new Size(601, 34);
            TxtEditora.TabIndex = 6;
            // 
            // LblEditora
            // 
            LblEditora.AutoSize = true;
            LblEditora.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEditora.Location = new Point(12, 198);
            LblEditora.Name = "LblEditora";
            LblEditora.Size = new Size(110, 32);
            LblEditora.TabIndex = 5;
            LblEditora.Text = "Editora:";
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCategoria.Location = new Point(12, 249);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(141, 32);
            LblCategoria.TabIndex = 7;
            LblCategoria.Text = "Categoria:";
            // 
            // CmbCategoria
            // 
            CmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbCategoria.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbCategoria.FormattingEnabled = true;
            CmbCategoria.Items.AddRange(new object[] { "Artes", "Biografias", "Comunicação", "Infanto-Juvenil", "Ficção", "Tecnologias" });
            CmbCategoria.Location = new Point(159, 244);
            CmbCategoria.Name = "CmbCategoria";
            CmbCategoria.Size = new Size(283, 34);
            CmbCategoria.TabIndex = 8;
            // 
            // GrpbTipoLivro
            // 
            GrpbTipoLivro.Controls.Add(RdUsado);
            GrpbTipoLivro.Controls.Add(RdNovo);
            GrpbTipoLivro.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrpbTipoLivro.Location = new Point(12, 310);
            GrpbTipoLivro.Name = "GrpbTipoLivro";
            GrpbTipoLivro.Size = new Size(430, 80);
            GrpbTipoLivro.TabIndex = 9;
            GrpbTipoLivro.TabStop = false;
            GrpbTipoLivro.Text = "Tipo do Livro";
            // 
            // RdUsado
            // 
            RdUsado.AutoSize = true;
            RdUsado.Checked = true;
            RdUsado.Location = new Point(297, 33);
            RdUsado.Name = "RdUsado";
            RdUsado.Size = new Size(100, 30);
            RdUsado.TabIndex = 1;
            RdUsado.TabStop = true;
            RdUsado.Text = "Usado";
            RdUsado.UseVisualStyleBackColor = true;
            // 
            // RdNovo
            // 
            RdNovo.AutoSize = true;
            RdNovo.Location = new Point(147, 33);
            RdNovo.Name = "RdNovo";
            RdNovo.Size = new Size(87, 30);
            RdNovo.TabIndex = 0;
            RdNovo.TabStop = true;
            RdNovo.Text = "Novo";
            RdNovo.UseVisualStyleBackColor = true;
            RdNovo.CheckedChanged += RdNovo_CheckedChanged;
            // 
            // TxtAno
            // 
            TxtAno.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAno.Location = new Point(106, 410);
            TxtAno.Name = "TxtAno";
            TxtAno.Size = new Size(101, 34);
            TxtAno.TabIndex = 11;
            // 
            // LblAno
            // 
            LblAno.AutoSize = true;
            LblAno.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAno.Location = new Point(12, 412);
            LblAno.Name = "LblAno";
            LblAno.Size = new Size(72, 32);
            LblAno.TabIndex = 10;
            LblAno.Text = "Ano:";
            // 
            // TxtPreco
            // 
            TxtPreco.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPreco.Location = new Point(106, 468);
            TxtPreco.Name = "TxtPreco";
            TxtPreco.Size = new Size(101, 34);
            TxtPreco.TabIndex = 13;
            // 
            // LblPreco
            // 
            LblPreco.AutoSize = true;
            LblPreco.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPreco.Location = new Point(12, 470);
            LblPreco.Name = "LblPreco";
            LblPreco.Size = new Size(94, 32);
            LblPreco.TabIndex = 12;
            LblPreco.Text = "Preço:";
            // 
            // GrpbAvarias
            // 
            GrpbAvarias.Controls.Add(ChkRasgos);
            GrpbAvarias.Controls.Add(ChkAnotacoes);
            GrpbAvarias.Controls.Add(ChkGrifos);
            GrpbAvarias.Controls.Add(ChkPaginas);
            GrpbAvarias.Controls.Add(ChkCapa);
            GrpbAvarias.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrpbAvarias.Location = new Point(306, 404);
            GrpbAvarias.Name = "GrpbAvarias";
            GrpbAvarias.Size = new Size(482, 226);
            GrpbAvarias.TabIndex = 14;
            GrpbAvarias.TabStop = false;
            GrpbAvarias.Text = "Avarias";
            // 
            // ChkRasgos
            // 
            ChkRasgos.AutoSize = true;
            ChkRasgos.Location = new Point(22, 182);
            ChkRasgos.Name = "ChkRasgos";
            ChkRasgos.Size = new Size(113, 30);
            ChkRasgos.TabIndex = 4;
            ChkRasgos.Text = "Rasgos";
            ChkRasgos.UseVisualStyleBackColor = true;
            // 
            // ChkAnotacoes
            // 
            ChkAnotacoes.AutoSize = true;
            ChkAnotacoes.Location = new Point(23, 146);
            ChkAnotacoes.Name = "ChkAnotacoes";
            ChkAnotacoes.Size = new Size(271, 30);
            ChkAnotacoes.TabIndex = 3;
            ChkAnotacoes.Text = "Anotações nas páginas";
            ChkAnotacoes.UseVisualStyleBackColor = true;
            // 
            // ChkGrifos
            // 
            ChkGrifos.AutoSize = true;
            ChkGrifos.Location = new Point(22, 108);
            ChkGrifos.Name = "ChkGrifos";
            ChkGrifos.Size = new Size(400, 30);
            ChkGrifos.TabIndex = 2;
            ChkGrifos.Text = "Grifos, marcações de caneta e lápis";
            ChkGrifos.UseVisualStyleBackColor = true;
            ChkGrifos.CheckedChanged += ChkGrifos_CheckedChanged;
            // 
            // ChkPaginas
            // 
            ChkPaginas.AutoSize = true;
            ChkPaginas.Location = new Point(22, 72);
            ChkPaginas.Name = "ChkPaginas";
            ChkPaginas.Size = new Size(438, 30);
            ChkPaginas.TabIndex = 1;
            ChkPaginas.Text = "Páginas amareladas e/ou com manchas";
            ChkPaginas.UseVisualStyleBackColor = true;
            ChkPaginas.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ChkCapa
            // 
            ChkCapa.AutoSize = true;
            ChkCapa.Location = new Point(22, 36);
            ChkCapa.Name = "ChkCapa";
            ChkCapa.Size = new Size(213, 30);
            ChkCapa.TabIndex = 0;
            ChkCapa.Text = "Capa desgastada";
            ChkCapa.UseVisualStyleBackColor = true;
            // 
            // FrmCadLivros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 642);
            Controls.Add(GrpbAvarias);
            Controls.Add(TxtPreco);
            Controls.Add(LblPreco);
            Controls.Add(TxtAno);
            Controls.Add(LblAno);
            Controls.Add(GrpbTipoLivro);
            Controls.Add(CmbCategoria);
            Controls.Add(LblCategoria);
            Controls.Add(TxtEditora);
            Controls.Add(LblEditora);
            Controls.Add(TxtAutor);
            Controls.Add(LblAutor);
            Controls.Add(TxtTitulo);
            Controls.Add(LblTitulo);
            Controls.Add(BarraFerramentasLivros);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadLivros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Livros";
            BarraFerramentasLivros.ResumeLayout(false);
            BarraFerramentasLivros.PerformLayout();
            GrpbTipoLivro.ResumeLayout(false);
            GrpbTipoLivro.PerformLayout();
            GrpbAvarias.ResumeLayout(false);
            GrpbAvarias.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip BarraFerramentasLivros;
        private ToolStripButton TSBtnNovo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TSBtnSalvar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TSBtnListar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton4;
        private Label LblTitulo;
        private TextBox TxtTitulo;
        private TextBox TxtAutor;
        private Label LblAutor;
        private TextBox TxtEditora;
        private Label LblEditora;
        private Label LblCategoria;
        private ComboBox CmbCategoria;
        private GroupBox GrpbTipoLivro;
        private RadioButton RdUsado;
        private RadioButton RdNovo;
        private TextBox TxtAno;
        private Label LblAno;
        private TextBox TxtPreco;
        private Label LblPreco;
        private GroupBox GrpbAvarias;
        private CheckBox ChkPaginas;
        private CheckBox ChkCapa;
        private CheckBox ChkGrifos;
        private CheckBox ChkAnotacoes;
        private CheckBox ChkRasgos;
    }
}