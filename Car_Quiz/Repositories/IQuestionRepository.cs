using System.Collections.Generic;
using Car_Quiz.Models;

namespace Car_Quiz.Repositories
{

    public interface IQuestionRepository
    {
        List<Question> GetAllQuestions();
    }
}
