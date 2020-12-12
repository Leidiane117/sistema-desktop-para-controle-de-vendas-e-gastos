using SeitonSystem.src.controller;
using SeitonSystem.src.dto;
using SeitonSystem.src.view.Pedido;
using SeitonSystem.view;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SeitonSystem.src.view
{
    public partial class FinancasCadastrarView : Form
    {
        FinancasController financasController;
        public FinancasCadastrarView()
        {
            InitializeComponent();

            try
            {
                financasController = new FinancasController();
                dataPikcerformat();


            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void validaFinanca()
        {
           try 
            { 
            if (string.IsNullOrEmpty(txt_titulo.Text) || string.IsNullOrEmpty(txt_valor.Text))
            {
                throw new Exception("Preencha todos os campos!");


            }
            if (!Regex.Match(txt_valor.Text, "^[0-9]{0,4}[,]{0,1}[0-9]{0,4}$").Success)
            {
                throw new Exception("Informe o valor corretamente!");
            }
            if (double.Parse(txt_valor.Text) <= 0)
            {
                throw new Exception("Informe o valor!");
            }

            if (!Regex.Match(txt_titulo.Text, "^[A-Za-zàáâãéèíóôúçÁÀÉÈÍÔÓÕÚÇ ]{3,80}$").Success)
            {
                throw new Exception("Informe o titulo corretamente!");
            }
           if (cb_cadastrar.SelectedItem == null)
           {
                    throw new Exception("Selecione o Tipo de Fluxo");
           }
          }
           catch (Exception){

                throw;
            }
   
       }
        private void dataPikcerformat()
        {
            dt_cadastrar.Value = DateTime.Now;
            dt_cadastrar.MaxDate = DateTime.Now.AddDays(60);
            dt_cadastrar.MinDate = DateTime.Now.AddDays(-60);


        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                validaFinanca();

                Financas financas = new Financas
                {
                    Titulo = txt_titulo.Text,
                    Valor = double.Parse(txt_valor.Text),
                    Descricao = txt_descricao.Text,
                    Data_lancamento = DateTime.Parse(dt_cadastrar.Text),
                    Tipo_fluxo = cb_cadastrar.SelectedItem.ToString()
                };

                this.financasController.inserirFluxo(financas);
                enviaMsg("Atividade Cadastrada!", "check");
                limparForm();

                FinancasView2 f = new FinancasView2();
                f.Show();
                this.Hide();

            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        public void limparForm()
        {
            txt_valor.Clear();
            txt_titulo.Clear();
            txt_descricao.Clear();
            cb_cadastrar.SelectedItem = null;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limparForm();
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

        private void btn_pedidos_Click(object sender, EventArgs e)
        {
            PedidoView p = new PedidoView();
            p.Show();
            this.Hide();
        }

        private void btn_financas_Click(object sender, EventArgs e)
        {
            FinancasView2 f = new FinancasView2();
            f.Show();
            this.Hide();
        }
    }
}
