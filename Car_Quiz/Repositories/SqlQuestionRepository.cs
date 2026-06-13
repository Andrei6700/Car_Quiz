using System.Collections.Generic;
using System.Data.SqlClient;
using Car_Quiz.Models;
using System.Configuration;

namespace Car_Quiz.Repositories
{
    public class SqlQuestionRepository : IQuestionRepository
    {
        private readonly string _connectionString;

        public SqlQuestionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Question> GetAllQuestions()
        {
            var questions = new List<Question>();

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Schimbă „intrebari_masini” și numele coloanelor după cum ai în BD
                using (var cmd = new SqlCommand("SELECT intrebare, optiune1, optiune2, optiune3, optiune4, raspuns_corect FROM intrebari_masini", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        questions.Add(new Question
                        {
                            Intrebare = reader["intrebare"].ToString(),
                            Optiuni = new List<string>
                            {
                                reader["optiune1"].ToString(),
                                reader["optiune2"].ToString(),
                                reader["optiune3"].ToString(),
                                reader["optiune4"].ToString()
                            },
                            RaspunsCorect = reader["raspuns_corect"].ToString()
                        });
                    }
                }
            }

            return questions;
        }
    }
}
