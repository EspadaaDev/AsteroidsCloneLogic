using System;
using System.Collections.Generic;
using GameLogic.Architecture.Weapons.Guns;

namespace GameLogic.Architecture.Spaceships
{
    public class StandartSpaceship : Spaceship
    {
        public StandartSpaceship()
        {
            MaxSpeed = GameConfigurations.Spaceship_MaxSpeed;
            MaxForce = GameConfigurations.Spaceship_MaxForce;
            TurnSpeed = GameConfigurations.Spaceship_TurnSpeed;

            Weapons = new Dictionary<WeaponType, Weapon>()
            {
                { WeaponType.Laser, new Laser() },
                { WeaponType.MachineGun, new MachineGun() }
            };
        }

        public override bool TakeShot(WeaponType type)
        {
            if (!Weapons.ContainsKey(type))
            {
                throw new ArgumentException("Unknown module type: " + type);
            }
            return Weapons[type].Shot();
        }
    }
}
