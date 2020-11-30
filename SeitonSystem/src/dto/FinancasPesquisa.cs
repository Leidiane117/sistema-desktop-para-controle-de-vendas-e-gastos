using System;

namespace SeitonSystem.src.dto
{
    class FinancasPesquisa
    {
        private int id;
        private String titulo;
        private double valor;
        private DateTime data_lancamento;
        private String fluxo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Identificacao
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public double Total
        {
            get { return this.valor; }
            set { this.valor = value; }
        }

        public DateTime Lancamento
        {
            get { return this.data_lancamento; }
            set { this.data_lancamento = value; }
        }

        public String Fluxo
        {
            get { return this.fluxo; }
            set { this.fluxo = value; }
        }

    }
}
