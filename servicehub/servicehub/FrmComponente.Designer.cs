namespace servicehub
{
    partial class FrmComponente
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
            listBox1 = new ListBox();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            dgvServicos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnPreco = new DataGridViewTextBoxColumn();
            clnDescontinuado = new DataGridViewCheckBoxColumn();
            dgvUsuarios = new DataGridView();
            clnId_user = new DataGridViewTextBoxColumn();
            clnNome_user = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnSenha = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            dtgSolicitação = new DataGridView();
            btnsolicitações = new Button();
            cln_ID_Solic = new DataGridViewTextBoxColumn();
            clnCliente_id = new DataGridViewTextBoxColumn();
            cln_descricao_problema = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgSolicitação).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 116);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite os valores para a operação";
            label1.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(392, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(269, 169);
            listBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(54, 179);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(147, 179);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Tabuada", "Radiciação" });
            comboBox1.Location = new Point(53, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 46);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Operação";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            textBox2.Visible = false;
            // 
            // dgvServicos
            // 
            dgvServicos.AllowUserToAddRows = false;
            dgvServicos.AllowUserToDeleteRows = false;
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnDescricao, clnPreco, clnDescontinuado });
            dgvServicos.Location = new Point(39, 239);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.ReadOnly = true;
            dgvServicos.RowHeadersVisible = false;
            dgvServicos.Size = new Size(712, 150);
            dgvServicos.TabIndex = 8;
            dgvServicos.CellContentClick += dgvServicos_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 200;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnPreco
            // 
            clnPreco.HeaderText = "Preço";
            clnPreco.Name = "clnPreco";
            clnPreco.ReadOnly = true;
            // 
            // clnDescontinuado
            // 
            clnDescontinuado.HeaderText = "Descontinuado";
            clnDescontinuado.Name = "clnDescontinuado";
            clnDescontinuado.ReadOnly = true;
            clnDescontinuado.Width = 106;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId_user, clnNome_user, clnEmail, clnSenha, clnAtivo });
            dgvUsuarios.Location = new Point(39, 406);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(503, 162);
            dgvUsuarios.TabIndex = 9;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // clnId_user
            // 
            clnId_user.HeaderText = "ID";
            clnId_user.Name = "clnId_user";
            clnId_user.ReadOnly = true;
            // 
            // clnNome_user
            // 
            clnNome_user.HeaderText = "Nome";
            clnNome_user.Name = "clnNome_user";
            clnNome_user.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // clnSenha
            // 
            clnSenha.HeaderText = "Senha";
            clnSenha.Name = "clnSenha";
            clnSenha.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            // 
            // dtgSolicitação
            // 
            dtgSolicitação.AllowUserToAddRows = false;
            dtgSolicitação.AllowUserToDeleteRows = false;
            dtgSolicitação.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSolicitação.Columns.AddRange(new DataGridViewColumn[] { cln_ID_Solic, clnCliente_id, cln_descricao_problema });
            dtgSolicitação.Location = new Point(39, 604);
            dtgSolicitação.Name = "dtgSolicitação";
            dtgSolicitação.ReadOnly = true;
            dtgSolicitação.RowHeadersVisible = false;
            dtgSolicitação.Size = new Size(503, 150);
            dtgSolicitação.TabIndex = 10;
            // 
            // btnsolicitações
            // 
            btnsolicitações.Location = new Point(548, 615);
            btnsolicitações.Name = "btnsolicitações";
            btnsolicitações.Size = new Size(93, 23);
            btnsolicitações.TabIndex = 11;
            btnsolicitações.Text = "Solicitações";
            btnsolicitações.UseVisualStyleBackColor = true;
            btnsolicitações.Click += btnsolicitações_Click;
            // 
            // cln_ID_Solic
            // 
            cln_ID_Solic.HeaderText = "ID";
            cln_ID_Solic.Name = "cln_ID_Solic";
            cln_ID_Solic.ReadOnly = true;
            // 
            // clnCliente_id
            // 
            clnCliente_id.HeaderText = "Cliente Id";
            clnCliente_id.Name = "clnCliente_id";
            clnCliente_id.ReadOnly = true;
            // 
            // cln_descricao_problema
            // 
            cln_descricao_problema.HeaderText = "Descrição do Problema";
            cln_descricao_problema.Name = "cln_descricao_problema";
            cln_descricao_problema.ReadOnly = true;
            cln_descricao_problema.Width = 300;
            // 
            // FrmComponente
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button1;
            ClientSize = new Size(800, 787);
            Controls.Add(btnsolicitações);
            Controls.Add(dtgSolicitação);
            Controls.Add(dgvUsuarios);
            Controls.Add(dgvServicos);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Name = "FrmComponente";
            Text = "FrmComponente";
            Load += FrmComponente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgSolicitação).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox2;
        private DataGridView dgvServicos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnPreco;
        private DataGridViewCheckBoxColumn clnDescontinuado;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnId_user;
        private DataGridViewTextBoxColumn clnNome_user;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnSenha;
        private DataGridViewCheckBoxColumn clnAtivo;
        private DataGridView dtgSolicitação;
        private Button btnsolicitações;
        private DataGridViewTextBoxColumn cln_ID_Solic;
        private DataGridViewTextBoxColumn clnCliente_id;
        private DataGridViewTextBoxColumn cln_descricao_problema;
    }
}