using System;

namespace SeitonSystem.src.dto
{
    public class Produto
    {
        private int id;
        private string nome;
        private double preco;
        private string descricao;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public double Preco
        {
            get { return this.preco; }
            set { this.preco = value; }
        }

        public String Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        public override String ToString()
        {
            return this.nome + ", R$" + this.preco + ". " + this.descricao;
        }
    }
}