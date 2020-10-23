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
using SeitonSystem.src.controller;
using SeitonSystem.src.view;
using SeitonSystem.view;

namespace SeitonSystem.src.view
{
    public partial class FinançasView : Form
    {
        FinançasController finançasController;


        int idFluxo;
        string tituloFluxo;


        public FinançasView()
        {
            InitializeComponent();
            

            try
            {

                finançasController = new FinançasController();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro");
            }

        }




        public void ListarFluxoTotal()
        {
            try
            {
                List<Finanças> lista = new List<Finanças>();
                lista = finançasController.ListarFluxoTotal();

                DataGridView2.DataSource = lista;
                FormatarGrid2();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Não foi possível listar as finanças");
            }

        }
        private void ListarSaídas()
        {
            try
            {
                List<Finanças> lista3 = new List<Finanças>();
                lista3 = finançasController.ListarFluxoSaida();

                dataGridSaida.DataSource = lista3; // alimentar o data grid
                FormatarGridSaida();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro");
            }

        }

        private void ListarEntradas()
        {
            try
            {
                List<Finanças> lista4 = new List<Finanças>();
                lista4 = finançasController.ListarFluxoEntrada();

                dataGridEntrada.DataSource = lista4; // alimentar o data grid
                FormatarGridEntrada();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro");
            }

        }



        private void FormatarGridSaida()
        {
            string[] header = { "Id", "Título", "Valor", "Descrição", "Data", "Tipo de Fluxo" };

            for (int i = 0; i < 6; i++)
            {
                dataGridSaida.Columns[i].HeaderText = header[i];
                dataGridSaida.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            DataGridViewCellStyle style =
            dataGridSaida.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Sienna;
            style.ForeColor = Color.White;
            style.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            dataGridSaida.Columns["data_lancamento"].DefaultCellStyle.Format = "d";
            dataGridSaida.Columns["valor"].DefaultCellStyle.Format = "c";
            dataGridSaida.MultiSelect = false; // slecionar uma linha por vez
            dataGridSaida.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // quebra de linha

        }

        private void FormatarGridEntrada()
        {
            string[] header = { "Id", "Título", "Valor", "Descrição", "Data", "Tipo de Fluxo" };

            for (int i = 0; i < 6; i++)
            {
                dataGridEntrada.Columns[i].HeaderText = header[i];
                dataGridEntrada.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DataGridViewCellStyle style =
            dataGridEntrada.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Sienna;
            style.ForeColor = Color.White;
            style.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            dataGridEntrada.Columns["data_lancamento"].DefaultCellStyle.Format = "d";
            dataGridEntrada.Columns["valor"].DefaultCellStyle.Format = "c";
            dataGridEntrada.MultiSelect = false; // slecionar uma linha por vez
            dataGridEntrada.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // quebra de linha
           
        }
        private void FormatarGrid2()
        {
            string[] header = { "Id", "Título", "Valor", "Descrição", "Data", "Tipo de Fluxo" };

            for (int i = 0; i < 6; i++)
            {
                DataGridView2.Columns[i].HeaderText = header[i];
                DataGridView2.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DataGridViewCellStyle style =
            DataGridView2.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Sienna;
            style.ForeColor = Color.White;
            style.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            DataGridView2.Columns["data_lancamento"].DefaultCellStyle.Format = "d";
            DataGridView2.Columns["valor"].DefaultCellStyle.Format = "c";
            DataGridView2.MultiSelect = false; // slecionar uma linha por vez
            DataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // quebra de linha


            foreach (DataGridViewRow row in DataGridView2.Rows)
            {
                if (Convert.ToString(row.Cells["tipo_fluxo"].Value) == "Entrada")
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkBlue;
                }


                   else if (Convert.ToString(row.Cells["tipo_fluxo"].Value) == "Saida")
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    
                }



            }
        
    }
        private void Finanças_Click(object sender, EventArgs e)
        {

            DataGridView2.Visible = true;
            dataGridEntrada.Visible = false;
            dataGridEntrada.Visible = false;
            ListarFluxoTotal();
            FormatarGrid2();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FinancasCadastrarView financas = new FinancasCadastrarView();
            financas.ShowDialog();
        }

             

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridEntrada.Visible = false;
            dataGridSaida.Visible = false;
            button_excluir.Visible = true;
            btn_atualizar.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView2.Rows[e.RowIndex];
                idFluxo = int.Parse(row.Cells["Id"].Value.ToString());
                tituloFluxo = row.Cells["Titulo"].Value.ToString();  //-----------------

            }



        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClienteView clienteView = new ClienteView();
            clienteView.ShowDialog(); // botão voltar- tela clientes
        }



