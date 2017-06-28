using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.MODEL
{
    public class ItemVenda
    {
        public int idItem { get; set; }
        public int idProd { get; set; }
        public int idVenda { get; set; }
        public float valor { get; set; }
        public int quantidade { get; set; }

    }
}
