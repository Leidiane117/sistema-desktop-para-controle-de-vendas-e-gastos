using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeitonSystem.src.dto {
    public class ProdutoPesquisa {
        private int id;
        private string nome;
        private double preco;

        private int quantidade;
        private string observacao;

        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Nome {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public double Preco {
            get { return this.preco; }
            set { this.preco = value; }
        }
        public int Quantidade {
            get { return this.quantidade; }
            set { this.quantidade = value; }
        }

        public String Observacao {
            get { return this.observacao; }
            set { this.observacao = value; }
        }

    }
}