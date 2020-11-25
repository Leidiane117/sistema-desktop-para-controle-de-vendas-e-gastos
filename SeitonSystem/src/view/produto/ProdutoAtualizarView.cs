using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeitonSystem.src.dao;
using SeitonSystem.src.dto;
using SeitonSystem.src.controller;
using SeitonSystem.src.view;
using System.Windows.Forms;
using SeitonSystem.src.view.Pedido;

namespace SeitonSystem.view{
    public partial class ProdutoAtualizarView : Form {
        ProdutoController produtoController;
        Produto produto;
  
        public ProdutoAtualizarView(int idProduto){
            InitializeComponent();

            try {
                this.produtoController = new ProdutoController();
                this.produto = new Produto();

                this.produto = produtoController.pesquisaProdutoId(idProduto);
                PreencheTextBox();

            }catch (Exception e) {
                enviaMsg(e.Message, "erro");
            }
        }
       
        private Produto PublicarProduto() {
            Produto produto = new Produto
            {
                Id = int.Parse(textID.Text),
                Nome = textAtualizarNome.Text,
                Preco = double.Parse(txtAtualizarPreco.Text),
                Descricao = txtAtualizarDescricao.Text
            };

            return produto;
        }

        private void enviaMsg(String msg, String tipo) {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void PreencheTextBox(){
            textID.Text = this.produto.Id.ToString();
            textAtualizarNome.Text = this.produto.Nome;
            txtAtualizarPreco.Text = this.produto.Preco.ToString();
            txtAtualizarDescricao.Text = produto.Descricao;
        }

        private void LimparForm(){
            textID.Text = "";
            textAtualizarNome.Clear();
            txtAtualizarPreco.Clear();
            txtAtualizarDescricao.Clear();

        }

        private void validaProduto(){
            double num;

            if(textAtualizarNome.Text == "" || textAtualizarNome.Text.Length < 2){
                throw new Exception("Informe o Nome");
            }

            if (txtAtualizarPreco.Text == ""){
                throw new Exception("Informe o Preço");
            }

            if (!double.TryParse(txtAtualizarPreco.Text, out num)) {
                throw new Exception("Informe um Preço Válido");
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e){
            try {
                validaProduto();

                Produto produto = PublicarProduto();
                produtoController.atualizarProduto(produto);

                enviaMsg("Produto Alterado!", "check");
                LimparForm();

                ProdutoView p = new ProdutoView();
                p.Show();
                this.Hide();

            }catch (Exception e1){
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void btn_produtos_Click(object sender, EventArgs e){
            ProdutoView p = new ProdutoView();
            p.Show();
            this.Hide();
        }

        private void btn_clientes_Click(object sender, EventArgs e){
            ClienteView cv = new ClienteView();
            cv.Show();
            this.Hide();
        }

        private void btn_pedido_Click(object sender, EventArgs e){
            PedidoView p = new PedidoView();
            p.Show();
            this.Hide();
        }

        private void btn_financas_Click(object sender, EventArgs e) {
            FinancasView f = new FinancasView();
            f.Show();
            this.Hide();
        }
    }

}








