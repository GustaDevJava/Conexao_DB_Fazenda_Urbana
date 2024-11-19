using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Endereco
    {
        protected int id;
        protected string rua;
        protected string numero;
        protected string complemento;
        protected string cidade;
        protected string estado;
        protected string cep;
        protected int fk_Pessoa_id;


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

        public string Rua
        {
            get
            {
                return rua;
            }
            set
            {
                rua = value;
            }
        }
        public string Numero
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
        public string Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                cidade = value;
            }
        }
        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
        public string Cep
        {
            get
            {
                return cep;
            }
            set
            {
                cep = value;
            }
        }
        public int Fk_Pessoa_id
        {
            get
            {
                return fk_Pessoa_id;
            }
            set
            {
                fk_Pessoa_id = value;
            }
        }

        public string Complemento
        {
            get
            {
                return complemento;
            }
            set
            {
                complemento = value;
            }
        }


    }
}


    

