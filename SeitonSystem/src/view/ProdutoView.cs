using System;
using SeitonSystem.src.controller;
using SeitonSystem.src.dto;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeitonSystem.src.view;

namespace SeitonSystem.view
{
    public partial class ProdutoView : Form
    {
        ProdutoClassController produtoController;


        int idProduto;
        string nomeProduto;


        public ProdutoView()
        {
            InitializeComponent();


            try
            {

                produtoController = new ProdutoClassController();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro");
            }


        }




        public void Listar()
        {
            try
            {
                List<ProdutoClassPrincipal> lista = new List<ProdutoClassPrincipal>();
                lista = produtoController.ListarProdutos1();

                DataGridViewProdutos.DataSource = lista;
                FormatarGridProdutos();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Não foi possível listar os produtos");
            }

        }


        private void ListarDeletados()
        {
            try
            {
                List<ProdutoClassPrincipal> lista3 = new List<ProdutoClassPrincipal>();
                lista3 = produtoController.ListarProdutosDeletados();

                DataGridExcluídos.DataSource = lista3; // alimentar o data grid
                FormatarGridExcluidos();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro");
            }

        }



        private void DataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btn_recuperar.Visible = false; //visibilidade dos botões quando clicar na celula do datagrid
            button_excluir.Visible = true;
            buttonAtualizar.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewProdutos.Rows[e.RowIndex];
                idProduto = int.Parse(row.Cells["Id"].Value.ToString());
                nomeProduto = row.Cells["Nome"].Value.ToString();  //-----------------

            }
        }


        private void ButtonProdutos_Click(object sender, EventArgs e)
        {
            btn_recuperar.Visible = false;
            button_excluir.Visible = false;
            buttonAtualizar.Visible = false;
            DataGridExcluídos.Visible = false;
            DataGridViewProdutos.Visible = true;
            Listar();
            FormatarGridProdutos();
            // ------------
        }



        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            TextBoxBuscar.Visible = true; //----------------
            panel1.Visible = true;
        }

        private void ButtonExcluidos_Click(object sender, EventArgs e)
        {

            btn_recuperar.Visible = false;
            button_excluir.Visible = false;
            buttonAtualizar.Visible = false;
            DataGridViewProdutos.Visible = false;
            DataGridExcluídos.Visible = true;

            ListarDeletados(); //------
            FormatarGridExcluidos();
        }



        private void DataGridExcluídos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewProdutos.Visible = false;
            btn_recuperar.Visible = true; //visibilidade dos botões quando clicar na celula do datagrid
            button_excluir.Visible = false;
            buttonAtualizar.Visible = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridExcluídos.Rows[e.RowIndex];
                idProduto = int.Parse(row.Cells["Id"].Value.ToString());
                nomeProduto = row.Cells["Nome"].Value.ToString();  //-----------------

            }



        }

        private void EnviaMsg(String msg, String tipo) 
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }
        
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            ProdutoCadastrarView produtoCadastrar = new ProdutoCadastrarView();
            produtoCadastrar.ShowDialog();
        }

        

        private void TextBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<ProdutoClassPrincipal> produto = new List<ProdutoClassPrincipal>();

                if (DataGridViewProdutos.Visible)
                {
                    produto = produtoController.BuscarProdutosNome(TextBoxBuscar.Text);

                    DataGridViewProdutos.Columns.Clear();
                    DataGridViewProdutos.DataSource = produto;
                    DataGridViewProdutos.Refresh();
                }
                else
                {
                    produto = produtoController.BuscarProdutosDeletadosNome(TextBoxBuscar.Text);

                    DataGridExcluídos.Columns.Clear();
                    DataGridExcluídos.DataSource = produto;
                    DataGridExcluídos.Refresh();
                }
            }
            catch (Exception e1)
            {
                EnviaMsg(e1.Message, "erro");
            }
        }


        private void FormatarGridExcluidos()
        {
         
            for (int i = 0; i < 4; i++)
            {
                string[] cabecalho = { "Id", "Nome", "Preço", "Descrição" };

                DataGridExcluídos.Columns[i].HeaderText = cabecalho[i];
                DataGridExcluídos.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            DataGridViewCellStyle style =
                DataGridExcluídos.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Sienna;
            style.ForeColor = Color.White;
            style.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            
            DataGridExcluídos.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True; // quebra de linha
            DataGridExcluídos.Columns["Preco"].DefaultCellStyle.Format = "c";
            DataGridExcluídos.MultiSelect = false; // selecionar apenas uma linha por vez
            
        }


        private void FormatarGridProdutos() // eu que fiz S2
        {
            for (int i = 0; i < 4; i++)
            {
                string[] cabecalho = { "Id", "Nome", "Preço", "Descrição" };

                DataGridViewProdutos.Columns[i].HeaderText = cabecalho[i];
                DataGridViewProdutos.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            DataGridViewCellStyle style =
            DataGridViewProdutos.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Sienna;
            style.ForeColor = Color.White;
            style.Font=new Font("Segoe UI", 8, FontStyle.Bold);
            
            DataGridViewProdutos.Columns["Preco"].DefaultCellStyle.Format = "c";
            DataGridViewProdutos.DefaultCellStyle.WrapMode =DataGridViewTriState.True; // quebra de linha
            DataGridViewProdutos.MultiSelect = false;
        }



        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            ProdutoAtualizarView produtoAtualizar = new ProdutoAtualizarView(idProduto);
            produtoAtualizar.ShowDialog();
        }

        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            String msg = "Deseja Recuperar " + nomeProduto + "?";

            MensagensView message = new MensagensView(msg, "recupera", idProduto,"produto");
            message.ShowDialog();

            ListarDeletados();

        }

        private void btn_financas_Click(object sender, EventArgs e)
        {
            FinançasView finanças = new FinançasView();
            finanças.ShowDialog();

            
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.ShowDialog();
        }

        private void button_excluir_Click_1(object sender, EventArgs e)
        {

            String msg = "Deseja Excluir " + nomeProduto + "?";

            MensagensView message = new MensagensView(msg, "deleta", idProduto, "produto");
            message.ShowDialog();

            Listar();
        }

        private void ProdutoView_Load(object sender, EventArgs e)
        {
            Listar();
            ListarDeletados();
        }
    }
}














