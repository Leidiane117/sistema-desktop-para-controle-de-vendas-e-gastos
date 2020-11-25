using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeitonSystem.src.dto {
    class Pedido : Endereco  {
        private int id_pedido;
        private String tipo_pedido;
        private String situacao_pedido;
        private String tipo_pagamento;
        private String data_pagamento;
        private double valor_total;
        private String data_entrega;
        private String hora_entrega;
        private int id_cliente;
        private String nome_cliente;

        public int Id_pedido {
            get { return id_pedido; }
            set { id_pedido = value; }
        }

        public String Tipo_pedido {
            get { return this.tipo_pedido; }
            set { this.tipo_pedido = value; }
        }

        public String Situacao_pedido {
            get { return this.situacao_pedido; }
            set { this.situacao_pedido = value; }
        }

        public String Tipo_pagamento {
            get { return this.tipo_pagamento; }
            set { this.tipo_pagamento = value; }
        }

        public String Data_pagamento {
            get { return this.data_pagamento; }
            set { this.data_pagamento = value; }
        }

        public double Valor_total {
            get { return this.valor_total; }
            set { this.valor_total = value; }
        }

        public String Data_entrega {
            get { return this.data_entrega; }
            set { this.data_entrega = value; }
        }

        public String Hora_entrega  {
            get { return this.hora_entrega; }
            set { this.hora_entrega = value; }
        }

        public int Id_cliente {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        public String Nome_cliente {
            get { return this.nome_cliente; }
            set { this.nome_cliente = value; }
        }
    }
}
