namespace GameLogic.Architecture.Enemies
{
    public class EnemyStats
    {
        public float MovementSpeed { get; private set; }
        public int PointsForDestroy { get; private set; }

        public EnemyStats(float movementSpeed, int pointsForDestroy)
        {
            MovementSpeed = movementSpeed;
            PointsForDestroy = pointsForDestroy;
        }
    }
}
