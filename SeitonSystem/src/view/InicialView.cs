using MySql.Data.MySqlClient;
using SeitonSystem.src.controller;
using SeitonSystem.src.dao;
using SeitonSystem.src.dto;
using SeitonSystem.src.view.Pedido;
using SeitonSystem.view;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SeitonSystem.src.view.Inicial
{

    public partial class InicialView : Form
    {
        FinancasController financasController;
        PedidoController pedidoController;
        double lucro;
        double entrada;
        double saida;

        public InicialView()
        {
            InitializeComponent();

            try
            {
                pedidoController = new PedidoController();
                financasController = new FinancasController();
                preencherDataGridView();
                dataGridview();

                lucroDia();

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }
        private void preencherDataGridView()
        {
            try
            {
                List<dto.PedidoPesquisa> pedidos = new List<dto.PedidoPesquisa>();
                pedidos = this.pedidoController.pesquisaPedidosPendentes();


                dt.DataSource = pedidos;
               

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }
        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }
        private void dataGridview()
        {
            dt.Columns["Total"].DefaultCellStyle.Format = "c";
            dt.MultiSelect = false; // selecionar apenas uma linha por vez

            for (int i = 0; i < dt.ColumnCount; i++)
            {
                string[] cabecalho = { "Id", "Cliente", "Pedido", "Total", "Pagamento", "Entrega", "Situação" };

                dt.Columns[i].HeaderText = cabecalho[i];
                dt.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            DataGridViewCellStyle style = dt.ColumnHeadersDefaultCellStyle;
            style.ForeColor = Color.White;
            style.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.BackColor = System.Drawing.Color.FromArgb(153, 88, 63);
            
           
            dt.Columns[0].Width = 50;
            dt.Columns[1].Width = 130;
            dt.Columns[2].Width = 100;
            dt.Columns[3].Width = 100;
            dt.Columns[4].Width = 100;
            dt.Columns[5].Width = 100;

        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ClienteView c = new ClienteView();
            c.Show();
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

        private void button6_Click(object sender, EventArgs e)
        {
            FinancasCadastrarView financasCadastrarView = new FinancasCadastrarView();
            financasCadastrarView.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FinancasView2 f = new FinancasView2();
            f.Show();
            this.Hide();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            ProdutoCadastrarView produtoCadastrarView = new ProdutoCadastrarView();
            produtoCadastrarView.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteCadastrarView clienteCadastrar = new ClienteCadastrarView();
            clienteCadastrar.Show();
            Hide();

        }

        private void btn_tbPedidos_Click(object sender, EventArgs e)
        {
            PedidoCadastrarView pedido = new PedidoCadastrarView();
            pedido.Show();
            Hide();
        }


        private void btn_bakup_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;


        }

        public void lucroDia()
        {
            this.lucro = 0;
            this.entrada = 0;
            this.saida = 0;

            calculaLucrosGastos("Último dia", "Entrada");
            calculaLucrosGastos("Último dia", "Saida");

            if (this.lucro <= 0)
            {
                txt_lucro.BackColor = Color.Salmon;
            }
            else
            {
                txt_lucro.BackColor = Color.PaleGreen;
            }

            txt_lucro.Text = "R$" + " " + this.lucro;


        }
        private void calculaLucrosGastos(String periodo, String tipo)
        {
            List<Financas> f = new List<Financas>();

            switch (periodo)
            {
                
                case "Último 3 meses":
                    f = this.financasController.pesquisaFluxosTipoData(tipo, DateTime.Now.AddMonths(-2));
                    break;
                case "Último 6 meses":
                    f = this.financasController.pesquisaFluxosTipoData(tipo, DateTime.Now.AddMonths(-5));
                    break;
                case "Último dia":
                    f = this.financasController.pesquisaFluxosTipoData(tipo, DateTime.Now.Date);
                    break;
            }

            foreach (Financas fi in f)
            {
                if (tipo == "Entrada")
                {
                    this.entrada += fi.Valor;
                }
                else
                {
                    this.saida += fi.Valor;
                }
            }

            this.lucro = this.entrada - this.saida;
           
        }

        private void InicialView_Load(object sender, EventArgs e)
        {



            //textLucro();
        }

        private void btn_abrir_manual_Click(object sender, EventArgs e)
        {
            using (var formWebBrowser = new ManualView())
            {
                formWebBrowser.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroProgressBar1.Value < metroProgressBar1.Maximum)
            {
                metroProgressBar1.Value += 1;
                label_percent.Text = string.Format("Processando {0}%", metroProgressBar1.ProgressTotalPercent);
                label_percent.ForeColor = Color.White;

            }
            else
            {
                timer1.Stop();
                ConnectDAO connect = new ConnectDAO();
                connect.BackupMySql();


            }
        }

        private void btn_ajuda_MouseEnter(object sender, EventArgs e)
        {
            //btn_ajuda.BackColor = Color.Pink;
        }

        private void btn_ajuda_MouseHover(object sender, EventArgs e)
        {
            //btn_ajuda.BackColor = Color.LightPink;
        }
    }

}










