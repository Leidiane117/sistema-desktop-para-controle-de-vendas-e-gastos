using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeitonSystem.src.dto;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SeitonSystem.src.dao {
    class ClienteDAO {
        public const String INSERT_CLIENTE = "INSERT INTO cliente(nome, telefone, celular, instagram, email, status)" +  
            "VALUES(@nome, @telefone, @celular, @instagram, @email, 'ativo')";

        public const String UPDATE_CLIENTE = "UPDATE cliente SET nome = @nome, telefone = @telefone, celular = @celular, " +
            "instagram = @instagram, email = @email WHERE id = @id";

        public const String SELECT_CLIENTES = "SELECT * FROM cliente WHERE status='ativo'";
        public const String SELECT_CLIENTE_ID = "SELECT * FROM cliente WHERE id = @id";
        public const String SELECT_CLIENTE_FILTRO = "SELECT * FROM cliente WHERE status='ativo' AND ";

        public const String SELECT_CLIENTES_DESATIVO = "SELECT * FROM cliente WHERE status='desativo'";
        public const String SELECT_CLIENTES_DESATIVO_FILTRO = "SELECT * FROM cliente WHERE status='desativo' AND ";

        public const String DESATIVE_CLIENTE = "UPDATE cliente SET status='desativo' WHERE id = @id";
        public const String REATIVA_CLIENTE = "UPDATE cliente SET status='ativo' WHERE id = @id";

        MySqlConnection conn;
        MySqlCommand command;
        MySqlDataReader dataReader;

        public ClienteDAO() {
            this.conn = ConnectDAO.GetConnection();
        }

        public ClienteDAO(MySqlConnection conexao){
            this.conn = conexao;
        }

        public void inserirCliente(Cliente cliente) {
            try {
                this.command = new MySqlCommand(INSERT_CLIENTE, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
                this.command.Parameters.Add(new MySqlParameter("@telefone", cliente.Telefone));
                this.command.Parameters.Add(new MySqlParameter("@celular", cliente.Celular));
                this.command.Parameters.Add(new MySqlParameter("@instagram", cliente.Instagram));
                this.command.Parameters.Add(new MySqlParameter("@email", cliente.Email));

                this.conn.Open();
                this.command.ExecuteNonQuery();

                
            }catch (Exception){
                throw new Exception("Erro ao Inserir Cliente");
            }finally{
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void atualizarCliente(Cliente cliente) {
            try {
                this.command = new MySqlCommand(UPDATE_CLIENTE, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
                this.command.Parameters.Add(new MySqlParameter("@telefone", cliente.Telefone));
                this.command.Parameters.Add(new MySqlParameter("@celular", cliente.Celular));
                this.command.Parameters.Add(new MySqlParameter("@instagram", cliente.Instagram));
                this.command.Parameters.Add(new MySqlParameter("@email", cliente.Email));

                this.command.Parameters.Add(new MySqlParameter("@id", cliente.Id));

                this.conn.Open();
                this.command.ExecuteNonQuery();
            } catch (Exception) {
                throw new Exception("Erro ao Atualizar Cliente");
            } finally {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void desativarCliente(int id) {
            try {
                this.command = new MySqlCommand(DESATIVE_CLIENTE, this.conn);
                this.command.Parameters.Add(new MySqlParameter("@id", id));

                this.conn.Open();
                this.command.ExecuteNonQuery();
         
            } catch (Exception) {
                throw;
            } finally {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void reativarCliente(int id) {
            try {
                this.command = new MySqlCommand(REATIVA_CLIENTE, this.conn);
                this.command.Parameters.Add(new MySqlParameter("@id", id));

                this.conn.Open();
                this.command.ExecuteNonQuery();
            } catch (Exception) {
                throw;
            } finally {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public List<Cliente> pesquisaClientes(){
            List<Cliente> clientes = new List<Cliente>();

            try {
                this.command = new MySqlCommand(SELECT_CLIENTES, this.conn);

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                while (this.dataReader.Read()){
                    Cliente cliente = populaCliente(this.dataReader);
                    clientes.Add(cliente);
                }
            }catch (Exception) {
                throw new Exception("Erro ao Pesquisar Clientes");
            }finally {
                this.dataReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return clientes;
        }

        public List<Cliente> pesquisaClientesDesativados() {
            List<Cliente> clientes = new List<Cliente>();

            try {
                this.command = new MySqlCommand(SELECT_CLIENTES_DESATIVO, this.conn);

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                while (this.dataReader.Read()) {
                    Cliente cliente = populaCliente(this.dataReader);
                    clientes.Add(cliente);
                }
            } catch (Exception) {
                throw new Exception("Erro ao Pesquisar Clientes Deletados");
            } finally {
                this.dataReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return clientes;
        }

        public Cliente pesquisaClienteId(int id){
            Cliente cliente = new Cliente();

            try {
                this.command = new MySqlCommand(SELECT_CLIENTE_ID, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@id", id));

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                if (this.dataReader.HasRows) {
                    while (this.dataReader.Read()) {
                       cliente = populaCliente(this.dataReader);
                    }
                } else {
                    throw new Exception("Id não Cadastrado");
                }

            }catch (Exception) {
                throw new Exception("Erro ao Carregar Dados");
            }finally{
                ConnectDAO.CloseConnection(this.conn);
                this.dataReader.Close();
            }

            return cliente;
        }

        public List<Cliente> pesquisaClientesFiltro(String filtro){
            List<Cliente> clientes = new List<Cliente>();

            try {
                int num;
                string select = SELECT_CLIENTE_FILTRO;

                if(!int.TryParse(filtro, out num)){
                    select += " nome LIKE @filtro";
                    filtro += "%";
                }else {
                    select += " id = @filtro";
                }
                
                this.command = new MySqlCommand(select, this.conn);
                this.command.Parameters.Add(new MySqlParameter("@filtro", filtro));

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                while (this.dataReader.Read()) {
                    Cliente cliente = populaCliente(this.dataReader);
                    clientes.Add(cliente);
                }
            }catch (Exception e) {
                throw new Exception(e.Message);
            }finally {
                this.dataReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return clientes;
        }

        public List<Cliente> pesquisaClientesDesativadosFiltro(String filtro) {
            List<Cliente> clientes = new List<Cliente>();

            try {
                int num;
                string select = SELECT_CLIENTES_DESATIVO_FILTRO;

                if (!int.TryParse(filtro, out num)){
                    select += " nome LIKE @filtro";
                    filtro += "%";
                }else {
                    select += " id = @filtro";
                }

                this.command = new MySqlCommand(select, this.conn);
                this.command.Parameters.Add(new MySqlParameter("@filtro", filtro));

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                while (this.dataReader.Read()) {
                    Cliente cliente = populaCliente(this.dataReader);
                    clientes.Add(cliente);
                }
            }catch (Exception e) {
                throw new Exception(e.Message);
            }finally {
                this.dataReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return clientes;
        }

        private Cliente populaCliente(MySqlDataReader dataReader){
            Cliente cliente = new Cliente();

            cliente.Id = int.Parse(dataReader["id"].ToString());
            cliente.Nome = dataReader["nome"].ToString();
            cliente.Telefone = dataReader["telefone"].ToString();
            cliente.Celular = dataReader["celular"].ToString();
            cliente.Instagram = dataReader["instagram"].ToString();
            cliente.Email = dataReader["email"].ToString();

            return cliente;
        }

    }
}
