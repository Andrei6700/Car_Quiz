
namespace Car_Quiz.Strategies
{
    public interface IScoreStrategy
    {
        int CalculateScore(int correctAnswers, int wrongAnswers);
    }
}
