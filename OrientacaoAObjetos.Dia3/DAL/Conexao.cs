using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia3.DAL
{
    public class Conexao
    {
        static string connectionString = "Data Source=LAB-F08-13;Initial Catalog=Servicos;Integrated Security = True;";
        
        public static SqlConnection Conectar()
        {
             
            //connectionString = @"Server=LAB-F08-13;Database=Servicos;Uid=sa;Pwd=senai@123;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }


    }
}
