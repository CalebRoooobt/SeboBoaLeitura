using SeboBoaLeitura.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeboBoaLeitura
{
    public partial class FrmCadLivros : Form
    {
        private bool categor;
        public FrmCadLivros()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkGrifos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TSBtnSalvar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                //Salvar Livos
                LivroController livroController = new LivroController();
                livroController.SalvarLivro();
            }
        }
 

        private void RdNovo_CheckedChanged(object sender, EventArgs e)
        {
            
            if (RdNovo.Checked == true)
            {
           
               ChkCapa.Enabled = false;
               ChkPaginas.Enabled = false;
               ChkAnotacoes.Enabled = false;
               ChkGrifos.Enabled = false;
               ChkRasgos.Enabled = false;
            }
            else
            {

                ChkCapa.Enabled = true;
                ChkPaginas.Enabled = true;
                ChkAnotacoes.Enabled = true;
                ChkGrifos.Enabled = true;
                ChkRasgos.Enabled = true;
            }
        }
        private bool CamposValidos()
        {
            string msg = "", titulo = "Campos Obrigatórios";
            MessageBoxButtons botao = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Stop;


            if (TxtTitulo.Text.Trim() == "")
            {
                msg = "O título é obrigatório, por favor informe";
                MessageBox.Show(msg, titulo, botao, icon);
                return false;
            }

            if (TxtAutor.Text.Trim() == "")
            {
                msg = "O Autor é obrigatório, por favor informe";
                MessageBox.Show(msg, titulo, botao, icon);
                return false;
            }

            if (TxtEditora.Text.Trim() == "")
            {
                msg = "A Editora é obrigatória, por favor informe";
                MessageBox.Show(msg, titulo, botao, icon);
                return false;
            }

            if (CmbCategoria.SelectedIndex == -1)
            {
                msg = "A Categoria é obrigatória, por favor informe";
                MessageBox.Show(msg, titulo, botao, icon);
                return false;
            }

            if (TxtAno.Text.Trim() == "")
            {
                msg = "O ano é obrigatório, por favor informe";
                MessageBox.Show(msg, titulo, botao, icon);
                return false;
            }

            if (TxtPreco.Text.Trim() == "")
            {
                msg = "O preco é obrigatório, por favor informe";
                MessageBox.Show(msg, titulo, botao, icon);
                return false;
            }
            return true;
        }
    }
}
