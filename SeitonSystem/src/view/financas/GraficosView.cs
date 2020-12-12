using FluentDateTime;
using SeitonSystem.src.controller;
using SeitonSystem.src.dto;
using SeitonSystem.view;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SeitonSystem.src.view.financas
{
    public partial class GraficosView : Form
    {
        PedidoController pedidoController;
        FinancasController financasController;

        public GraficosView()
        {
            InitializeComponent();

            try
            {
                this.pedidoController = new PedidoController();
                this.financasController = new FinancasController();

                preencheComboBox();

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");

                FinancasView2 f = new FinancasView2();
                f.Show();
                this.Close();
            }
        }

        private void preencheComboBox()
        {
            DateTime data = DateTime.Now;

            cb_pesquisaAno.Items.Add(data.Year);
            cb_pesquisaAno.SelectedItem = data.Year;
            cb_pesquisaData.SelectedIndex = 1;
        }

        private void cb_pesquisaData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_pesquisaAno.SelectedItem != null)
                {
                    escolhePeriodoGraficos();

                    if (gf_entrada.Series[0].Points.Count == 0)
                    {
                        throw new Exception("Dados insuficientes para exibir gráficos");
                    }

                    if (gf_lucro.Series[0].Points.Count == 0)
                    {
                        throw new Exception("Dados insuficientes para exibir gráficos");
                    }

                    if (gf_saida.Series[0].Points.Count == 0)
                    {
                        throw new Exception("Dados insuficientes para exibir gráficos");
                    }

                    if (gf_pedido.Series[0].Points.Count == 0)
                    {
                        throw new Exception("Dados insuficientes para exibir gráficos");
                    }
                }
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "aviso");

                FinancasView2 f = new FinancasView2();
                f.Show();
                this.Close();
            }
        }

        private void cb_pesquisaAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_pesquisaData.SelectedItem != null)
                {
                    escolhePeriodoGraficos();
                }

            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void escolhePeriodoGraficos()
        {
            int ano = int.Parse(cb_pesquisaAno.SelectedItem.ToString());
            DateTime data;

            if (cb_pesquisaAno.SelectedItem.ToString() != DateTime.Now.Year.ToString())
            {
                data = new DateTime(ano, 12, 1);
            }
            else
            {
                data = DateTime.Now;
            }

            if (cb_pesquisaData.SelectedItem.ToString() == "Últimos 6 meses")
            {
                limparGrafico();

                preencheGraficoPedido(data, ano);
                preencheGraficoEntrada(data, ano);
                preencheGraficoSaida(data, ano);
                preencheGraficoLucro(data, ano);

                for (int cont = 1; cont < 5; cont++)
                {
                    preencheGraficoPedido(data.AddMonths(-cont), ano);
                    preencheGraficoEntrada(data.AddMonths(-cont), ano);
                    preencheGraficoSaida(data.AddMonths(-cont), ano);
                    preencheGraficoLucro(data.AddMonths(-cont), ano);
                }

                preencheGraficoProdutos(data, ano, 5);

            }
            else
            {
                limparGrafico();

                preencheGraficoPedido(data, ano);
                preencheGraficoEntrada(data, ano);
                preencheGraficoSaida(data, ano);
                preencheGraficoLucro(data, ano);

                for (int cont = 1; cont < 11; cont++)
                {
                    preencheGraficoPedido(data.AddMonths(-cont), ano);
                    preencheGraficoEntrada(data.AddMonths(-cont), ano);
                    preencheGraficoSaida(data.AddMonths(-cont), ano);
                    preencheGraficoLucro(data.AddMonths(-cont), ano);
                }

                preencheGraficoProdutos(data, ano, 11);
            }
        }

        private void preencheGraficoPedido(DateTime mes, int ano)
        {
            DateTime data = new DateTime(ano, mes.Month, 1);

            List<dto.Pedido> pedidos = new List<dto.Pedido>();
            pedidos = this.pedidoController.pesquisaPedidoData(data, data.LastDayOfMonth());

            if (pedidos.Count != 0)
            {
                gf_pedido.Series[0].Points.AddXY(data.ToString("MMM"), pedidos.Count);
            }
        }

        private void preencheGraficoEntrada(DateTime mes, int ano)
        {
            DateTime data = new DateTime(ano, mes.Month, 1);

            List<Financas> financas = new List<Financas>();
            financas = this.financasController.pesquisaFluxosTipoDataPeriodo("Entrada", data, data.LastDayOfMonth());

            double valor = 0;

            foreach (Financas f in financas)
            {
                valor += f.Valor;
            }

            String desc = data.ToString("MMM") + "- R$" + valor;

            if (valor > 0)
            {
                gf_entrada.Series[0].Points.AddXY(desc, valor);
            }
        }

        private void preencheGraficoSaida(DateTime mes, int ano)
        {
            DateTime data = new DateTime(ano, mes.Month, 1);

            List<Financas> financas = new List<Financas>();
            financas = this.financasController.pesquisaFluxosTipoDataPeriodo("Saída", data, data.LastDayOfMonth());

            double valor = 0;

            foreach (Financas f in financas)
            {
                valor += f.Valor;
            }

            String desc = data.ToString("MMM") + "- R$" + valor;

            if (valor > 0)
            {
                gf_saida.Series[0].Points.AddXY(desc, valor);
            }
        }

        private void preencheGraficoLucro(DateTime mes, int ano)
        {
            DateTime data = new DateTime(ano, mes.Month, 1);

            List<Financas> financasEntrada = new List<Financas>();
            List<Financas> financasSaida = new List<Financas>();

            financasEntrada = this.financasController.pesquisaFluxosTipoDataPeriodo("Entrada", data, data.LastDayOfMonth());
            financasSaida = this.financasController.pesquisaFluxosTipoDataPeriodo("Saida", data, data.LastDayOfMonth());

            double valorEntrada = 0;
            double valorSaida = 0;

            foreach (Financas f in financasEntrada)
            {
                valorEntrada += f.Valor;
            }

            foreach (Financas f in financasSaida)
            {
                valorSaida += f.Valor;
            }

            double lucro = valorEntrada - valorSaida;
            if (lucro > 0)
            {
                gf_lucro.Series[0].Points.AddXY(data.ToString("MMM"), lucro);
            }
        }

        private void preencheGraficoProdutos(DateTime mes, int ano, int cont)
        {
            int cont2 = 0;
            DateTime data = new DateTime(ano, mes.Month, 1);
            DateTime data2 = new DateTime(ano, mes.AddMonths(-cont).Month, 1);

            List<ProdutoPesquisa> p = new List<ProdutoPesquisa>();

            if (data < data2)
            {
                p = this.pedidoController.pesquisaProdutoMaisVendidoData(data, data2.LastDayOfMonth());
            }
            else
            {
                p = this.pedidoController.pesquisaProdutoMaisVendidoData(data2, data.LastDayOfMonth());
            }

            if (p.Count > 0)
            {
                foreach (ProdutoPesquisa pr in p)
                {
                    if (cont2 <= 4)
                    {
                        gf_produtos.Series[0].Points.AddXY(pr.Nome, pr.Quantidade);
                    }
                    cont2++;
                }
            }
        }

        private void limparGrafico()
        {
            foreach (var serie in gf_pedido.Series)
            {
                serie.Points.Clear();
            }

            foreach (var serie in gf_entrada.Series)
            {
                serie.Points.Clear();
            }

            foreach (var serie in gf_saida.Series)
            {
                serie.Points.Clear();
            }

            foreach (var serie in gf_lucro.Series)
            {
                serie.Points.Clear();
            }

            foreach (var serie in gf_produtos.Series)
            {
                serie.Points.Clear();
            }
        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView m = new MensagensView(msg, tipo);
            m.ShowDialog();
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
            Pedido.PedidoView p = new Pedido.PedidoView();
            p.Show();
            this.Hide();
        }

        private void btn_financas_Click(object sender, EventArgs e)
        {
            FinancasView2 f = new FinancasView2();
            f.Show();
            this.Hide();
        }

        private void gf_entrada_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
