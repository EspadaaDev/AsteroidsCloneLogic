namespace GameLogic.Architecture.Weapons.Projectiles
{
    public class  Projectile
    {
        public ProjectileType Type { get; protected set; }
        public float MovementSpeed { get; protected set; }
        public Projectile(ProjectileType type, float speed)
        {
            Type = type;
            MovementSpeed = speed;
        }
    }
}
