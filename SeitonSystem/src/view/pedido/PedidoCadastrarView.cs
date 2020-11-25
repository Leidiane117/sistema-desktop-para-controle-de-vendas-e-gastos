using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeitonSystem.view;
using SeitonSystem.src.view.Pedido;
using SeitonSystem.src.dto;
using SeitonSystem.src.controller;
using System.Globalization;

namespace SeitonSystem.src.view.Pedido {
    public partial class PedidoCadastrarView : Form {
        ClienteController clienteController;
        ProdutoController produtoController;
        PedidoController pedidoController;

        List<Cliente> clientes;
        List<ProdutoPesquisa> produtos;
        List<Produto> produtosCadastrados;

        Cliente cliente;
        dto.Pedido pedido;

        int colunaIndex;
        double valorTotal = 0;

        public PedidoCadastrarView() {
            InitializeComponent();

            try {
                clientes = new List<Cliente>();
                produtos = new List<ProdutoPesquisa>();
                produtosCadastrados = new List<Produto>();

                pedidoController = new PedidoController();
                clienteController = new ClienteController();
                produtoController = new ProdutoController();

                cliente = new Cliente();
                pedido = new dto.Pedido();

                this.produtosCadastrados = this.produtoController.pesquisarProdutos();
                this.clientes = this.clienteController.pesquisaClientes();

                preencheComboBox();

                txt_dataEntrega.MinDate = DateTime.Now;
                txt_dataPag.MinDate = DateTime.Now;

                txt_dataEntrega.MaxDate = DateTime.Now.AddYears(2);
                txt_dataPag.MaxDate = DateTime.Now.AddYears(2);

            }catch(Exception e) {
                enviaMsg(e.Message, "erro");

                PedidoView p = new PedidoView();
                p.Show();
                this.Hide();
            }
        }

        private void btn_clientes_Click(object sender, EventArgs e) {
            ClienteView c = new ClienteView();
            c.Show();
            this.Hide();
        }

        private void btn_produtos_Click(object sender, EventArgs e){
            ProdutoView p = new ProdutoView();
            p.Show();
            this.Hide();
        }

        private void btn_pedido_Click(object sender, EventArgs e) {
            PedidoView p = new PedidoView();
            p.Show();
            this.Hide();
        }

        private void btn_financas_Click(object sender, EventArgs e){
            FinancasView f = new FinancasView();
            f.Show();
            this.Hide();
        }

        private void preencheComboBox(){
            try {
                foreach (Produto p in this.produtosCadastrados){
                    cb_produtos.Items.Add(p);
                }

                foreach (Cliente c in this.clientes){
                    cb_cliente.Items.Add(c);
                }

            }catch (Exception e){
                enviaMsg(e.Message, "erro");
            }
        }

        private void dataGridview(DataGridView dt) {
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

        private void atualizaValorTotal() {
            this.valorTotal = 0;

            foreach (ProdutoPesquisa p in this.produtos) {
                this.valorTotal += p.Preco * p.Quantidade;
            }

            txt_valorTotal.Text = this.valorTotal.ToString();
        }

        private void validaProduto() {
            if (cb_produtos.SelectedItem == null){
                throw new Exception("Selecione um Produto");
            }

            if (txt_quantidade.Value <= 0) {
                throw new Exception("Informe a Quantidade");
            }   
        }

        private void cb_produtos_SelectedIndexChanged(object sender, EventArgs e) {
            txt_quantidade.ReadOnly = false;
            txt_obs.ReadOnly = false;

            btn_limpar.Visible = true;

            btn_addProd.Visible = true;
            btn_addProd.Enabled = true;
        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            txt_quantidade.Value = 0;
            txt_obs.Clear();

            txt_quantidade.ReadOnly = false;
            txt_obs.ReadOnly = false;

            btn_limpar.Visible = false;
        }

        private void db_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex >= 0) {
                panel_produtos.Visible = true;

                DataGridViewRow row = this.db_produtos.Rows[e.RowIndex];
                this.colunaIndex = row.Index;

                btn_limpar.Visible = true;
                btn_addProd.Enabled = false;

                txt_quantidade.ReadOnly = true;
                txt_obs.ReadOnly = true;

                txt_quantidade.Value = int.Parse(row.Cells["Quantidade"].Value.ToString());
                txt_obs.Text = row.Cells["Observacao"].Value.ToString();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e) {
            this.produtos.RemoveAt(this.colunaIndex);

            db_produtos.DataSource = null;
            db_produtos.DataSource = this.produtos;
            dataGridview(db_produtos);

            btn_addProd.Enabled = true;
            btn_limpar.Visible = false;

            txt_quantidade.Value = 0;
            txt_obs.Clear();

            atualizaValorTotal();

            panel_produtos.Visible = false;

            txt_quantidade.ReadOnly = false;
            txt_obs.ReadOnly = false;
        }

