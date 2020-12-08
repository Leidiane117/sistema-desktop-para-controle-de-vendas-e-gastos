using MySql.Data.MySqlClient;
using SeitonSystem.src.dto;
using System;
using System.Collections.Generic;

namespace SeitonSystem.src.dao
{
    public class FinancasDAO
    {
        public const string INSERT_FLUXO = "INSERT INTO fluxo_de_caixa(titulo, valor, descricao, data_lancamento, tipo_fluxo)" +
                "VALUES(@titulo,@valor, @descricao, @data_lancamento,@tipo_fluxo)";

        public const string UPDATE_FLUXO = "UPDATE fluxo_de_caixa SET titulo=@titulo, valor=@valor,descricao=@descricao, " +
            "data_lancamento=@data_lancamento, tipo_fluxo=@tipo_fluxo  WHERE id=@id";

        public const string SELECT_FLUXO_ID = "SELECT * FROM fluxo_de_caixa WHERE id=@id";
        public const string SELECT_FLUXO_DATA = "SELECT * FROM fluxo_de_caixa WHERE data_lancamento >= @data ORDER BY data_lancamento ASC";

        public const string SELECT_FLUXO_TIPO = "SELECT * FROM fluxo_de_caixa WHERE tipo_fluxo=@tipo ORDER BY data_lancamento ASC";
        public const string SELECT_FLUXO_TIPO_DATA = "SELECT * FROM fluxo_de_caixa WHERE tipo_fluxo=@tipo AND data_lancamento >= @data ORDER BY data_lancamento ASC ";
        public const string SELECT_FLUXO_TIPO_DATA_PERIODO = "SELECT * FROM fluxo_de_caixa WHERE tipo_fluxo=@tipo AND data_lancamento BETWEEN @data1  AND @data2 ";

        public const string DELETE_FLUXO = "DELETE FROM fluxo_de_caixa WHERE id=@id";

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dtReader;

        public FinancasDAO()
        {
            this.conn = ConnectDAO.GetConnection();
        }

        public FinancasDAO(MySqlConnection conexao)
        {
            this.conn = conexao;
        }

