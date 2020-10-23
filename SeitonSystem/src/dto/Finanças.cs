using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeitonSystem.src.dto
{
    public class Finanças
    {
        int id;
        string titulo;
        double valor;
        string descricao;
        DateTime data_lancamento;
        string tipo_fluxo;
       // int fluxoE = (int)Tipo_Fluxo.Entrada;
        //int fluxoS = (int)Tipo_Fluxo.Saida;

      
       
       
        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Data_lancamento { get => data_lancamento; set => data_lancamento = value; }
        public string Tipo_fluxo { get => tipo_fluxo; set => tipo_fluxo = value; }
       
    }
  }

