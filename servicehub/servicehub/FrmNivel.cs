using ServiceHubClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Servicehub
{
    public partial class FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
        }





        private void FrmNivel_Load(object sender, EventArgs e)
        {

        }

        private void CarregaGrid(string busca = " ")
        {
            List<Nivel> lista = Nivel.ObterLista(busca);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }




        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            Nivel nivel = new(txtNome.Text, txtSigla.Text);
            nivel.Inserir();
            if (nivel.Id > 0)
            {
                MessageBox.Show($"Categoria {nivel.Id} inserida com sucesso!");
                CarregaGrid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int idValido))
            {
                MessageBox.Show("Por favor, selecione um nível na tabela antes de tentar atualizar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Nivel cat = new Nivel(idValido, txtNome.Text, txtSigla.Text);
            if (cat.Update())
            {
                txtId.Clear();
                txtNome.Clear();
                txtSigla.Clear();
                CarregaGrid();
                MessageBox.Show($"Categoria {cat.Id} alterada com sucesso!\nLista atualizada");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar categoria!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim().Length > 1)
            {
                CarregaGrid(txtBuscar.Text.Trim());
            }
            else
            {
                CarregaGrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                var resposta = MessageBox.Show($"Deseja excluir o nível {txtId.Text} - {txtNome.Text}?",
                    "Exclusão de Nível", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
                    );

                if (resposta == DialogResult.Yes)
                {
                    Nivel cat = new Nivel(int.Parse(txtId.Text));
                    cat.Excluir();

                    txtId.Clear();
                    txtNome.Clear();
                    txtSigla.Clear();

                    MessageBox.Show("Nível excluído com sucesso!");
                    CarregaGrid();
                }
            }
        }
    }
}
