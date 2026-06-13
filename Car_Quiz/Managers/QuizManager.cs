using System;
using System.Collections.Generic;
using Car_Quiz.Models;
using Car_Quiz.Strategies;

namespace Car_Quiz.Managers
{
    public class QuizManager
    {
        private readonly List<Question> _questions;
        private readonly IScoreStrategy _scoreStrategy;
        private int _correctCount;
        private int _wrongCount;

        public QuizManager(List<Question> questions, IScoreStrategy scoreStrategy)
        {
            _questions = questions;
            _scoreStrategy = scoreStrategy;
        }

        public void StartQuiz()
        {
            Console.WriteLine("A inceput quiz‐ul!\n");

            foreach (var q in _questions)
            {
                Console.WriteLine(q.Intrebare);
                for (int i = 0; i < q.Optiuni.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {q.Optiuni[i]}");
                }

                Console.Write("Alege un numar (1-4): ");
                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Alegere invalida. Sarim la urmatoarea intrebare.\n");
                    continue;
                }

                if (q.Optiuni[choice - 1] == q.RaspunsCorect)
                {
                    Console.WriteLine("Corect!\n");
                    _correctCount++;
                }
                else
                {
                    Console.WriteLine($"GRESIT! Raspuns corect: {q.RaspunsCorect}\n");
                    _wrongCount++;
                }
            }

            int finalScore = _scoreStrategy.CalculateScore(_correctCount, _wrongCount);
            Console.WriteLine($"Scor final: {finalScore}");
        }
    }
}
