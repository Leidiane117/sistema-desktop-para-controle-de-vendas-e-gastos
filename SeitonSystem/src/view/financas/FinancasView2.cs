using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeitonSystem.src.dto;
using SeitonSystem.src.view.financas;
using SeitonSystem.src.view.Inicial;
using SeitonSystem.src.controller;
using SeitonSystem.view;
using System.Globalization;

namespace SeitonSystem.src.view 
{
    public partial class FinancasView2 : Form 
    {
        FinancasController financasController;
        List<Financas> financas;
        List<FinancasPesquisa> financasPesquisa;

        int idFluxo;
        string tituloFluxo;

        double lucro;
        double entrada;
        double mLucro;
        double saida;
        
        public FinancasView2()
        {
            InitializeComponent();
            
            try 
            {
               financasController = new FinancasController();

                financasPesquisa = new List<FinancasPesquisa>();
                financas = new List<Financas>();

                preencheComboBox();
                exibeFluxos();
                dataGridview(db_fluxos);
            }
            catch (Exception e){
                enviaMsg(e.Message, "erro"); 
            }
        }

        private void preencheComboBox() {
            cb_pesquisaRentData.Text = "Últimos 3 meses";
           
            cb_pesquisaTipo.Text = "Todas as Operações";
            
            cb_pesquisaData.Text = "Últimos 3 meses";

        }

