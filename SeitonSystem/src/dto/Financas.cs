using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeitonSystem.src.dto {
    public class Financas {
        private int id;
        private String titulo;
        private double valor;
        private String descricao;
        private DateTime data_lancamento;
        private String tipo_fluxo;

        public int Id{
            get { return id; }
            set { id = value; }
        }

        public String Titulo {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public double Valor {
            get { return this.valor; }
            set { this.valor = value; }
        }

        public String Descricao {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        public DateTime Data_lancamento {
            get { return this.data_lancamento; }
            set { this.data_lancamento = value; }
        }

        public String Tipo_fluxo{
            get { return this.tipo_fluxo; }
            set { this.tipo_fluxo = value; }
        }

     }
  }

