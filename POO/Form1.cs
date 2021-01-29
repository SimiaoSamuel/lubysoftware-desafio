using POO.Model;
using POO.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        BebidaViewModel bvw = null;
        public Form1()
        {
            InitializeComponent();
            
            bvw = new BebidaViewModel {MeuButton = btnAdicionar, MeuButtonComprar = btnComprar, MeuButtonRemover = btnRemover
                ,DataCarrinho = dataGridCarrinho, DataEstoque = dataGridEstoque, TxtValorAPagar = lblValorAPagar
                , TxtLucroBruto = lblLucro, TxtTotalVendas = lblVendasTotal, Dinheiro = txtDinheiro, Quantidade = upDownQtd};
            bvw.LoadDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
