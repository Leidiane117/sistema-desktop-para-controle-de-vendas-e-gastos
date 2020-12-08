using SeitonSystem.src.controller;
using SeitonSystem.src.dto;
using SeitonSystem.src.view;
using SeitonSystem.src.view.Pedido;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SeitonSystem.view
{
    public partial class ProdutoAtualizarView : Form
    {
        ProdutoController produtoController;
        Produto produto;

        public ProdutoAtualizarView(int idProduto)
        {
            InitializeComponent();

            try
            {
                this.produtoController = new ProdutoController();
                this.produto = new Produto();

                this.produto = produtoController.pesquisaProdutoId(idProduto);
                PreencheTextBox();

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private Produto publicarProduto()
        {
            Produto produto = new Produto();

            
            produto.Id = int.Parse(textID.Text);
            produto.Nome = textAtualizarNome.Text;
            produto.Preco = double.Parse(txtAtualizarPreco.Text);
            produto.Descricao = txtAtualizarDescricao.Text;
            return produto;
    

        }
        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void PreencheTextBox()
        {
            textID.Text = this.produto.Id.ToString();
            textAtualizarNome.Text = this.produto.Nome;
            txtAtualizarPreco.Text = this.produto.Preco.ToString();
            txtAtualizarDescricao.Text = produto.Descricao;
        }

        private void LimparForm()
        {
            textID.Text = "";
            textAtualizarNome.Clear();
            txtAtualizarPreco.Clear();
            txtAtualizarDescricao.Clear();

        }

        private void validaProduto()
        {
            try
            {

                if (string.IsNullOrEmpty(textAtualizarNome.Text)|| string.IsNullOrEmpty(txtAtualizarPreco.Text))
                {
                    throw new Exception("Preencha todos os campos!");


                }
                if (produto.Preco <= 0)
                {
                    throw new Exception("Informe o preço do produto!");
                }

                if (!Regex.Match(txtAtualizarPreco.Text, "^[0-9]{0,4}[,]{0,1}[0-9]{0,4}$").Success)
                {
                    throw new Exception("Informe o preço do produto corretamente!");
                }
                

                if (!Regex.Match(textAtualizarNome.Text, "^[A-Za-zàáâãéèíóôúçÁÀÉÈÍÔÓÕÚÇ ]{3,80}$").Success)
                {
                    throw new Exception("Informe o Nome do produto corretamente!");
                }

               
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Produto produto = publicarProduto();
                validaProduto();
                produtoController.atualizarProduto(produto);

                enviaMsg("Produto Alterado!", "check");
                LimparForm();

                ProdutoView p = new ProdutoView();
                p.Show();
                Close();

            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            ProdutoView p = new ProdutoView();
            p.Show();
            this.Hide();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ClienteView cv = new ClienteView();
            cv.Show();
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








