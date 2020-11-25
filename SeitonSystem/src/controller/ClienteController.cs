using SeitonSystem.src.dao;
using SeitonSystem.src.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeitonSystem.src.controller {
    class ClienteController {
        ClienteDAO clienteDAO;

        public ClienteController(){
            try {
                this.clienteDAO = new ClienteDAO();
            } catch (Exception){
                throw;
            }
        }

        public void inserirCliente(Cliente cliente) {
            try {
                this.clienteDAO.inserirCliente(cliente);
            }catch (Exception) {
                throw;
            }
        }

        public void atualizarCliente(Cliente cliente) {
            try {
                this.clienteDAO.atualizarCliente(cliente);
            } catch (Exception){
                throw;
            }        
        }

        public void desativarCliente(int id) {
            try {
                this.clienteDAO.desativarCliente(id);
            } catch (Exception){
                throw;
            }

        }

        public void reativarCliente(int id){
            try {
                this.clienteDAO.reativarCliente(id);
            } catch (Exception){
                throw;
            }
        }

        public List<Cliente> pesquisaClientes(){
            try {
                return this.clienteDAO.pesquisaClientes();
            } catch (Exception) {
                throw;
            }
        }

        public List<Cliente> pesquisaClientesDesativados(){
            try {
                return this.clienteDAO.pesquisaClientesDesativados();
            } catch (Exception) {
                throw;
            }
        }

        public Cliente pesquisaClienteId(int id) {
            try {
               return this.clienteDAO.pesquisaClienteId(id);
            } catch (Exception){
                throw;
            }
        }

        public List<Cliente> pesquisaClientesFiltro(String filtro) {
            try {
                if(filtro.Trim() == "" || filtro == null) {
                    return this.clienteDAO.pesquisaClientes();
                }else {
                    return this.clienteDAO.pesquisaClientesFiltro(filtro);
                }
            } catch (Exception) {
                throw;
            }
        }

        public List<Cliente> pesquisaClientesDesativadosFiltro(String filtro) {
            try {
                if (filtro.Trim() == "" || filtro == null) {
                    return this.clienteDAO.pesquisaClientesDesativados();
                }else {
                    return this.clienteDAO.pesquisaClientesDesativadosFiltro(filtro);
                }
            }
            catch (Exception) {
                throw;
            }
        }

    }
}
