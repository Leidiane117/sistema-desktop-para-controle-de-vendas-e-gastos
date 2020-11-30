using SeitonSystem.src.controller;
using System;
using System.Windows.Forms;

namespace SeitonSystem.src.view
{
    public partial class MensagensView : Form
    {
        ProdutoController produtoController;
        ClienteController clienteController;
        FinancasController financasController;

        String tipo;
        String obj;
        int id;

        public MensagensView(String msg, String tipo, int id, string obj)
        {
            InitializeComponent();
            pic_info.BackgroundImage = global::SeitonSystem.Properties.Resources.icon_aviso;

            this.tipo = tipo;
            this.id = id;
            this.obj = obj;

            btn_ok.Visible = true;
            lbl_msg.Text = msg;

            produtoController = new ProdutoController();
            clienteController = new ClienteController();
            financasController = new FinancasController();

        }

        public MensagensView(String msg, String tipo)
        {
            InitializeComponent();

            this.tipo = tipo;
            lbl_msg.Text = msg;

            verificaTipoMsg();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (this.tipo == "deleta" && this.obj == "produto")
            {
                DeletarProduto(id);
            }

            if (this.tipo == "recupera" && this.obj == "produto")
            {
                RecuperarProduto(id);
            }

            if (this.tipo == "deleta" && this.obj == "cliente")
            {
                deletarCliente(this.id);
            }

            if (this.tipo == "recupera" && this.obj == "cliente")
            {
                recuperarCliente(this.id);
            }

            if (this.tipo == "deleta" && this.obj == "financas")
            {
                deletarFinancas(this.id);
            }

        }

        private void verificaTipoMsg()
        {
            switch (this.tipo)
            {
                case "erro":
                    pic_info.BackgroundImage = global::SeitonSystem.Properties.Resources.icon_erro;
                    break;
                case "aviso":
                    pic_info.BackgroundImage = global::SeitonSystem.Properties.Resources.icon_aviso;
                    break;
                case "check":
                    pic_info.BackgroundImage = global::SeitonSystem.Properties.Resources.icon_check;
                    break;
                default:
                    break;
            }
        }

        private void DeletarProduto(int id)
        {
            try
            {
                produtoController.desativarProduto(id);

                enviaMsg("Produto Desativado", "check");
            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void RecuperarProduto(int id)
        {
            try
            {
                produtoController.reativarProduto(id);

                enviaMsg("Produto Reativado", "check");
            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void deletarCliente(int id)
        {
            try
            {
                this.clienteController.desativarCliente(this.id);

                enviaMsg("Cliente Desativado", "check");
            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void recuperarCliente(int id)
        {
            try
            {
                this.clienteController.reativarCliente(this.id);

                enviaMsg("Cliente Reativado", "check");
            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void deletarFinancas(int id)
        {
            try
            {
                this.financasController.deletarFluxo(this.id);

                enviaMsg("Atividade Deletada", "check");
            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
            Hide();
        }

    }
}
