using System;
using System.Collections.Generic;
using Car_Quiz.Strategies;

namespace Car_Quiz.Factories
{
    public static class ScoreStrategyFactory
    {
        private static readonly Dictionary<string, Func<IScoreStrategy>> _strategies =
            new Dictionary<string, Func<IScoreStrategy>>(StringComparer.OrdinalIgnoreCase)
            {
                { "Clasic", () => new ClassicScoreStrategy() },
                { "Penalizare", () => new PenalizeScoreStrategy() }
            };

        public static IScoreStrategy Create(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Key cannot be null or whitespace.", nameof(key));

            if (_strategies.TryGetValue(key, out var ctor))
                return ctor();

            throw new InvalidOperationException($"No score strategy registered for '{key}'.");
        }
    }
}
