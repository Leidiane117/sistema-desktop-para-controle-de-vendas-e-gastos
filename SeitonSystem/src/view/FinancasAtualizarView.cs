using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SeitonSystem.src.dto;
using SeitonSystem.src.controller;
using SeitonSystem.src.view;

namespace SeitonSystem.src.view
{
    public partial class FinancasAtualizarView : Form
    {
        Finanças finanças;
        FinançasController finançasController;

        public FinancasAtualizarView(int idFluxo)
        {

            InitializeComponent();

            try
            {

                finançasController = new FinançasController();
                finanças = new Finanças();

                finanças = finançasController.PesquisarPId(idFluxo);
                PreencheTextBox();

            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");

            }
        }



        private Finanças PopulaFinanças()
        {
            Finanças finanças = new Finanças
            {
                Id = int.Parse(text_id.Text),
                Titulo = txt_AtualizarTitulo.Text,
                Valor = double.Parse(textAtualizarValor.Text),
                Data_lancamento = DateTime.Parse(atualizar_dateTime.Text),
                Descricao = txt_descricao.Text
            };

            return finanças;
        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }



        private void PreencheTextBox()
        {

            text_id.Text = finanças.Id.ToString();
            txt_AtualizarTitulo.Text = finanças.Titulo;
            atualizar_dateTime.Text = finanças.Data_lancamento.ToString();
            textAtualizarValor.Text = finanças.Valor.ToString();
            txt_descricao.Text = finanças.Descricao;
        }

        


        private void LimparForm()
        {
            text_id.Text = "";
            txt_AtualizarTitulo.Clear();
            textAtualizarValor.Clear();
            txt_descricao.Clear();

        }


                    

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btn_salvar_Click_1(object sender, EventArgs e)
        {

                try
                {

                    Finanças finanças = PopulaFinanças();

                    if (!Regex.Match(textAtualizarValor.Text, "^[0-9]{1,4}[,]{0,1}[0-9]{1,2}$").Success)
                    {
                        enviaMsg(" Informe o valor corretamente!", "aviso");
                    }
                    else if (finanças.Valor <= 0.00)
                    {
                        enviaMsg("Informe o valor!", "aviso");
                    }


                    else if (!Regex.Match(txt_AtualizarTitulo.Text, "^[A-Za-zàáâãéèíóôúçÁÀÉÈÍÔÓÕÚÇ ]{1,80}$").Success)
                    {
                        enviaMsg("Informe o Título corretamente!", "aviso");
                    }


                    else
                    {
                    finançasController.AtualizarFluxo(finanças);
                        enviaMsg("Atividade editada com Sucesso", "check");
                        LimparForm();
                    }
                }
                catch (Exception)
                {
                    enviaMsg("Preencha todos os dados corretamente!", "erro");


                }



            }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
           
                FinançasView finançasView = new FinançasView();
                finançasView.ShowDialog();
            }
        }
    }
    

















