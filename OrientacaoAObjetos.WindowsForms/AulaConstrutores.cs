using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrientacaoAObjetos.Dia2;
//PASSO 1
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace OrientacaoAObjetos.WindowsForms
{
    public partial class AulaConstrutores : Form
    {
        string connectionString = @"Server=LAB-F08-13;Database=Servicos;User Id=sa;Password=senai@123;TrustServerCertificate=False";
       
        public AulaConstrutores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Objeto
      
            //Passo 2 - Connection String
            

            //Passo 3
         /*   using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                Inserir(segurado);

                connection.Close();
            }
         */

        }

        public void Inserir(Segurado segurado)
        {
            string sql = "INSERT INTO Segurado (Nome) VALUES (@Nome)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Adicione os parâmetros e defina seus valores
                    command.Parameters.AddWithValue("@Nome", segurado.Nome);
                

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inserção bem-sucedida!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma linha afetada.");
                    }
                }
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
     
        }

        private void button5_Click(object sender, EventArgs e)
        {
      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new RevisaoConstrutores().Show();
        }
    }
}
