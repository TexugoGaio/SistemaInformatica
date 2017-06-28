using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.MODEL
{
    public class Produto
    {
        public int idProd { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
        public float valor { get; set; }
        public int estoque { get; set; }

    }
}
