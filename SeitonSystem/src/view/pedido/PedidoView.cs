using SeitonSystem.src.controller;
using SeitonSystem.src.dto;
using SeitonSystem.src.view.Inicial;
using SeitonSystem.view;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SeitonSystem.src.view.Pedido
{
    public partial class PedidoView : Form
    {
        PedidoController pedidoController;
        ClienteController clienteController;
        ProdutoController produtoController;

        List<Cliente> clientes;
        List<Produto> produtosCadastrados;

        int idPedido;

        int verificar = 0;

        public PedidoView()
        {
            InitializeComponent();

            try
            {
                pedidoController = new PedidoController();
                clienteController = new ClienteController();
                produtoController = new ProdutoController();

                clientes = new List<Cliente>();
                produtosCadastrados = new List<Produto>();

                preencherDataGridView();
                dataGridview(db_pedidos);

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
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

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void preencherDataGridView()
        {
            try
            {
                List<dto.PedidoPesquisa> pedidos = new List<dto.PedidoPesquisa>();
                pedidos = this.pedidoController.pesquisaPedido();

                db_pedidos.Columns.Clear();
                db_pedidos.DataSource = pedidos;
                db_pedidos.Refresh();

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void dataGridview(DataGridView dt)
        {
            dt.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

            dt.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(235, 207, 206);
            dt.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

            dt.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(195, 167, 166);
            dt.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

            dt.BackgroundColor = System.Drawing.Color.FromArgb(235, 207, 206);
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCellStyle style = dt.ColumnHeadersDefaultCellStyle;
            style.BackColor = System.Drawing.Color.FromArgb(153, 88, 63);
            style.ForeColor = Color.White;
            style.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string[] cabecalho = { "Id", "Cliente", "Pedido",
                    "Total","Pagamento", "Entrega","Situação" };

                dt.Columns[i].HeaderText = cabecalho[i];
                dt.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            dt.Columns[0].Width = 50;
            dt.Columns[1].Width = 100;
            dt.Columns[3].Width = 80;
            dt.Columns[6].Width = 110;
            dt.Columns["Total"].DefaultCellStyle.Format = "c";
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            txt_pesquisa.Visible = true;
            linha2.Visible = true;
        }

        private void db_pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panel_pedidos.Visible = true;

                DataGridViewRow row = this.db_pedidos.Rows[e.RowIndex];
                this.idPedido = int.Parse(row.Cells["Id"].Value.ToString());

                if (Convert.ToString(row.Cells["Situação"].Value) == "Finalizado" || Convert.ToString(row.Cells["Situação"].Value) == "Cancelado")
                {
                    this.verificar = 1;
                }
                else
                {
                    this.verificar = 0;
                }
            }
        }

        private void btn_redirecionar_Click(object sender, EventArgs e)
        {
            panel_pedidos.Visible = false;

            PedidoDetailView p = new PedidoDetailView(idPedido);
            p.Show();
            this.Hide();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.verificar != 0)
                {
                    throw new Exception("Não é possível alterar Situação de um Pedido Finalizado ou Cancelado");
                }

                if (cb_situacao.SelectedIndex.Equals(-1))
                {
                    throw new Exception("Informe a Situação");
                }
                else
                {
                    this.pedidoController.atualizarSituacao(cb_situacao.SelectedItem.ToString(), this.idPedido);
                    enviaMsg("Situação Atualizada", "check");

                    if (cb_situacao.SelectedItem.ToString() == "Finalizado")
                    {
                        dto.Pedido p = this.pedidoController.pesquisaPedidoId(this.idPedido);
                        Cliente c = this.clienteController.pesquisaClienteId(p.Id_cliente);

                        Financas f = new Financas
                        {
                            Tipo_fluxo = "Entrada",
                            Titulo = "Pedido " + " de " + c.Nome,
                            Descricao = "Contato:" + c.Celular +
                            ", Data de Entrega: " + p.Data_entrega.Substring(0, 10),
                            Valor = p.Valor_total,
                            Data_lancamento = DateTime.Now
                        };

                        FinancasController financasController = new FinancasController();
                        financasController.inserirFluxo(f);

                        enviaMsg("Pedido Transferido para Finanças", "check");
                    }

                    preencherDataGridView();
                    dataGridview(db_pedidos);
                    panel_pedidos.Visible = false;
                }
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }

        }

        private void txt_pesquisa_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                List<PedidoPesquisa> pedidos = new List<PedidoPesquisa>();

                pedidos = this.pedidoController.pesquisaPedidoFiltro(txt_pesquisa.Text);

                db_pedidos.Columns.Clear();
                db_pedidos.DataSource = pedidos;
                db_pedidos.Refresh();

                dataGridview(db_pedidos);

            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtosCadastrados = this.produtoController.pesquisarProdutos();
                this.clientes = this.clienteController.pesquisaClientes();

                if (this.produtosCadastrados.Count <= 0)
                {
                    throw new Exception("Sem Produtos Cadastrados para Realizar Pedido");
                }

                if (this.clientes.Count <= 0)
                {
                    throw new Exception("Sem Clientes Cadastrados para Realizar Pedido");
                }

                PedidoCadastrarView pc = new PedidoCadastrarView();
                pc.Show();
                this.Hide();

            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }

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

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            InicialView i = new InicialView();
            i.Show();
            this.Hide();
        }

        private void cb_situacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }

}
