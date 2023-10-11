namespace Enunciado_B
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.painel = new System.Windows.Forms.RichTextBox();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.pesquisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apagar = new System.Windows.Forms.TextBox();
            this.botaoApagar = new System.Windows.Forms.Button();
            this.painelApagar = new System.Windows.Forms.RichTextBox();
            this.fornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPRESA XYZ ADM";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(12, 70);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(128, 13);
            this.a.TabIndex = 1;
            this.a.Text = "CÓDIGO DO PRODUTO:";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(12, 100);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(118, 13);
            this.b.TabIndex = 2;
            this.b.Text = "NOME DO PRODUTO:";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(12, 136);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(158, 13);
            this.c.TabIndex = 3;
            this.c.Text = "QUANTIDADE EM ESTOQUE: ";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(143, 67);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(127, 20);
            this.codigo.TabIndex = 4;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(136, 100);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(127, 20);
            this.nome.TabIndex = 5;
            // 
            // quantidade
            // 
            this.quantidade.Location = new System.Drawing.Point(176, 133);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(127, 20);
            this.quantidade.TabIndex = 6;
            // 
            // painel
            // 
            this.painel.Location = new System.Drawing.Point(409, 57);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(236, 297);
            this.painel.TabIndex = 7;
            this.painel.Text = "";
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Location = new System.Drawing.Point(110, 258);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(153, 23);
            this.botaoCadastrar.TabIndex = 8;
            this.botaoCadastrar.Text = "CADASTRAR PRODUTO";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // pesquisa
            // 
            this.pesquisa.Location = new System.Drawing.Point(536, 28);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(109, 20);
            this.pesquisa.TabIndex = 9;
            this.pesquisa.TextChanged += new System.EventHandler(this.pesquisa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PESQUISAR PRODUTO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "APAGAR PRODUTO: ";
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(795, 35);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(109, 20);
            this.apagar.TabIndex = 13;
            // 
            // botaoApagar
            // 
            this.botaoApagar.Location = new System.Drawing.Point(752, 76);
            this.botaoApagar.Name = "botaoApagar";
            this.botaoApagar.Size = new System.Drawing.Size(152, 23);
            this.botaoApagar.TabIndex = 14;
            this.botaoApagar.Text = "APAGAR PRODUTO";
            this.botaoApagar.UseVisualStyleBackColor = true;
            this.botaoApagar.Click += new System.EventHandler(this.botaoApagar_Click);
            // 
            // painelApagar
            // 
            this.painelApagar.Location = new System.Drawing.Point(718, 105);
            this.painelApagar.Name = "painelApagar";
            this.painelApagar.Size = new System.Drawing.Size(236, 77);
            this.painelApagar.TabIndex = 15;
            this.painelApagar.Text = "";
            // 
            // fornecedor
            // 
            this.fornecedor.Location = new System.Drawing.Point(176, 166);
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.Size = new System.Drawing.Size(127, 20);
            this.fornecedor.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "FORNECEDOR: ";
            // 
            // pVenda
            // 
            this.pVenda.Location = new System.Drawing.Point(176, 193);
            this.pVenda.Name = "pVenda";
            this.pVenda.Size = new System.Drawing.Size(127, 20);
            this.pVenda.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "PREÇO DE VENDA:";
            // 
            // pCompra
            // 
            this.pCompra.Location = new System.Drawing.Point(176, 219);
            this.pCompra.Name = "pCompra";
            this.pCompra.Size = new System.Drawing.Size(127, 20);
            this.pCompra.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "PREÇO DE COMPRA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 637);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.painelApagar);
            this.Controls.Add(this.botaoApagar);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pesquisa);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.RichTextBox painel;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.TextBox pesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apagar;
        private System.Windows.Forms.Button botaoApagar;
        private System.Windows.Forms.RichTextBox painelApagar;
        private System.Windows.Forms.TextBox fornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

