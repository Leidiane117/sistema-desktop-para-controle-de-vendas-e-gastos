using SeitonSystem.src.controller;
using SeitonSystem.src.dao;
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

namespace SeitonSystem.view {
    public partial class ClienteCadastrarView : Form {
        ClienteController clienteController;

        public ClienteCadastrarView() {
            InitializeComponent();

            try {
                clienteController = new ClienteController();
            }catch(Exception e){
                enviaMsg(e.Message, "erro");
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e) {
            ClienteView cv = new ClienteView();
            cv.Show();
            this.Close();
        }

        private void btn_clientes_Click(object sender, EventArgs e){
            ClienteView cv = new ClienteView();
            cv.Show();
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            limparCampos();
        }

        private void btn_salvar_Click(object sender, EventArgs e) {
            try {
                Cliente cliente = populaCliente();
                validaCliente(cliente);

                this.clienteController.inserirCliente(cliente);
                limparCampos();

                enviaMsg("Cliente Salvo", "check");

            } catch (Exception e1) {
                enviaMsg(e1.Message, "aviso");
            }
            
        }

        private void limparCampos() {
            txt_nome.Text = "";
            txt_ddTel.Text = "";
            txt_telefone.Text = "";
            txt_ddCel.Text = "";
            txt_celular.Text = "";
            txt_insta.Text = "";
            txt_email.Text = "";
        }

        private Cliente populaCliente(){
            Cliente cliente = new Cliente();

            cliente.Nome = txt_nome.Text;
            cliente.Telefone = txt_ddTel.Text + txt_telefone.Text;
            cliente.Celular = txt_ddCel.Text + txt_celular.Text;
            cliente.Instagram = txt_insta.Text;
            cliente.Email = txt_email.Text;

            return cliente;
        }

        private void validaCliente(Cliente cliente) {
            try{
                double num;

                if (cliente.Nome.Trim() == "" || cliente.Nome == null) {
                    throw new Exception("Informe o Nome");
                }

                if (!double.TryParse(cliente.Telefone, out num)) {
                    throw new Exception("DDD e Telefone Inválido");
                }

                if (cliente.Celular.Trim() == "" || cliente.Celular == null){
                    throw new Exception("Informe o DDD e Celular");
                }else if(!double.TryParse(cliente.Celular, out num)){
                    throw new Exception("DDD e Celular Inválido");
                }

                if (cliente.Email.Trim() == "" || cliente.Email == null) {
                    throw new Exception("Informe o Email");
                }
            }catch (Exception){
                limparCampos();
                throw;
            }
        }

        private void enviaMsg(String msg, String tipo){
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

    }
}
