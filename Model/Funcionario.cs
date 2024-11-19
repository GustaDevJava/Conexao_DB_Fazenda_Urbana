using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Funcionario : Pessoa
    {
        protected double salario;
        protected string funcao;
        protected int fazendaId;
        protected string nomeGerente;
        protected DateTime dataAdmissao = DateTime.Now;
        protected string imagem;

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        } 
        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }

        public int FazendaId
        {
            get { return fazendaId;}
            set { fazendaId = value; }
        }
        public string NomeGerente
        {
            get
            {
                return nomeGerente;
            }
            set 
            { 
                nomeGerente = value; 
            }
        }
        public DateTime DataAdmissao
        {
            get
            {
                return dataAdmissao;
            }
        }
        public string Imagem
        {
            get
            { 
                return imagem;
            }
            set 
            { 
                imagem = value;
            }
        }
    }
}
