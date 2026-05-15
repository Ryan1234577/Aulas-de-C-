namespace servicehub
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criar uma instancia do formulario listar clientes
            FrmListaClientes listaClientes = new();

            //associando o form listar clientes como filho do form principal
            listaClientes.MdiParent = this;

            //chama o formulario de clientes

            listaClientes.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoCliente NovoCliente = new();
            NovoCliente.MdiParent = this;
            NovoCliente.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListarServico listarServico = new();
            listarServico.MdiParent = this;
            listarServico.Show();
        }
    }
}
