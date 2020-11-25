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
using SeitonSystem.view;
using System.Globalization;

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
                totalizar();

            }
            catch (Exception e)
            {
                EnviaMsg("Não foi possível listar as finanças","erro");
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
                totalizar();
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

                //dataGridEntrada.Columns.Clear();
                dataGridEntrada.DataSource = lista4;
                //dataGridEntrada.Refresh();// alimentar o data grid
                FormatarGridEntrada();
                totalizar();
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
            label_Vendas.Visible = false;
            label_Gastos.Visible = false;
            txt_total.Visible = true;
            ListarFluxoTotal();
            totalizar();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ClienteView clienteView = new ClienteView();
            clienteView.ShowDialog(); // botão voltar- tela clientes
        }



        private void button_excluir_Click(object sender, EventArgs e)
        {

            String msg = "Deseja Excluir " + tituloFluxo + "?";

            MensagensView message = new MensagensView(msg, "deleta", idFluxo, "financas");
            message.ShowDialog();

            ListarFluxoTotal();
            totalizar();
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
                    finanças = finançasController.BuscarPFiltro(txt_pesquisa.Text);

                    DataGridView2.Columns.Clear();
                    DataGridView2.DataSource = finanças;
                    totalizar();
                    DataGridView2.Refresh();
                }

                else if (dataGridEntrada.Visible)
                {

                    finanças = finançasController.BuscarPFiltro(txt_pesquisa.Text);

                    dataGridEntrada.Columns.Clear();
                    dataGridEntrada.DataSource = finanças;

                    totalizar();
                    dataGridEntrada.Refresh();

                }

                else if (dataGridSaida.Visible)
                {

                    finanças = finançasController.BuscarPFiltro(txt_pesquisa.Text);

                    dataGridSaida.Columns.Clear();
                    dataGridSaida.DataSource = finanças;

                    totalizar();
                    dataGridSaida.Refresh();
                }
            }
            catch (Exception e1)
            {
                EnviaMsg(e1.Message, "erro");
            }

        }



        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            
                txt_pesquisa.Visible = true; //----------------
                panel1.Visible = true;
         }
          
        

       /* public void ListarPorData(string data1, string data2)
        {
            try
            {
                List<Finanças> lista = new List<Finanças>();
                lista = finançasController.ListarPorData(data1, data2);

                DataGridView2.DataSource = lista;
                FormatarGrid2();
                totalizar();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Não foi possível listar as finanças");
            }

        }
       */

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
            label_Gastos.Visible = true;
            label_Vendas.Visible = false;
            txt_total.Visible = false;
            ListarSaídas();
            totalizar();
            
            
        }

        private void button_vendas_Click(object sender, EventArgs e)
        {

            dataGridSaida.Visible = false;
            DataGridView2.Visible = false;
            dataGridEntrada.Visible = true;
            btn_atualizar.Visible = false;
            button_excluir.Visible = false;
            label_Vendas.Visible = true;
            label_Gastos.Visible = false;
            txt_total.Visible = false;
            ListarEntradas();
            FormatarGridEntrada();
            totalizar();
        }

        private void buttonGraficos_Click(object sender, EventArgs e)
        {
           // FormVendasRelatorio formVendasRelatorio = new FormVendasRelatorio();
            //formVendasRelatorio.Show();

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            {
                FinancasAtualizarView financas = new FinancasAtualizarView(idFluxo);
                financas.ShowDialog();
            }
        }

       


        private double CalculoTotal()
        {
            double totalEntrada = 0, totalSaida = 0;
            


            for (int i = 0; i < DataGridView2.Rows.Count; i++)
            {
                if (DataGridView2.Rows[i].Cells[5].Value.ToString() == "Entrada")
                {
                    totalEntrada = totalEntrada + Convert.ToDouble(DataGridView2.Rows[i].Cells[2].Value);
                    label_Vendas.Text = totalEntrada.ToString();
                }
                else
                {
                    totalSaida = totalSaida + Convert.ToDouble(DataGridView2.Rows[i].Cells[2].Value);
                    label_Gastos.Text = totalSaida.ToString();
                }
            }

         return totalEntrada - totalSaida;

        }
       

        private void totalizar()
        {

            label_Gastos.ForeColor = Color.DarkRed;
            label_Vendas.ForeColor = Color.DarkBlue;
            txt_total.Text = CalculoTotal().ToString();
            if (Convert.ToDouble(txt_total.Text) < 0)
            {
                txt_total.ForeColor = Color.DarkRed;

            }
            else
            {
                txt_total.ForeColor = Color.DarkGreen;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //
        }

        
    }

}












