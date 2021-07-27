using System;

namespace GameLogic.Architecture
{
    public class Score
    {
        public event Action<int> ScoreChangeNotify;
        // Score
        private int points;

        // Return number of points
        public int Count
        {
            get
            {
                return points;
            }
        }

        // The method adds some value to the points
        public void Add(int value)
        {
            points += value;
            ScoreChangeNotify?.Invoke(points);
        }

        public Score()
        {
            points = 0;
        }
        public Score(int StartScore)
        {
            points = StartScore;
        }
    }
}