        private void btn_addProd_Click(object sender, EventArgs e) {
            try {
                int cont = 0;

                validaProduto();

                Produto p = (Produto)cb_produtos.SelectedItem;
                ProdutoPesquisa produto = new ProdutoPesquisa();

                produto.Id = p.Id;
                produto.Nome = p.Nome;
                produto.Preco = p.Preco;
                produto.Quantidade = int.Parse(txt_quantidade.Value.ToString());
                produto.Observacao = txt_obs.Text;

                foreach (ProdutoPesquisa pr in this.produtos) {
                    if (pr.Id == produto.Id){
                        pr.Quantidade += produto.Quantidade;
                        cont = 1;
                    }
                }

                if (cont != 1){
                    this.produtos.Add(produto);
                }

                db_produtos.DataSource = null;
                db_produtos.DataSource = this.produtos;
                dataGridview(db_produtos);

                atualizaValorTotal();

                cb_produtos.SelectedItem = null;

                txt_quantidade.Value = 0;
                txt_obs.Clear();

                btn_addProd.Visible = false;
                btn_limpar.Visible = false;
            }catch (Exception e1){
                enviaMsg(e1.Message, "erro");
            }
        }

        private void validaCliente(){ 
            if(cb_cliente.SelectedItem == null) {
                throw new Exception("Selecione um Cliente");
            }

            if (cb_tipoPedido.SelectedItem == null){
                throw new Exception("Selecione o Tipo de Pedido");
            }

            if (cb_tipoPag.SelectedItem == null) {
                throw new Exception("Selecione o Tipo de Pagamento");
            }

            DateTime dt = Convert.ToDateTime(txt_horaEntrega.Value);
            if (dt.Hour >= 0 && dt.Hour <= 6) {
                throw new Exception("Informe uma Hora Válida");
            }

            if (txt_dataPag.Value > txt_dataEntrega.Value) {
                throw new Exception("Informe uma Data de Pagamento Válida");
            }

        }

        private void validaEndereco(){
            int num;

            if (txt_logradouro.Text == null || txt_logradouro.Text.Trim() == ""){
                throw new Exception("Informe o Logradouro");
            }

            if (txt_bairro.Text == null || txt_bairro.Text.Trim() == "") {
                throw new Exception("Informe o Bairro");
            }

            if (txt_cidade.Text == null || txt_cidade.Text.Trim() == "") {
                throw new Exception("Informe a Cidade");
            }

            if (txt_cep.Text == null || txt_cep.Text.Trim() == ""){
                throw new Exception("Informe o CEP");
            }

            if (txt_cep.Text.Length < 8 || !int.TryParse(txt_cep.Text, out num)) {
                throw new Exception("Informe um CEP Válido");
            }

            if (txt_num.Text == null || txt_num.Text.Trim() == "") {
                throw new Exception("Informe o Número");
            }

            if (txt_num.Text.Where(c => char.IsNumber(c)).Count() == 0){
                throw new Exception("Informe um Número Válido");
            }

            if (Convert.ToInt32(txt_num.Text) <= 0) {
                throw new Exception("Informe um Número Válido");
            }

            if (txt_uf.Text == null || txt_uf.Text.Trim() == ""){
                throw new Exception("Informe o UF");
            }

            if (txt_uf.Text.Length < 2){
                throw new Exception("Informe um UF Válido");
            }
        }

        private void txt_cep_Leave(object sender, EventArgs e) {
            try{
                if(txt_cep.Text.Trim() == "") {
                    throw new Exception("Informe o CEP para consulta");
                }else{
                    using(var ws = new WSCorreios.AtendeClienteClient()){
                        var endereco = ws.consultaCEP(txt_cep.Text.Trim());

                        txt_logradouro.Text = endereco.end;
                        txt_bairro.Text = endereco.bairro;
                        txt_cidade.Text = endereco.cidade;
                        txt_uf.Text = endereco.uf;
                    }
                }
            }catch (Exception e1){
                enviaMsg(e1.Message, "erro");
            }
        }

        private void cb_tipoPedido_SelectedIndexChanged(object sender, EventArgs e) {
            if(cb_tipoPedido.SelectedItem.ToString() == "Entrega") {
                btn_proximoDoisE.Visible = true;
                btn_proximoDois.Visible = false;
            }else {
                btn_proximoDoisE.Visible = false;
                btn_proximoDois.Visible = true;
            }
        }

        private String converteData(DateTimePicker txt) {
            DateTime dt = Convert.ToDateTime(txt.Value);
            return dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
        }

        private String converteHora(DateTimePicker txt){
            DateTime dt = Convert.ToDateTime(txt.Value);
            return dt.Hour.ToString() + ":" + dt.Minute.ToString() + ":" + dt.Second.ToString();
        }

