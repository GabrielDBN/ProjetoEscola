using Escola.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entities
{
    internal class Matricula
    {
        private int id;
        private int aluno_Id;
        private int turma_Id;


        public int Id { get; set; }
        public int Aluno_Id { get; set; }
        public int Turma_Id { get; set;  }


        public int Insert()
        {
                using (var cn = ConexaoDB.GetConexao())
                {
                    using var cmd = new MySqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "INSERT INTO Matriculas (aluno_id, turma_id) VALUES (@aluno_id, @turma_id)";
                    cmd.Parameters.AddWithValue("@aluno_id", Aluno_Id);
                    cmd.Parameters.AddWithValue("@turma_id", Turma_Id);

                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    string selectQuery = "SELECT LAST_INSERT_ID()";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, cn);
                    int lastInsertedId = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return lastInsertedId;
                }
            
        }
    }
           
}
