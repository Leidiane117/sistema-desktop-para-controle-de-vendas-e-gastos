using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeitonSystem.src.dao;
using SeitonSystem.src.view;
using SeitonSystem.src.dto;
using SeitonSystem.src.controller;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SeitonSystem.view
{
    public partial class ProdutoCadastrarView : Form
    {
        ProdutoClassController produtoController;


        public ProdutoCadastrarView()
        {
            InitializeComponent();

            try
            {
                produtoController = new ProdutoClassController();

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
                ProdutoClassPrincipal produto = new ProdutoClassPrincipal
                {
                    Nome = txt_nome.Text,
                    Preco = double.Parse(txtPreco.Text),
                    Descricao = txt_descricao.Text
                };
                if (!Regex.Match(txtPreco.Text, "^[0-9]{0,4}[,]{0,1}[0-9]{1,}$").Success)
                {
                    enviaMsg(" Informe o preço do produto corretamente!", "aviso");
                }
                else if (produto.Preco <=0.00)
                {
                    enviaMsg("Informe o preço do produto!", "aviso");
                }

                else if (!Regex.Match(txt_nome.Text, "^[A-Za-zàáâãéèíóôúçÁÀÉÈÍÔÓÕÚÇ ]{1,80}$").Success)
                {
                    enviaMsg("Informe o Nome do produto corretamente!", "aviso");
                }


                else
                {
                    produtoController.InserirProduto(produto);
                    enviaMsg("Produto Cadastrado com Sucesso", "check");
                    LimparForm();
                }
               
            }
            catch (Exception)
            {
                enviaMsg("Preencha todos os dados corretamente", "erro");
            }

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        public void LimparForm()
        {

            txt_nome.Clear();
            txtPreco.Clear();
            txt_descricao.Clear();



        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }


              
            

        
    }

}