        private void button_excluir_Click(object sender, EventArgs e)
        {

            String msg = "Deseja Excluir " + tituloFluxo + "?";

            //MensagensView message = new MensagensView(msg,"deleta",idFluxo,"financas");
            //message.ShowDialog();
            DeletarFluxo(idFluxo);
            ListarFluxoTotal();

        }

        private void EnviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Finanças> finanças = new List<Finanças>();

                if (DataGridView2.Visible)
                {
                    finanças = finançasController.BuscarPNome(txt_pesquisa.Text);

                    DataGridView2.Columns.Clear();
                    DataGridView2.DataSource = finanças;
                    DataGridView2.Refresh();
                }

                else if (dataGridEntrada.Visible)
                {

                    finanças = finançasController.BuscarPNome(txt_pesquisa.Text);

                    dataGridEntrada.Columns.Clear();
                    dataGridEntrada.DataSource = finanças;
                    dataGridEntrada.Refresh();

                }

                else if (dataGridSaida.Visible)
                {

                    finanças = finançasController.BuscarPNome(txt_pesquisa.Text);

                    dataGridSaida.Columns.Clear();
                    dataGridSaida.DataSource = finanças;
                    dataGridSaida.Refresh();
                }
            }
            catch (Exception e1)
            {
                EnviaMsg(e1.Message, "erro");
            }

        }

        private void DeletarFluxo(int id)
        {
            try
            {
                finançasController.ApagarFluxo(id);

                EnviaMsg("Registro deletado com Sucesso", "check");
            }
            catch (Exception e)
            {
                EnviaMsg(e.Message, "erro");
            }
        }



        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            txt_pesquisa.Visible = true; //----------------
            panel1.Visible = true;
        }

       

        private void dataGridEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView2.Visible = false;
            dataGridSaida.Visible = false;
            btn_atualizar.Visible = false;
            button_excluir.Visible = false;


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridEntrada.Rows[e.RowIndex];
                idFluxo = int.Parse(row.Cells["Id"].Value.ToString());
                tituloFluxo = row.Cells["Titulo"].Value.ToString();  //-----------------

            }
        }

        private void dataGridSaida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView2.Visible = false;
            dataGridEntrada.Visible = false;
            btn_atualizar.Visible = false;
            button_excluir.Visible = false;


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridSaida.Rows[e.RowIndex];
                idFluxo = int.Parse(row.Cells["Id"].Value.ToString());
                tituloFluxo = row.Cells["Titulo"].Value.ToString();  //-----------------

            }
        }

        private void button_gastos_Click(object sender, EventArgs e)
        {


            dataGridSaida.Visible = true;
            DataGridView2.Visible = false;
            dataGridEntrada.Visible = false;
            btn_atualizar.Visible = false;
            button_excluir.Visible = false;
            ListarSaídas();

            FormatarGridSaida();
        }

        private void button_vendas_Click(object sender, EventArgs e)
        {

            dataGridSaida.Visible = false;
            DataGridView2.Visible = false;
            dataGridEntrada.Visible = true;
            btn_atualizar.Visible = false;
            button_excluir.Visible = false;
            ListarEntradas();
            FormatarGridEntrada();
        }

        private void buttonGraficos_Click(object sender, EventArgs e)
        {
            FinançasViewGráficos finançasViewGráficos = new FinançasViewGráficos();
            finançasViewGráficos.ShowDialog();

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            {
                FinancasAtualizarView financas = new FinancasAtualizarView(idFluxo);
                financas.ShowDialog();
            }
        }
    }
}











