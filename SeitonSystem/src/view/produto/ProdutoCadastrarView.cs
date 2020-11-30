using SeitonSystem.src.controller;
using SeitonSystem.src.dto;
using SeitonSystem.src.view;
using SeitonSystem.src.view.Pedido;
using System;
using System.Windows.Forms;

namespace SeitonSystem.view
{
    public partial class ProdutoCadastrarView : Form
    {
        ProdutoController produtoController;

        public ProdutoCadastrarView()
        {
            InitializeComponent();

            try
            {
                this.produtoController = new ProdutoController();

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                validaProduto();

                Produto produto = new Produto
                {
                    Nome = txt_nome.Text,
                    Preco = double.Parse(txt_preco.Text),
                    Descricao = txt_descricao.Text
                };

                this.produtoController.inserirProduto(produto);
                enviaMsg("Produto Cadastrado!", "check");
                LimparForm();

                ProdutoView p = new ProdutoView();
                p.Show();
                this.Hide();
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        public void LimparForm()
        {
            txt_nome.Clear();
            txt_preco.Clear();
            txt_descricao.Clear();
        }

        private void validaProduto()
        {
            double num;

            if (txt_nome.Text == "" || txt_nome.Text.Length < 2)
            {
                throw new Exception("Informe o Nome");
            }

            if (txt_preco.Text == "")
            {
                throw new Exception("Informe o Preço");
            }

            if (!double.TryParse(txt_preco.Text, out num))
            {
                throw new Exception("Informe um Preço Válido");
            }
        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ClienteView cv = new ClienteView();
            cv.Show();
            this.Hide();
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            ProdutoView p = new ProdutoView();
            p.Show();
            this.Hide();
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            PedidoView p = new PedidoView();
            p.Show();
            this.Hide();
        }

        private void btn_financas_Click(object sender, EventArgs e)
        {
            FinancasView f = new FinancasView();
            f.Show();
            this.Hide();
        }
    }
}

