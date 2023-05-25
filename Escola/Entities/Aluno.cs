using Escola.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entities
{
    internal class Aluno
    {
        private int id;
        private string nome;
        private DateTime dataNascimento;
        private string email; 
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }


        public int SalvarAluno()
        {
                using (var cn = ConexaoDB.GetConexao())
                {
                    using var cmd = new MySqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "INSERT INTO Alunos (nome, dataNascimento, email) VALUES (@nome, @dataNascimento, @email)";
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@dataNascimento", DataNascimento);
                    cmd.Parameters.AddWithValue("@email", Email);

                    cmd.ExecuteNonQuery();
                    string selectQuery = "SELECT LAST_INSERT_ID()";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, cn);
                    int lastInsertedId = Convert.ToInt32(selectCommand.ExecuteScalar());
                    MessageBox.Show("Aluno salvo com sucesso!");
                    return lastInsertedId;

                }
        }
    }
}
