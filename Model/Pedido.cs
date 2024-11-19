using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Pedido
    {
        //Atributos
        protected int id;
        protected string clienteId;
        protected string produtoId;
        protected string desconto;
        protected double total;
        protected string cupom;
        protected int fk_Cliente_fk_Pessoa_id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string ClienteId
        {
            get
            {
                return clienteId;
            }

            set
            {
                clienteId = value;
            }
        }

        public string ProdutoId
        {
            get
            {
                return produtoId;
            }

            set
            {
                produtoId = value;
            }
        }

        public string Desconto
        {
            get
            {
                return desconto;
            }

            set
            {
                desconto = value;
            }
        }

        public double Total

        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public string Cupom
        {
            get
            {
                return cupom;
            }

            set
            {
                cupom = value;
            }
        }
            public int Fk_Cliente_fk_Pessoa_id
        {
            get
            {
                return fk_Cliente_fk_Pessoa_id;
            }
            set
            {
                fk_Cliente_fk_Pessoa_id = value;
            }
        }


        //Métodos

    }
}

    

