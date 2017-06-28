using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.DAL
{
    public class ItemVenda
    {
        private string strCon = Conexao.getConexao();
        
        public List<MODEL.ItemVenda> Select()
        {
            List<MODEL.ItemVenda> lstItem = new List<MODEL.ItemVenda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from itemVenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto itemVenda
                    MODEL.ItemVenda itemVenda = new MODEL.ItemVenda();
                    //carregar dados do objeto -- popular itemVenda
                    itemVenda.idItem = Convert.ToInt32(reader["idItem"]);
                    itemVenda.idProd = Convert.ToInt32(reader["idProd"]);
                    itemVenda.idVenda = Convert.ToInt32(reader["idVenda"]);
                    itemVenda.valor = Convert.ToSingle(reader["valor"]);
                    lstItem.Add(itemVenda);
                }
            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT ItemVenda");
            }
            finally
            {
                conexao.Close();
            }
            return lstItem;
        }

        public List<MODEL.ItemVenda> SelectByVenda(int idVenda)
        {
            List<MODEL.ItemVenda> lstItem = new List<MODEL.ItemVenda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from ItemVenda where idVenda=@idVenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("idVenda", idVenda);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto itemVenda
                    MODEL.ItemVenda itemVenda = new MODEL.ItemVenda();
                    //carregar dados do objeto -- popular itemVenda
                    itemVenda.idItem = Convert.ToInt32(reader["idItem"]);
                    itemVenda.idProd = Convert.ToInt32(reader["idProd"]);
                    itemVenda.idVenda = Convert.ToInt32(reader["idVenda"]);
                    itemVenda.valor = Convert.ToSingle(reader["valor"]);
                    itemVenda.quantidade = Convert.ToInt16(reader["quantidade"]);
                    lstItem.Add(itemVenda);
                }

            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT ItemVenda BY VENDA");
            }
            finally
            {
                conexao.Close();
            }
            return lstItem;
        }

        public List<MODEL.ItemVenda> SelectById(int idItem)
        {
            List<MODEL.ItemVenda> lstItem = new List<MODEL.ItemVenda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from ItemVenda where idItem=@idItem;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("idItem", idItem);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto itemVenda
                    MODEL.ItemVenda itemVenda = new MODEL.ItemVenda();
                    //carregar dados do objeto -- popular itemVenda
                    itemVenda.idItem = Convert.ToInt32(reader["idItem"]);
                    itemVenda.idProd = Convert.ToInt32(reader["idProd"]);
                    itemVenda.idVenda = Convert.ToInt32(reader["idVenda"]);
                    itemVenda.valor = Convert.ToSingle(reader["valor"]);
                    itemVenda.quantidade = Convert.ToInt16(reader["quantidade"]);
                    lstItem.Add(itemVenda);
                }
                
            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT ItemVenda BY ID");
            }
            finally
            {
                conexao.Close();
            }
            return lstItem;
        }

        public void Insert(MODEL.ItemVenda itemVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into ItemVenda values ";
            sql += " (@idProd , @idVenda , @valor , @quantidade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProd", itemVenda.idProd);
            cmd.Parameters.AddWithValue("@idVenda", itemVenda.idVenda);
            cmd.Parameters.AddWithValue("@valor", itemVenda.valor);
            cmd.Parameters.AddWithValue("@quantidade", itemVenda.quantidade);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - SQL INSERIR ItemVENDA");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.ItemVenda itemVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update ItemVenda set idProd=@idProd , idVenda=@idVenda , valor=@valor , quantidade=@quantidade";
            sql += "where idItem=@idItem;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProd", itemVenda.idProd);
            cmd.Parameters.AddWithValue("@idVenda", itemVenda.idVenda);
            cmd.Parameters.AddWithValue("@valor", itemVenda.valor);
            cmd.Parameters.AddWithValue("@quantidade", itemVenda.quantidade);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - SQL UPDATE ItemVenda");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.ItemVenda itemVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from ItemVenda where idItem=@idItem;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idItem", itemVenda.idItem);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - SQL DELETE ItemVenda");
            }
            finally
            {
                conexao.Close();
            }
        }


    }
}
