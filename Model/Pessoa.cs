using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        protected int id;
        protected string nome;
        protected string cpf;
        protected string cnpj;
        protected DateTime dataNascimento;
        protected string celular;
        protected string email;
        protected string senha;
        protected Endereco endereco;
        
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
        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }
        public string Cnpj
        {
            get
            {
                return cnpj;
            }
            set
            {
                cnpj = value;
            }

        }
        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }
            set
            {
                dataNascimento = value;
            }
        }
        public string Celular
        {
            get
            {
                return celular;
            }
            set
            {
                celular = value;
            }
        }
        public string Email
        {
            get
            {
                return email;

            }
            set
            {
                email = value;
            }
        }
        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }

        public Endereco Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }
    }
}
