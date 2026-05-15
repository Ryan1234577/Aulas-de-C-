namespace servicehub
{
    partial class FrmListaClientes
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
            textBox1 = new TextBox();
            label1 = new Label();
            dgvClientes = new DataGridView();
            ClnSeq = new DataGridViewTextBoxColumn();
            Clnid = new DataGridViewTextBoxColumn();
            ClnNome = new DataGridViewTextBoxColumn();
            ClnCPF = new DataGridViewTextBoxColumn();
            ClnEmail = new DataGridViewTextBoxColumn();
            ClnTelefone = new DataGridViewTextBoxColumn();
            ClnAtivo = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(540, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 66);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ClnSeq, Clnid, ClnNome, ClnCPF, ClnEmail, ClnTelefone, ClnAtivo });
            dgvClientes.Location = new Point(26, 87);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(780, 280);
            dgvClientes.TabIndex = 2;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ClnSeq
            // 
            ClnSeq.Frozen = true;
            ClnSeq.HeaderText = "#";
            ClnSeq.Name = "ClnSeq";
            ClnSeq.ReadOnly = true;
            ClnSeq.Width = 30;
            // 
            // Clnid
            // 
            Clnid.Frozen = true;
            Clnid.HeaderText = "ID";
            Clnid.Name = "Clnid";
            Clnid.ReadOnly = true;
            Clnid.Width = 78;
            // 
            // ClnNome
            // 
            ClnNome.Frozen = true;
            ClnNome.HeaderText = "Nome";
            ClnNome.Name = "ClnNome";
            ClnNome.ReadOnly = true;
            ClnNome.Width = 200;
            // 
            // ClnCPF
            // 
            ClnCPF.Frozen = true;
            ClnCPF.HeaderText = "CPF";
            ClnCPF.Name = "ClnCPF";
            ClnCPF.ReadOnly = true;
            // 
            // ClnEmail
            // 
            ClnEmail.HeaderText = "Email";
            ClnEmail.Name = "ClnEmail";
            ClnEmail.ReadOnly = true;
            ClnEmail.Width = 168;
            // 
            // ClnTelefone
            // 
            ClnTelefone.HeaderText = "Telefone";
            ClnTelefone.Name = "ClnTelefone";
            ClnTelefone.ReadOnly = true;
            // 
            // ClnAtivo
            // 
            ClnAtivo.HeaderText = "Ativo";
            ClnAtivo.Name = "ClnAtivo";
            ClnAtivo.ReadOnly = true;
            ClnAtivo.Width = 50;
            // 
            // FrmListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 431);
            Controls.Add(dgvClientes);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FrmListaClientes";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "FrmListaClientes";
            Load += FrmListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn ClnSeq;
        private DataGridViewTextBoxColumn Clnid;
        private DataGridViewTextBoxColumn ClnNome;
        private DataGridViewTextBoxColumn ClnCPF;
        private DataGridViewTextBoxColumn ClnEmail;
        private DataGridViewTextBoxColumn ClnTelefone;
        private DataGridViewCheckBoxColumn ClnAtivo;
    }
}