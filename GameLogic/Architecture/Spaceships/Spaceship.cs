using System;
using System.Collections.Generic;
using GameLogic.Architecture.Weapons.Guns;

namespace GameLogic.Architecture.Spaceships
{
    public abstract class Spaceship
    {
        public Dictionary<WeaponType, Weapon> Weapons;
        public float MaxSpeed { get; protected set; }
        public float MaxForce { get; protected set; }
        public float TurnSpeed { get; protected set; }

        // Events
        public event Action CollideHandler;

        public abstract bool TakeShot(WeaponType type);

        public void CollideWithAnObject()
        {
            CollideHandler?.Invoke();
        }
    }
}
