using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeitonSystem.src.dao;
using SeitonSystem.src.dto;

namespace SeitonSystem.src.controller {
    class PedidoController {
        PedidoDAO pedidoDAO;

        public PedidoController() {
            try {
                this.pedidoDAO = new PedidoDAO();
            }catch (Exception) {
                throw;
            }
        }

        public void inserirPedido(Pedido pedido, List<ProdutoPesquisa> produtos) {
            try{
                this.pedidoDAO.inserirPedido(pedido, produtos);
            }catch (Exception){
                throw;
            }
        }

        public void inserirEndereco(Pedido pedido, int id) {
            try {
                this.pedidoDAO.inserirEndereco(pedido, id);
            }catch (Exception) {
                throw;
            }
        }

        public void atualizarPedido(Pedido pedido, List<ProdutoPesquisa> produtos){
            try {
                this.pedidoDAO.atualizarPedido(pedido, produtos);
            }catch (Exception) {
                throw;
            }
        }

        public void atualizarSituacao(String situacao, int id) {
            try {
                this.pedidoDAO.atualizarSituacao(situacao, id);
            }catch (Exception){
                throw;
            }
        }

        public void deletarEndereco(int idPedido) {
            try {
                this.pedidoDAO.deletarEndereco(idPedido);
            }catch (Exception) {
                throw;
            }
        }

        public List<PedidoPesquisa> pesquisaPedido(){
            try{
                return this.pedidoDAO.pesquisaPedido();
            }catch (Exception){
                throw;
            }
        }

        public Pedido pesquisaPedidoId(int id){
            try {
                return this.pedidoDAO.pesquisaPedidoId(id);
            }catch (Exception){
                throw;
            }
        }

        public Pedido pesquisaEnderecoId(int id){
            try {
                return this.pedidoDAO.pesquisaEnderecoId(id);
            }catch (Exception){
                throw;
            }
        }

        public ProdutoPesquisa pesquisaProdutoId(int id){
            try {
                return this.pedidoDAO.pesquisaProdutoId(id);
            }catch (Exception) {
                throw;
            }
        }

        public List<ProdutoPesquisa> pesquisaProduto(int id){
            try {
                return this.pedidoDAO.pesquisaProduto(id);
            }catch (Exception){
                throw;
            }
        }

        public List<ProdutoPesquisa> pesquisaProdutoMaisVendidoData(DateTime data1, DateTime data2){
            try{
                return this.pedidoDAO.pesquisaProdutoMaisVendidoData(data1, data2);
            }catch (Exception) {
                throw;
            }
        }

        public List<Pedido> pesquisaPedidoData(DateTime dt, DateTime dt2) {
            try {
                return this.pedidoDAO.pesquisaPedidoData(dt, dt2);
            }catch (Exception) {
                throw;
            }
        }

        public List<PedidoPesquisa> pesquisaPedidoFiltro(String filtro) {
            try {
                if (filtro.Trim() == "" || filtro == null) {
                    return this.pedidoDAO.pesquisaPedido();
                }else {
                    return this.pedidoDAO.pesquisaPedidosFiltro(filtro);
                }
            }catch (Exception){
                throw;
            }
        }
    }
}
