using SeitonSystem.src.dao;
using SeitonSystem.src.dto;
using SeitonSystem.src.controller;
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
using SeitonSystem.src.view.Pedido;

namespace SeitonSystem.view {
    public partial class ClienteAtualizarView : Form {
        ClienteController clienteController;
        Cliente cliente;

        public ClienteAtualizarView(int idCliente) {
            InitializeComponent();

            try {
                this.clienteController = new ClienteController();
                this.cliente = new Cliente();

                this.cliente = this.clienteController.pesquisaClienteId(idCliente);
                preencheTextBox();
            } catch (Exception e){
                enviaMsg(e.Message, "erro");
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e){
            try {
                Cliente cliente = populaCliente();
                validaCliente(cliente);

                this.clienteController.atualizarCliente(cliente);
                limparCampos();

                enviaMsg("Cliente Alterado", "check");

                ClienteView cv = new ClienteView();
                cv.Show();
                this.Close();
            }catch (Exception e1) {
                enviaMsg(e1.Message, "aviso");
            }
        }

        private void enviaMsg(String msg, String tipo) {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void limparCampos() {
            txt_id.Text = "";
            txt_nome.Text = "";
            txt_ddTel.Text = "";
            txt_telefone.Text = "";
            txt_ddCel.Text = "";
            txt_celular.Text = "";
            txt_insta.Text = "";
            txt_email.Text = "";
        }

        private Cliente populaCliente() {
            Cliente cliente = new Cliente();

            cliente.Id = int.Parse(txt_id.Text);
            cliente.Nome = txt_nome.Text;
            cliente.Telefone = txt_ddTel.Text + txt_telefone.Text;
            cliente.Celular = txt_ddCel.Text + txt_celular.Text;
            cliente.Instagram = txt_insta.Text;
            cliente.Email = txt_email.Text;

            return cliente;
        }

        private void validaCliente(Cliente cliente) {
            try {
                double num;

                if (cliente.Nome.Trim() == "" || cliente.Nome == null) {
                    throw new Exception("Informe o Nome");
                }

                if (cliente.Telefone.Trim() != "")  {
                    if (!double.TryParse(cliente.Telefone, out num) || cliente.Telefone.Length < 10) {
                        throw new Exception("DDD e Telefone Inválido");
                    }
                }

                if (cliente.Celular.Trim() == "" || cliente.Celular == null) {
                    throw new Exception("Informe o Celular");
                }else if (!double.TryParse(cliente.Celular, out num) || cliente.Celular.Length < 11)
                {
                    throw new Exception("DDD e Celular Inválido");
                }

                if (cliente.Email.Trim() == "" || cliente.Email == null) {
                    throw new Exception("Informe o Email");
                }
            }catch (Exception) {
                throw;
            }
        }

        private void preencheTextBox() {
            txt_id.Text = this.cliente.Id.ToString();
            txt_nome.Text = this.cliente.Nome;

            txt_ddTel.Text = this.cliente.Telefone.Substring(0, 2);
            txt_telefone.Text = this.cliente.Telefone.Substring(2);

            txt_ddCel.Text = this.cliente.Celular.Substring(0, 2);
            txt_celular.Text = this.cliente.Celular.Substring(2);

            txt_insta.Text = this.cliente.Instagram;
            txt_email.Text = this.cliente.Email;
        }

        private void btn_produtos_Click(object sender, EventArgs e){
            ProdutoView p = new ProdutoView();
            p.Show();
            this.Hide();
        }

        private void btn_clientes_Click(object sender, EventArgs e){
            ClienteView cv = new ClienteView();
            cv.Show();
            this.Hide();
        }

        private void btn_pedido_Click(object sender, EventArgs e){
            PedidoView p = new PedidoView();
            p.Show();
            this.Hide();
        }

        private void btn_financas_Click(object sender, EventArgs e){
            FinancasView f = new FinancasView();
            f.Show();
            this.Hide();
        }
    }
}
