using SeitonSystem.src.controller;
using SeitonSystem.src.dto;
using SeitonSystem.src.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SeitonSystem.view
{
    public partial class ClienteView : Form
    {
        ClienteController clienteController;
        int idCliente;
        String nomeCliente;

        public ClienteView()
        {
            InitializeComponent();

            try
            {
                clienteController = new ClienteController();

               
            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void btn_tbClientes_Click(object sender, EventArgs e)
        {


            db_clientes.Visible = true;
            db_excluidos.Visible = false;

            btn_recuperar.Visible = false;
            btn_atualizar.Visible = false;
            btn_excluir.Visible = false;

            preencherDataGridView();
            FormatarGrid();
        }

        private void btn_tbExcluidos_Click_1(object sender, EventArgs e)
        {


            db_clientes.Visible = false;
            db_excluidos.Visible = true;

            btn_recuperar.Visible = false; //ok
            btn_atualizar.Visible = false;
            btn_excluir.Visible = false;

            preencherDataGridViewDeletados();
            FormatarGridExcluidos();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            txt_pesquisa.Visible = true; //ok
            linha2.Visible = true;
        }

        private void txt_pesquisa_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();

                if (db_clientes.Visible)
                {
                    clientes = this.clienteController.pesquisaClientesFiltro(txt_pesquisa.Text);

                    db_clientes.Columns.Clear();
                    db_clientes.DataSource = clientes;
                    db_clientes.Refresh();
                }
                else
                {
                    clientes = this.clienteController.pesquisaClientesDeletadosFiltro(txt_pesquisa.Text);

                    db_excluidos.Columns.Clear();
                    db_excluidos.DataSource = clientes;
                    db_excluidos.Refresh();
                }
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            ClienteCadastrarView cdv = new ClienteCadastrarView();
            cdv.Show();
            this.Hide();
        }

        private void db_excluidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_recuperar.Visible = true;

            btn_atualizar.Visible = false;
            btn_excluir.Visible = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.db_excluidos.Rows[e.RowIndex];
                this.idCliente = int.Parse(row.Cells["Id"].Value.ToString());
                this.nomeCliente = row.Cells["Nome"].Value.ToString();
            }
        }

        private void db_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_recuperar.Visible = false;

            btn_atualizar.Visible = true;
            btn_excluir.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.db_clientes.Rows[e.RowIndex];
                this.idCliente = int.Parse(row.Cells["Id"].Value.ToString());
                this.nomeCliente = row.Cells["Nome"].Value.ToString();
            }
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
                List<Cliente> clientes = new List<Cliente>();
                clientes = this.clienteController.pesquisaClientes();

                db_clientes.Columns.Clear();
                db_clientes.DataSource = clientes;
                db_clientes.Refresh();
                FormatarGrid();

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void preencherDataGridViewDeletados()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                clientes = this.clienteController.pesquisaClientesDeletados();

                db_excluidos.Columns.Clear();
                db_excluidos.DataSource = clientes;
                db_excluidos.Refresh();
                FormatarGridExcluidos();

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            ClienteAtualizarView clienteAtualizar = new ClienteAtualizarView(this.idCliente);
            clienteAtualizar.Show();
            this.Hide();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            String msg = "Deseja Excluir " + this.nomeCliente + "?";

            MensagensView message = new MensagensView(msg, "deleta", this.idCliente,"cliente");
            message.ShowDialog();

            preencherDataGridView();
        }

        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            String msg = "Deseja Recuperar " + this.nomeCliente + "?";

            MensagensView message = new MensagensView(msg, "recupera", this.idCliente,"cliente");
            message.ShowDialog();

            preencherDataGridViewDeletados();
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            ProdutoView produtoView = new ProdutoView();
            produtoView.ShowDialog();

        }

        private void FormatarGridExcluidos()
        {
            string[] header = { "Id", "Nome", "Telefone", "Celular", "Instagram", "Email" };
            for (int i = 0; i < 6; i++)
            {
                db_excluidos.Columns[i].HeaderText = header[i];
                db_excluidos.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
           
                                   
            DataGridViewCellStyle style =
                db_excluidos.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Sienna;
            style.ForeColor = Color.White;
            style.Font = new Font(db_excluidos.Font, FontStyle.Bold);

            db_excluidos.MultiSelect = false;
            db_excluidos.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // quebra de linha

            foreach (DataGridViewColumn column in db_excluidos.Columns)
            {
                if (column.DataPropertyName == "Id")
                    column.Width = 50; //tamanho fixo da primeira coluna


                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (column.DataPropertyName == "Email")
                    column.Width = 170; //tamanho fixo da ultima coluna

                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void FormatarGrid()
        {
            string[] header = { "Id", "Nome", "Telefone", "Celular", "Instagram", "Email" };
            for (int i = 0; i < 6; i++)
            {
                db_clientes.Columns[i].HeaderText = header[i];
                db_clientes.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            DataGridViewCellStyle style =
            db_clientes.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Sienna;
            style.ForeColor = Color.White;
            style.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            db_clientes.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // quebra de linha
            db_clientes.MultiSelect = false; // selecionar apenas uma linha por vez

            foreach (DataGridViewColumn column in db_clientes.Columns)
            {
                if (column.DataPropertyName == "Id")
                    column.Width = 50; //tamanho fixo da primeira coluna


                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (column.DataPropertyName == "Email")
                    column.Width = 170; //tamanho fixo da ultima coluna

                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    

        private void btn_financas_Click(object sender, EventArgs e)
        {

            FinançasView finanças = new FinançasView();
            finanças.ShowDialog();
        }

        private void ClienteView_Load(object sender, EventArgs e)
        {
            preencherDataGridView();
            preencherDataGridViewDeletados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinançasViewGráficos finançasViewGráficos =  new FinançasViewGráficos();
            finançasViewGráficos.ShowDialog();
        }
    }
}


