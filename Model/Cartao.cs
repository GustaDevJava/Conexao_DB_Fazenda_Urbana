using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Cartao
    {
        protected int id;
        protected string nome;
        protected int numero;
        protected int cvv;
        protected string apelido;
        protected int fk_Client_fk_Pessoa_id;
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


        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {

                nome = value;

            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
        public int Cvv
        {
            get
            {
                return cvv;
            }
            set
            {
                cvv = value;
            }
        }
        public int Fk_Client_fk_Pessoa_id
        {
            get
            {
                return fk_Client_fk_Pessoa_id;
            }
            set
            {
                fk_Client_fk_Pessoa_id = value;
            }
        }
        public string Apelido
        {
            get
            {
                return apelido;
            }
            set
            {
                apelido = value;
            }
        }
    }
}
