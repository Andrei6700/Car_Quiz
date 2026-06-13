using Car_Quiz.Strategies;

namespace Car_Quiz.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ClassicScoreStrategy_CalculateScore_ReturnsCorrectAnswers()
        {
            // Arrange
            var strategy = new ClassicScoreStrategy();
            int correct = 8;
            int wrong = 3;

            // Act
            int score = strategy.CalculateScore(correct, wrong);

            // Assert
            Assert.AreEqual(8, score);
        }

        [TestMethod]
        public void ClassicScoreStrategy_CalculateScore_WithZeroCorrectAnswers_ReturnsZero()
        {
            // Arrange
            var strategy = new ClassicScoreStrategy();
            int correct = 0;
            int wrong = 5;

            // Act
            int score = strategy.CalculateScore(correct, wrong);

            // Assert
            Assert.AreEqual(0, score);
        }

        [TestMethod]
        public void PenalizeScoreStrategy_CalculateScore_SubtractsWrongFromCorrect()
        {
            // Arrange
            var strategy = new PenalizeScoreStrategy();
            int correct = 10;
            int wrong = 4;

            // Act
            int score = strategy.CalculateScore(correct, wrong);

            // Assert
            Assert.AreEqual(6, score);
        }

        [TestMethod]
        public void PenalizeScoreStrategy_CalculateScore_CanReturnNegativeScore()
        {
            // Arrange
            var strategy = new PenalizeScoreStrategy();
            int correct = 3;
            int wrong = 7;

            // Act
            int score = strategy.CalculateScore(correct, wrong);

            // Assert
            Assert.AreEqual(-4, score);
        }

        [TestMethod]
        public void TestMethod1()
        {
            // Placeholder original test
            Assert.IsTrue(true);
        }
    }
}
