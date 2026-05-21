namespace servicehub
{
    partial class FrmProduto
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
            label1 = new Label();
            txtCdgBarras = new TextBox();
            btnBuscar = new Button();
            picImagem = new PictureBox();
            label2 = new Label();
            txtDescricao = new TextBox();
            label3 = new Label();
            nudPreco = new NumericUpDown();
            label4 = new Label();
            txtUnidVenda = new TextBox();
            label5 = new Label();
            label6 = new Label();
            nudEstoqueMinimo = new NumericUpDown();
            label7 = new Label();
            nudClasseDesconto = new NumericUpDown();
            btnCarregarImg = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            chkDescontinuado = new CheckBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 62);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "CodBarras";
            // 
            // txtCdgBarras
            // 
            txtCdgBarras.Location = new Point(111, 54);
            txtCdgBarras.Name = "txtCdgBarras";
            txtCdgBarras.PlaceholderText = "Código de Barras";
            txtCdgBarras.Size = new Size(279, 23);
            txtCdgBarras.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = Properties.Resources.Zoom_In;
            btnBuscar.Location = new Point(416, 33);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 63);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "B&uscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // picImagem
            // 
            picImagem.Location = new Point(545, 34);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(213, 199);
            picImagem.TabIndex = 3;
            picImagem.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 111);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(111, 103);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.Size = new Size(405, 23);
            txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 164);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Preço";
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Location = new Point(111, 156);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(90, 23);
            nudPreco.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 164);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 8;
            label4.Text = "Unidade Venda";
            // 
            // txtUnidVenda
            // 
            txtUnidVenda.Location = new Point(416, 156);
            txtUnidVenda.Name = "txtUnidVenda";
            txtUnidVenda.PlaceholderText = "Unid.Venda";
            txtUnidVenda.Size = new Size(100, 23);
            txtUnidVenda.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 218);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 10;
            label5.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 270);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 12;
            label6.Text = "Estoque Mínimo";
            // 
            // nudEstoqueMinimo
            // 
            nudEstoqueMinimo.DecimalPlaces = 3;
            nudEstoqueMinimo.Location = new Point(135, 262);
            nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            nudEstoqueMinimo.Size = new Size(90, 23);
            nudEstoqueMinimo.TabIndex = 7;
            nudEstoqueMinimo.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(317, 270);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 8;
            label7.Text = "Classe Desconto";
            // 
            // nudClasseDesconto
            // 
            nudClasseDesconto.DecimalPlaces = 3;
            nudClasseDesconto.Location = new Point(426, 262);
            nudClasseDesconto.Name = "nudClasseDesconto";
            nudClasseDesconto.Size = new Size(90, 23);
            nudClasseDesconto.TabIndex = 9;
            // 
            // btnCarregarImg
            // 
            btnCarregarImg.Image = Properties.Resources.Refresh;
            btnCarregarImg.Location = new Point(590, 246);
            btnCarregarImg.Name = "btnCarregarImg";
            btnCarregarImg.Size = new Size(124, 63);
            btnCarregarImg.TabIndex = 10;
            btnCarregarImg.Text = "Carregar Imagem";
            btnCarregarImg.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCarregarImg.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.Save_As;
            btnSalvar.Location = new Point(66, 338);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(145, 79);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "&Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.Edit_Alt;
            btnEditar.Location = new Point(290, 338);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(145, 79);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.Location = new Point(528, 338);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 79);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // chkDescontinuado
            // 
            chkDescontinuado.AutoSize = true;
            chkDescontinuado.Location = new Point(234, 304);
            chkDescontinuado.Name = "chkDescontinuado";
            chkDescontinuado.Size = new Size(106, 19);
            chkDescontinuado.TabIndex = 11;
            chkDescontinuado.Text = "Descontinuado";
            chkDescontinuado.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Amortecedores", "Óleos e Lubrificantes" });
            comboBox1.Location = new Point(111, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(405, 23);
            comboBox1.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(779, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(431, 274);
            listBox1.TabIndex = 20;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 450);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(chkDescontinuado);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnCarregarImg);
            Controls.Add(nudClasseDesconto);
            Controls.Add(label7);
            Controls.Add(nudEstoqueMinimo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtUnidVenda);
            Controls.Add(label4);
            Controls.Add(nudPreco);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(picImagem);
            Controls.Add(btnBuscar);
            Controls.Add(txtCdgBarras);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCdgBarras;
        private Button btnBuscar;
        private PictureBox picImagem;
        private Label label2;
        private TextBox txtDescricao;
        private Label label3;
        private NumericUpDown nudPreco;
        private Label label4;
        private TextBox txtUnidVenda;
        private Label label5;
        private Label label6;
        private NumericUpDown nudEstoqueMinimo;
        private Label label7;
        private NumericUpDown nudClasseDesconto;
        private Button btnCarregarImg;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnCancelar;
        private CheckBox chkDescontinuado;
        private ComboBox comboBox1;
        private ListBox listBox1;
    }
}