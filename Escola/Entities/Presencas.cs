using Escola.DB;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entities
{
    internal class Presencas
    {
        private int id;
        private int aluno_Id;
        private int disciplina_Id;
        private DateTime dia;
        private int faltou;

        public int Id { get; set; }
        public int Aluno_Id { get; set; }
        public int Disciplina_Id { get; set; }
        public DateTime Dia { get; set; }
        public int Faltou { get; set; }

        public int Insert()
        {
                using (var cn = ConexaoDB.GetConexao())
                {
                    using var cmd = new MySqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "INSERT INTO Presencas (aluno_id, disciplina_id, data, faltou) VALUES (@aluno_id, @disciplina_id, @data, @faltou)";
                    cmd.Parameters.AddWithValue("@aluno_id", Aluno_Id);
                    cmd.Parameters.AddWithValue("@disciplina_id", Disciplina_Id);
                    cmd.Parameters.AddWithValue("@data", Dia);
                    cmd.Parameters.AddWithValue("@faltou", Faltou);

                    cmd.ExecuteNonQuery();
                    string selectQuery = "SELECT LAST_INSERT_ID()";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, cn);
                    int lastInsertedId = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return lastInsertedId;

                }
        }

        public List<Presencas> SelectByAlunoAndDisciplina(int idAluno, int idDisciplina)
        {
            List<Presencas> list = new List<Presencas>();
            using (var cn = ConexaoDB.GetConexao())
            {
                using var cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT * FROM Presencas WHERE aluno_id=@aluno_id AND disciplina_id=@disciplina_id";
                cmd.Parameters.AddWithValue("@aluno_id", idAluno);
                cmd.Parameters.AddWithValue("@disciplina_id", idDisciplina);

                
                using (var reader = cmd.ExecuteReader()) { 
                   while (reader.Read())
                    {
                        var presenca = new Presencas 
                        {
                            Id = reader.GetInt32(0),
                            Aluno_Id = reader.GetInt32(1),
                            Disciplina_Id = reader.GetInt32(2),
                            Dia = reader.GetDateTime(3),
                            Faltou = reader.GetInt32(4)
                        };
                        list.Add(presenca);
                    }
                }
            }
            return list;
        }

        
        public static Presencas FindByPresencaId(int presenca_id)
        {
            Presencas presencas = null;
            using (var cn = ConexaoDB.GetConexao())
            {
                using var cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT * FROM Presencas WHERE id=@presenca_id";
                cmd.Parameters.AddWithValue("@presenca_id", presenca_id);

                
                using (var reader = cmd.ExecuteReader()) { 
                   if (reader.Read())
                    {
                        presencas = new Presencas 
                        {
                            Id = reader.GetInt32(0),
                            Aluno_Id = reader.GetInt32(1),
                            Disciplina_Id = reader.GetInt32(2),
                            Dia = reader.GetDateTime(3),
                            Faltou = reader.GetInt32(4)
                        };
                    }
                }
            }
            return presencas;
        }

        public void UpdatePresenca(Presencas presencas)
        {
            Presencas old = Presencas.FindByPresencaId(presencas.Id);
            if(presencas.Faltou != old.Faltou)
            {
                using (var cn = ConexaoDB.GetConexao())
                {
                    using var cmd = new MySqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "UPDATE Presencas SET faltou = @presenca_faltou WHERE id = @id";
                    cmd.Parameters.AddWithValue("@presenca_faltou", presencas.Faltou);
                    cmd.Parameters.AddWithValue("@id", presencas.Id);
                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    MessageBox.Show("Presença atualizada");
                }
            }
        }
    }
}
