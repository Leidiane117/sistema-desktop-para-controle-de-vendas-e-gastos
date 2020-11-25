using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SeitonSystem.src.dto;
using SeitonSystem.src.controller;
using SeitonSystem.src.view;
using SeitonSystem.src.view.Pedido;
using SeitonSystem.view;

namespace SeitonSystem.src.view{
    public partial class FinancasAtualizarView : Form {
        Financas financas;
        FinancasController financasController;

        public FinancasAtualizarView(int idFluxo) {

            InitializeComponent();
         
            try {

                this.financasController = new FinancasController();
                this.financas = new Financas();

                financas = financasController.pesquisaFinancasId(idFluxo);
                preencheTextBox();

                dt_atualizar.MaxDate = DateTime.Now.AddYears(2);
            }catch (Exception e){
                enviaMsg(e.Message, "erro");
            }
        }

        private void enviaMsg(String msg, String tipo){
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void preencheTextBox() {
            txt_id.Text = this.financas.Id.ToString();
            txt_atualizarTitulo.Text = this.financas.Titulo;
            dt_atualizar.Text = this.financas.Data_lancamento.ToString();
            txt_atualizarValor.Text = this.financas.Valor.ToString();
            txt_atualizarDescricao.Text = this.financas.Descricao;
            cb_atualizar.SelectedItem = this.financas.Tipo_fluxo;
        }

        private void LimparForm()  {
            txt_id.Text = "";
            txt_atualizarTitulo.Clear();
            txt_atualizarValor.Clear();
            txt_atualizarDescricao.Clear(); 
        }

        private void validaFinanca() {
            if (txt_atualizarTitulo.Text.Trim() == ""){
                throw new Exception("Informe o Título");
            }

            if (!Regex.Match(txt_atualizarValor.Text, "^[0-9]{0,4}[,]{0,1}[0-9]{1,}$").Success) {
                throw new Exception("Informe um Valor Válido");
            }

            if (double.Parse(txt_atualizarValor.Text) <= 0){
                throw new Exception("Informe o valor");
            }

            if (cb_atualizar.SelectedItem == null) {
                throw new Exception("Selecione o Tipo de Fluxo");
            }

        }

        private void btn_atualizar_Click(object sender, EventArgs e) {
            try {
                validaFinanca();

                Financas finanças = new Financas {
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

                FinancasView f = new FinancasView();
                f.Show();
                this.Hide();

            }catch (Exception e1){
                enviaMsg(e1.Message, "aviso");
            }

        }

        private void btn_clientes_Click(object sender, EventArgs e){
            ClienteView cv = new ClienteView();
            cv.Show();
            this.Hide();
        }

        private void btn_produtos_Click(object sender, EventArgs e) {
            ProdutoView p = new ProdutoView();
            p.Show();
            this.Hide();
        }

        private void btn_pedidos_Click(object sender, EventArgs e) {
            PedidoView p = new PedidoView();
            p.Show();
            this.Hide();
        }

        private void btn_financas_Click(object sender, EventArgs e)  {
            FinancasView f = new FinancasView();
            f.Show();
            this.Hide();
        }
    }
}
    

















