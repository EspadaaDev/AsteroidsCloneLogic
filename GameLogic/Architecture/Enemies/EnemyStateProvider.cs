namespace GameLogic.Architecture.Enemies
{
    public class EnemyStateProvider
    {
        public EnemyStats GetStats(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Asteroid:
                    return new EnemyStats(10f, 100);

                case EnemyType.SmallAsteroid:
                    return new EnemyStats(15f, 150);

                case EnemyType.FlyingSaucer:
                    return new EnemyStats(12f, 300);
            }
            return null;
        }
    }
}
