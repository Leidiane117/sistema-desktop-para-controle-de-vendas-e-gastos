using MySql.Data.MySqlClient;
using SeitonSystem.src.dto;
using System;
using System.Collections.Generic;

namespace SeitonSystem.src.dao
{
    class ProdutoDAO
    {
        public const string INSERT_PRODUTO = "INSERT INTO produto(nome, preco, descricao, status)" +
                 "VALUES(@nome, @preco, @descricao, 'ativo')";

        public const string UPDATE_PRODUTO = "UPDATE produto SET nome=@nome,preco=@preco,descricao=@descricao  WHERE id=@id";
        public const string DESATIVE_PRODUTO = "UPDATE produto SET status='desativo' WHERE id=@id";
        public const string REATIVA_PRODUTO = "UPDATE produto SET status='ativo' WHERE id=@id";

        public const string SELECT_PRODUTO = "SELECT * FROM produto WHERE status='ativo'";
        public const string SELECT_PRODUTO_FILTRO = "SELECT * FROM produto WHERE status='ativo' AND ";

        public const string SELECT_PRODUTO_ID = "SELECT * FROM produto WHERE id=@id";

        public const string SELECT_PRODUTO_DESATIVADO = "SELECT * FROM produto WHERE status='desativo'";
        public const string SELECT_PRODUTO_DESATIVO_FILTRO = "SELECT * FROM produto WHERE status='desativo' AND ";

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dataReader;

        public ProdutoDAO()
        {
            this.conn = ConnectDAO.GetConnection();
        }

        public ProdutoDAO(MySqlConnection conexao)
        {
            this.conn = conexao;
        }

