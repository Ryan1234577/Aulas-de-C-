namespace Servicehub
{
    partial class FrmNivel
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            btn_Adicionar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            txtBuscar = new TextBox();
            dataGridView1 = new DataGridView();
            ClnID = new DataGridViewTextBoxColumn();
            ClnNome = new DataGridViewTextBoxColumn();
            ClnSigla = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria Nivel ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 127);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 127);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 127);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Sigla";
            // 
            // txtId
            // 
            txtId.Location = new Point(62, 145);
            txtId.Name = "txtId";
            txtId.Size = new Size(50, 23);
            txtId.TabIndex = 28;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(272, 145);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(213, 23);
            txtNome.TabIndex = 29;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(631, 145);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(121, 23);
            txtSigla.TabIndex = 30;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Image = Properties.Resources.Add;
            btn_Adicionar.ImageAlign = ContentAlignment.TopCenter;
            btn_Adicionar.Location = new Point(42, 228);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(121, 78);
            btn_Adicionar.TabIndex = 31;
            btn_Adicionar.Text = "&Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Edit;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(229, 228);
            button2.Name = "button2";
            button2.Size = new Size(119, 78);
            button2.TabIndex = 32;
            button2.Text = "&Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.Search;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(413, 228);
            button3.Name = "button3";
            button3.Size = new Size(114, 78);
            button3.TabIndex = 33;
            button3.Text = "&Pesquisar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.Delete;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(589, 228);
            button4.Name = "button4";
            button4.Size = new Size(108, 78);
            button4.TabIndex = 34;
            button4.Text = "&Excluir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.Cancel;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(744, 228);
            button5.Name = "button5";
            button5.Size = new Size(101, 78);
            button5.TabIndex = 35;
            button5.Text = "&Cancelar";
            button5.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(74, 346);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Nivel";
            txtBuscar.Size = new Size(686, 23);
            txtBuscar.TabIndex = 36;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ClnID, ClnNome, ClnSigla });
            dataGridView1.Location = new Point(161, 400);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(545, 160);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ClnID
            // 
            ClnID.DataPropertyName = "Id";
            ClnID.HeaderText = "ID";
            ClnID.Name = "ClnID";
            // 
            // ClnNome
            // 
            ClnNome.DataPropertyName = "Nome";
            ClnNome.HeaderText = "Nome";
            ClnNome.Name = "ClnNome";
            ClnNome.Width = 300;
            // 
            // ClnSigla
            // 
            ClnSigla.DataPropertyName = "Sigla";
            ClnSigla.HeaderText = "Sigla";
            ClnSigla.Name = "ClnSigla";
            // 
            // FrmNivel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 598);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_Adicionar);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNivel";
            Text = "FrmNivel";
            Load += FrmNivel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtSigla;
        private Button btn_Adicionar;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox txtBuscar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ClnID;
        private DataGridViewTextBoxColumn ClnNome;
        private DataGridViewTextBoxColumn ClnSigla;
    }
}