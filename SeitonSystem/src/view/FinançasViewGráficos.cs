using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeitonSystem.src.controller;
using SeitonSystem.src.dto;
using SeitonSystem.src.view;

namespace SeitonSystem.src.view
{
    public partial class FinançasViewGráficos : Form
    {
        FinançasController financasController;

        public FinançasViewGráficos()
        {


            InitializeComponent();
         

            try
            {

                financasController = new FinançasController();
               

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro");
            }


        }

        private void graficoVendas()
        {
            try
            {
                List<Finanças> lista4 = new List<Finanças>();

                 
                lista4 = financasController.ListarFluxoEntrada();
                // = lista4;

                // ch_vendas.DataSource = lista4;
                //ch_vendas.ChartAreas = "Vendas por Período";
                
               




            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro");
            }

       

        }

       
        private void FinançasViewGráficos_Load(object sender, EventArgs e)
        {
            graficoVendas();    // TODO: esta linha de código carrega dados na tabela 'seiton_systemDataSet.fluxo_de_caixa'. Você pode movê-la ou removê-la conforme necessário.

            this.reportViewer1.RefreshReport();
        }
    }
}

