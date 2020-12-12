using SeitonSystem.src.controller;
using SeitonSystem.src.dto;
using SeitonSystem.src.view;
using SeitonSystem.src.view.Inicial;
using SeitonSystem.src.view.Pedido;
using System;
using System.Collections.Generic;
using System.Drawing;
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

                preencherDataGridView();
                preencherDataGridViewDeletados();

                dataGridview(db_clientes);
                dataGridview(db_excluidos);

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void btn_tbClientes_Click(object sender, EventArgs e)
        {
            btn_tbClientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_tbDesativados.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            db_clientes.Visible = true;
            db_excluidos.Visible = false;

            panel_clientes.Visible = false;
            panel_excluidos.Visible = false;

            preencherDataGridView();
        }

        private void btn_tbDesativados_Click(object sender, EventArgs e)
        {
            btn_tbDesativados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_tbClientes.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            db_clientes.Visible = false;
            db_excluidos.Visible = true;

            panel_clientes.Visible = false;
            panel_excluidos.Visible = false;

            preencherDataGridViewDeletados();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            txt_pesquisa.Visible = true;
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
                    db_clientes.DataSource = clientes;

                }
                else
                {
                    clientes = this.clienteController.pesquisaClientesDesativadosFiltro(txt_pesquisa.Text);
                    db_excluidos.DataSource = clientes;
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
            panel_clientes.Visible = false;
            panel_excluidos.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.db_excluidos.Rows[e.RowIndex];

                this.idCliente = int.Parse(row.Cells["Id"].Value.ToString());
                this.nomeCliente = row.Cells["Nome"].Value.ToString();
            }
        }

        private void db_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_clientes.Visible = true;
            panel_excluidos.Visible = false;

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
                db_clientes.DataSource = clientes;

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
                clientes = this.clienteController.pesquisaClientesDesativados();
                db_excluidos.DataSource = clientes;

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

        private void btn_desativar_Click(object sender, EventArgs e)
        {
            String msg = "Deseja Desativar " + this.nomeCliente + "?";

            MensagensView message = new MensagensView(msg, "deleta", this.idCliente, "cliente");
            message.ShowDialog();

            preencherDataGridView();
            panel_clientes.Visible = false;
        }

        private void btn_reativar_Click(object sender, EventArgs e)
        {
            String msg = "Deseja Reativar " + this.nomeCliente + "?";

            MensagensView message = new MensagensView(msg, "recupera", this.idCliente, "cliente");
            message.ShowDialog();

            preencherDataGridViewDeletados();
            panel_excluidos.Visible = false;
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

            dt.Columns["Id"].Width = 50;
            dt.Columns["Nome"].Width = 120;
            dt.Columns["Email"].Width = 200;
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
    }
}
