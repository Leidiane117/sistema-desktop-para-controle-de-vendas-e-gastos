using System;

namespace SeitonSystem.src.dto
{
    class PedidoPesquisa
    {
        private int id_pedido;
        private String tipo_pedido;
        private String situacao_pedido;
        private String data_pagamento;
        private double valor_total;
        private String data_entrega;
        private String nome_cliente;

        public int Id
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }

        public String Cliente
        {
            get { return this.nome_cliente; }
            set { this.nome_cliente = value; }
        }

        public String Pedido
        {
            get { return this.tipo_pedido; }
            set { this.tipo_pedido = value; }
        }

        public double Total
        {
            get { return this.valor_total; }
            set { this.valor_total = value; }
        }

        public String Pagamento
        {
            get { return this.data_pagamento; }
            set { this.data_pagamento = value; }
        }

        public String Entrega
        {
            get { return this.data_entrega; }
            set { this.data_entrega = value; }
        }

        public String Situação
        {
            get { return this.situacao_pedido; }
            set { this.situacao_pedido = value; }
        }


    }
}
