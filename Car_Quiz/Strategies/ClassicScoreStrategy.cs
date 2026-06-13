using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Quiz.Strategies;


namespace Car_Quiz.Strategies
{
    public class ClassicScoreStrategy : IScoreStrategy
    {
        public int CalculateScore(int correctAnswers, int wrongAnswers)
        {
            return correctAnswers;
        }
    }
}
