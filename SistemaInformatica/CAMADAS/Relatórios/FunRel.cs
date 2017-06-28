using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemaInformatica.CAMADAS.Relatórios
{
    public class FunRel
    {
        public static string diretorioPasta()
        {
            string folder = @"c:\RelADS";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            return folder;
        }
    }
}
