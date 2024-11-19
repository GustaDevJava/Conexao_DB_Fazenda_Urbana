using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }
        public double Desconto { get; set; } = 0.0;
        public string Imagem { get; set; }
        public int Quantidade { get; set; }

    }
}


