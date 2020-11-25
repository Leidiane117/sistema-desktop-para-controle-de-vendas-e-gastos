using SeitonSystem.src.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeitonSystem.src.view {
    public partial class MensagensView : Form {
        ProdutoClassController produtoController;
        FinançasController finançasController;
       //ClienteController clienteController;
            String tipo,obj;
            int id;

        public MensagensView(String msg, String tipo, int id, String obj){
            InitializeComponent();
            pic_info.BackgroundImage = global::SeitonSystem.Properties.Resources.icon_aviso;

            this.tipo = tipo;
            this.id = id;
            this.obj = obj;

            btn_ok.Visible = true;
            lbl_msg.Text = msg;

            finançasController = new FinançasController();
            produtoController = new ProdutoClassController();
        }

        public MensagensView(String msg, String tipo){
            InitializeComponent();

            this.tipo = tipo;
            lbl_msg.Text = msg;
            

            
            verificaTipoMsg();

        }


        private void btn_voltar_Click(object sender, EventArgs e){
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            if (tipo == "deleta" && obj=="produto")  {
                DeletarProduto(id);
            }
            if (tipo == "deleta" && obj=="financas")
            {
                DeletarFluxo(id);
            }

             if (tipo == "recupera" && obj=="produto") {
                RecuperarProduto(id);
            }
           /*else if (tipo=="recupera" && obj=="cliente")
            {
                RecuperarCliente(id);
            }
    */    
    }

        private void verificaTipoMsg() {
            switch (this.tipo) {
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

        private void DeletarProduto(int id) {
            try {
                produtoController.ApagarProduto(id);

                EnviaMsg("Produto Deletado com Sucesso", "check");
            }catch (Exception e){
                EnviaMsg(e.Message, "erro");
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

        private void RecuperarProduto(int id) {
            try {
                produtoController.RecuperarProduto(id);

                EnviaMsg("Produto Recuperado", "check");
            }catch (Exception e) {
                EnviaMsg(e.Message, "erro");
            }
        }

        private void EnviaMsg(String msg, String tipo) {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog(); 
            Hide();
        }

    }
}
