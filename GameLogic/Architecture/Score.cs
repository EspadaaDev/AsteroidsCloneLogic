using System;

namespace GameLogic.Architecture
{
    public class Score
    {
        public event Action<int> ScoreChangeNotify;
        // Score
        private int points = 0;

        // Return number of points
        public int Count => points;

        // The method adds some value to the points
        public void Add(int value)
        {
            points += value;
            ScoreChangeNotify?.Invoke(points);
        }
    }
}
