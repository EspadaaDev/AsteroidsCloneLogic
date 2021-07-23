using GameLogic.Architecture.Enemies;
using System;
using System.Collections.Generic;

namespace GameLogic.Architecture
{
    public class Factory
    {
        // Enemies
        private readonly Dictionary<EnemyType, Enemy> enemies = new Dictionary<EnemyType, Enemy>()
        {
            // Asteroid
            { EnemyType.Asteroid, new Enemy(
                EnemyType.Asteroid,
                GameConfigurations.Asteroid_MovementSpeed,
                GameConfigurations.Asteroid_PointsForDestroy)
            },

            // Small asteroid
            { EnemyType.SmallAsteroid, new Enemy(
                EnemyType.SmallAsteroid,
                GameConfigurations.SmallAsteroid_MovementSpeed,
                GameConfigurations.SmallAsteroid_PointsForDestroy)
            },

            // FlyingSaucer
            { EnemyType.FlyingSaucer, new Enemy(
                EnemyType.FlyingSaucer,
                GameConfigurations.FlyingSaucer_MovementSpeed,
                GameConfigurations.FlyingSaucer_PointsForDestroy)
            }
        };

        // Instantiate enemy
        public Enemy ProduceEnemy(EnemyType type)
        {
            if (!enemies.ContainsKey(type))
            {
                throw new ArgumentException("Unknown enemy type: " + type);
            }

            return enemies[type];
        }
    }
}
