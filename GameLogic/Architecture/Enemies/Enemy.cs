namespace GameLogic.Architecture.Enemies
{
    public class Enemy
    {
        // Fields
        public EnemyType Type { get; }
        public float MovementSpeed { get; }
        public int PointsForDestroy { get; }

        // Constructor
        public Enemy(EnemyType type, float speed, int points)
        {
            Type = type;
            MovementSpeed = speed;
            PointsForDestroy = points;
        }

        public float Destroy()
        {
            return PointsForDestroy;
        }
    }
}
