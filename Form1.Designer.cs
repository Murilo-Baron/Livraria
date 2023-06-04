
namespace Livraria
{
    partial class Form1livraria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1nomedolivro = new System.Windows.Forms.Label();
            this.label2categoria = new System.Windows.Forms.Label();
            this.label3qtdvendida = new System.Windows.Forms.Label();
            this.label4valorpagar = new System.Windows.Forms.Label();
            this.textBox1nomedolivro = new System.Windows.Forms.TextBox();
            this.textBox3qtd = new System.Windows.Forms.TextBox();
            this.textBox4valorapagar = new System.Windows.Forms.TextBox();
            this.button1limpar = new System.Windows.Forms.Button();
            this.button2confirmar = new System.Windows.Forms.Button();
            this.button3calcularvalor = new System.Windows.Forms.Button();
            this.comboBox1categoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1nomedolivro
            // 
            this.label1nomedolivro.AutoSize = true;
            this.label1nomedolivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1nomedolivro.Location = new System.Drawing.Point(27, 36);
            this.label1nomedolivro.Name = "label1nomedolivro";
            this.label1nomedolivro.Size = new System.Drawing.Size(184, 29);
            this.label1nomedolivro.TabIndex = 0;
            this.label1nomedolivro.Text = "Nome do Livro";
            // 
            // label2categoria
            // 
            this.label2categoria.AutoSize = true;
            this.label2categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2categoria.Location = new System.Drawing.Point(27, 85);
            this.label2categoria.Name = "label2categoria";
            this.label2categoria.Size = new System.Drawing.Size(127, 29);
            this.label2categoria.TabIndex = 1;
            this.label2categoria.Text = "Categoria";
            // 
            // label3qtdvendida
            // 
            this.label3qtdvendida.AutoSize = true;
            this.label3qtdvendida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3qtdvendida.Location = new System.Drawing.Point(27, 137);
            this.label3qtdvendida.Name = "label3qtdvendida";
            this.label3qtdvendida.Size = new System.Drawing.Size(154, 29);
            this.label3qtdvendida.TabIndex = 2;
            this.label3qtdvendida.Text = "Qtd vendida";
            // 
            // label4valorpagar
            // 
            this.label4valorpagar.AutoSize = true;
            this.label4valorpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4valorpagar.Location = new System.Drawing.Point(27, 235);
            this.label4valorpagar.Name = "label4valorpagar";
            this.label4valorpagar.Size = new System.Drawing.Size(169, 29);
            this.label4valorpagar.TabIndex = 3;
            this.label4valorpagar.Text = "Valor a pagar";
            // 
            // textBox1nomedolivro
            // 
            this.textBox1nomedolivro.Location = new System.Drawing.Point(212, 39);
            this.textBox1nomedolivro.Name = "textBox1nomedolivro";
            this.textBox1nomedolivro.Size = new System.Drawing.Size(317, 20);
            this.textBox1nomedolivro.TabIndex = 4;
            // 
            // textBox3qtd
            // 
            this.textBox3qtd.Location = new System.Drawing.Point(176, 141);
            this.textBox3qtd.Name = "textBox3qtd";
            this.textBox3qtd.Size = new System.Drawing.Size(100, 20);
            this.textBox3qtd.TabIndex = 6;
            // 
            // textBox4valorapagar
            // 
            this.textBox4valorapagar.Location = new System.Drawing.Point(203, 239);
            this.textBox4valorapagar.Name = "textBox4valorapagar";
            this.textBox4valorapagar.ReadOnly = true;
            this.textBox4valorapagar.Size = new System.Drawing.Size(122, 20);
            this.textBox4valorapagar.TabIndex = 7;
            // 
            // button1limpar
            // 
            this.button1limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1limpar.Location = new System.Drawing.Point(419, 146);
            this.button1limpar.Name = "button1limpar";
            this.button1limpar.Size = new System.Drawing.Size(187, 36);
            this.button1limpar.TabIndex = 8;
            this.button1limpar.Text = "Limpar";
            this.button1limpar.UseVisualStyleBackColor = true;
            this.button1limpar.Click += new System.EventHandler(this.button1limpar_Click);
            // 
            // button2confirmar
            // 
            this.button2confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2confirmar.Location = new System.Drawing.Point(419, 188);
            this.button2confirmar.Name = "button2confirmar";
            this.button2confirmar.Size = new System.Drawing.Size(187, 36);
            this.button2confirmar.TabIndex = 9;
            this.button2confirmar.Text = "Confirmar";
            this.button2confirmar.UseVisualStyleBackColor = true;
            this.button2confirmar.Click += new System.EventHandler(this.button2confirmar_Click);
            // 
            // button3calcularvalor
            // 
            this.button3calcularvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3calcularvalor.Location = new System.Drawing.Point(419, 230);
            this.button3calcularvalor.Name = "button3calcularvalor";
            this.button3calcularvalor.Size = new System.Drawing.Size(187, 35);
            this.button3calcularvalor.TabIndex = 10;
            this.button3calcularvalor.Text = "Calcular Valor";
            this.button3calcularvalor.UseVisualStyleBackColor = true;
            this.button3calcularvalor.Click += new System.EventHandler(this.button3calcularvalor_Click);
            // 
            // comboBox1categoria
            // 
            this.comboBox1categoria.FormattingEnabled = true;
            this.comboBox1categoria.Items.AddRange(new object[] {
            "Romance",
            "Comedia",
            "Terror",
            "Infantil",
            "Ação",
            "Fantasia"});
            this.comboBox1categoria.Location = new System.Drawing.Point(159, 87);
            this.comboBox1categoria.Name = "comboBox1categoria";
            this.comboBox1categoria.Size = new System.Drawing.Size(172, 21);
            this.comboBox1categoria.TabIndex = 11;
            // 
            // Form1livraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 301);
            this.Controls.Add(this.comboBox1categoria);
            this.Controls.Add(this.button3calcularvalor);
            this.Controls.Add(this.button2confirmar);
            this.Controls.Add(this.button1limpar);
            this.Controls.Add(this.textBox4valorapagar);
            this.Controls.Add(this.textBox3qtd);
            this.Controls.Add(this.textBox1nomedolivro);
            this.Controls.Add(this.label4valorpagar);
            this.Controls.Add(this.label3qtdvendida);
            this.Controls.Add(this.label2categoria);
            this.Controls.Add(this.label1nomedolivro);
            this.Name = "Form1livraria";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1nomedolivro;
        private System.Windows.Forms.Label label2categoria;
        private System.Windows.Forms.Label label3qtdvendida;
        private System.Windows.Forms.Label label4valorpagar;
        private System.Windows.Forms.TextBox textBox1nomedolivro;
        private System.Windows.Forms.TextBox textBox3qtd;
        private System.Windows.Forms.TextBox textBox4valorapagar;
        private System.Windows.Forms.Button button1limpar;
        private System.Windows.Forms.Button button2confirmar;
        private System.Windows.Forms.Button button3calcularvalor;
        private System.Windows.Forms.ComboBox comboBox1categoria;
    }
}

