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
            timer1.Enabled = true;
            if (txt_user.Text.Trim() == "" || txt_senha.Text.Trim() == "")
            {

                enviaMsg("Preencha todos os campos!", "aviso");


                if (txt_user.Text != "admin" && txt_senha.Text != "4321")
                {
                    enviaMsg("Senha ou usuário inválidos!", "erro");

                }

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

        private void timer1_Tick(object sender, EventArgs e)
        {


            pb_login.Visible = true;
            if (pb_login.Value < pb_login.Maximum)
            {
                pb_login.Value += 1;

            }
            else
            {
                timer1.Stop();
                
                InicialView inicial = new InicialView();
                inicial.Show();
                this.Hide();


            }

        }
    }
}


