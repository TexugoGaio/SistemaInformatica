using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInformatica.CAMADAS.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Cliente> Select() 
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Cliente;";
            SqlCommand cmd = new SqlCommand(sql , conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando o objeto cliente:
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    //carregar os dados no objeto cliente -- popular objeto
                    cliente.idCli = Convert.ToInt32(reader["idCli"]);   
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.celular = reader["celular"].ToString();
                    cliente.email = reader["email"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT CLIENTE.");
            }
            finally
            {
                conexao.Close();
            }

            return lstCliente;
        }

        public List<MODEL.Cliente> SelectById(int idCli)
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Cliente where idCli=@idCli;";
            SqlCommand cmd = new SqlCommand(sql,conexao);
            cmd.Parameters.AddWithValue("@idCli", idCli);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando o objeto cliente 
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    //carregar os dados no objeto cliente
                    cliente.idCli = Convert.ToInt32(reader["idCli"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.celular = reader["celular"].ToString();
                    cliente.email = reader["email"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT CLIENTE BY ID.");
            }
            finally
            {
                conexao.Close();
            }

            return lstCliente;
        }

        public List<MODEL.Cliente> SelectByNome(string nome)
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Cliente where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando o objeto cliente 
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    //carregar os dados no objeto cliente
                    cliente.idCli = Convert.ToInt32(reader["idCli"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.celular = reader["celular"].ToString();
                    cliente.email = reader["email"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("ERRO - SQL SELECT CLIENTE BY NOME.");
            }
            finally
            {
                conexao.Close();
            }

            return lstCliente;
        }
        
        public void Insert(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Cliente values ";
            sql = sql + " (@nome ,@cidade ,@estado ,@celular ,@endereco ,@email);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO NA INSERÇÃO DE CLIENTE.");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Update(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set nome=@nome, cidade=@cidade, estado=@estado, ";
            sql += " celular=@celular, endereco=@endereco, email=@email ";
            sql += " where idCli=@idCli;";  
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            cmd.Parameters.AddWithValue("@idCli", cliente.idCli);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - SQL ATUALIZAÇÃO DE CLIENTE.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cliente where idCli=@idCli;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCli", cliente.idCli);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO - REMOÇÃO DE CLIENTE.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
