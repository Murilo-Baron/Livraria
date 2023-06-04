using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Form1livraria : Form
    {
        public Form1livraria()
        {
            InitializeComponent();
        }

        
        
        private void button2confirmar_Click(object sender, EventArgs e)
        {
            if (textBox1nomedolivro.Text == "")
            {
                MessageBox.Show("Digite o nome do livro");
                textBox1nomedolivro.Focus();
                return; //sai do metodo confirmar
            }
            if (textBox3qtd.Text == "")
            {
                MessageBox.Show("Digite a Qtd");
                textBox3qtd.Focus();
                return;
            }
        }

        private void button3calcularvalor_Click(object sender, EventArgs e)
        {
            int qtd; //decimal, float
            double totalPagar;

            try
            {
                qtd = int.Parse(textBox3qtd.Text);
                if (comboBox1categoria.Text == "Romance")
                {
                    totalPagar = qtd * 20;
                }
                else if (comboBox1categoria.Text == "Ação")
                {
                    totalPagar = qtd * 10;
                }
                else
                {
                    totalPagar = qtd * 30;
                }
                textBox4valorapagar.Text = totalPagar.ToString("C2");
            } //fim do try
            catch
            {
                MessageBox.Show("Preste atenção!!! Digite certo");
            }// fim do catch
            
        }

        private void button1limpar_Click(object sender, EventArgs e)
        {
            textBox1nomedolivro.Clear();
            //textbox1nomedolivro.Text = "";
            textBox4valorapagar.Clear();
            //comboBox1categoria.SelectedIndex = -1;
            comboBox1categoria.ResetText();
            textBox3qtd.Clear();
        }
    }
}