        public void inserirProduto(Produto produto)
        {
            try
            {

                this.cmd = new MySqlCommand(INSERT_PRODUTO, this.conn);
                this.cmd.Parameters.Add(new MySqlParameter("@id", produto.Id));
                this.cmd.Parameters.Add(new MySqlParameter("@nome", produto.Nome));
                this.cmd.Parameters.Add(new MySqlParameter("@preco", produto.Preco));
                this.cmd.Parameters.Add(new MySqlParameter("@descricao", produto.Descricao));

                this.conn.Open();
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Inserir Produto");
            }
            finally
            {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void atualizarProduto(Produto produto)
        {
            try
            {

                this.cmd = new MySqlCommand(UPDATE_PRODUTO, this.conn);
                this.cmd.Parameters.Add(new MySqlParameter("@id", produto.Id));
                this.cmd.Parameters.Add(new MySqlParameter("@nome", produto.Nome));
                this.cmd.Parameters.Add(new MySqlParameter("@preco", produto.Preco));
                this.cmd.Parameters.Add(new MySqlParameter("@descricao", produto.Descricao));

                this.conn.Open();
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Atualizar Produto");
            }
            finally
            {
                ConnectDAO.CloseConnection(this.conn);
            }

        }

        public void desativarProduto(int id)
        {
            try
            {
                this.cmd = new MySqlCommand(DESATIVE_PRODUTO, this.conn);
                this.cmd.Parameters.Add(new MySqlParameter("@id", id));

                this.conn.Open();
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void reativarProduto(int id)
        {
            try
            {
                this.cmd = new MySqlCommand(REATIVA_PRODUTO, this.conn);
                this.cmd.Parameters.Add(new MySqlParameter("@id", id));

                this.conn.Open();
                this.cmd.ExecuteNonQuery();
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

        public List<Produto> pesquisarProdutos()
        {
            List<Produto> lista = new List<Produto>();

            try
            {
                this.cmd = new MySqlCommand(SELECT_PRODUTO, this.conn);

                this.conn.Open();

                this.dataReader = cmd.ExecuteReader();

                if (this.dataReader.HasRows)
                {
                    while (this.dataReader.Read())
                    {
                        Produto produto = publicarProduto(this.dataReader);
                        lista.Add(produto);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Listar Produtos");
            }
            finally
            {
                this.dataReader.Close();
                ConnectDAO.CloseConnection(conn);
            }

            return lista;
        }

        public List<Produto> pesquisaProdutosFiltro(string filtro)
        {
            List<Produto> lista = new List<Produto>();

            try
            {
                int num;
                string select = SELECT_PRODUTO_FILTRO;

                if (!int.TryParse(filtro, out num))
                {
                    filtro += "%";
                    select += " nome LIKE @nome";
                }
                else
                {
                    select += " id = @id";
                }

                this.cmd = new MySqlCommand(select, this.conn);
                this.cmd.Parameters.Add(new MySqlParameter("@nome", filtro));

                this.conn.Open();
                this.cmd.ExecuteNonQuery();
                this.dataReader = this.cmd.ExecuteReader();

                if (this.dataReader.HasRows)
                {
                    while (this.dataReader.Read())
                    {
                        Produto dado = publicarProduto(this.dataReader);
                        lista.Add(dado);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.dataReader.Close();
                ConnectDAO.CloseConnection(conn);
            }

            return lista;
        }

        public Produto pesquisaProdutosId(int id)
        {
            Produto produto = new Produto();

            try
            {
                this.cmd = new MySqlCommand(SELECT_PRODUTO_ID, this.conn);
                this.cmd.Parameters.Add(new MySqlParameter("@id", id));

                this.conn.Open();
                this.dataReader = this.cmd.ExecuteReader();

                if (this.dataReader.HasRows)
                {
                    while (this.dataReader.Read())
                    {
                        produto = publicarProduto(this.dataReader);
                    }
                }
                else
                {
                    throw new Exception("Id não Cadastrado");
                }

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Carregar Dados" + e.Message);
            }
            finally
            {
                ConnectDAO.CloseConnection(this.conn);
            }

            return produto;
        }

        public List<Produto> pesquisaProdutosDesativados()
        {
            List<Produto> lista = new List<Produto>();

            try
            {
                this.cmd = new MySqlCommand(SELECT_PRODUTO_DESATIVADO, this.conn);

                this.conn.Open();

                this.dataReader = cmd.ExecuteReader();

                if (this.dataReader.HasRows)
                {
                    while (this.dataReader.Read())
                    {
                        Produto produto = publicarProduto(this.dataReader);
                        lista.Add(produto);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Listar Produtos Deletados");
            }
            finally
            {
                this.dataReader.Close();
                ConnectDAO.CloseConnection(conn);
            }

            return lista;
        }


        public List<Produto> pesquisaProdutosDesativadosFiltro(string filtro)
        {
            List<Produto> lista = new List<Produto>();

            try
            {
                int num;
                string select = SELECT_PRODUTO_DESATIVO_FILTRO;

                if (!int.TryParse(filtro, out num))
                {
                    filtro += "%";
                    select += " nome LIKE @nome";
                }
                else
                {
                    select += " id = @id";
                }

                this.cmd = new MySqlCommand(select, this.conn);
                this.cmd.Parameters.Add(new MySqlParameter("@nome", filtro));

                this.conn.Open();
                this.cmd.ExecuteNonQuery();
                this.dataReader = this.cmd.ExecuteReader();

                if (this.dataReader.HasRows)
                {
                    while (this.dataReader.Read())
                    {
                        Produto dado = publicarProduto(this.dataReader);
                        lista.Add(dado);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.dataReader.Close();
                ConnectDAO.CloseConnection(conn);
            }

            return lista;
        }

        private Produto publicarProduto(MySqlDataReader dataReader)
        {
            Produto produto = new Produto
            {
                Id = int.Parse(dataReader["id"].ToString()),
                Nome = dataReader["nome"].ToString(),
                Preco = double.Parse(dataReader["preco"].ToString()),
                Descricao = dataReader["descricao"].ToString()
            };

            return produto;
        }

    }

}


