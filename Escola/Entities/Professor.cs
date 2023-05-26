using Escola.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Escola.Entities
{
    internal class Professor
    {
        private int id;
        private string nome;
        private int usuario_id;
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Usuario_id { get; set; }


        public void Insert()
        {
            try
            {
                using (var cn = ConexaoDB.GetConexao())
                {
                    using var cmd = new MySqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "INSERT INTO Professores (nome, usuario_id) VALUES (@nome, @usuario_id)";
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@usuario_id", Usuario_id);
                    int linhasAfetadas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public List<Professor> ListAll()
        {
            List<Professor> list = new List<Professor>();
            using (var cn = ConexaoDB.GetConexao())
            {
                using var cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT * FROM Professores";
                
                using (var reader = cmd.ExecuteReader()) { 
                   while (reader.Read())
                    {
                        var professor = new Professor 
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Usuario_id = reader.GetInt32(2)
                        };
                        list.Add(professor);
                    }
                }
            }
            return list;
        }

        public void ImportProfessorsFromCSV(string caminhoArquivo)
        {
            List<string[]> linhas = new List<string[]>();
            
            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] colunas = linha.Split(';');
                    linhas.Add(colunas);
                }
            }

            foreach (string[] colunas in linhas)
            {
                if (colunas.Length >= 3)
                {
                    Usuario usuario = new Usuario();
                    usuario.Nome = colunas[0].Replace("\"", " ");
                    usuario.Email = colunas[1];
                    usuario.Senha = colunas[2];
                    usuario.Tipo = "professor";
                    var userId = usuario.InsertUser();

                    if (colunas.Length >= 1)
                    {
                        Nome = colunas[0];
                        Usuario_id = userId;
                        Insert();
                    }
                    
                }
                
            }
        }
    }
}
