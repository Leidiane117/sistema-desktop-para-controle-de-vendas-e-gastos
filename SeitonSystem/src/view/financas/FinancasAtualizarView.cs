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
    public partial class FinancasAtualizarView : Form
    {
        Financas financas;
        FinancasController financasController;

        public FinancasAtualizarView(int idFluxo)
        {

            InitializeComponent();

            try
            {

                this.financasController = new FinancasController();
                this.financas = new Financas();

                financas = financasController.pesquisaFinancasId(idFluxo);
                preencheTextBox();
                dataPikcerformat();

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void dataPikcerformat()
        {
            dt_atualizar.Value = DateTime.Now;
            dt_atualizar.CalendarMonthBackground = Color.Aquamarine;
            dt_atualizar.MaxDate = DateTime.Now.AddDays(60);
            dt_atualizar.MinDate = DateTime.Now.AddDays(-60);


        }
        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void preencheTextBox()
        {
            txt_id.Text = this.financas.Id.ToString();
            txt_atualizarTitulo.Text = this.financas.Titulo;
            txt_atualizarValor.Text = this.financas.Valor.ToString();
            txt_atualizarDescricao.Text = this.financas.Descricao;
            cb_atualizar.SelectedItem = this.financas.Tipo_fluxo;
        }

        private void LimparForm()
        {
            txt_id.Text = "";
            txt_atualizarTitulo.Clear();
            txt_atualizarValor.Clear();
            txt_atualizarDescricao.Clear();
        }

        private void validaFinanca()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_atualizarTitulo.Text) || string.IsNullOrEmpty(txt_atualizarValor.Text))
                {
                    throw new Exception("Preencha todos os campos!");


                }
                if (!Regex.Match(txt_atualizarValor.Text, "^[0-9]{0,4}[,]{0,1}[0-9]{0,4}$").Success)
                {
                    throw new Exception("Informe o valor corretamente!");
                }
                if (double.Parse(txt_atualizarValor.Text) <= 0)
                {
                    throw new Exception("Informe o valor!");
                }

                if (!Regex.Match(txt_atualizarTitulo.Text, "^[A-Za-zàáâãéèíóôúçÁÀÉÈÍÔÓÕÚÇ ]{3,80}$").Success)
                {
                    throw new Exception("Informe o titulo corretamente!");
                }
                if (cb_atualizar.SelectedItem == null)
                {
                    throw new Exception("Selecione o Tipo de Fluxo");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                validaFinanca();

                Financas finanças = new Financas
                {
                    Id = int.Parse(txt_id.Text),
                    Titulo = txt_atualizarTitulo.Text,
                    Valor = double.Parse(txt_atualizarValor.Text),
                    Descricao = txt_atualizarDescricao.Text,
                    Data_lancamento = DateTime.Parse(dt_atualizar.Text),
                    Tipo_fluxo = cb_atualizar.SelectedItem.ToString()
                };

                this.financasController.atualizarFluxo(finanças);
                enviaMsg("Atividade Atualizada", "check");
                LimparForm();

                FinancasView2 f = new FinancasView2();
                f.Show();
                this.Hide();

            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "aviso");
            }

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

        private void cb_atualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}


















