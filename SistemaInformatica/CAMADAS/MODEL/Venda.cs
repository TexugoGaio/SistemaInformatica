using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.MODEL
{
    public class Venda
    {
        public int idVenda { get; set; }
        public int idCli { get; set; }
        public string nome { get; set; }
        public DateTime dataVenda { get; set; }
        public float total { get; set; }
        
    }
}
