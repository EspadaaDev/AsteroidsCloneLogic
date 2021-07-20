namespace GameLogic.Architecture.Weapons
{    
    class Laser : Weapon
    {
        public readonly int MaximumShots = GameConfigurations.Laser_MaximumShots;
        public int NumOfShots { get; private set; }

        // Constructor
        public Laser()
        {
            Type = WeaponType.MachineGun;
        }

        public bool TakeShot()
        {
            if (NumOfShots > 0)
            {
                NumOfShots--;
                return true;
            }
            return false;
        }

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
