using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.MODEL
{
    public class Cliente
    {
        public int idCli { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string celular { get; set; }
        public string email { get; set; }


    }
}
