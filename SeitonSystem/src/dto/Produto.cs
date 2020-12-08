using System;

namespace SeitonSystem.src.dto
{
    public class Produto
    {
        private int id;
        private string nome;
        private double preco;
        private string descricao;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public string Descricao { get => descricao; set => descricao = value; }


        public override String ToString()
        {
            return this.nome + ", R$" + this.preco + ". " + this.descricao;
        }
    }
}