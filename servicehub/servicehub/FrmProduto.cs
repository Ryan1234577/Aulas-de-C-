using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace servicehub
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string CodBarras = txtCdgBarras.Text;
            string descricao = txtDescricao.Text;
            decimal preco = nudPreco.Value;
            string unidade = txtUnidVenda.Text;
            string categoria = comboBox1.Text;
            decimal estoquemin = nudEstoqueMinimo.Value;
            decimal desconto = nudClasseDesconto.Value;
            string status = chkDescontinuado.Checked ? "1" : "0";
            string registro = $"{CodBarras} - {descricao} | Preço: {preco:C2} | Categoria: {categoria} | Descontinuado: {status}";
            listBox1.Items.Add(registro);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
