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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string data_nasc = txtDataNasc.Text;
            string data_cad = txtDataCad.Text;
            string valorDataNasc = string.IsNullOrWhiteSpace(data_nasc) ? "NULL" : $"'{data_nasc}'";
            int ativo = checkBox1.Checked ? 1 : 0;
            var cmd = Banco.Abrir();
            cmd.CommandText = $"insert into clientes (nome, cpf, telefone, email, data_nasc, ativo) "
                + $"values ('{nome}', '{cpf}', '{telefone}', '{email}', {valorDataNasc}, {ativo})";
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.CommandText = "select last_insert_id()";
                txtId.Text = cmd.ExecuteScalar().ToString();
                txtNome.Clear();
                txtCpf.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                txtDataNasc.Clear();
                txtDataCad.Clear();
                checkBox1.Checked = false;
                txtId.Clear();
                btnAdd.Enabled = false;
                //ou
                //txtId.Text = cmd.ExecuteScalar().ToString();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            var cmd_2 = Banco.Abrir();
            cmd_2.CommandText = "select * from clientes";
            var dr_2 = cmd_2.ExecuteReader();
            while (dr_2.Read())
            {
                dgvClientes.Rows.Add();

                int linha = dgvClientes.RowCount - 1;

                dgvClientes.Rows[linha].Cells[0].Value = dr_2.GetInt32(0);
                dgvClientes.Rows[linha].Cells[1].Value = dr_2.GetString(1);
                dgvClientes.Rows[linha].Cells[2].Value = dr_2.GetString(2);
                dgvClientes.Rows[linha].Cells[3].Value = dr_2.GetString(3);
                dgvClientes.Rows[linha].Cells[4].Value = dr_2.GetString(4);


                
                if (dr_2.IsDBNull(6))
                {
                    dgvClientes.Rows[linha].Cells[6].Value = "";
                }
                else
                {
                    
                    dgvClientes.Rows[linha].Cells[6].Value = dr_2.GetValue(6).ToString();
                }

                
                if (dr_2.IsDBNull(7))
                {
                    dgvClientes.Rows[linha].Cells[7].Value = "";
                }
                else
                {
                    
                    dgvClientes.Rows[linha].Cells[7].Value = dr_2.GetValue(7).ToString();
                }

            }
            dr_2.Close();

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
