using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Funcao
    {
        protected int id;
        protected string funcao;


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



            public string Funcao2
        {
            get
            {
                return funcao;
            }
            set
            {
                funcao = value;
            }
        }
    }
}