namespace GameLogic.Architecture.Enemies
{
    public class Enemy
    {        
        public EnemyStats Stats;

        private EnemyStateProvider stateProvider = new EnemyStateProvider();

        public Enemy(EnemyType type)
        {
            Stats = stateProvider.GetStats(type);
        }
    }
}
