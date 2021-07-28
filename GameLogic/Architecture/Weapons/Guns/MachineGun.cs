using System;

namespace GameLogic.Architecture.Weapons.Guns
{
    public class MachineGun : Weapon
    {
        private float reloadTimer = 0;
        public MachineGun()
        {
            Type = WeaponType.MachineGun;
            reloadTime = 0.05f;
        }
        public override bool Shot()
        {
            if (reloadTimer <= 0) {
                return true;
            }
            return false;
        }
        private void Reload(float value)
        {
            if (reloadTimer > 0)
            {
                reloadTimer -= value;
            }
        }
        public override void TimeFlow(float value)
        {
            Reload(value);
        }
    }
}
