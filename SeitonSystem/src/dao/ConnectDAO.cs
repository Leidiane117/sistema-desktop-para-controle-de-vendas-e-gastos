using MySql.Data.MySqlClient;
using SeitonSystem.src.view;
using System;
using SeitonSystem.src.view.Inicial;
using System.Windows.Forms;

namespace SeitonSystem.src.dao
{
    class ConnectDAO
    {
        public const String url = @"server=127.0.0.1;user id=root;database=seiton_system;SslMode=none";

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(url);
                return conn;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível realizar Conexão com Banco de Dados");
            }
        }

        public static void CloseConnection(MySqlConnection conn)
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Fechar Banco de Dados");
            }
        }



        public void BackupMySql()

        {
            try
            {
                string arquivo = "C:\\backup_restore\\seiton_system.txt";
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        using (MySqlBackup dados = new MySqlBackup(comando))
                        {
                            comando.Connection = conn;
                            conn.Open();
                            dados.ExportProgressChanged += Dados_ExportProgressChanged;
                            dados.ExportCompleted += Dados_ExportCompleted1;
                            dados.ExportInfo.IntervalForProgressReport = (int)500;
                            dados.ExportToFile(arquivo);
                            conn.Close();

                        }
                    }
                }

            }
            catch (Exception)
            {
                enviaMsg("Erro ao Fazer Backup", "erro");
            }
        }

        public void Dados_ExportProgressChanged(object sender, ExportProgressArgs e)
        {


            ProgressBar progressBar = new ProgressBar();
            progressBar.Visible = true;
            progressBar.Minimum = 1;
            progressBar.Maximum = 100;
            progressBar.Value = 1;
            progressBar.Step = 1;




        }




        private void Dados_ExportCompleted1(object sender, ExportCompleteArgs e)
        {

            enviaMsg("Backup realizado com Sucesso", "check");
        }



        
        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }



    }

}
