using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeitonSystem.src.dto;
using SeitonSystem.src.dao;


namespace SeitonSystem.src.controller{
    public class ProdutoController {

        ProdutoDAO produtoDAO;

        public ProdutoController(){
            try{
                this.produtoDAO = new ProdutoDAO();
            } catch (Exception){
                throw;
            }
        }


        public void inserirProduto(Produto produto){
            try {
                this.produtoDAO.inserirProduto(produto);
            }catch (Exception){
                throw;
            }
        }


        public void atualizarProduto(Produto produto){
            try{
                this.produtoDAO.atualizarProduto(produto);
            } catch (Exception){
                throw;
            }

        }

        public Produto pesquisaProdutoId(int id){
            try {
                return this.produtoDAO.pesquisaProdutosId(id);
            }catch (Exception){
                throw;
            }
        }

        public List<Produto> pesquisarProdutos(){
            try{
                return this.produtoDAO.pesquisarProdutos();
            }catch (Exception){
                throw;
            }
        }

        public List<Produto> pesquisaProdutosFitro(string filtro) {
            try {
                if (filtro.Trim() == "" || filtro == null) { 
                    return this.produtoDAO.pesquisarProdutos();
                }else{
                    return this.produtoDAO.pesquisaProdutosFiltro(filtro);
                }
            }catch (Exception){
                throw;
            }
        }

        public void reativarProduto(int id){
            try{
                this.produtoDAO.reativarProduto(id);
            } catch (Exception){
                throw;
            }
        }

        public List<Produto> pesquisaProdutosDesativados(){
            try {
                return this.produtoDAO.pesquisaProdutosDesativados();
            }catch (Exception){
                throw;
            }
        }


        public List<Produto> pesquisaProdutosDesativadosFiltro(string filtro){
            try{
                if (filtro.Trim() == "" || filtro == null){
                    return this.produtoDAO.pesquisaProdutosDesativados();
                }else{
                    return this.produtoDAO.pesquisaProdutosDesativadosFiltro(filtro);
                }
            }catch (Exception){
                throw;
            }
        }

        public void desativarProduto(int id){
            try {
                this.produtoDAO.desativarProduto(id);
            }catch (Exception){
                throw;
            }
        }

    }

}


