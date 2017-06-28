using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.DAL
{
    public class Produto
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Produto> Select()
        {
            List<MODEL.Produto> lstProduto = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Produto;
                    MODEL.Produto produto = new MODEL.Produto();
                    // carregar os dados no objeto produto -- popular objeto
                    produto.idProd = Convert.ToInt32(reader["idProd"]);
                    produto.descricao = reader["descricao"].ToString();
                    produto.marca = reader["marca"].ToString();
                    produto.valor = Convert.ToSingle(reader["valor"]);
                    produto.estoque = Convert.ToInt32(reader["estoque"]);
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT PRODUTO");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }

        public List<MODEL.Produto> SelectById(int idProd)
        {
            List<MODEL.Produto> lstProduto = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto where idProd=@idProd;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("idProd", idProd);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Produto;
                    MODEL.Produto produto = new MODEL.Produto();
                    // carregar os dados no objeto produto -- popular objeto
                    produto.idProd = Convert.ToInt32(reader["idProd"]);
                    produto.descricao = reader["descricao"].ToString();
                    produto.marca = reader["marca"].ToString();
                    produto.valor = Convert.ToSingle(reader["valor"]);
                    produto.estoque = Convert.ToInt32(reader["estoque"]);
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT PRODUTO BY ID");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }

        public List<MODEL.Produto> SelectByMarca(string marca)
        {
            List<MODEL.Produto> lstProduto = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Produto where (marca like @marca);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@marca", "%" + marca.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Produto;
                    MODEL.Produto produto = new MODEL.Produto();
                    // carregar os dados no objeto produto -- popular objeto
                    produto.idProd = Convert.ToInt32(reader["idProd"]);
                    produto.descricao = reader["descricao"].ToString();
                    produto.marca = reader["marca"].ToString();
                    produto.valor = Convert.ToSingle(reader["valor"]);
                    produto.estoque = Convert.ToInt32(reader["estoque"]);
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT PRODUTO BY MARCA");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }

        public void Insert(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Produto values ";
            sql = sql + " (@descricao ,@marca ,@valor ,@estoque);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            cmd.Parameters.AddWithValue("@estoque", produto.estoque);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - SQL INSERÇÃO DE PRODUTO");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set descricao=@descricao, marca=@marca, valor=@valor, estoque=@estoque ";
            sql += " where idProd=@idProd;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            cmd.Parameters.AddWithValue("@estoque", produto.estoque);
            cmd.Parameters.AddWithValue("@idProd", produto.idProd);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - SQL UPDATE DE PRODUTO");
            }
            finally
            {
                conexao.Close();
            }
            
        }

        public void Delete(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Produto where idProd=@idProd;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("idProd", produto.idProd);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - SQL DELETE PRODUTO");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
