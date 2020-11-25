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
using System.Windows.Forms;
using SeitonSystem.src.dto;
using SeitonSystem.src.view;
using SeitonSystem.view;

namespace SeitonSystem.src.view
{
    public partial class LoginView : Form
    {

        public LoginView()
        {
            InitializeComponent();


        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_senha.Clear();
            txt_user.Clear();
        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        

        private void entrar_Click(object sender, EventArgs e)
        {

            if (txt_user.Text == "admin" && txt_senha.Text == "4321")
            {
                enviaMsg("Bem vindo(a) ao Sistema", "check");
                Close();

                ClienteView cliente = new ClienteView();
                cliente.ShowDialog();
            }

            else
            {
                enviaMsg("Você não tem acesso ao Sistema!", "erro");

            }
        
        }
    }
 }

