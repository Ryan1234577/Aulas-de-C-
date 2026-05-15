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
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.Rows.Add();
            dgvClientes.Rows[0].Cells[0].Value = 1;
            dgvClientes.Rows[0].Cells[1].Value = 1520;
            dgvClientes.Rows[0].Cells[2].Value = "Maria da Silva";
            dgvClientes.Rows[0].Cells[3].Value = "12345678974";
            dgvClientes.Rows[0].Cells[4].Value = "maria@couves.com";
            dgvClientes.Rows[0].Cells[5].Value = "11987654321";
            dgvClientes.Rows[0].Cells[6].Value = true;

            dgvClientes.Rows.Add();
            dgvClientes.Rows[1].Cells[0].Value = 1;
            dgvClientes.Rows[1].Cells[1].Value = 1620;
            dgvClientes.Rows[1].Cells[2].Value = "José da Silva";
            dgvClientes.Rows[1].Cells[3].Value = "16840678955";
            dgvClientes.Rows[1].Cells[4].Value = "jose@couves.com";
            dgvClientes.Rows[1].Cells[5].Value = "11987654444";
            dgvClientes.Rows[1].Cells[6].Value = false;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            string id = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show(id);
        }
    }
}
