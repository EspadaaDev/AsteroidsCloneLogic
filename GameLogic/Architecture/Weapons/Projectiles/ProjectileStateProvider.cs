namespace GameLogic.Architecture.Weapons.Projectiles
{
    public class ProjectileStateProvider
    {
        public Projectile GetStats(ProjectileType type)
        {
            switch (type)
            {
                case ProjectileType.Bullet:
                    return new Projectile(ProjectileType.Bullet, 100);

                case ProjectileType.LaserRay:
                    return new Projectile(ProjectileType.LaserRay, 150);
            }
            return null;
        }
    }
}
