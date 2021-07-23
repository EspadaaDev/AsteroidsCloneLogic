using System;

namespace GameLogic.Architecture.Weapons.Guns
{
    public class Laser : Weapon
    {
        public readonly int MaximumShots = GameConfigurations.Laser_MaximumShots;
        public event Action<float> NumOfShotsHandler;
        public int NumOfShots { get; private set; }

        // Constructor
        public Laser()
        {
            Type = WeaponType.MachineGun;
            reloadTime = 4f;
        }

        // Shot
        public override bool Shot()
        {
            if (NumOfShots > 0)
            {
                NumOfShots--;
                return true;
            }

            return false;
        }

        // Add num of shots
        public bool AddShot()
        {
            if (NumOfShots < GameConfigurations.Laser_MaximumShots)
            {
                NumOfShots++;
                return true;
            }

            return false;
        }
    }
}
