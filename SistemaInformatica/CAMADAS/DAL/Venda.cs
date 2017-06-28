using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.DAL
{
    public class Venda 
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Venda> Select()
        {
            List<MODEL.Venda> lstVenda = new List<MODEL.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Venda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Venda
                    MODEL.Venda venda = new MODEL.Venda();
                    //carregar os dados no objeto -- popular objeto
                    venda.idVenda = Convert.ToInt32(reader["idVenda"]);
                    venda.idCli = Convert.ToInt32(reader["idCli"]);
                    venda.nome = reader["nome"].ToString();
                    venda.dataVenda = Convert.ToDateTime(reader["dataVenda"]);
                    venda.total = Convert.ToSingle(reader["total"]);
                    lstVenda.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT VENDA");
            }
            finally
            {
                conexao.Close();
            }
            return lstVenda;
        }

        public List<MODEL.Venda> SelectByIdVenda(int idVenda)
        {
            List<MODEL.Venda> lstVenda = new List<MODEL.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Venda where idVenda=@idVenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idVenda", idVenda);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Venda
                    MODEL.Venda venda = new MODEL.Venda();
                    //carregar os dados no objeto -- popular objeto
                    venda.idVenda = Convert.ToInt32(reader["idVenda"]);
                    venda.idCli = Convert.ToInt32(reader["idCli"]);
                    venda.dataVenda = Convert.ToDateTime(reader["dataVenda"]);
                    venda.total = Convert.ToSingle(reader["total"]);
                    lstVenda.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT VENDA ByIdVenda ");
            }
            finally
            {
                conexao.Close();
            }
            return lstVenda;
        }

        public List<MODEL.Venda> SelectByIdCliente(int idCli)
        {
            List<MODEL.Venda> lstVenda = new List<MODEL.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Venda where idCli=@idCli;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("idCli", idCli);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Venda
                    MODEL.Venda venda = new MODEL.Venda();
                    //carregar os dados no objeto -- popular objeto
                    venda.idVenda = Convert.ToInt32(reader["idVenda"]);
                    venda.idCli = Convert.ToInt32(reader["idCli"]);
                    venda.dataVenda = Convert.ToDateTime(reader["dataVenda"]);
                    venda.total = Convert.ToSingle(reader["total"]);
                    lstVenda.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT VENDA BY IdCliente");
            }
            finally
            {
                conexao.Close();
            }
            return lstVenda;
        }

        public void Insert(MODEL.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Venda values ";
            sql += " (@dataVenda ,@idCli ,@total);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@dataVenda", venda.idCli);
            cmd.Parameters.AddWithValue("@idCli", venda.dataVenda);
            cmd.Parameters.AddWithValue("@total", venda.total);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - INSERÇÃO DE VENDA");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void UpdateTotal(MODEL.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Venda set total=@total where idVenda=@idVenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("total", venda.total);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - INSERÇÃO DE VENDATOTAL");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Venda set idCli=@idCli, dataVenda=@dataVenda, total=@total where idVenda=@idVenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCli", venda.idCli);
            cmd.Parameters.AddWithValue("@dataVenda", venda.dataVenda);
            cmd.Parameters.AddWithValue("total", venda.total);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - SQL UPDATE VENDA");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Venda where idVenda=@idVenda;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idVenda", venda.idVenda);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - SQL DELETE VENDA");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
