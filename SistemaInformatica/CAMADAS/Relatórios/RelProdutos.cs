using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SistemaInformatica.CAMADAS.Relatórios
{
    public class RelProdutos
    {
        public static void impRelProd()
        {
            //carregando dados para impressão - gerar lista de produtos
            List<CAMADAS.MODEL.Produto> lstProd = new List<MODEL.Produto>();
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            lstProd = bllProd.Select();

            //configurando e iniciando relatorio
            string folder = FunRel.diretorioPasta();
            string arquivo = folder + @"\RelProdutos.html";
            using (StreamWriter sw = new StreamWriter(arquivo))
            {   
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(@"<meta http-equive=\Content-type\Content=\'html;charset=utf-8\'>");
                sw.WriteLine("</head");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório de Produtos</h1>");
                sw.WriteLine("<table>");
                //cabeçalho de tabela
                sw.WriteLine("<tr>");
                sw.WriteLine("<th width ='30px' align='right'>ID</th>");
                sw.WriteLine("<th width ='150px' align='left'>DESCRIÇÃO</th>");
                sw.WriteLine("<th width ='200px' align='right'>MARCA</th>");
                sw.WriteLine("<th width ='90px' align='right'>ESTOQUE</th>");
                sw.WriteLine("<th width ='30px' align='center'>VALOR</th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                float soma = 0;
                int estoque;
                //detalhes itens do relatorio
                foreach(CAMADAS.MODEL.Produto produto in lstProd)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width ='30px' align='right'>" + produto.idProd + "</td>");
                    sw.WriteLine("<td width ='150px' align='left'>" + produto.descricao + "</td>");
                    sw.WriteLine("<td width ='200px' align='right'>" + produto.marca + "</td>");
                    sw.WriteLine("<td width ='90px' align='right'>" + produto.estoque + "</td>");
                    sw.WriteLine("<td width ='30px' align='center'>" + produto.valor + "</td>");
                    cont++;
                    estoque = produto.estoque;
                    soma = soma + (produto.valor * estoque);

                }
                //fim da tabela
                sw.WriteLine("</table");
                sw.WriteLine("<hr align='left' width='300px' border='2px'>");
                sw.WriteLine("<h5> Total de Produtos impressos: " + cont + "</h5>");
                sw.WriteLine("<h5> Total da soma do valor: R$ " + soma.ToString("0.00") + "</h5>");

                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
