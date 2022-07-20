using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TesteReturnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] row = new string[3];

            string[] testeRetorno()
            {
                MySqlConnection conexao;
                MySqlDataReader dr;

                try
                {
                    string data_source = "server=localhost;Port=3307;database=db_napolitana;Uid=root;Pwd=bibi2835201819";
                    conexao = new MySqlConnection(data_source);

                    string sql = $"SELECT * FROM Funcionario WHERE username = 'GabOliveira' AND senha = sha1(123456)";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    conexao.Open();

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        row[0] = dr.GetString(0);
                        row[1] = dr.GetString(1);
                        row[2] = dr.GetString(2);
                    }

                    return row;
                }
                catch (MySqlException err)
                {
                    Console.WriteLine(err.Message);
                    return row;
                }
            }

            string[] dados = testeRetorno();
            if(dados[0] == null)
            {
                Console.WriteLine("Usuário não existe!");
            } else
            {
                Console.WriteLine("");

                foreach (string i in dados)
                {
                    Console.WriteLine($"{i}");
                }
            }

            Console.ReadKey();
        }
    }
}
