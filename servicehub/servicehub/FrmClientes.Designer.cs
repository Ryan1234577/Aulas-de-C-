namespace servicehub
{
    partial class FrmClientes
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
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            ID = new Label();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtDataNasc = new TextBox();
            txtDataCad = new TextBox();
            dgvClientes = new DataGridView();
            ClnSeq = new DataGridViewTextBoxColumn();
            Clnid = new DataGridViewTextBoxColumn();
            ClnNome = new DataGridViewTextBoxColumn();
            ClnCPF = new DataGridViewTextBoxColumn();
            ClnEmail = new DataGridViewTextBoxColumn();
            ClnTelefone = new DataGridViewTextBoxColumn();
            ClnAtivo = new DataGridViewCheckBoxColumn();
            clnDataNas = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            checkBox1 = new CheckBox();
            btnListar = new Button();
            btnAdd = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(94, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(191, 25);
            txtNome.TabIndex = 14;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 10F);
            txtCpf.Location = new Point(94, 147);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(191, 25);
            txtCpf.TabIndex = 17;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(94, 51);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(66, 25);
            txtId.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(39, 150);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 23;
            label3.Text = "CPF";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(57, 64);
            label6.Name = "label6";
            label6.Size = new Size(0, 19);
            label6.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(39, 107);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 22;
            label2.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(39, 49);
            label5.Name = "label5";
            label5.Size = new Size(0, 19);
            label5.TabIndex = 21;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 10F);
            ID.Location = new Point(40, 54);
            ID.Name = "ID";
            ID.Size = new Size(23, 19);
            ID.TabIndex = 16;
            ID.Text = "ID";
            ID.Click += ID_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 197);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 26;
            label1.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 247);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 27;
            label4.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 296);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 28;
            label7.Text = "Data Nascimento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 347);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 29;
            label8.Text = "Data de Cadastro";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(105, 189);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(180, 23);
            txtTelefone.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 239);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 23);
            txtEmail.TabIndex = 32;
            // 
            // txtDataNasc
            // 
            txtDataNasc.Location = new Point(144, 288);
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(177, 23);
            txtDataNasc.TabIndex = 33;
            // 
            // txtDataCad
            // 
            txtDataCad.Location = new Point(145, 339);
            txtDataCad.Name = "txtDataCad";
            txtDataCad.Size = new Size(177, 23);
            txtDataCad.TabIndex = 34;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ClnSeq, Clnid, ClnNome, ClnCPF, ClnEmail, ClnTelefone, ClnAtivo, clnDataNas, clnDataCad });
            dgvClientes.Location = new Point(40, 545);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1000, 281);
            dgvClientes.TabIndex = 35;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
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
            // clnDataNas
            // 
            clnDataNas.HeaderText = "Data de Nascimento";
            clnDataNas.Name = "clnDataNas";
            clnDataNas.ReadOnly = true;
            clnDataNas.Width = 140;
            // 
            // clnDataCad
            // 
            clnDataCad.HeaderText = "Data de Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            clnDataCad.Width = 130;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(357, 64);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 19);
            checkBox1.TabIndex = 36;
            checkBox1.Text = "Ativo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.ForeColor = Color.FromArgb(255, 128, 255);
            btnListar.Image = Properties.Resources.Document;
            btnListar.Location = new Point(40, 417);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(151, 86);
            btnListar.TabIndex = 37;
            btnListar.Text = "L&istar Clientes";
            btnListar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.FromArgb(255, 128, 255);
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.Location = new Point(268, 417);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 86);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "A&dicionar Cliente";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Verdana", 11.25F);
            btnEditar.ForeColor = Color.FromArgb(255, 128, 255);
            btnEditar.Image = Properties.Resources.Ruler;
            btnEditar.Location = new Point(522, 416);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 86);
            btnEditar.TabIndex = 39;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.White;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Verdana", 11.25F);
            btnPesquisar.ForeColor = Color.FromArgb(255, 128, 255);
            btnPesquisar.Image = Properties.Resources.Search;
            btnPesquisar.Location = new Point(728, 417);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(157, 86);
            btnPesquisar.TabIndex = 40;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.White;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Verdana", 11.25F);
            btnExcluir.ForeColor = Color.FromArgb(255, 128, 255);
            btnExcluir.Image = Properties.Resources.Delete;
            btnExcluir.Location = new Point(935, 417);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(156, 85);
            btnExcluir.TabIndex = 41;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(255, 128, 255);
            btnCancelar.Image = Properties.Resources.Cancel1;
            btnCancelar.Location = new Point(1148, 417);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(148, 86);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 840);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdd);
            Controls.Add(btnListar);
            Controls.Add(checkBox1);
            Controls.Add(dgvClientes);
            Controls.Add(txtDataCad);
            Controls.Add(txtDataNasc);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtCpf);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(ID);
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtId;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label5;
        private Label ID;
        private Label label1;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtDataNasc;
        private TextBox txtDataCad;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn ClnSeq;
        private DataGridViewTextBoxColumn Clnid;
        private DataGridViewTextBoxColumn ClnNome;
        private DataGridViewTextBoxColumn ClnCPF;
        private DataGridViewTextBoxColumn ClnEmail;
        private DataGridViewTextBoxColumn ClnTelefone;
        private DataGridViewCheckBoxColumn ClnAtivo;
        private DataGridViewTextBoxColumn clnDataNas;
        private DataGridViewTextBoxColumn clnDataCad;
        private CheckBox checkBox1;
        private Button btnListar;
        private Button btnAdd;
        private Button btnEditar;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnCancelar;
    }
}