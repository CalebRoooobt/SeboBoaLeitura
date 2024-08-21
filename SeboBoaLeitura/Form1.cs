namespace SeboBoaLeitura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadLivros frm = new FrmCadLivros();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