        private void dataGridview(DataGridView dt) {
            dt.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            dt.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(195, 167, 166);
            dt.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCellStyle style = dt.ColumnHeadersDefaultCellStyle;
            style.BackColor = System.Drawing.Color.FromArgb(153, 88, 63);
            style.ForeColor = Color.White;
            style.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dt.MultiSelect = false;
            dt.Columns["Id"].Width = 40;
            dt.Columns["Identificacao"].Width = 110;
            dt.Columns["Lancamento"].Width = 90;
            dt.Columns["Total"].Width = 80;
            dt.Columns["Total"].DefaultCellStyle.Format = "c";

            foreach (DataGridViewRow row in dt.Rows){
               if (Convert.ToString(row.Cells["Fluxo"].Value) == "Saida"){
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    row.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
                }else if(Convert.ToString(row.Cells["Fluxo"].Value) == "Entrada"){
                    row.DefaultCellStyle.ForeColor = Color.MediumBlue;
                    row.DefaultCellStyle.SelectionForeColor = Color.MediumBlue;
                    
                }
            }
            for (int i = 0; i < dt.ColumnCount; i++)
            {
               
               dt.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            dt.Columns["Fluxo"].Visible = false;

        }

        private void exibeFluxos() {
            try {
                this.financasPesquisa.Clear();

                foreach (Financas fi in this.financas) {
                    this.financasPesquisa.Add(populaFinanca(fi));
                }

              db_fluxos.DataSource = null;
               db_fluxos.DataSource = this.financasPesquisa;

                dataGridview(db_fluxos);
            }catch (Exception e){
                enviaMsg(e.Message, "erro");
            }
        }

        private FinancasPesquisa populaFinanca(Financas fi){
            FinancasPesquisa f = new FinancasPesquisa();

            f.Id = fi.Id;
            f.Identificacao = fi.Titulo;
            f.Lancamento = fi.Data_lancamento;
            f.Total = fi.Valor;
            f.Fluxo = fi.Tipo_fluxo;

            return f; 
        }

        private void btn_cadastrar_Click(object sender, EventArgs e) {
            FinancasCadastrarView financas = new FinancasCadastrarView();
            financas.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            InicialView i = new InicialView();
            i.Show();
            this.Hide();
        }

        private void btn_deletar_Click(object sender, EventArgs e) {
            String msg = "Deseja Excluir " + tituloFluxo + "?";

            MensagensView message = new MensagensView(msg, "deleta", idFluxo, "financas");
            message.ShowDialog();

            lbl_desc.Visible = false;
            txt_descricao.Visible = false;

            btn_atualizar.Visible = false;
            btn_deletar.Visible = false;
            txt_descricao.Clear();

            if (cb_pesquisaTipo.SelectedItem.ToString() != "Todas as Operações") {
                this.financas.Clear();
                pesquisaTipo(cb_pesquisaData.SelectedItem.ToString(), cb_pesquisaTipo.SelectedItem.ToString());
                exibeFluxos();
            } else {
                this.financas.Clear();
                pesquisaFluxo(cb_pesquisaData.SelectedItem.ToString());
                exibeFluxos();
            }

        }

        private void enviaMsg(String msg, String tipo) {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void btn_atualizar_Click(object sender, EventArgs e){
            FinancasAtualizarView financas = new FinancasAtualizarView(this.idFluxo);
            financas.Show();

            lbl_desc.Visible = false;
            txt_descricao.Visible = false;

            btn_atualizar.Visible = false;
            btn_deletar.Visible = false;
            txt_descricao.Clear();

            this.Hide();     
        }

        private void cb_pesquisaTipo_SelectedIndexChanged(object sender, EventArgs e) {
            try
            {

                if (cb_pesquisaTipo.SelectedItem.ToString() != "Todas as Operações")
                {
                    this.financas.Clear();
                    pesquisaTipo(cb_pesquisaData.SelectedItem.ToString(), cb_pesquisaTipo.SelectedItem.ToString());
                    exibeFluxos();
                }
                 if (cb_pesquisaTipo.SelectedItem.ToString() == null)
                {
                    this.financas.Clear();
                   // pesquisaFluxo("Últimos 3 meses");
                    pesquisaTipo("Últimos 3 meses", "Todas as Operações");
                    exibeFluxos();
                } 

            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "aviso");
            }
        }
        
        private void cb_pesquisaData_SelectedIndexChanged(object sender, EventArgs e){
              
            
            try{
                if (cb_pesquisaTipo.SelectedItem.ToString() !="Todas as Operações"){
                    this.financas.Clear();
                    pesquisaTipo(cb_pesquisaData.SelectedItem.ToString(), cb_pesquisaTipo.SelectedItem.ToString());
                    exibeFluxos();
                }else {
                    this.financas.Clear();
                    pesquisaFluxo(cb_pesquisaData.SelectedItem.ToString());
                    exibeFluxos();
                }
            }catch (Exception e1) {
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void pesquisaTipo(String periodo, String tipo) {
            switch (periodo) {
              
                case "Últimos 3 meses":
                    this.financas = this.financasController.pesquisaFluxosTipoData(tipo, DateTime.Now.AddMonths(-2));
                    break;
                case "Último mês":
                    this.financas = this.financasController.pesquisaFluxosTipoData(tipo, DateTime.Now.AddMonths(-1));
                    break;

                case "Última Semana":
                    this.financas = this.financasController.pesquisaFluxosTipoData(tipo, DateTime.Now.AddDays(-7));
                    break;
            }
        }

        private void pesquisaFluxo(String periodo){
            switch (periodo) {
               
                case "Últimos 3 meses":
                    this.financas = this.financasController.pesquisaFluxosData(DateTime.Now.AddMonths(-2));
                    break;

                case "Último mês":
                    this.financas = this.financasController.pesquisaFluxosData(DateTime.Now.AddMonths(-1));
                    break;
                case "Última Semana":
                    this.financas = this.financasController.pesquisaFluxosData(DateTime.Now.AddDays(-7));
                    break;
            }
        }

             

            

        private void cb_pesquisaRentData_SelectedIndexChanged(object sender, EventArgs e){
            this.lucro = 0;
            this.entrada = 0;
            this.mLucro = 0;
            this.saida = 0;

            calculaLucrosGastos(cb_pesquisaRentData.SelectedItem.ToString(), "Entrada");
            calculaLucrosGastos(cb_pesquisaRentData.SelectedItem.ToString(), "Saida");


            if (this.lucro <= 0) {
                lbl_lucroV.BackColor = Color.Salmon;
                mLucro = 0;
            }else{
                lbl_lucroV.BackColor = Color.PaleGreen;
                this.mLucro = (this.lucro / this.entrada) * 100;
                
            }

            if (this.mLucro < 20) {
                lbl_margemLucro.BackColor = Color.Salmon;
            }else {
                lbl_margemLucro.BackColor = Color.PaleGreen;
            }
            

            lbl_lucroV.Text = "R$" + this.lucro;
            lbl_entradaV.Text = "R$" + this.entrada;
            lbl_saidaV.Text = "R$" + this.saida;
            lbl_margemLucro.Text = Math.Round(this.mLucro) + "%";

        }

        private void calculaLucrosGastos(String periodo, String tipo) {
            List<Financas> f = new List<Financas>();

            switch (periodo) {
                
                case "Últimos 3 meses":
                    f = this.financasController.pesquisaFluxosTipoData(tipo, DateTime.Now.AddMonths(-2));
                    break;
                case "Último mês":
                    f = this.financasController.pesquisaFluxosTipoData(tipo, DateTime.Now.AddMonths(-1));
                    break;
                case "Última Semana":
                   f = this.financasController.pesquisaFluxosTipoData(tipo, DateTime.Now.AddDays(-7));
                    break;
            }

            foreach (Financas fi in f) {
                if(tipo == "Entrada") {
                    this.entrada += fi.Valor;
                }else {
                    this.saida += fi.Valor;
                }
            }

            this.lucro = this.entrada - this.saida;
        }

        private void btn_graficos_Click(object sender, EventArgs e) {
            GraficosView g = new GraficosView();
            g.Show();
            this.Hide();
        }

        private void btn_clientes_Click(object sender, EventArgs e) {
            ClienteView c = new ClienteView();
            c.Show();
            this.Hide();
        }

        private void btn_produtos_Click(object sender, EventArgs e) {
            ProdutoView p = new ProdutoView();
            p.Show();
            this.Hide();
        }

        private void btn_pedidos_Click(object sender, EventArgs e){
            Pedido.PedidoView p = new Pedido.PedidoView();
            p.Show();
            this.Hide();
        }

        private void db_fluxos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                lbl_desc.Visible = true;
                txt_descricao.Visible = true;

                btn_atualizar.Visible = true;
                btn_deletar.Visible = true;

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.db_fluxos.Rows[e.RowIndex];

                    this.idFluxo = int.Parse(row.Cells["Id"].Value.ToString());
                    this.tituloFluxo = row.Cells["Identificacao"].Value.ToString();

                    Financas f = this.financasController.pesquisaFinancasId(this.idFluxo);
                    txt_descricao.Text = f.Descricao;
                }
            }

        private void FinancasView2_Load(object sender, EventArgs e)
        {


            //.SelectedIndex = 0;
           // cb_pesquisaTipo.SelectedIndex = 0;
            preencheComboBox();
            exibeFluxos();
            dataGridview(db_fluxos);
        }

        private void txt_pesquisa_KeyUp(object sender, KeyEventArgs e)
        {

            List<FinancasPesquisa> f = new List<FinancasPesquisa>();

            if (txt_pesquisa.Text.Trim() != "")
            {
                foreach (FinancasPesquisa fi in this.financasPesquisa)
                {
                    if (fi.Identificacao.Contains(txt_pesquisa.Text))
                    {
                        f.Add(fi);
                    }
                }

                db_fluxos.DataSource = null;
                db_fluxos.DataSource = f;
                dataGridview(db_fluxos);
            }
            else
            {
                if (cb_pesquisaTipo.SelectedItem.ToString() != "Todas as Operações")
                {
                    this.financas.Clear();
                    pesquisaTipo(cb_pesquisaData.SelectedItem.ToString(), cb_pesquisaTipo.SelectedItem.ToString());
                    exibeFluxos();
                }
                else
                {
                    this.financas.Clear();
                    pesquisaFluxo(cb_pesquisaData.SelectedItem.ToString());
                    exibeFluxos();
                }
            }
        }

    }
}
 
    














