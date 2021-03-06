using System;

namespace GameLogic.Architecture.Weapons.Guns
{
    public abstract class Weapon
    {
        public WeaponType Type { get; protected set; }
        public abstract bool Shot();
        public abstract void TimeFlow(float value);
        protected float reloadTime;
    }
}
