using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.BLL
{
    public class Venda
    {
        public List<MODEL.Venda> Select()
        {
            DAL.Venda dalVenda = new DAL.Venda();
            //regras negocio
            return dalVenda.Select();
        }

        public List<MODEL.Venda> SelectByIdVenda(int idVenda)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            //regras negocio
            return dalVenda.SelectByIdVenda(idVenda);
        }

        public List<MODEL.Venda> SelectByIdCliente(int idCli)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            //regras negocio
            return dalVenda.SelectByIdCliente(idCli);
        }

        public void Insert(MODEL.Venda venda)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            //regras negocio
            dalVenda.Insert(venda);
        }

        public void Update(MODEL.Venda venda)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            //regras negocio
            dalVenda.Update(venda);
        }

        public void Delete(MODEL.Venda venda)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            //regras negocio
            dalVenda.Delete(venda);
        }
    }
}
