using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeitonSystem.src.dto {
    class Endereco {
        private int id_endereco;
        private String logradouro;
        private int numero;
        private String bairro;
        private String cep;
        private String complemento;
        private String cidade;
        private String uf;

        public int Id_endereco {
            get { return this.id_endereco; }
            set { this.id_endereco = value; }
        }

        public String Logradouro {
            get { return this.logradouro; }
            set { this.logradouro = value; }
        }

        public int Numero {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public String Bairro {
            get { return this.bairro; }
            set { this.bairro = value; }
        }

        public String Cep {
            get { return this.cep; }
            set { this.cep = value; }
        }

        public String Complemento {
            get { return this.complemento; }
            set { this.complemento = value; }
        }

        public String Cidade {
            get { return this.cidade; }
            set { this.cidade = value; }
        }

        public String Uf {
            get { return this.uf; }
            set { this.uf = value; }
        }

    }
}
