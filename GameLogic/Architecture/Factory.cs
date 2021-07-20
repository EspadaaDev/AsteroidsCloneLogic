using GameLogic.Architecture.Enemies;
using System;
using System.Collections.Generic;

namespace GameLogic.Architecture
{
    class Factory
    {
        // Enemies
        private readonly Dictionary<EnemyType, EnemyConfig> enemies = new Dictionary<EnemyType, EnemyConfig>()
        {
            // Asteroid
            { EnemyType.Asteroid, new EnemyConfig()
            {
                Type = EnemyType.Asteroid,
                MovementSpeed = GameConfigurations.Asteroid_MovementSpeed,
                PointsForDestroy = GameConfigurations.Asteroid_PointsForDestroy
            }
            },

            // Small asteroid
            { EnemyType.SmallAsteroid, new EnemyConfig()
            {
                Type = EnemyType.SmallAsteroid,
                MovementSpeed = GameConfigurations.SmallAsteroid_MovementSpeed,
                PointsForDestroy = GameConfigurations.SmallAsteroid_PointsForDestroy
            }
            },

            // FlyingSaucer
            { EnemyType.FlyingSaucer, new EnemyConfig()
            {
                Type = EnemyType.FlyingSaucer,
                MovementSpeed = GameConfigurations.FlyingSaucer_MovementSpeed,
                PointsForDestroy = GameConfigurations.FlyingSaucer_PointsForDestroy
            }
            }
        };

        // Produce enemy
        public Enemy ProduceEnemy(EnemyType type)
        {
            if (!enemies.ContainsKey(type))
            {
                throw new ArgumentException("Unknown module type: " + type);
            }

            return new Enemy(enemies[type]);
        }
    }
}
