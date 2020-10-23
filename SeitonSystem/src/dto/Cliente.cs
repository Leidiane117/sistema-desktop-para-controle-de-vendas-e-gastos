using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeitonSystem.src.dto {
    class Cliente {
        private int id;
        private String nome;
        private String telefone;
        private String celular;
        private String instagram;
        private String email;

        public int Id{
            get { return id; }
            set { id = value; }
        }

        public String Nome {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public String Telefone{
            get { return this.telefone; }
            set { this.telefone = value; }
        }

        public String Celular {
            get { return this.celular; }
            set { this.celular = value; }
        }

        public String Instagram {
            get { return this.instagram; }
            set { this.instagram = value; }
        }

        public String Email{
            get { return this.email; }
            set { this.email = value; }
        }
    }
}
