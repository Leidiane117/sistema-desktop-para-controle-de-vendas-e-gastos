using System;
using SeitonSystem.src.dao;
using SeitonSystem.src.controller;
using SeitonSystem.src.dto;
using SeitonSystem.src.view;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeitonSystem.src.view.Pedido;
using SeitonSystem.src.view.Inicial; 

namespace SeitonSystem.view {
    public partial class ProdutoView : Form {

        ProdutoController produtoController;
        int idProduto;
        string nomeProduto;

        public ProdutoView() {
            InitializeComponent();

            try {
                this.produtoController = new ProdutoController();

                listar();
                listarDeletados();

                dataGridview(DataGridDesativados);
                dataGridview(DataGridViewProdutos);

            }catch (Exception e) {
                enviaMsg(e.Message, "erro");
            }

        }

        public void listar(){
            try{
                List<Produto> lista = new List<Produto>();
                lista = produtoController.pesquisarProdutos();

                DataGridViewProdutos.DataSource = lista;

            }catch (Exception e) {
                enviaMsg(e.Message, "erro");
            }

        }


        private void listarDeletados(){
            try {
                List<Produto> lista = new List<Produto>();
                lista = produtoController.pesquisaProdutosDesativados();

                DataGridDesativados.DataSource = lista;

            }catch (Exception e){
                enviaMsg(e.Message, "erro");
            }

        }

        private void DataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e){
            panel_produtos.Visible = true;
            panel_excluidos.Visible = false;

            if (e.RowIndex >= 0){
                DataGridViewRow row = DataGridViewProdutos.Rows[e.RowIndex];
                idProduto = int.Parse(row.Cells["Id"].Value.ToString());
                nomeProduto = row.Cells["Nome"].Value.ToString();  
            }
        }


        private void ButtonProdutos_Click(object sender, EventArgs e){
            buttonProdutos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonDesativados.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            panel_produtos.Visible = false;
            panel_excluidos.Visible = false;

            DataGridDesativados.Visible = false;
            DataGridViewProdutos.Visible = true;

            listar();  
        }

        private void ButtonPesquisar_Click(object sender, EventArgs e) {
            txt_pesquisa.Visible = true; 
            panel1.Visible = true;
        }

        private void ButtonDesativados_Click(object sender, EventArgs e){
            buttonDesativados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonProdutos.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            panel_produtos.Visible = false;
            panel_excluidos.Visible = false;

            DataGridViewProdutos.Visible = false;
            DataGridDesativados.Visible = true;

            listarDeletados();
        }

        private void DataGridDesativados_CellContentClick(object sender, DataGridViewCellEventArgs e){
            panel_produtos.Visible = false;
            panel_excluidos.Visible = true;

            if (e.RowIndex >= 0){
                DataGridViewRow row = DataGridDesativados.Rows[e.RowIndex];
                idProduto = int.Parse(row.Cells["Id"].Value.ToString());
                nomeProduto = row.Cells["Nome"].Value.ToString(); 
            }
        }

        private void enviaMsg(String msg, String tipo){
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }


        private void btn_cadastrar_Click(object sender, EventArgs e) {
            ProdutoCadastrarView produtoCadastrar = new ProdutoCadastrarView();
            produtoCadastrar.Show();
            this.Hide();
        }

        private void button_desativar_Click(object sender, EventArgs e) {
            String msg = "Deseja Desativar " + nomeProduto + "?";

            MensagensView message = new MensagensView(msg, "deleta", idProduto, "produto");
            message.ShowDialog();

            listar();
            panel_produtos.Visible = false;
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

            dt.Columns["Id"].Width = 100;
            dt.Columns["Descricao"].Width = 180;
            dt.Columns["Preco"].DefaultCellStyle.Format = "c";
        }

        private void buttonAtualizar_Click(object sender, EventArgs e) {
            ProdutoAtualizarView produtoAtualizar = new ProdutoAtualizarView(idProduto);
            produtoAtualizar.Show();
            this.Hide();
        }

        private void btn_reativar_Click(object sender, EventArgs e){
            String msg = "Deseja Reativar " + nomeProduto + "?";

            MensagensView message = new MensagensView(msg, "recupera", idProduto, "produto");
            message.ShowDialog();

            listarDeletados();
            panel_excluidos.Visible = false;
        }

        private void txt_pesquisa_KeyUp(object sender, EventArgs e) {
            try {
                List<Produto> produto = new List<Produto>();

                if (DataGridViewProdutos.Visible){
                    produto = this.produtoController.pesquisaProdutosFitro(txt_pesquisa.Text);
                    DataGridViewProdutos.DataSource = produto;
                }else {
                    produto = this.produtoController.pesquisaProdutosDesativadosFiltro(txt_pesquisa.Text);
                    DataGridDesativados.DataSource = produto;
                }
            }
            catch (Exception e1){
                enviaMsg(e1.Message, "erro");
            }
        }

        private void btn_clientes_Click(object sender, EventArgs e){
            ClienteView cv = new ClienteView();
            cv.Show();
            this.Hide();
        }

        private void btn_pedido_Click(object sender, EventArgs e){
            PedidoView p = new PedidoView();
            p.Show();
            this.Hide();
        }

        private void btn_financas_Click(object sender, EventArgs e){
            FinancasView f = new FinancasView();
            f.Show();
            this.Hide();
        }

        private void btn_voltar_Click(object sender, EventArgs e) {
            InicialView i = new InicialView();
            i.Show();
            this.Hide();
        }
    }
}














