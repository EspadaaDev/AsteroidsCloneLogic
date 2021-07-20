using GameLogic.Architecture.Weapons;

namespace GameLogic.Architecture.Spacesheeps
{
    public abstract class Spacesheep
    {
        public Weapon[] Weapons;
        public float MaxSpeed { get; protected set; }
        public float Acceleration { get; protected set; }
    }
}
