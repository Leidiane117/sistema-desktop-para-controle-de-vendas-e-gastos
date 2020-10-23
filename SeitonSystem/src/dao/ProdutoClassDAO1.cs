using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeitonSystem.src.dto;

namespace SeitonSystem.src.dao
{
   public  class ProdutoClassDAO1
    {
        public const string inserirProduto = "INSERT INTO produto(nome, preco, descricao)" +
                 "VALUES(@nome, @preco, @descricao)"; //0k

        public const string atualizarProduto = "UPDATE produto SET nome=@nome,preco=@preco,descricao=@descricao  WHERE id=@id";
        public const string deletarRegistro = "DELETE FROM produto WHERE id=@id"; // apaga um registro de acordo com id
        public const string encaminharProdutoDeletado = "INSERT INTO produtos_deletados SELECT id, nome, preco, descricao FROM produto WHERE id = @id";
        // insere o produto  deletado(de acordo com seu id) na tabela produtos deletados //0k
        
        public const string selectProduto = "SELECT id,nome,preco, descricao FROM produto"; // selecionar todas as colunas 0k
        public const string selectPorNome = "SELECT id,nome,preco, descricao FROM produto WHERE"; // selecionar os dados por nome/filtro 0k
        public const string selectProdutId = "SELECT * FROM produto WHERE id=@id";
        
        public const string selectProdutosDeletados = "SELECT id,nome,preco,descricao FROM produtos_deletados";
        public const string selectProdutosDeletadosNome = "SELECT id,nome,preco,descricao FROM produtos_deletados WHERE";
        
        public const string deleteProdutosDeletados= "DELETE FROM produtos_deletados WHERE id=@id";
        public const string recuperarClientesDeletados = "INSERT INTO produto SELECT id, nome, preco, descricao FROM produtos_deletados WHERE id = @id";





        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader MySqlDataReader;


        public ProdutoClassDAO1() // método para nova conexão
        {
            conn = ConnectDAO.GetConnection();
        }

        public ProdutoClassDAO1(MySqlConnection conexao)
        {
            conn = conexao;
        }

