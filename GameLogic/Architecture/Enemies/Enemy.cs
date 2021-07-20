namespace GameLogic.Architecture.Enemies
{
    public class Enemy
    {
        // Fields
        public readonly EnemyType Type;
        public readonly float MovementSpeed;
        public readonly float PointsForDestroy;

        public Enemy(EnemyConfig config )
        {
            Type = config.Type;
            MovementSpeed = config.MovementSpeed;
            PointsForDestroy = config.PointsForDestroy;
        }
    }
}
