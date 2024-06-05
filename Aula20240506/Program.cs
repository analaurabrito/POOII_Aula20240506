using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aula20240506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* PARTE 1 Abrir conexão */
            SqlConnection conexao;
            conexao = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Banco00; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            
            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta!");

                /*
                // PARTE 2 Inserir dados
                var insertCmd = conexao.CreateCommand();
                insertCmd.CommandText = "INSERT INTO Exemplo (Nome, Sobrenome) " +
                    "VALUES (@nome, @sobrenome);";

                var parmNome = new SqlParameter("nome", "Maria");
                var parmSobrenome = new SqlParameter("sobrenome", "Silva");

                insertCmd.Parameters.Add(parmNome);
                insertCmd.Parameters.Add(parmSobrenome);

                insertCmd.ExecuteNonQuery();
                Console.WriteLine("Linha inserida!");
                */

                /* PARTE 3 Buscar dados */

                var selectCmd = conexao.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Exemplo";

                SqlDataReader leitorDados = selectCmd.ExecuteReader();

                while (leitorDados.Read())
                {
                    Console.WriteLine("Nome: " + leitorDados["Nome"] + 
                        " Sobrenome: " + leitorDados["Sobrenome"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO!");
            }
            finally
            {
                conexao.Close();
                Console.WriteLine("Conexão fechada!");
            }
        }
    }
}
