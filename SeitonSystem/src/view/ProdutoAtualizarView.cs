using System;
using SeitonSystem.src.dto;
using SeitonSystem.src.controller;
using SeitonSystem.src.view;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace SeitonSystem.view
{
    public partial class ProdutoAtualizarView : Form
    {

        ProdutoClassController produtoController;
        ProdutoClassPrincipal produto;


        public ProdutoAtualizarView(int idProduto)
        {
            InitializeComponent();
            try
            {
                produtoController = new ProdutoClassController();
                produto = new ProdutoClassPrincipal();
           
                produto = produtoController.PesquisarPId(idProduto);
                PreencheTextBox();

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }


        private ProdutoClassPrincipal PublicarProduto()
        {
            ProdutoClassPrincipal produto = new ProdutoClassPrincipal
            {
                Id = int.Parse(textID.Text),
                Nome = textAtualizarNome.Text,
                Preco = double.Parse(txtAtualizarPreco.Text),
                Descricao = txtAtualizarDescricao.Text
            };

            return produto;
        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }



        private void PreencheTextBox()
        {

            textID.Text = produto.Id.ToString();
            textAtualizarNome.Text = produto.Nome;
            txtAtualizarPreco.Text = produto.Preco.ToString();
            txtAtualizarDescricao.Text = produto.Descricao;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ProdutoView produtoView = new ProdutoView();
            produtoView.ShowDialog();
        }

        private void btn_limpar_Click_1(object sender, EventArgs e)
        {
            LimparForm();

        }

        private void LimparForm()
        {
            textID.Text = "";
            textAtualizarNome.Clear();
            txtAtualizarPreco.Clear();
            txtAtualizarDescricao.Clear();

        }

        

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            try
            {

                ProdutoClassPrincipal produto = PublicarProduto();
                if (!Regex.Match(txtAtualizarPreco.Text, "^[0-9]{1,4}[,]{0,1}[0-9]{1,2}$").Success)
                {
                    enviaMsg(" Informe o preço do produto corretamente!", "aviso");
                }
                else if (produto.Preco <= 0.00)
                {
                    enviaMsg("Informe o preço do produto!", "aviso");
                }
                

                else if (!Regex.Match(textAtualizarNome.Text, "^[A-Za-zàáâãéèíóôúçÁÀÉÈÍÔÓÕÚÇ ]{1,80}$").Success)
                    {
                    enviaMsg("Informe o Nome do produto corretamente!", "aviso");
                     }
                
                    
                    else
                    {
                        produtoController.EditarProduto(produto);
                        enviaMsg("Produto Alterado com Sucesso", "check");
                        LimparForm();
                    }
                  }
            catch (Exception)
            {
                enviaMsg("Preencha todos os dados corretamente!", "erro");
                               

            }



        }
    }
}
  

    
        


      

      

    





