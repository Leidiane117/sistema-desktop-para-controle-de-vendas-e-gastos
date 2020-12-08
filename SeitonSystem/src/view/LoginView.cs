using SeitonSystem.src.view.Inicial;
using SeitonSystem.view;
using System;
using System.Windows.Forms;

namespace SeitonSystem.src.view
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {


            if (txt_user.Text.Trim() == "" || txt_senha.Text.Trim() == "")
            {

                enviaMsg("Preencha todos os campos!", "aviso");


            }
            else if (txt_user.Text == "admin" && txt_senha.Text == "4321")
            {

                InicialView inicial = new InicialView();
                inicial.Show();
                Close();
            }


            else
            {
                enviaMsg("Senha ou usuário inválidos!", "erro");

            }
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




    }
}
