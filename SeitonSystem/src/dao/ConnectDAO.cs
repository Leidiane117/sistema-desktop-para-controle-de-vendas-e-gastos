using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SeitonSystem.src.dao {
    class ConnectDAO {
        public const String url = @"server=127.0.0.1;user id=root;database=seiton_system;SslMode=none";
        
        public static MySqlConnection GetConnection(){
            try{
                MySqlConnection conn = new MySqlConnection(url);
                return conn;
            }
            catch (Exception){
                throw new Exception("Não foi possível realizar Conexão com Banco de Dados");
            }
        }
    
        public static void CloseConnection(MySqlConnection conn){
            try {
                if(conn != null) {
                    conn.Close();
                }
            }
            catch (Exception){
                throw new Exception("Erro ao Fechar Banco de Dados");
            }
        }
    
    }
}
