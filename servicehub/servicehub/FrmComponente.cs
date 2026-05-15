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
    public partial class FrmComponente : Form
    {

        public FrmComponente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                double numero1 = 0;
                numero1 = double.Parse(textBox1.Text);
                double numero2 = 0;
                numero2 = comboBox1.SelectedIndex < 5 ? double.Parse(textBox2.Text) : 0;
                switch (comboBox1.SelectedIndex)
                {
                    case 0: //Multiplicação
                        listBox1.Items.Add("----------MULTIPLICAÇÃO----------");
                        listBox1.Items.Add($"{numero1} X {numero2} = {numero1 * numero2}");
                        break;

                    case 1: //Divisão

                        listBox1.Items.Add("----------DIVISÃO----------");

                        listBox1.Items.Add($"{numero1} / {numero2} = {numero1 / numero2:F3}");

                        break;

                    case 2: //Adição

                        listBox1.Items.Add("----------ADIÇÃO----------");

                        listBox1.Items.Add($"{numero1} + {numero2} = {numero1 + numero2}");

                        break;

                    case 3: //Subtração

                        listBox1.Items.Add("----------SUBTRAÇÃO----------");

                        listBox1.Items.Add($"{numero1} - {numero2} = {numero1 - numero2}");

                        break;

                    case 5: //Tabuada

                        listBox1.Items.Add("----------TABUADA----------");

                        for (int i = 1; i <= 11; i++)

                        {

                            listBox1.Items.Add($"      {numero1} X {i} = {numero1 * i}");

                        }

                        break;

                    case 4: //exponenciação

                        listBox1.Items.Add("----------EXPONENCIAÇÃO----------");

                        listBox1.Items.Add(Math.Pow(numero1, numero2));

                        break;

                    case 6: //Radiciação

                        listBox1.Items.Add("----------RADICIAÇÃO----------");
                        listBox1.Items.Add(Math.Sqrt(numero1));
                        break;

                    default:

                        break;

                }


            }

            textBox1.Clear();

            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)

        {

            textBox1.Clear();

            textBox1.Focus();

        }

        private void label1_Click(object sender, EventArgs e)

        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

            //MessageBox.Show("olá", "Mensagem",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            //var resposta = MessageBox.Show("oi", "titulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button3);

            //if (resposta == DialogResult.No)

            //{

            //    MessageBox.Show("Muito bem, você escolheu ok!");

            //}

            //MessageBox.Show(comboBox1.SelectedIndex.ToString());

            if (comboBox1.SelectedIndex < 5)

            {

                label1.Visible = true;

                textBox1.Visible = true;

                textBox2.Visible = true;

                textBox1.Focus();

            }

            else

            {

                label1.Visible = true;

                textBox1.Visible = true;

                textBox2.Visible = false;

                textBox1.Focus();

            }

        }

    }

}

