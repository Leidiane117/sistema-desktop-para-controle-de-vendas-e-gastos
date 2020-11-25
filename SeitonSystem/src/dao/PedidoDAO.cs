using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SeitonSystem.src.dto;

namespace SeitonSystem.src.dao {
    class PedidoDAO {
        public const String INSERT_PEDIDO = "INSERT INTO pedido(tipo_pedido, situacao_pedido, tipo_pagamento, data_pagamento, valor_total, " +
        "data_entrega, hora_entrega, cliente_id) VALUES (@tipo, @situacao, @tipo_pag, @data_pag, @valor, @data_ent, @hora_ent, @id_cliente)";

        public const String INSERT_PRODUTO = "INSERT INTO pedido_produto VALUES (@id_produto, @id_pedido, @qtd, @obs)";

        public const String INSERT_ENDERECO = "INSERT INTO endereco(logradouro, numero, bairro, cep, complemento, cidade, uf, pedido_id) " +
        "VALUES (@log, @num, @bairro, @cep, @compl, @cid, @uf, @id_pedido)";

        public const String UPDATE_PEDIDO = "UPDATE pedido SET tipo_pedido = @tipo, situacao_pedido = @situacao, tipo_pagamento = @tipo_pag,  " +
        "data_pagamento = @data_pag, valor_total = @valor, data_entrega = @data_ent, hora_entrega = @hora_ent WHERE id = @id";

        public const String UPDATE_ENDERECO = "UPDATE endereco SET logradouro = @log, numero = @num, bairro = @bairro, cep = @cep, " +
        "complemento = @compl, cidade = @cid, uf = @uf  WHERE id = @id";

        public const String UPDATE_SITUACAO = "UPDATE pedido SET situacao_pedido = @situacao WHERE id = @id";

        public const String SELECT_LAST_ID = "SELECT LAST_INSERT_ID() AS id";

        public const String DELETE_PRODUTO = "DELETE FROM pedido_produto WHERE pedido_id = @pedido_id";
        public const String DELETE_ENDERECO = "DELETE FROM endereco WHERE pedido_id = @pedido_id";

        public const String SELECT_PRODUTO_ID = "SELECT * FROM produto p INNER JOIN pedido_produto pe ON (p.id = pe.produto_id) WHERE pe.produto_id = @id";
        public const String SELECT_ENDERECO_ID = "SELECT * FROM endereco WHERE pedido_id = @id";
        public const String SELECT_PEDIDO_ID = "SELECT * FROM pedido WHERE id = @id";
        public const String SELECT_PEDIDO_DATA = "SELECT * FROM pedido WHERE data_entrega BETWEEN @data AND @data2";

        public const String SELECT_PRODUTO = "SELECT * FROM produto p INNER JOIN pedido_produto pe ON (p.id = pe.produto_id) WHERE pe.pedido_id = @id";

        public const String SELECT_PEDIDO = "SELECT p.id, c.nome, p.tipo_pedido, p.valor_total, p.data_entrega, p.data_pagamento,  " +
        "p.situacao_pedido FROM pedido p INNER JOIN cliente c ON(p.cliente_id = c.id) ORDER BY data_entrega DESC";

        public const String SELECT_PEDIDO_FILTRO = "SELECT p.id, c.nome, p.tipo_pedido, p.valor_total, p.data_entrega, p.data_pagamento,  " +
        "p.situacao_pedido FROM pedido p INNER JOIN cliente c ON(p.cliente_id = c.id) WHERE";

        public const String SELECT_PRODUTO_MAIS_VENDIDO = "SELECT pro.id, pro.nome, sum(pe.quantidade) AS qtd FROM pedido_produto pe " +
        "INNER JOIN produto pro ON(pro.id = pe.produto_id) INNER JOIN pedido p ON(p.id = pe.pedido_id) " +
        "WHERE p.data_entrega BETWEEN @data1 AND @data2 GROUP BY pro.nome, pro.id ORDER BY qtd DESC";

        MySqlConnection conn;
        MySqlCommand command;
        MySqlDataReader dataReader;

