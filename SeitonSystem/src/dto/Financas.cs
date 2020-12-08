using System;

namespace SeitonSystem.src.dto
{
    public class Financas
    {
        private int id;
        private string titulo;
        private double valor;
        private string descricao;
        private DateTime data_lancamento;
        private string tipo_fluxo;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Data_lancamento { get => data_lancamento; set => data_lancamento = value; }
        public string Tipo_fluxo { get => tipo_fluxo; set => tipo_fluxo = value; }
    }
}

