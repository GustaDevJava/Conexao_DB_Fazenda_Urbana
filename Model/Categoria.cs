using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Categoria
    {
        protected int id;
        protected string tipoCategoria;


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
        
        public string TipoCategoria
        {
            get
            {
                return tipoCategoria;
            }
            set
            {
                tipoCategoria = value;
            }
        }

    }
        
}
