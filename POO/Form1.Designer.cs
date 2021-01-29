namespace POO
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridEstoque = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLucro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblValorAPagar = new System.Windows.Forms.Label();
            this.dataGridCarrinho = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.upDownQtd = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblVendasTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estoque";
            // 
            // dataGridEstoque
            // 
            this.dataGridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstoque.Location = new System.Drawing.Point(12, 27);
            this.dataGridEstoque.Name = "dataGridEstoque";
            this.dataGridEstoque.RowTemplate.Height = 25;
            this.dataGridEstoque.Size = new System.Drawing.Size(313, 281);
            this.dataGridEstoque.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendas Total ->";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(548, 335);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lucro Bruto ->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 5;
            // 
            // lblLucro
            // 
            this.lblLucro.AutoSize = true;
            this.lblLucro.Location = new System.Drawing.Point(119, 421);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(29, 15);
            this.lblLucro.TabIndex = 6;
            this.lblLucro.Text = "R$ 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Valor a pagar -> ";
            // 
            // lblValorAPagar
            // 
            this.lblValorAPagar.AutoSize = true;
            this.lblValorAPagar.Location = new System.Drawing.Point(485, 314);
            this.lblValorAPagar.Name = "lblValorAPagar";
            this.lblValorAPagar.Size = new System.Drawing.Size(29, 15);
            this.lblValorAPagar.TabIndex = 8;
            this.lblValorAPagar.Text = "R$ 0";
            // 
            // dataGridCarrinho
            // 
            this.dataGridCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarrinho.Location = new System.Drawing.Point(383, 27);
            this.dataGridCarrinho.Name = "dataGridCarrinho";
            this.dataGridCarrinho.RowTemplate.Height = 25;
            this.dataGridCarrinho.Size = new System.Drawing.Size(324, 284);
            this.dataGridCarrinho.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Carrinho";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Dinheiro -> ";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(460, 335);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(82, 23);
            this.txtDinheiro.TabIndex = 13;
            // 
            // upDownQtd
            // 
            this.upDownQtd.Location = new System.Drawing.Point(88, 314);
            this.upDownQtd.Name = "upDownQtd";
            this.upDownQtd.Size = new System.Drawing.Size(51, 23);
            this.upDownQtd.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Quantidade";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(157, 314);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(713, 27);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 17;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // lblVendasTotal
            // 
            this.lblVendasTotal.AutoSize = true;
            this.lblVendasTotal.Location = new System.Drawing.Point(119, 387);
            this.lblVendasTotal.Name = "lblVendasTotal";
            this.lblVendasTotal.Size = new System.Drawing.Size(13, 15);
            this.lblVendasTotal.TabIndex = 18;
            this.lblVendasTotal.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVendasTotal);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.upDownQtd);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridCarrinho);
            this.Controls.Add(this.lblValorAPagar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLucro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridEstoque);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridEstoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLucro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblValorAPagar;
        private System.Windows.Forms.DataGridView dataGridCarrinho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.NumericUpDown upDownQtd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblVendasTotal;
    }
}

