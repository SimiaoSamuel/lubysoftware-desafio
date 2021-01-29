using POO.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.ViewModel
{
    public class BebidaViewModel
    {
        List<Bebida> Estoque = new List<Bebida>() 
        { 
            new Bebida { Id = 1, Nome = "Coca-Cola", Preco = 9, Quantidade = 5 },
            new Bebida { Id = 2, Nome = "Pepsi", Preco = 5, Quantidade = 15 },
            new Bebida { Id = 3, Nome = "Fanta", Preco = 4, Quantidade = 51 },
            new Bebida { Id = 4, Nome = "Soda", Preco = 4, Quantidade = 10 },
            new Bebida { Id = 5, Nome = "Chá", Preco = 3, Quantidade = 6 },
            new Bebida { Id = 6, Nome = "Leite", Preco = 2, Quantidade = 7 },
            new Bebida { Id = 7, Nome = "Redbull", Preco = 10, Quantidade = 10 },
            new Bebida { Id = 8, Nome = "Toddy", Preco = 100, Quantidade = 19 }
        };
        List<Bebida> Carrinho = new List<Bebida>();

        private int vendas = 0;
        private double lucro = 0;
        private Bebida bebidaSelecionada;
        public Label TxtValorAPagar { get; set; }
        public Label TxtLucroBruto { get; set; }
        public TextBox Dinheiro { get; set; }
        public Label TxtTotalVendas { get; set; }
        public NumericUpDown Quantidade { get; set; }

        Button btn;
        public Button MeuButton
        {
            get
            {
                return btn;
            }
            set
            {
                btn = value;
                btn.Click += new EventHandler(this.ButtonAction_Click);
            }
        }

        public virtual void ButtonAction_Click(object sender, EventArgs e)
        {
                if (DataEstoque.CurrentCell.Value != null)
                {
                    Bebida bebida = Estoque.Where(bebida => bebida.Id.Equals(DataEstoque.CurrentCell.Value)).FirstOrDefault();
                    if (bebida != null && bebida.Quantidade >= (int)Quantidade.Value & bebida.Quantidade > 0)
                    {
                        Estoque.Remove(bebida);
                        bebidaSelecionada = new Bebida { Id = bebida.Id, Nome = bebida.Nome, Preco = bebida.Preco };
                        bebidaSelecionada.Quantidade = (int)Quantidade.Value;
                        bebida.Quantidade = bebida.Quantidade - bebidaSelecionada.Quantidade;
                        Estoque.Add(bebida);
                        Carrinho.Add(bebidaSelecionada);
                    }
                    else
                    {
                        MessageBox.Show("Quantidade maior do que o estoque ou nenhum item selecionado");
                    }
                }
            LoadDataGridView();
        }

        Button btnRemover;
        public Button MeuButtonRemover
        {
            get
            {
                return btnRemover;
            }
            set
            {
                btnRemover = value;
                btnRemover.Click += new EventHandler(this.ButtonRemoverAction_Click);
            }
        }

        public virtual void ButtonRemoverAction_Click(object sender, EventArgs e)
        {
            if (DataEstoque.CurrentCell.Value != null)
            {
                Bebida bebida = Carrinho.Where(bebida => bebida.Id.Equals(DataEstoque.CurrentCell.Value)).FirstOrDefault();
                Bebida bebidaEstoque = Estoque.Where(bebida => bebida.Id.Equals(DataEstoque.CurrentCell.Value)).FirstOrDefault();
                if (bebida != null && bebidaEstoque != null)
                {
                    Carrinho.Remove(bebida);
                    Estoque.Remove(bebidaEstoque);
                    
                    bebida.Quantidade = bebida.Quantidade + bebidaEstoque.Quantidade;
                    Estoque.Add(bebida);
                }
            }
            LoadDataGridView();
        }

        Button btnComprar;
        public Button MeuButtonComprar
        {
            get
            {
                return btnComprar;
            }
            set
            {
                btnComprar = value;
                btnComprar.Click += new EventHandler(this.ButtonComprarAction_Click);
            }
        }

        public virtual void ButtonComprarAction_Click(object sender, EventArgs e)
        {
            double valorAPagar = Convert.ToDouble(TxtValorAPagar.Text.Replace("R$ ", ""));
            double dinheiro = 0;
            if(Double.TryParse(Dinheiro.Text, out dinheiro))
            {
                double troco = Math.Round(dinheiro - valorAPagar,2,MidpointRounding.AwayFromZero);
                if(troco >= 0)
                {
                    foreach(Bebida bebida in Carrinho)
                    {
                        vendas += bebida.Quantidade;
                        lucro += bebida.Preco * bebida.Quantidade;
                    }
                    TxtTotalVendas.Text = vendas.ToString();
                    Carrinho.Clear();
                    TxtLucroBruto.Text = "R$ " + lucro.ToString();
                    MessageBox.Show("Seu troco é: R$ " + troco.ToString().Replace(".",","));
                }
                else
                {
                    MessageBox.Show("Valor Menor do que o necessário, está faltando: R$ " + Math.Abs(troco).ToString().Replace(".",","));
                }
            }
            else
            {
                MessageBox.Show("Digite um valor em dinheiro válido");
            }
            LoadDataGridView();
        }

        public DataGridView DataEstoque { get; set; }

        public DataGridView DataCarrinho { get; set; }

        public void LoadDataGridView()
        {
            double valorTotal = 0;
            Carrinho.ForEach(bebida => valorTotal += bebida.Preco * bebida.Quantidade);
            TxtValorAPagar.Text = "R$ " + valorTotal;
            DataEstoque.DataSource = new BindingSource(Estoque, null);
            DataCarrinho.DataSource = new BindingSource(Carrinho, null);
        }
    }
}