        public PedidoDAO() {
            this.conn = ConnectDAO.GetConnection();
        }

        public PedidoDAO(MySqlConnection conexao) {
            this.conn = conexao;
        }

        public void inserirPedido(Pedido pedido, List<ProdutoPesquisa> produtos){
            try {
                int idPedido = 0;

                this.command = new MySqlCommand(INSERT_PEDIDO, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@tipo", pedido.Tipo_pedido));
                this.command.Parameters.Add(new MySqlParameter("@situacao", pedido.Situacao_pedido));
                this.command.Parameters.Add(new MySqlParameter("@tipo_pag", pedido.Tipo_pagamento));
                this.command.Parameters.Add(new MySqlParameter("@data_pag", pedido.Data_pagamento));
                this.command.Parameters.Add(new MySqlParameter("@valor", pedido.Valor_total));
                this.command.Parameters.Add(new MySqlParameter("@data_ent", pedido.Data_entrega));
                this.command.Parameters.Add(new MySqlParameter("@hora_ent", pedido.Hora_entrega));
                this.command.Parameters.Add(new MySqlParameter("@id_cliente", pedido.Id_cliente));

                this.conn.Open();
                this.command.ExecuteNonQuery();

                this.command = new MySqlCommand(SELECT_LAST_ID, this.conn);

                this.dataReader = this.command.ExecuteReader();

                if (this.dataReader.HasRows) {
                    while (this.dataReader.Read()){
                        idPedido = int.Parse(this.dataReader["id"].ToString());
                    }

                    this.dataReader.Close();
                }else {
                    throw new Exception("Erro ao Carregar Dados");
                }

                if (pedido.Tipo_pedido == "Entrega") {
                    inserirEndereco(pedido, idPedido);
                }

                foreach (ProdutoPesquisa p in produtos) {
                    inserirProduto(p, idPedido);
                }

            }catch (Exception e) {
                throw new Exception(e.Message);
            } finally {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void inserirProduto(ProdutoPesquisa produto, int idPedido) {
            try {
                this.command = new MySqlCommand(INSERT_PRODUTO, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@id_produto", produto.Id));
                this.command.Parameters.Add(new MySqlParameter("@id_pedido", idPedido));
                this.command.Parameters.Add(new MySqlParameter("@qtd", produto.Quantidade));
                this.command.Parameters.Add(new MySqlParameter("@obs", produto.Observacao));

                if (this.conn.State != System.Data.ConnectionState.Open) {
                    this.conn.Open();
                }

                this.command.ExecuteNonQuery();

            } catch (Exception){
                throw;
            }finally {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void inserirEndereco(Pedido pedido, int id) {
            try {
                this.command = new MySqlCommand(INSERT_ENDERECO, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@log", pedido.Logradouro));
                this.command.Parameters.Add(new MySqlParameter("@num", pedido.Numero));
                this.command.Parameters.Add(new MySqlParameter("@bairro", pedido.Bairro));
                this.command.Parameters.Add(new MySqlParameter("@cep", pedido.Cep));
                this.command.Parameters.Add(new MySqlParameter("@compl", pedido.Complemento));
                this.command.Parameters.Add(new MySqlParameter("@cid", pedido.Cidade));
                this.command.Parameters.Add(new MySqlParameter("@uf", pedido.Uf));
                this.command.Parameters.Add(new MySqlParameter("@id_pedido", id));

                if (this.conn.State != System.Data.ConnectionState.Open){
                    this.conn.Open();
                }
              
                this.command.ExecuteNonQuery();

            }catch (Exception) {
                throw;
            }finally {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void atualizarSituacao(String situacao, int id) {
            try{
                this.command = new MySqlCommand(UPDATE_SITUACAO, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@situacao", situacao));
                this.command.Parameters.Add(new MySqlParameter("@id", id));
           
                this.conn.Open();
                this.command.ExecuteNonQuery();
            }catch (Exception){
                throw;
            }finally{
                ConnectDAO.CloseConnection(this.conn);
            }
        
        }

        public void atualizarPedido(Pedido pedido, List<ProdutoPesquisa> produtos) {
            try{
                this.command = new MySqlCommand(UPDATE_PEDIDO, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@tipo", pedido.Tipo_pedido));
                this.command.Parameters.Add(new MySqlParameter("@situacao", pedido.Situacao_pedido));
                this.command.Parameters.Add(new MySqlParameter("@tipo_pag", pedido.Tipo_pagamento));
                this.command.Parameters.Add(new MySqlParameter("@data_pag", pedido.Data_pagamento));
                this.command.Parameters.Add(new MySqlParameter("@valor", pedido.Valor_total));
                this.command.Parameters.Add(new MySqlParameter("@data_ent", pedido.Data_entrega));
                this.command.Parameters.Add(new MySqlParameter("@hora_ent", pedido.Hora_entrega));
                this.command.Parameters.Add(new MySqlParameter("@id", pedido.Id_pedido));

                this.conn.Open();
                this.command.ExecuteNonQuery();

                if (pedido.Tipo_pedido == "Entrega") {
                    atualizarEndereco(pedido);
                }

                deletarProduto(pedido.Id_pedido);

                foreach (ProdutoPesquisa p in produtos){
                    inserirProduto(p, pedido.Id_pedido);
                }

            } catch (Exception e){
                throw new Exception(e.Message);
            }finally
            {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void atualizarEndereco(Pedido pedido){
            try{
                this.command = new MySqlCommand(UPDATE_ENDERECO, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@log", pedido.Logradouro));
                this.command.Parameters.Add(new MySqlParameter("@num", pedido.Numero));
                this.command.Parameters.Add(new MySqlParameter("@bairro", pedido.Bairro));
                this.command.Parameters.Add(new MySqlParameter("@cep", pedido.Cep));
                this.command.Parameters.Add(new MySqlParameter("@compl", pedido.Complemento));
                this.command.Parameters.Add(new MySqlParameter("@cid", pedido.Cidade));
                this.command.Parameters.Add(new MySqlParameter("@uf", pedido.Uf));
                this.command.Parameters.Add(new MySqlParameter("@id", pedido.Id_endereco));

                if (this.conn.State != System.Data.ConnectionState.Open){
                    this.conn.Open();
                }

                this.command.ExecuteNonQuery();

            }catch (Exception){
                throw;
            } finally {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void deletarProduto(int idPedido) {
            try {
                this.command = new MySqlCommand(DELETE_PRODUTO, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@pedido_id", idPedido));

                if (this.conn.State != System.Data.ConnectionState.Open){
                    this.conn.Open();
                }

                this.command.ExecuteNonQuery();

            }catch (Exception) {
                throw;
            }finally {
                ConnectDAO.CloseConnection(this.conn);
            }
        }

        public void deletarEndereco(int idPedido) {
            try {
                this.command = new MySqlCommand(DELETE_ENDERECO, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@pedido_id", idPedido));

                this.conn.Open();
                this.command.ExecuteNonQuery();

            }catch (Exception) {
                throw;
            }finally {
                ConnectDAO.CloseConnection(this.conn);
            }
        }
        public Pedido pesquisaPedidoId(int id){
            Pedido pedido = new Pedido();

            try {
                this.command = new MySqlCommand(SELECT_PEDIDO_ID, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@id", id));

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                if (this.dataReader.HasRows){
                    while (this.dataReader.Read()){
                        pedido = populaPedido(this.dataReader);
                    }
                }else {
                    throw new Exception("Id não Cadastrado");
                }

            } catch (Exception){
                throw new Exception("Erro ao Carregar Dados");
            }finally{
                ConnectDAO.CloseConnection(this.conn);
                this.dataReader.Close();
            }

            return pedido;
        }

        public List<Pedido> pesquisaPedidoData(DateTime data, DateTime data2) {
            List<Pedido> lista = new List<Pedido>();

            try {
                this.command = new MySqlCommand(SELECT_PEDIDO_DATA, this.conn);
                this.command.Parameters.Add(new MySqlParameter("@data", data));
                this.command.Parameters.Add(new MySqlParameter("@data2", data2));


                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                if (this.dataReader.HasRows) {
                    while (this.dataReader.Read()){
                        lista.Add(populaPedido(this.dataReader));
                    }
                }

            }catch (Exception){
                throw new Exception("Erro ao carregar Dados");
            }finally {
                this.dataReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return lista;
        }

        public List<ProdutoPesquisa> pesquisaProduto(int id) {
            List<ProdutoPesquisa> produtos = new List<ProdutoPesquisa>();

            try {
                this.command = new MySqlCommand(SELECT_PRODUTO, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@id", id));

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                if (this.dataReader.HasRows) {
                    while (this.dataReader.Read()){
                        produtos.Add(populaProduto(this.dataReader));
                    }
                }else{
                    throw new Exception("Id não Cadastrado");
                }

            }catch (Exception){
                throw new Exception("Erro ao Carregar Dados");
            } finally{
                ConnectDAO.CloseConnection(this.conn);
                this.dataReader.Close();
            }

            return produtos;
        }

        public ProdutoPesquisa pesquisaProdutoId(int id) {
            ProdutoPesquisa produto = new ProdutoPesquisa();

            try {
                this.command = new MySqlCommand(SELECT_PRODUTO_ID, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@id", id));

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                if (this.dataReader.HasRows) {
                    while (this.dataReader.Read()) {
                        produto = populaProduto(this.dataReader);
                    }
                }else {
                    throw new Exception("Id não Cadastrado");
                }

            }catch (Exception) {
                throw new Exception("Erro ao Carregar Dados");
            }finally{
                ConnectDAO.CloseConnection(this.conn);
                this.dataReader.Close();
            }

            return produto;
        }

        public List<ProdutoPesquisa> pesquisaProdutoMaisVendidoData(DateTime data, DateTime data2) {
            List<ProdutoPesquisa> lista = new List<ProdutoPesquisa>();

            try {
                this.command = new MySqlCommand(SELECT_PRODUTO_MAIS_VENDIDO, this.conn);
                this.command.Parameters.Add(new MySqlParameter("@data1", data));
                this.command.Parameters.Add(new MySqlParameter("@data2", data2));

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                if (this.dataReader.HasRows) {
                    while (this.dataReader.Read()) {
                        ProdutoPesquisa p = new ProdutoPesquisa()
                        {
                            Id = int.Parse(dataReader["id"].ToString()),
                            Nome = dataReader["nome"].ToString(),
                            Quantidade = int.Parse(dataReader["qtd"].ToString())
                        };

                        lista.Add(p);
                    }
                }

            }catch (Exception) {
                throw new Exception("Erro ao carregar Dados");
            }finally {
                this.dataReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return lista;
        }

        public Pedido pesquisaEnderecoId(int id) {
            Pedido pedido = new Pedido();

            try {
                this.command = new MySqlCommand(SELECT_ENDERECO_ID, this.conn);

                this.command.Parameters.Add(new MySqlParameter("@id", id));

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                if (this.dataReader.HasRows) {
                    while (this.dataReader.Read()){
                        pedido = populaEndereco(this.dataReader);
                    }
                }else{
                    throw new Exception("Id não Cadastrado");
                }

            }catch (Exception){
                throw new Exception("Erro ao Carregar Dados");
            }finally{
                ConnectDAO.CloseConnection(this.conn);
                this.dataReader.Close();
            }

            return pedido;
        }

        public List<PedidoPesquisa> pesquisaPedido() {
            List<PedidoPesquisa> pedidos = new List<PedidoPesquisa>();
           
            try {
                this.command = new MySqlCommand(SELECT_PEDIDO, this.conn);

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                if (this.dataReader.HasRows) {
                    while (this.dataReader.Read()) {
                        pedidos.Add(populaPedidoPesquisa(this.dataReader));
                    }
                }

            }catch (Exception) {
                throw new Exception("Erro ao Carregar Dados");
            }finally {
                ConnectDAO.CloseConnection(this.conn);
                this.dataReader.Close();
            }

            return pedidos;
        }

        public List<PedidoPesquisa> pesquisaPedidosFiltro(String filtro) {
            List<PedidoPesquisa> pedidos = new List<PedidoPesquisa>();

            try {
                int num;
                string select = SELECT_PEDIDO_FILTRO;

                if (!int.TryParse(filtro, out num)) {
                    select += " nome LIKE @filtro OR situacao_pedido LIKE @filtro2 ORDER BY data_entrega DESC";
                    filtro += "%";
                }else {
                    select += " p.id = @filtro ORDER BY data_entrega DESC";
                }

                this.command = new MySqlCommand(select, this.conn);
                this.command.Parameters.Add(new MySqlParameter("@filtro", filtro));
                this.command.Parameters.Add(new MySqlParameter("@filtro2", filtro));

                this.conn.Open();
                this.dataReader = this.command.ExecuteReader();

                while (this.dataReader.Read()){
                    pedidos.Add(populaPedidoPesquisa(this.dataReader));
                }
            }catch (Exception e) {
                throw new Exception(e.Message);
            }finally {
                this.dataReader.Close();
                ConnectDAO.CloseConnection(this.conn);
            }

            return pedidos;
        }


        private ProdutoPesquisa populaProduto(MySqlDataReader dataReader){
            ProdutoPesquisa produto = new ProdutoPesquisa();

            produto.Id = int.Parse(dataReader["id"].ToString());
            produto.Nome = dataReader["nome"].ToString();
            produto.Preco = double.Parse(dataReader["preco"].ToString());
            produto.Quantidade = int.Parse(dataReader["quantidade"].ToString());
            produto.Observacao = dataReader["observacao"].ToString();

            return produto;
        }

        private Pedido populaPedido(MySqlDataReader dataReader) {
            Pedido pedido = new Pedido();

            pedido.Id_pedido = int.Parse(dataReader["id"].ToString());
            pedido.Tipo_pedido = dataReader["tipo_pedido"].ToString();
            pedido.Situacao_pedido = dataReader["situacao_pedido"].ToString();
            pedido.Tipo_pagamento = dataReader["tipo_pagamento"].ToString();
            pedido.Data_pagamento = dataReader["data_pagamento"].ToString();
            pedido.Valor_total = double.Parse(dataReader["valor_total"].ToString());
            pedido.Data_entrega = dataReader["data_entrega"].ToString();
            pedido.Hora_entrega = dataReader["hora_entrega"].ToString();
            pedido.Id_cliente  = int.Parse(dataReader["cliente_id"].ToString());

            return pedido;
        }

        private PedidoPesquisa populaPedidoPesquisa(MySqlDataReader dataReader) {
            PedidoPesquisa pedido = new PedidoPesquisa();

            pedido.Id = int.Parse(dataReader["id"].ToString());
            pedido.Cliente = dataReader["nome"].ToString();
            pedido.Pedido = dataReader["tipo_pedido"].ToString();
            pedido.Situação = dataReader["situacao_pedido"].ToString();
            pedido.Pagamento = dataReader["data_pagamento"].ToString().Substring(0,10);
            pedido.Total = double.Parse(dataReader["valor_total"].ToString());
            pedido.Entrega = dataReader["data_entrega"].ToString().Substring(0,10);
   
            return pedido;
        }

        private Pedido populaEndereco(MySqlDataReader dataReader){
            Pedido pedido = new Pedido();

            pedido.Logradouro = dataReader["logradouro"].ToString();
            pedido.Numero = int.Parse(dataReader["numero"].ToString());
            pedido.Bairro = dataReader["bairro"].ToString();
            pedido.Cep = dataReader["cep"].ToString();
            pedido.Complemento = dataReader["complemento"].ToString();
            pedido.Cidade = dataReader["cidade"].ToString();
            pedido.Uf = dataReader["uf"].ToString();
            pedido.Id_endereco = int.Parse(dataReader["id"].ToString());

            return pedido;
        }
    }
}   
