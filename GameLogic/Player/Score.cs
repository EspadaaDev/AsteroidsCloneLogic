namespace GameLogic.Player
{
    public class Score
    {
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
