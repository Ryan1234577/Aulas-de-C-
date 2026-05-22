using servicehub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servicehub
{
    public partial class FrmServico : Form
    {
        public FrmServico()
        {
            InitializeComponent();
        }


        private void HabilitaControle()
        {
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void DesabilitaControle()
        {
            btnAdicionar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void FrmServico_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            double preco = (double)nudPreco.Value;

            var cmd = Banco.Abrir();
            cmd.CommandText = $" insert servicos (nome, descricao,preco)"
                + $"values('{nome}', '{descricao}',{preco})";
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.CommandText = "select last_insert_id()";
                txtId.Text = cmd.ExecuteScalar().ToString();
                btnAdicionar.Enabled = false;
                //ou
                //txtId.Text = cmd.ExecuteScalar().ToString();

            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DesabilitaControle();
            if (btnPesquisar.Text == "&Pesquisar")
            {
                txtId.ReadOnly = false;
                txtNome.ReadOnly = true;
                txtDescricao.ReadOnly = true;
                nudPreco.ReadOnly = true;
                checkBox_Descontinuado.Enabled = false;
                txtId.Focus();
                btnPesquisar.Text = "Buscar";
            }
            else if (btnPesquisar.Text == "Buscar")
            {
                // buscar no banco
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from servicos where id = {txtId.Text}";
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNome.Text = dr.GetString(1);
                    txtDescricao.Text = dr.GetString(2);
                    nudPreco.Value = dr.GetDecimal(3);
                    checkBox_Descontinuado.Checked = dr.GetBoolean(4);
                }
                btnPesquisar.Text = "&Pesquisar";
                txtId.ReadOnly = true;
                btnEditar.Enabled = true;
                btnPesquisar.Enabled = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "&editar")
            {
                txtDescricao.ReadOnly = false;
                txtNome.ReadOnly = false;
                nudPreco.ReadOnly = false;
                checkBox_Descontinuado.Enabled = true;
                btnEditar.Text = "salvar";
            }
            else
            {
                string descont = checkBox_Descontinuado.Checked ? "1" : "0";
                double pre = (double)nudPreco.Value;
                string descricao = txtDescricao.Text;
                string nome = txtNome.Text;
                var cmd = Banco.Abrir();
                cmd.CommandText = $"update servicos set nome = '{nome}', " + $"descricao = '{descricao}', preco = {pre} , " + $"descontinuado = {descont} where id = {txtId.Text}";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    btnEditar.Text = "&Editar";
                    txtNome.ReadOnly = true;
                    txtDescricao.ReadOnly = true;
                    nudPreco.ReadOnly = true;
                    checkBox_Descontinuado.Enabled = false;

                }
                HabilitaControle();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete from servicos where id = {txtId.Text}";
            if (cmd.ExecuteNonQuery() > 0)
            {
                txtId.Clear();
                txtNome.Clear();
                txtDescricao.Clear();
                nudPreco.Value = 0;
                btnExcluir.Enabled = false;
                //ou
                //txtId.Text = cmd.ExecuteScalar().ToString();

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}