        private void populaPedido() {
            this.cliente = (Cliente)cb_cliente.SelectedItem;
            this.pedido.Id_cliente = this.cliente.Id;

            this.pedido.Situacao_pedido = cb_situacao.SelectedItem.ToString();
            this.pedido.Tipo_pedido = cb_tipoPedido.SelectedItem.ToString();
            this.pedido.Tipo_pagamento = cb_tipoPag.SelectedItem.ToString();

            this.pedido.Hora_entrega = converteHora(txt_horaEntrega);
            this.pedido.Data_entrega = converteData(txt_dataEntrega);
            this.pedido.Data_pagamento = converteData(txt_dataPag);
        }

        private void populaEndereco() {
            this.pedido.Logradouro = txt_logradouro.Text;
            this.pedido.Numero = int.Parse(txt_num.Text);
            this.pedido.Bairro = txt_bairro.Text;
            this.pedido.Cep = txt_cep.Text;
            this.pedido.Complemento = txt_compl.Text;
            this.pedido.Cidade = txt_cidade.Text;
            this.pedido.Uf = txt_uf.Text;
        }

        private void preencheTextBox() {
            if (this.pedido.Tipo_pedido == "Entrega") {
                panel_pedido.Location = new System.Drawing.Point(61, 171);

                panel_enderecoV.Visible = true;

                txt_logradouroV.Text = this.pedido.Logradouro;
                txt_numV.Text = this.pedido.Numero.ToString();
                txt_cepV.Text = this.pedido.Cep;
                txt_bairroV.Text = this.pedido.Bairro;
                txt_complV.Text = this.pedido.Complemento;
                txt_cidadeV.Text = this.pedido.Cidade;
                txt_ufV.Text = this.pedido.Uf;
            }else {
                panel_pedido.Location = new System.Drawing.Point(61, 238);
            }

            panel_pedido.Visible = true;

            db_produtosV.DataSource = this.produtos;
            dataGridview(db_produtosV);

            txt_clienteV.Text = this.cliente.ToString();

            cb_situacaoV.SelectedItem = this.pedido.Situacao_pedido;
            cb_tipoPagV.SelectedItem = this.pedido.Tipo_pagamento;
            cb_tipoPedidoV.SelectedItem = this.pedido.Tipo_pedido;;
            txt_valorTotalV.Text = this.pedido.Valor_total.ToString();

            txt_dataEntregaV.Value = DateTime.Parse(this.pedido.Data_entrega, new CultureInfo("pt-BR"));
            txt_dataPagV.Value = DateTime.Parse(this.pedido.Data_pagamento, new CultureInfo("pt-BR"));
            txt_horaEntregaV.Value = DateTime.Parse(this.pedido.Hora_entrega, new CultureInfo("pt-BR"));

        }

        private void enviaMsg(String msg, String tipo) {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void btn_proximo_Click(object sender, EventArgs e){
            try {
                if (this.produtos.Count <= 0) {
                    throw new Exception("Selecione Produtos para realizar o Pedido");
                }

                this.pedido.Valor_total = this.valorTotal;

                panel_produto.Visible = false;
                panel_cliente.Visible = true;

            }catch(Exception e1) {
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e){
            panel_produto.Visible = true;
            panel_cliente.Visible = false;
        }

        private void btn_proximoDois_Click(object sender, EventArgs e) {
            try {
                validaCliente();
                populaPedido();

                panel_cliente.Visible = false;
                preencheTextBox();
            }catch (Exception e1){
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void btn_proximoDoisE_Click(object sender, EventArgs e) {
            try {
                validaCliente();
                populaPedido();

                panel_cliente.Visible = false;
                panel_endereco.Visible = true;
            }catch(Exception e1) {
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void btn_anteriorDois_Click(object sender, EventArgs e){
            panel_cliente.Visible = true;
            panel_endereco.Visible = false;
        }

        private void btn_proximoTres_Click(object sender, EventArgs e){
            try {
                validaEndereco();
                populaEndereco();

                panel_endereco.Visible = false;
                preencheTextBox();
            }catch (Exception e1) {
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void btn_anteriorTres_Click(object sender, EventArgs e){
            if(this.pedido.Tipo_pedido == "Entrega"){
                panel_endereco.Visible = true;
                panel_pedido.Visible = false;
            }else{
                panel_cliente.Visible = true;
                panel_pedido.Visible = false;
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e) {
            try {
                this.pedidoController.inserirPedido(this.pedido, this.produtos);
                enviaMsg("Pedido Cadastrado!", "check");

                PedidoView p = new PedidoView();
                p.Show();
                this.Hide();

            }catch (Exception e1){
                enviaMsg(e1.Message, "erro");
            }
        }

    }
}
