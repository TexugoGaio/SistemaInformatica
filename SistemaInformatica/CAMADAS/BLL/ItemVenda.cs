using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.BLL
{
    public class ItemVenda
    {
        public List<MODEL.ItemVenda> Select()
        {
            DAL.ItemVenda dalItem = new DAL.ItemVenda();
            //regras negocio
            return dalItem.Select();
        }

        public List<MODEL.ItemVenda> SelectById(int idItem)
        {
            DAL.ItemVenda dalItem = new DAL.ItemVenda();
            //regras negocio
            return dalItem.SelectById(idItem);
        }

        public List<MODEL.ItemVenda> SelectByVenda(int idVenda)
        {
            DAL.ItemVenda dalItem = new DAL.ItemVenda();
            //regras negocio
            return dalItem.SelectById(idVenda);
        }

        public void Insert(MODEL.ItemVenda item)
        {
            DAL.ItemVenda dalItem = new DAL.ItemVenda();
            //regras negocio
            dalItem.Insert(item);
        }

        public void Update(MODEL.ItemVenda item)
        {
            DAL.ItemVenda dalItem = new DAL.ItemVenda();
            //regras negocio
            dalItem.Update(item);
        }

        public void Delete(MODEL.ItemVenda item)
        {
            DAL.ItemVenda dalItem = new DAL.ItemVenda();
            //regras negocio
            dalItem.Delete(item);
        }
    }
}
