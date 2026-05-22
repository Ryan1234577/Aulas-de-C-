namespace servicehub
{
    partial class FrmServico
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
            ID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtDescricao = new TextBox();
            nudPreco = new NumericUpDown();
            label1 = new Label();
            checkBox_Descontinuado = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 10F);
            ID.Location = new Point(34, 101);
            ID.Name = "ID";
            ID.Size = new Size(23, 19);
            ID.TabIndex = 0;
            ID.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(34, 151);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 10;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(34, 200);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 11;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(377, 253);
            label4.Name = "label4";
            label4.Size = new Size(101, 19);
            label4.TabIndex = 3;
            label4.Text = "Descontinuado";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(89, 95);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(66, 25);
            txtId.TabIndex = 13;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 10F);
            txtDescricao.Location = new Point(107, 194);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(191, 25);
            txtDescricao.TabIndex = 1;
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Font = new Font("Segoe UI", 10F);
            nudPreco.Location = new Point(89, 247);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(213, 25);
            nudPreco.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(34, 253);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 12;
            label1.Text = "Preço";
            // 
            // checkBox_Descontinuado
            // 
            checkBox_Descontinuado.AutoSize = true;
            checkBox_Descontinuado.Font = new Font("Segoe UI", 10F);
            checkBox_Descontinuado.Location = new Point(356, 258);
            checkBox_Descontinuado.Name = "checkBox_Descontinuado";
            checkBox_Descontinuado.Size = new Size(15, 14);
            checkBox_Descontinuado.TabIndex = 0;
            checkBox_Descontinuado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(34, 93);
            label5.Name = "label5";
            label5.Size = new Size(0, 19);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(52, 108);
            label6.Name = "label6";
            label6.Size = new Size(0, 19);
            label6.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(107, 148);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(191, 25);
            txtNome.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.White;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Verdana", 11.25F);
            btnAdicionar.ForeColor = Color.FromArgb(255, 128, 255);
            btnAdicionar.Image = Properties.Resources.Add;
            btnAdicionar.Location = new Point(34, 321);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(104, 61);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
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
            btnEditar.Location = new Point(159, 321);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(104, 61);
            btnEditar.TabIndex = 5;
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
            btnPesquisar.Location = new Point(286, 321);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(104, 61);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
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
            btnExcluir.Location = new Point(419, 321);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(104, 61);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
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
            btnCancelar.Location = new Point(555, 321);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 61);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNome);
            Controls.Add(checkBox_Descontinuado);
            Controls.Add(label1);
            Controls.Add(nudPreco);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(ID);
            Name = "FrmServico";
            Text = "Servicehub - Serviços";
            Load += FrmServico_Load;
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtDescricao;
        private NumericUpDown nudPreco;
        private Label label1;
        private CheckBox checkBox_Descontinuado;
        private Label label5;
        private Label label6;
        private TextBox txtNome;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnCancelar;
    }
}