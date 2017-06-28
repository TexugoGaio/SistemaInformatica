using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.BLL
{
    public class Produto
    {
        public List<MODEL.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();
            //regras de negócio
            return dalProd.Select();
        }

        public List<MODEL.Produto> SelectById(int idProd)
        {
            DAL.Produto dalProd = new DAL.Produto();
            //regras de negocio
            return dalProd.SelectById(idProd);
        }

        public List<MODEL.Produto> SelectByMarca(string marca)
        {
            DAL.Produto dalProd = new DAL.Produto();
            //regras de negocio
            return dalProd.SelectByMarca(marca);
        }

        public void Insert(MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            //regras de negocio
            dalProd.Insert(produto);
        }

        public void Update(MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            //regras de negocio
            dalProd.Update(produto);
        }

        public void Delete(MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            //regras de negocio
            dalProd.Delete(produto);
        }
    }
}
