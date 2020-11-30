using SeitonSystem.src.controller;
using SeitonSystem.src.dto;
using SeitonSystem.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SeitonSystem.src.view.Pedido
{
    public partial class PedidoDetailView : Form
    {
        PedidoController pedidoController;
        ClienteController clienteController;
        ProdutoController produtoController;

        int idPedido;
        int colunaIndex;

        double valorTotal = 0;

        Cliente cliente;
        List<ProdutoPesquisa> produtos;
        List<Produto> produtosCadastrados;
        dto.Pedido pedido;
        dto.Pedido endereco;

        public PedidoDetailView(int id)
        {
            InitializeComponent();

            try
            {
                produtos = new List<ProdutoPesquisa>();
                produtosCadastrados = new List<Produto>();

                pedidoController = new PedidoController();
                clienteController = new ClienteController();
                produtoController = new ProdutoController();

                pedido = new dto.Pedido();
                endereco = new dto.Pedido();

                this.idPedido = id;

                this.pedido = this.pedidoController.pesquisaPedidoId(this.idPedido);
                this.cliente = this.clienteController.pesquisaClienteId(this.pedido.Id_cliente);

                cb_tipoPedido.SelectedItem = this.pedido.Tipo_pedido;
                this.valorTotal = this.pedido.Valor_total;

                txt_dataEntrega.Value = DateTime.Now;
                txt_dataEntrega.CalendarMonthBackground = Color.Aquamarine;
                txt_dataEntrega.MaxDate = DateTime.Now.AddDays(60);
                txt_dataEntrega.MinDate = DateTime.Now.AddDays(-60);
               
              

                preencheComboBoxProduto();
                preencheDataGrid();

                dataGridview(db_produtos);
                dataGridview(db_produtosE);

                if (pedido.Tipo_pedido == "Entrega")
                {
                    panel_dadosEntrega.Visible = true;
                    panel_dadosRetirada.Visible = false;

                    endereco = this.pedidoController.pesquisaEnderecoId(this.idPedido);
                    preencheTextBoxEntrega();

                }
                else
                {
                    panel_dadosEntrega.Visible = false;
                    panel_dadosRetirada.Visible = true;

                    preencheTextBox();
                }

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            PedidoView p = new PedidoView();
            p.Show();
            this.Hide();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ClienteView c = new ClienteView();
            c.Show();
            this.Hide();
        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void preencheComboBoxProduto()
        {
            try
            {
                this.produtosCadastrados = this.produtoController.pesquisarProdutos();

                foreach (Produto p in this.produtosCadastrados)
                {
                    cb_produtos.Items.Add(p);
                    cb_produtosE.Items.Add(p);
                }

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }

        }
        private void atualizaValorTotal()
        {
            this.valorTotal = 0;

            foreach (ProdutoPesquisa p in this.produtos)
            {
                this.valorTotal += p.Preco * p.Quantidade;
            }

            txt_valorTotal.Text = this.valorTotal.ToString();
            txt_valorTotalE.Text = this.valorTotal.ToString();
        }

        private void preencheTextBox()
        {
            txt_idPedido.Text = this.pedido.Id_pedido.ToString();
            txt_cliente.Text = this.cliente.ToString();

            cb_situacao.SelectedItem = this.pedido.Situacao_pedido;
            cb_tipoPag.SelectedItem = this.pedido.Tipo_pagamento;

            txt_valorTotal.Text = this.pedido.Valor_total.ToString();

            txt_dataEntrega.Value = DateTime.Parse(this.pedido.Data_entrega, new CultureInfo("pt-BR"));
            txt_dataPag.Value = DateTime.Parse(this.pedido.Data_pagamento, new CultureInfo("pt-BR"));

            txt_horaEntrega.Value = DateTime.Parse(this.pedido.Hora_entrega, new CultureInfo("pt-BR"));
        }

        private void preencheTextBoxEntrega()
        {
            txt_idPedidoE.Text = this.pedido.Id_pedido.ToString();
            txt_clienteE.Text = this.cliente.ToString();

            cb_situacaoE.SelectedItem = this.pedido.Situacao_pedido;
            cb_tipoPagE.SelectedItem = this.pedido.Tipo_pagamento;

            txt_valorTotalE.Text = this.pedido.Valor_total.ToString();

            txt_dataEntregaE.Value = DateTime.Parse(this.pedido.Data_entrega, new CultureInfo("pt-BR"));
            txt_dataPagE.Value = DateTime.Parse(this.pedido.Data_pagamento, new CultureInfo("pt-BR"));

            txt_horaEntregaE.Value = DateTime.Parse(this.pedido.Hora_entrega, new CultureInfo("pt-BR"));

            txt_logradouro.Text = this.endereco.Logradouro;
            txt_numero.Text = this.endereco.Numero.ToString();
            txt_cep.Text = this.endereco.Cep;
            txt_bairro.Text = this.endereco.Bairro;
            txt_compl.Text = this.endereco.Complemento;
            txt_cidade.Text = this.endereco.Cidade;
            txt_uf.Text = this.endereco.Uf;
        }

        private void preencheDataGrid()
        {
            try
            {
                this.produtos = this.pedidoController.pesquisaProduto(this.idPedido);

                db_produtos.DataSource = this.produtos;
                db_produtosE.DataSource = this.produtos;
            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void dataGridview(DataGridView dt)
        {
            dt.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(235, 207, 206);
            dt.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

            dt.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(195, 167, 166);
            dt.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

            dt.BackgroundColor = System.Drawing.Color.FromArgb(235, 207, 206);
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCellStyle style = dt.ColumnHeadersDefaultCellStyle;
            style.BackColor = System.Drawing.Color.FromArgb(153, 88, 63);
            style.ForeColor = Color.White;
            style.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dt.Columns["Id"].Width = 30;
            dt.Columns["Nome"].Width = 90;
            dt.Columns["Quantidade"].Width = 80;
            dt.Columns["Observacao"].Width = 100;
            dt.Columns["Preco"].DefaultCellStyle.Format = "c";
           

        }

        private void txt_cep_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_cep.Text.Trim() == "")
                {
                    throw new Exception("Informe o CEP para consulta");
                }
                else
                {
                    using (var ws = new WSCorreios.AtendeClienteClient())
                    {
                        var endereco = ws.consultaCEP(txt_cep.Text.Trim());

                        txt_logradouro.Text = endereco.end;
                        txt_bairro.Text = endereco.bairro;
                        txt_cidade.Text = endereco.cidade;
                        txt_uf.Text = endereco.uf;
                    }
                }
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "aviso");
            }
        }


        private void db_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_produtos.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.db_produtos.Rows[e.RowIndex];
                this.colunaIndex = row.Index;

                btn_limpar.Visible = true;
                btn_addProduto.Enabled = false;

                txt_quantidade.Enabled = false;
                txt_obs.Enabled = false;

                txt_quantidade.Value = int.Parse(row.Cells["Quantidade"].Value.ToString());
                txt_obs.Text = row.Cells["Observacao"].Value.ToString();
            }
        }

        private void db_produtosE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_produtosE.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.db_produtosE.Rows[e.RowIndex];
                this.colunaIndex = row.Index;

                btn_limparE.Visible = true;
                btn_addProdutoE.Enabled = false;

                txt_quantidadeE.Enabled = false;
                txt_obsE.Enabled = false;

                txt_quantidadeE.Value = int.Parse(row.Cells["Quantidade"].Value.ToString());
                txt_obsE.Text = row.Cells["Observacao"].Value.ToString();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            this.produtos.RemoveAt(this.colunaIndex);

            db_produtos.DataSource = null;
            db_produtos.DataSource = this.produtos;
            dataGridview(db_produtos);

            btn_addProduto.Enabled = true;
            btn_limpar.Visible = false;

            txt_quantidade.Value = 0;
            txt_obs.Clear();

            atualizaValorTotal();

            panel_produtos.Visible = false;

            txt_quantidade.Enabled = true;
            txt_obs.Enabled = true;
        }

        private void btn_excluirE_Click(object sender, EventArgs e)
        {
            this.produtos.RemoveAt(this.colunaIndex);

            db_produtosE.DataSource = null;
            db_produtosE.DataSource = this.produtos;
            dataGridview(db_produtosE);

            btn_addProdutoE.Enabled = true;
            btn_limparE.Visible = false;

            txt_quantidadeE.Value = 0;
            txt_obsE.Clear();

            atualizaValorTotal();

            panel_produtosE.Visible = false;

            txt_quantidadeE.Enabled = true;
            txt_obsE.Enabled = true;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            btn_addProduto.Enabled = true;
            btn_addProduto.Visible = false;

            btn_limpar.Visible = false;

            txt_quantidade.Value = 0;
            txt_obs.Clear();

            panel_produtos.Visible = false;
        }

        private void btn_limparE_Click(object sender, EventArgs e)
        {
            btn_addProdutoE.Enabled = true;
            btn_addProdutoE.Visible = false;

            btn_limparE.Visible = false;

            txt_quantidadeE.Value = 0;
            txt_obsE.Clear();

            panel_produtosE.Visible = false;
        }

        private void validaPedido()
        {
            if (cb_tipoPag.SelectedItem == null)
            {
                throw new Exception("Informe o Tipo de Pagamento");
            }

            if (txt_dataEntrega.Value < DateTime.Parse(this.pedido.Data_pagamento, new CultureInfo("pt-BR")))
            {
                throw new Exception("Informe uma Data de Entrega Válida");
            }

            DateTime dt = Convert.ToDateTime(txt_horaEntrega.Value);
            if (dt.Hour >= 0 && dt.Hour <= 6)
            {
                throw new Exception("Informe uma Hora Válida");
            }

            if (this.produtos.Count <= 0)
            {
                throw new Exception("Selecione os Produtos para o Pedido");
            }
        }

        private void validaPedidoEntrega()
        {
            int num;

            if (cb_tipoPagE.SelectedItem == null)
            {
                throw new Exception("Informe o Tipo de Pagamento");
            }

            if (txt_dataEntregaE.Value < DateTime.Parse(this.pedido.Data_pagamento, new CultureInfo("pt-BR")))
            {
                throw new Exception("Informe uma Data de Entrega Válida");
            }

            DateTime dt = Convert.ToDateTime(txt_horaEntregaE.Value);
            if (dt.Hour >= 0 && dt.Hour <= 6)
            {
                throw new Exception("Informe uma Hora Válida");
            }

            if (this.produtos.Count <= 0)
            {
                throw new Exception("Selecione os Produtos para o Pedido");
            }

            if (txt_cep.Text == null || txt_cep.Text.Trim() == "")
            {
                throw new Exception("Informe o CEP");
            }

            if (txt_cep.Text.Length < 8 || !int.TryParse(txt_cep.Text, out num))
            {
                throw new Exception("Informe um CEP Válido");
            }

            if (txt_logradouro.Text == null || txt_logradouro.Text.Trim() == "")
            {
                throw new Exception("Informe o Logradouro");
            }

            if (txt_cidade.Text == null || txt_cidade.Text.Trim() == "")
            {
                throw new Exception("Informe a Cidade");
            }

            if (txt_uf.Text == null || txt_uf.Text.Trim() == "")
            {
                throw new Exception("Informe o UF");
            }

            if (txt_uf.Text.Length < 2)
            {
                throw new Exception("Informe um UF Válido");
            }

            if (txt_numero.Text == null || txt_numero.Text.Trim() == "")
            {
                throw new Exception("Informe o Número");
            }

            if (txt_numero.Text.Where(c => char.IsNumber(c)).Count() == 0)
            {
                throw new Exception("Informe um Número Válido");
            }

            if (Convert.ToInt32(txt_numero.Text) <= 0)
            {
                throw new Exception("Informe um Número Válido");
            }

            if (txt_bairro.Text == null || txt_bairro.Text.Trim() == "")
            {
                throw new Exception("Informe o Bairro");
            }


        }

        private void validaProduto()
        {
            if (txt_quantidade.Value <= 0)
            {
                throw new Exception("Informe a Quantidade");
            }

            if (cb_produtos.SelectedItem == null)
            {
                throw new Exception("Selecione um Produto");
            }
        }

        private void validaProdutoE()
        {
            if (txt_quantidadeE.Value <= 0)
            {
                throw new Exception("Informe a Quantidade");
            }

            if (cb_produtosE.SelectedItem == null)
            {
                throw new Exception("Selecione um Produto");
            }
        }

        private void btn_addProduto_Click(object sender, EventArgs e)
        {
            try
            {
                int cont = 0;

                validaProduto();

                Produto p = (Produto)cb_produtos.SelectedItem;
                ProdutoPesquisa produto = new ProdutoPesquisa();

                produto.Id = p.Id;
                produto.Nome = p.Nome;
                produto.Preco = p.Preco;
                produto.Quantidade = int.Parse(txt_quantidade.Value.ToString());
                produto.Observacao = txt_obs.Text;

                foreach (ProdutoPesquisa pr in this.produtos)
                {
                    if (pr.Id == produto.Id)
                    {
                        pr.Quantidade += produto.Quantidade;
                        cont = 1;
                    }
                }

                if (cont != 1)
                {
                    this.produtos.Add(produto);
                }

                db_produtos.DataSource = null;
                db_produtos.DataSource = this.produtos;
                dataGridview(db_produtos);

                atualizaValorTotal();

                cb_produtos.SelectedItem = null;

                txt_quantidade.Value = 0;
                txt_obs.Clear();

                btn_addProduto.Visible = false;
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        private void btn_addProdutoE_Click(object sender, EventArgs e)
        {
            try
            {
                int cont = 0;

                validaProdutoE();

                Produto p = (Produto)cb_produtosE.SelectedItem;
                ProdutoPesquisa produto = new ProdutoPesquisa();

                produto.Id = p.Id;
                produto.Nome = p.Nome;
                produto.Preco = p.Preco;
                produto.Quantidade = int.Parse(txt_quantidadeE.Value.ToString());
                produto.Observacao = txt_obsE.Text;

                foreach (ProdutoPesquisa pr in this.produtos)
                {
                    if (pr.Id == produto.Id)
                    {
                        pr.Quantidade += produto.Quantidade;
                        cont = 1;
                    }
                }

                if (cont != 1)
                {
                    this.produtos.Add(produto);
                }

                db_produtosE.DataSource = null;
                db_produtosE.DataSource = this.produtos;
                dataGridview(db_produtosE);

                atualizaValorTotal();

                cb_produtosE.SelectedItem = null;

                txt_quantidadeE.Value = 0;
                txt_obsE.Clear();

                btn_addProdutoE.Visible = false;
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (this.pedido.Situacao_pedido != "Finalizado" && this.pedido.Situacao_pedido != "Cancelado")
            {
                btn_atualizar.Enabled = false;
                btn_salvar.Visible = true;
                btn_cancelar.Visible = true;

                mudaCampos(true);
            }
            else
            {
                enviaMsg("Não é possível Atualizar Pedido Cancelado ou Finalizado", "erro");
            }

        }

        private void mudaCampos(bool a)
        {
            cb_tipoPedido.Enabled = a;

            cb_tipoPag.Enabled = a;
            cb_situacao.Enabled = a;
            cb_produtos.Enabled = a;

            txt_dataEntrega.Enabled = a;
            txt_dataPag.Enabled = a;
            txt_horaEntrega.Enabled = a;

            txt_quantidade.Enabled = a;
            txt_obs.Enabled = a;

            txt_logradouro.Enabled = a;
            txt_numero.Enabled = a;
            txt_bairro.Enabled = a;
            txt_cep.Enabled = a;
            txt_compl.Enabled = a;
            txt_cidade.Enabled = a;
            txt_uf.Enabled = a;

            cb_tipoPagE.Enabled = a;
            cb_situacaoE.Enabled = a;
            cb_produtosE.Enabled = a;

            txt_dataEntregaE.Enabled = a;
            txt_dataPagE.Enabled = a;
            txt_horaEntregaE.Enabled = a;

            txt_quantidadeE.Enabled = a;
            txt_obsE.Enabled = a;

            db_produtos.Enabled = a;
            db_produtosE.Enabled = a;
        }

        private void cb_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_addProduto.Visible = true;
        }

        private void cb_produtosE_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_addProdutoE.Visible = true;
        }

        private void cb_tipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipoPedido.SelectedItem.ToString() == "Retirada")
            {
                panel_dadosEntrega.Visible = false;
                panel_dadosRetirada.Visible = true;

                preencheTextBox();

                cb_tipoPedido.SelectedItem = "Retirada";

                preencheDataGrid();
            }
            else
            {
                panel_dadosRetirada.Visible = false;
                panel_dadosEntrega.Visible = true;

                preencheTextBoxEntrega();

                cb_tipoPedido.SelectedItem = "Entrega";

                preencheDataGrid();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_atualizar.Enabled = true;
            btn_salvar.Visible = false;
            btn_cancelar.Visible = false;

            cb_tipoPedido.SelectedItem = this.pedido.Tipo_pedido;
            cb_produtos.SelectedItem = null;

            mudaCampos(false);

            preencheTextBox();
            preencheTextBoxEntrega();

            preencheDataGrid();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_tipoPedido.SelectedItem.ToString() == "Retirada")
                {
                    validaPedido();

                    if (this.pedido.Tipo_pedido == "Entrega")
                    {
                        this.pedidoController.deletarEndereco(this.idPedido);
                    }

                    this.pedidoController.atualizarPedido(populaPedido(), this.produtos);
                    enviaMsg("Pedido Atualizado!", "check");
                }
                else
                {
                    validaPedidoEntrega();

                    if (this.pedido.Tipo_pedido == "Retirada")
                    {
                        this.pedidoController.inserirEndereco(populaPedidoEntrega(), this.idPedido);
                    }

                    this.pedidoController.atualizarPedido(populaPedidoEntrega(), this.produtos);
                    enviaMsg("Pedido Atualizado!", "check");
                }

                PedidoView p = new PedidoView();
                p.Show();
                this.Hide();

            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        private String converteData(DateTimePicker txt)
        {
            DateTime dt = Convert.ToDateTime(txt.Value);
            return dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
        }

        private String converteHora(DateTimePicker txt)
        {
            DateTime dt = Convert.ToDateTime(txt.Value);
            return dt.Hour.ToString() + ":" + dt.Minute.ToString() + ":" + dt.Second.ToString();
        }

        private dto.Pedido populaPedido()
        {
            dto.Pedido pedido = new dto.Pedido();

            pedido.Id_pedido = this.pedido.Id_pedido;
            pedido.Id_cliente = this.cliente.Id;

            pedido.Situacao_pedido = cb_situacao.SelectedItem.ToString();
            pedido.Tipo_pagamento = cb_tipoPag.SelectedItem.ToString();
            pedido.Tipo_pedido = cb_tipoPedido.SelectedItem.ToString();

            pedido.Data_entrega = converteData(txt_dataEntrega);
            pedido.Data_pagamento = converteData(txt_dataPag);
            pedido.Hora_entrega = converteHora(txt_horaEntrega);

            pedido.Valor_total = this.valorTotal;

            return pedido;
        }

        private dto.Pedido populaPedidoEntrega()
        {
            dto.Pedido pedido = new dto.Pedido();

            pedido.Id_pedido = this.pedido.Id_pedido;
            pedido.Id_cliente = this.cliente.Id;

            pedido.Situacao_pedido = cb_situacaoE.SelectedItem.ToString();
            pedido.Tipo_pagamento = cb_tipoPagE.SelectedItem.ToString();
            pedido.Tipo_pedido = cb_tipoPedido.SelectedItem.ToString();

            pedido.Data_entrega = converteData(txt_dataEntregaE);
            pedido.Data_pagamento = converteData(txt_dataPagE);
            pedido.Hora_entrega = converteHora(txt_horaEntregaE);

            pedido.Valor_total = this.valorTotal;

            pedido.Id_endereco = this.endereco.Id_endereco;
            pedido.Logradouro = txt_logradouro.Text;
            pedido.Numero = int.Parse(txt_numero.Text);
            pedido.Bairro = txt_bairro.Text;
            pedido.Cep = txt_cep.Text;
            pedido.Complemento = txt_compl.Text;
            pedido.Cidade = txt_cidade.Text;
            pedido.Uf = txt_uf.Text;

            return pedido;
        }


        private void btn_produtos_Click(object sender, EventArgs e)
        {
            ProdutoView p = new ProdutoView();
            p.Show();
            this.Hide();
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            PedidoView p = new PedidoView();
            p.Show();
            this.Hide();
        }

        private void btn_financas_Click(object sender, EventArgs e)
        {
            FinancasView f = new FinancasView();
            f.Show();
            this.Hide();
        }
    }
}