        public void InserirProduto(ProdutoClassPrincipal produto) // método Inserir OK
        {
            try
            {
                cmd = new MySqlCommand(inserirProduto, conn);
                cmd.Parameters.Add(new MySqlParameter("@id", produto.Id));
                cmd.Parameters.Add(new MySqlParameter("@nome", produto.Nome));
                cmd.Parameters.Add(new MySqlParameter("@preco", produto.Preco));
                cmd.Parameters.Add(new MySqlParameter("@descricao", produto.Descricao));

                conn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {
                throw new Exception("Erro ao Inserir Produto");
            }
            finally
            {
                ConnectDAO.CloseConnection(conn);
            }
        }


        public void EditarProduto(ProdutoClassPrincipal produto)// método editar
        {
            try
            {
                cmd = new MySqlCommand(atualizarProduto, conn);// abrindo a conexão e chamando a string de consulta
                cmd.Parameters.Add(new MySqlParameter("@id", produto.Id));
                cmd.Parameters.Add(new MySqlParameter("@nome", produto.Nome));
                cmd.Parameters.Add(new MySqlParameter("@preco", produto.Preco));
                cmd.Parameters.Add(new MySqlParameter("@descricao", produto.Descricao));
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception)
            {
                throw new Exception("Erro ao Editar Produto");
            }
            finally
            {
                ConnectDAO.CloseConnection(conn);
            }

        }

        public void ApagarProduto(int id) // método que apaga o produto da tabela produto
        {
            try
            {
                cmd = new MySqlCommand(encaminharProdutoDeletado, conn);
                cmd.Parameters.Add(new MySqlParameter("@id", id)); // seleciona o id e encaminha para tabela produtos deletados

                conn.Open();
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand(deletarRegistro, conn); // apaga registro da tabela produtos
                cmd.Parameters.Add(new MySqlParameter("@id", id));

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConnectDAO.CloseConnection(conn);
            }
        }

        public List<ProdutoClassPrincipal> ListarProdutos() // método select listar todos os produtos
        {
            List<ProdutoClassPrincipal> lista = new List<ProdutoClassPrincipal>();// crio um objeto do tipo lista da minha classe
            //produtopincipal,instancio.

            try
            {
                cmd = new MySqlCommand(selectProduto, conn); //string query para consultar produtos

                conn.Open();
                MySqlDataReader = cmd.ExecuteReader(); // adapatar o mysql para executar a leitura dos dados da minha tabela produtos
                if (MySqlDataReader.HasRows)
                {
                    while (MySqlDataReader.Read())
                    { //enquanto houver leitura
                        ProdutoClassPrincipal dado = new ProdutoClassPrincipal
                        {
                            Id = int.Parse(MySqlDataReader["id"].ToString()),
                            Nome = MySqlDataReader["nome"].ToString(),
                            Preco = double.Parse(MySqlDataReader["preco"].ToString()),
                            Descricao = MySqlDataReader["descricao"].ToString()
                        };
                        lista.Add(dado);
                    }

                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Listar Produtos");
            }
            finally
            {
                MySqlDataReader.Close();
                ConnectDAO.CloseConnection(conn);
            }

            return lista;
        }

               

        public List<ProdutoClassPrincipal> BuscarProdutosPorNome(string nome) // select por nome do produto
        {
            List<ProdutoClassPrincipal> lista2 = new List<ProdutoClassPrincipal>();// crio um objeto do tipo lista da minha classe
            try
            {
                int num;
                string select = selectPorNome;

                if (!int.TryParse(nome, out num))
                {
                    select += " nome LIKE @nome";
                    nome += "%";
                }
                else
                {
                    select += " id = @id";
                }                                                                  //produtopincipal,instancio.

                cmd = new MySqlCommand(select, conn); //string query para consultar produtos
                cmd.Parameters.Add(new MySqlParameter("@nome", nome));

                conn.Open();
                cmd.ExecuteNonQuery();
                MySqlDataReader = cmd.ExecuteReader(); // adapatar o mysql para executar a leitura dos dados da minha tabela produtos
                if (MySqlDataReader.HasRows)
                {
                    while (MySqlDataReader.Read())
                    { //enquanto houver leitura
                        ProdutoClassPrincipal dado = new ProdutoClassPrincipal
                        {
                            Id = int.Parse(MySqlDataReader["id"].ToString()),
                            Nome = MySqlDataReader["nome"].ToString(),
                            Preco = double.Parse(MySqlDataReader["preco"].ToString()),
                            Descricao = MySqlDataReader["descricao"].ToString()
                        };
                        lista2.Add(dado);
                    }

                }
            }
            catch (Exception)
            {
                throw new Exception("Produto não cadastrado!");
            }
            finally
            {
                MySqlDataReader.Close();
                ConnectDAO.CloseConnection(conn);
            }

            return lista2;
        }



        public ProdutoClassPrincipal PesquisaProdutosId(int id)
        {
            ProdutoClassPrincipal produto = new ProdutoClassPrincipal();

            try
            {
                cmd = new MySqlCommand(selectProdutId, conn);

                cmd.Parameters.Add(new MySqlParameter("@id", id));

                conn.Open();
                MySqlDataReader = cmd.ExecuteReader();

                if (MySqlDataReader.HasRows)
                {
                    while (MySqlDataReader.Read())
                    {
                        produto = PublicarProduto1(MySqlDataReader);
                    }
                }
                else
                {
                    throw new Exception("Id não Cadastrado");
                }

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Carregar Dados" +e.Message);
            }
            finally
            {
                ConnectDAO.CloseConnection(this.conn);
            }

            return produto;
        }

       


        public List<ProdutoClassPrincipal> ListarProdutoDeletados() // método select listar todos os produtos
        {
            List<ProdutoClassPrincipal> lista = new List<ProdutoClassPrincipal>();// crio um objeto do tipo lista da minha classe
            //produtopincipal,instancio.

            try
            {
                cmd = new MySqlCommand(selectProdutosDeletados, conn); //string query para consultar produtos

                conn.Open();
                MySqlDataReader = cmd.ExecuteReader(); // adapatar o mysql para executar a leitura dos dados da minha tabela produtos
                if (MySqlDataReader.HasRows)
                {
                    while (MySqlDataReader.Read())
                    { //enquanto houver leitura
                        ProdutoClassPrincipal dado = new ProdutoClassPrincipal
                        {
                            Id = int.Parse(MySqlDataReader["id"].ToString()),
                            Nome = MySqlDataReader["nome"].ToString(),
                            Preco = double.Parse(MySqlDataReader["preco"].ToString()),
                            Descricao = MySqlDataReader["descricao"].ToString()
                        };
                        lista.Add(dado);
                    }

                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Listar Produtos deletados");
            }
            finally
            {
                MySqlDataReader.Close();
                ConnectDAO.CloseConnection(conn);
            }

            return lista;
        }


        public List<ProdutoClassPrincipal> BuscarProdutosDeletadosNome(string nome) // select por nome do produto
        {
            List<ProdutoClassPrincipal> lista2 = new List<ProdutoClassPrincipal>();// crio um objeto do tipo lista da minha classe
            try
            {
                int num;
                string select = selectProdutosDeletadosNome ;

                if (!int.TryParse(nome, out num))
                {
                    select += " nome LIKE @nome";
                    nome += "%";
                }
                else
                {
                    select += " id = @id";
                }                                                                  //produtopincipal,instancio.

                cmd = new MySqlCommand(select, conn); //string query para consultar produtos
                cmd.Parameters.Add(new MySqlParameter("@nome", nome));

                conn.Open();
                cmd.ExecuteNonQuery();
                MySqlDataReader = cmd.ExecuteReader(); // adapatar o mysql para executar a leitura dos dados da minha tabela produtos
                if (MySqlDataReader.HasRows)
                {
                    while (MySqlDataReader.Read())
                    { //enquanto houver leitura
                        ProdutoClassPrincipal dado = new ProdutoClassPrincipal
                        {
                            Id = int.Parse(MySqlDataReader["id"].ToString()),
                            Nome = MySqlDataReader["nome"].ToString(),
                            Preco = double.Parse(MySqlDataReader["preco"].ToString()),
                            Descricao = MySqlDataReader["descricao"].ToString()
                        };
                        lista2.Add(dado);
                    }

                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao pesquisar produto excluído");
            }
            finally
            {
                MySqlDataReader.Close();
                ConnectDAO.CloseConnection(conn);
            }

            return lista2;
        }


        public void RecuperarProduto(int id) // método que apaga o produto da tabela produto
        {
            try
            {
                cmd = new MySqlCommand(recuperarClientesDeletados, conn);
                cmd.Parameters.Add(new MySqlParameter("@id", id)); // seleciona o id e encaminha para tabela produtos deletados

                conn.Open();
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand(deleteProdutosDeletados, conn); // apaga registro da tabela produtos
                cmd.Parameters.Add(new MySqlParameter("@id", id));

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConnectDAO.CloseConnection(conn);
            }
        }

                                          

        private ProdutoClassPrincipal PublicarProduto1(MySqlDataReader MySqlDataReader)
        {
            ProdutoClassPrincipal produto = new ProdutoClassPrincipal
            {
                Id = int.Parse(MySqlDataReader["id"].ToString()),
                Nome = MySqlDataReader["nome"].ToString(),
                Preco = double.Parse(MySqlDataReader["preco"].ToString()),
                Descricao = MySqlDataReader["descricao"].ToString()
            };


            return produto;



        }




    }






}


