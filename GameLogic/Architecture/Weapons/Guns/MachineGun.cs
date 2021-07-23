using System;

namespace GameLogic.Architecture.Weapons.Guns
{
    public class MachineGun : Weapon
    {
        public MachineGun()
        {
            Type = WeaponType.MachineGun;
            reloadTime = 0.3f;
        }
        public override bool Shot()
        {
            return true;
        }
    }
}
