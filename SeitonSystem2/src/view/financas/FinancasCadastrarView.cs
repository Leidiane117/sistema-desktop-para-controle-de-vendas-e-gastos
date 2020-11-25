using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeitonSystem.src.controller;
using System.Text.RegularExpressions;
using SeitonSystem.src.dto;
using SeitonSystem.view;
using SeitonSystem.src.view;
using SeitonSystem.src.view.Pedido;

namespace SeitonSystem.src.view {
    public partial class FinancasCadastrarView : Form {
        FinancasController financasController;
        public FinancasCadastrarView() {
            InitializeComponent();

            try{
                financasController = new FinancasController();

                dt_cadastrar.MinDate = DateTime.Now.AddMonths(-4);
                dt_cadastrar.MaxDate = DateTime.Now.AddYears(2);

            }catch (Exception e){
                enviaMsg(e.Message, "erro");
            }
        }

        private void validaFinanca() {
            if(txt_titulo.Text.Trim() == "") {
                throw new Exception("Informe o Título");
            }

            if (!Regex.Match(txt_valor.Text, "^[0-9]{0,4}[,]{0,1}[0-9]{1,}$").Success){
                throw new Exception("Informe um Valor Válido");
            }

            if (double.Parse(txt_valor.Text) <= 0){
                throw new Exception("Informe o valor");
            }

            if(cb_cadastrar.SelectedItem == null) {
                throw new Exception("Selecione o Tipo de Fluxo");
            }

        }

        private void btn_salvar_Click(object sender, EventArgs e) {
            try {
                validaFinanca();

                Financas financas = new Financas{
                    Titulo = txt_titulo.Text,
                    Valor = double.Parse(txt_valor.Text),
                    Descricao = txt_descricao.Text,
                    Data_lancamento= DateTime.Parse(dt_cadastrar.Text),
                    Tipo_fluxo= cb_cadastrar.SelectedItem.ToString()
                };
                
                this.financasController.inserirFluxo(financas);
                enviaMsg("Atividade Cadastrada!", "check");
                limparForm();

                FinancasView f = new FinancasView();
                f.Show();
                this.Hide();

            }catch (Exception e1){
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void enviaMsg(String msg, String tipo) {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        public void limparForm() {
            txt_valor.Clear();
            txt_titulo.Clear();
            txt_descricao.Clear();
            cb_cadastrar.SelectedItem = null;
        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            limparForm();
        }

        private void btn_clientes_Click(object sender, EventArgs e){
            ClienteView cv = new ClienteView();
            cv.Show();
            this.Hide();
        }

        private void btn_produtos_Click(object sender, EventArgs e){
            ProdutoView p = new ProdutoView();
            p.Show();
            this.Hide();
        }

        private void btn_pedidos_Click(object sender, EventArgs e){
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
