namespace WFProj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbNome = new Label();
            txtNome = new TextBox();
            button1 = new Button();
            N1 = new Label();
            N2 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(76, 32);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(76, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(266, 23);
            txtNome.TabIndex = 1;
            txtNome.Text = "Digite seu nome:";
            // 
            // button1
            // 
            button1.Location = new Point(376, 49);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "&Enviar";
            button1.UseVisualStyleBackColor = true;
            // 
            // N1
            // 
            N1.AutoSize = true;
            N1.Location = new Point(76, 149);
            N1.Name = "N1";
            N1.Size = new Size(22, 15);
            N1.TabIndex = 3;
            N1.Text = "N1";
            // 
            // N2
            // 
            N2.AutoSize = true;
            N2.Location = new Point(243, 149);
            N2.Name = "N2";
            N2.Size = new Size(22, 15);
            N2.TabIndex = 3;
            N2.Text = "N2";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(76, 186);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 4;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(242, 186);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(386, 186);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "&Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(N2);
            Controls.Add(N1);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(lbNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNome;
        private TextBox txtNome;
        private Button button1;
        private Label N1;
        private Label N2;
        private TextBox txtN1;
        private TextBox txtN2;
        private Button button2;
    }
}
