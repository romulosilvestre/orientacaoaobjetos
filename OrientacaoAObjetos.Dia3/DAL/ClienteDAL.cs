using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia3.DAL
{
    public class ClienteDAL
    {        
        public void Inserir(Cliente cliente)
        {
            //Conectar
         
            string query = "INSERT INTO Segurado(Nome) VALUES (@Nome)";
            SqlCommand cmd = new SqlCommand(query,Conexao.Conectar());
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.ExecuteNonQuery();
            Conexao.Conectar().Close();                           

          
        }
    }



}
