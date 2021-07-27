using System;

namespace GameLogic.Architecture.Weapons.Guns
{
    public class MachineGun : Weapon
    {
        public MachineGun()
        {
            Type = WeaponType.MachineGun;
            reloadTime = 0.05f;
        }
        public override bool Shot()
        {
            return true;
        }
    }
}
