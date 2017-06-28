using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SistemaInformatica.CAMADAS.Relatórios
{
    public class RelClientes
    {
        public static void impRelCli()
        {
            //carregando dados para impressão - gerar lista de clientes
            List<CAMADAS.MODEL.Cliente> lstCli = new List<MODEL.Cliente>();
            CAMADAS.BLL.Cliente bllCli = new BLL.Cliente();
            lstCli = bllCli.Select();

            //configurando e iniciando relatorio
            string folder = FunRel.diretorioPasta();
            string arquivo = folder + @"\RelClientes.html";
            using(StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(@"<meta http-equive=\Content-type\Content=\'html;charset=utf-8\'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatorio de Clientes</h1>");
                sw.WriteLine("<table>");
                //cabeçalho da tabela
                sw.WriteLine("<tr>");
                sw.WriteLine("<th width ='30px' align='right'>ID</th>");
                sw.WriteLine("<th width ='150px' align='left'>NOME</th>");
                sw.WriteLine("<th width ='200px' align='right'>CIDADE</th>");
                sw.WriteLine("<th width ='300px' align='right'>ESTADO</th>");
                sw.WriteLine("<th width ='90px' align='right'>CELULAR</th>");
                sw.WriteLine("<th width ='30px' align='center'>EMAIL</th>");
                sw.WriteLine("</tr>");

                //DETALHES DO RELATORIO
                foreach(CAMADAS.MODEL.Cliente cliente in lstCli)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width ='30px' align='right'>" + cliente.idCli + "</td>");
                    sw.WriteLine("<td width ='150px' align='left'>" + cliente.nome + "</td>");
                    sw.WriteLine("<td width ='200px' align='right'>" + cliente.cidade + "</td>");
                    sw.WriteLine("<td width ='300px' align='right'>" + cliente.estado + "</td>");
                    sw.WriteLine("<td width ='90px' align='right'>" + cliente.celular + "</td>");
                    sw.WriteLine("<td width ='30px' align='center'>" + cliente.email + "</td>");
                }
                //fim tabela
                sw.WriteLine("</table>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
