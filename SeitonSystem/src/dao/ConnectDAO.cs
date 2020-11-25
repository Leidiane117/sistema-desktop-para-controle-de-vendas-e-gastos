using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SeitonSystem.src.view;

namespace SeitonSystem.src.dao {
    class ConnectDAO {
        public const String url = @"server=127.0.0.1;user id=root;database=seiton_system;SslMode=none";

        public static MySqlConnection GetConnection() {
            try {
                MySqlConnection conn = new MySqlConnection(url);
                return conn;
            }
            catch (Exception) {
                throw new Exception("Não foi possível realizar Conexão com Banco de Dados");
            }
        }

        public static void CloseConnection(MySqlConnection conn) {
            try {
                if (conn != null) {
                    conn.Close();
                }
            }
            catch (Exception) {
                throw new Exception("Erro ao Fechar Banco de Dados");
            }
        }


        public void BackupMySql()

        {
            try
            {
                string arquivo = "C:\\BackUp_Seiton_System\\seiton_system.sql";
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        using (MySqlBackup dados = new MySqlBackup(comando))
                        {
                            comando.Connection = conn;
                            conn.Open();
                            dados.ExportToFile(arquivo);
                            conn.Close();

                        }
                    }
                }
                enviaMsg("Backup realizado com Sucesso", "check"); // dá pra colocar o mensagens view
            }
            catch (Exception e)
            {
                enviaMsg("Erro ao Fazer Backup", "erro" + e);
            }
        }
           public void RestoreMySql()

            {
                try
                {
                    string arquivo = "C:\\BackUp_Seiton_System\\seiton_systemRestore.sql";
                    using (MySqlConnection conn = new MySqlConnection(url))
                    {
                        using (MySqlCommand comando = new MySqlCommand())
                        {
                            using (MySqlBackup dados = new MySqlBackup(comando))
                            {
                                comando.Connection = conn;
                                conn.Open();
                                dados.ImportFromFile(arquivo);
                                conn.Close();

                            }
                        }
                    }
                    enviaMsg("Resutauração realizada com Sucesso","check");
                }
                catch (Exception e)
                {
                    enviaMsg("Erro ao Fazer Restauração","erro" + e);
                }

            }
            private void enviaMsg(String msg, String tipo)
            {
                MensagensView message = new MensagensView(msg, tipo);
                message.ShowDialog();
            }


        }

    }
