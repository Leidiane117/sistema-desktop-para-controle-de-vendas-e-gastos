using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeitonSystem.view;
using SeitonSystem.src.view;
using SeitonSystem.src.view.Pedido;
using SeitonSystem.src.dao;
namespace SeitonSystem.src.view.Inicial{
    public partial class InicialView : Form{
        public InicialView(){
            InitializeComponent();
        }

        private void btn_clientes_Click(object sender, EventArgs e) {
            ClienteView c = new ClienteView();
            c.Show();
            this.Hide();
        }

        private void btn_produtos_Click(object sender, EventArgs e) {
            ProdutoView p = new ProdutoView();
            p.Show();
            this.Hide();
        }

        private void btn_pedido_Click(object sender, EventArgs e){
            Pedido.PedidoView p = new Pedido.PedidoView();
            p.Show();
            this.Hide();
        }

        private void btn_financas_Click(object sender, EventArgs e) {
            FinancasView f = new FinancasView();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FinancasCadastrarView financasCadastrarView = new FinancasCadastrarView();
            financasCadastrarView.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FinancasView f = new FinancasView();
            f.Show();
            this.Hide();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            ProdutoCadastrarView produtoCadastrarView = new ProdutoCadastrarView();
            produtoCadastrarView.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteCadastrarView clienteCadastrar = new ClienteCadastrarView();
            clienteCadastrar.Show();
            Hide();

        }

        private void btn_tbPedidos_Click(object sender, EventArgs e)
        {
            PedidoCadastrarView pedido = new PedidoCadastrarView();
            pedido.Show();
            Hide();
        }

        private void btn_bakup_Click(object sender, EventArgs e)
        
            {
                ConnectDAO connectDAO = new ConnectDAO();
                connectDAO.BackupMySql();
            }

          

        private void btn_restore_Click(object sender, EventArgs e)
        {
            ConnectDAO connectDAO = new ConnectDAO();
            connectDAO.RestoreMySql();
        }
    }
}
