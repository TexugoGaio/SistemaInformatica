using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.BLL
{
    public class Cliente
    {
        public List<MODEL.Cliente> Select()
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras negocio
            return dalCli.Select();
        }

        public List<MODEL.Cliente> SelectById(int idCli)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras negocio
            return dalCli.SelectById(idCli);
        }

        public List<MODEL.Cliente> SelectByNome(string nome)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras negocio
            return dalCli.SelectByNome(nome);
        }

        public void Insert(MODEL.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras negocio
            dalCli.Insert(cliente);
        }

        public void Update(MODEL.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras negocio
            dalCli.Update(cliente);
        }

        public void Delete(MODEL.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            dalCli.Delete(cliente);
        }
    }
}
