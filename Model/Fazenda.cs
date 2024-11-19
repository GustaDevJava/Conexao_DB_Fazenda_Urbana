using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Fazenda
    {
        protected int id;
        protected string filial;

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
        public string Filial
        {
            get
            {
                return filial;
            }
            set
            {
                filial = value;
            }
        }
        
    }
}
