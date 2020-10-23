using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeitonSystem.src.dto;
using SeitonSystem.src.dao;



namespace SeitonSystem.src.controller
{
    public class ProdutoClassController
    {

        ProdutoClassDAO1 produtoDAO;


        public ProdutoClassController()
        {
            try
            {
                produtoDAO = new ProdutoClassDAO1();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void InserirProduto(ProdutoClassPrincipal produto)
        {
            try
            {
                produtoDAO.InserirProduto(produto);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void EditarProduto(ProdutoClassPrincipal produto)
        {
            try
            {
                produtoDAO.EditarProduto(produto);

            }

            catch (Exception)
            {
                throw;

            }

        }

        public ProdutoClassPrincipal PesquisarPId(int id)
        {
            try
            {
                return produtoDAO.PesquisaProdutosId(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

       

        public List<ProdutoClassPrincipal> ListarProdutos1()
        {
            try
            {
                return produtoDAO.ListarProdutos();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<ProdutoClassPrincipal> BuscarProdutosNome(string nome)
        {
            try
            {
                return produtoDAO.BuscarProdutosPorNome(nome);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void RecuperarProduto(int id)
        {
            try
            {
                produtoDAO.RecuperarProduto(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ProdutoClassPrincipal> ListarProdutosDeletados()
        {
            try
            {
                return produtoDAO.ListarProdutoDeletados();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<ProdutoClassPrincipal> BuscarProdutosDeletadosNome(string nome)
        {
            try
            {
                return produtoDAO.BuscarProdutosDeletadosNome(nome);
            }
            catch (Exception)
            {
                throw;
            }
        }



        public void ApagarProduto(int id)
        {
            try
            {
                produtoDAO.ApagarProduto(id);
            }
            catch (Exception)
            {
                throw;
            }

        }

        internal List<ProdutoClassPrincipal> BuscarDeletados(string text)
        {
            throw new NotImplementedException();
        }
    }

}


