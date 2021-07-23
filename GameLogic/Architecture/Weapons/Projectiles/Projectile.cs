namespace GameLogic.Architecture.Weapons.Projectiles
{
    public abstract class  Projectile
    {
        public ProjectileType Type { get; protected set; }
        public float MovementSpeed { get; protected set; }    
    }
}
