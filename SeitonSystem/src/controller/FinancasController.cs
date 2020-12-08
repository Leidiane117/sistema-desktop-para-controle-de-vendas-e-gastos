using SeitonSystem.src.dao;
using SeitonSystem.src.dto;
using System;
using System.Collections.Generic;

namespace SeitonSystem.src.controller
{
    class FinancasController
    {
        FinancasDAO financasDAO;

        public FinancasController()
        {
            try
            {
                this.financasDAO = new FinancasDAO();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void inserirFluxo(Financas financas)
        {
            try
            {
                this.financasDAO.inserirFluxo(financas);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void atualizarFluxo(Financas financas)
        {
            try
            {
                this.financasDAO.atualizarFluxo(financas);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deletarFluxo(int id)
        {
            try
            {
                this.financasDAO.deletarFluxo(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

      

        public double lucroProcedure()
        {
            try
            {
                return financasDAO.lucroProcedure();
            }
            catch (Exception)
            {
                throw;
            }



        }

        public List<Financas> pesquisaFluxosData(DateTime data)
        {
            try
            {
                return this.financasDAO.pesquisaFluxosData(data);
            }
            catch (Exception)
            {
                throw;
            }
        }

      
        public Financas pesquisaFinancasId(int id)
        {
            try
            {
                return this.financasDAO.pesquisaFinancasId(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Financas> pesquisaFluxosTipo(String tipo)
        {
            try
            {
                return this.financasDAO.pesquisaFluxosTipo(tipo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Financas> pesquisaFluxosTipoData(String tipo, DateTime data)
        {
            try
            {
                return this.financasDAO.pesquisaFluxosTipoData(tipo, data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Financas> pesquisaFluxosTipoDataPeriodo(String tipo, DateTime data1, DateTime data2)
        {
            try
            {
                return this.financasDAO.pesquisaFluxosTipoDataPeriodo(tipo, data1, data2);
            }
            catch (Exception)
            {
                throw;
            }
        }

      
            
        
        }
    }