        public void inserirFluxo(Financas financas)
        {
            try
            {
                this.cmd = new MySqlCommand(INSERT_FLUXO, this.conn);

                this.cmd.Parameters.Add(new MySqlParameter("@titulo", financas.Titulo));
                this.cmd.Parameters.Add(new MySqlParameter("@valor", financas.Valor));
                this.cmd.Parameters.Add(new MySqlParameter("@descricao", financas.Descricao));
                this.cmd.Parameters.Add(new MySqlParameter("@data_lancamento", financas.Data_lancamento));
                this.cmd.Parameters.Add(new MySqlParameter("@tipo_fluxo", financas.Tipo_fluxo));

                this.conn.Open();
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Inserir Atividade");
            }
            finally
            {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void atualizarFluxo(Financas financas)
        {
            try
            {
                this.cmd = new MySqlCommand(UPDATE_FLUXO, this.conn);

                this.cmd.Parameters.Add(new MySqlParameter("@id", financas.Id));
                this.cmd.Parameters.Add(new MySqlParameter("@titulo", financas.Titulo));
                this.cmd.Parameters.Add(new MySqlParameter("@valor", financas.Valor));
                this.cmd.Parameters.Add(new MySqlParameter("@descricao", financas.Descricao));
                this.cmd.Parameters.Add(new MySqlParameter("@data_lancamento", financas.Data_lancamento));
                this.cmd.Parameters.Add(new MySqlParameter("@tipo_fluxo", financas.Tipo_fluxo));

                this.conn.Open();
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao Atualizar Atividade");
            }
            finally
            {
                ConnectDAO.CloseConnection(this.conn);
            }

        }

        public void deletarFluxo(int id)
        {
            try
            {
                this.cmd = new MySqlCommand(DELETE_FLUXO, this.conn);
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

        public List<Financas> pesquisaFluxosData(DateTime data)
        {
            List<Financas> lista = new List<Financas>();

            try
            {
                this.cmd = new MySqlCommand(SELECT_FLUXO_DATA, this.conn);
                this.cmd.Parameters.Add(new MySqlParameter("@data", data));

                this.conn.Open();
                this.dtReader = this.cmd.ExecuteReader();

                if (this.dtReader.HasRows)
                {
                    while (this.dtReader.Read())
                    {
                        lista.Add(populaFinanca(this.dtReader));
                    }
                }

            }
            catch (Exception)
            {
                throw new Exception("Erro ao carregar Dados");
            }
            finally
            {
                this.dtReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return lista;
        }

        public List<Financas> pesquisaFluxosSemana(DateTime data)
        {
            List<Financas> lista = new List<Financas>();

            try
            {
                this.cmd = new MySqlCommand(SELECT_FLUXO_DATA, this.conn);
                this.cmd.Parameters.Add(new MySqlParameter("@data", data));

                this.conn.Open();
                this.dtReader = this.cmd.ExecuteReader();

                if (this.dtReader.HasRows)
                {
                    while (this.dtReader.Read())
                    {
                        lista.Add(populaFinanca(this.dtReader));
                    }
                }

            }
            catch (Exception)
            {
                throw new Exception("Erro ao carregar Dados");
            }
            finally
            {
                this.dtReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return lista;
        }

        public List<Financas> pesquisaFluxosTipo(String tipo)
        {
            List<Financas> lista = new List<Financas>();

            try
            {
                this.cmd = new MySqlCommand(SELECT_FLUXO_TIPO, this.conn);
                this.cmd.Parameters.Add(new MySqlParameter("@tipo", tipo));

                this.conn.Open();
                this.dtReader = this.cmd.ExecuteReader();

                if (this.dtReader.HasRows)
                {
                    while (this.dtReader.Read())
                    {
                        lista.Add(populaFinanca(this.dtReader));
                    }
                }

            }
            catch (Exception)
            {
                throw new Exception("Erro ao carregar Dados");
            }
            finally
            {
                this.dtReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return lista;
        }

        public List<Financas> pesquisaFluxosTipoData(String tipo, DateTime data)
        {
            List<Financas> lista = new List<Financas>();

            try
            {
                this.cmd = new MySqlCommand(SELECT_FLUXO_TIPO_DATA, this.conn);

                this.cmd.Parameters.Add(new MySqlParameter("@tipo", tipo));
                this.cmd.Parameters.Add(new MySqlParameter("@data", data));

                this.conn.Open();
                this.dtReader = this.cmd.ExecuteReader();

                if (this.dtReader.HasRows)
                {
                    while (this.dtReader.Read())
                    {
                        lista.Add(populaFinanca(this.dtReader));
                    }
                }

            }
            catch (Exception)
            {
                throw new Exception("Erro ao carregar Dados");
            }
            finally
            {
                this.dtReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return lista;
        }

        public List<Financas> pesquisaFluxosTipoDataPeriodo(String tipo, DateTime data1, DateTime data2)
        {
            List<Financas> lista = new List<Financas>();

            try
            {
                this.cmd = new MySqlCommand(SELECT_FLUXO_TIPO_DATA_PERIODO, this.conn);

                this.cmd.Parameters.Add(new MySqlParameter("@tipo", tipo));
                this.cmd.Parameters.Add(new MySqlParameter("@data1", data1));
                this.cmd.Parameters.Add(new MySqlParameter("@data2", data2));

                this.conn.Open();
                this.dtReader = this.cmd.ExecuteReader();

                if (this.dtReader.HasRows)
                {
                    while (this.dtReader.Read())
                    {
                        lista.Add(populaFinanca(this.dtReader));
                    }
                }

            }
            catch (Exception)
            {
                throw new Exception("Erro ao carregar Dados");
            }
            finally
            {
                this.dtReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return lista;
        }

       

        public Financas pesquisaFinancasId(int id)
        {
            Financas financas = new Financas();

            try
            {
                this.cmd = new MySqlCommand(SELECT_FLUXO_ID, this.conn);

                this.cmd.Parameters.Add(new MySqlParameter("@id", id));

                this.conn.Open();
                this.dtReader = this.cmd.ExecuteReader();

                if (this.dtReader.HasRows)
                {
                    while (this.dtReader.Read())
                    {
                        financas = populaFinanca(this.dtReader);
                    }
                }
                else
                {
                    throw new Exception("Id Não Cadastrado");
                }

            }
            catch (Exception)
            {
                throw new Exception("Erro ao Carregar Dados");
            }
            finally
            {
                ConnectDAO.CloseConnection(conn);
            }

            return financas;
        }

        private Financas populaFinanca(MySqlDataReader dtReader)
        {
            Financas dado = new Financas
            {
                Id = int.Parse(dtReader["id"].ToString()),
                Titulo = dtReader["titulo"].ToString(),
                Valor = double.Parse(dtReader["valor"].ToString()),
                Descricao = dtReader["descricao"].ToString(),
                Data_lancamento = DateTime.Parse(dtReader["data_lancamento"].ToString()),
                Tipo_fluxo = dtReader["tipo_fluxo"].ToString(),
            };

            return dado;
        }


        public  double  lucroProcedure()
        {
            
            try
            {
                cmd = new MySqlCommand("lucro", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                cmd.BeginExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao exibir lucro" +"" +e);
            }
            finally
            {

                ConnectDAO.CloseConnection(conn);
            }
            return lucroProcedure();

        }
        }
    }





































































