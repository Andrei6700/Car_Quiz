using System;
using System.Collections.Generic;
using Car_Quiz.Models;

namespace Car_Quiz.Repositories
{

    public class LoggingQuestionRepositoryDecorator : IQuestionRepository
    {
        private readonly IQuestionRepository _innerRepository;

        public LoggingQuestionRepositoryDecorator(IQuestionRepository innerRepository)
        {
            _innerRepository = innerRepository;
        }

        public List<Question> GetAllQuestions()
        {
            Console.WriteLine($"[LOG] Start loading questions at {DateTime.Now}");
            var result = _innerRepository.GetAllQuestions();
            Console.WriteLine($"[LOG] Loaded {result.Count} questions");
            return result;
        }
    }
}
