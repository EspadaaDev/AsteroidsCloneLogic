using System;

namespace GameLogic.Architecture.Weapons.Guns
{
    public class Laser : Weapon
    {
        public readonly int MaximumShots;
        public float NumOfShots { get; private set; }
        public float ReloadTimer { get; private set; } = 0;
        public float AddShotTime { get; private set; } = 0;

        // Constructor
        public Laser(int maxShots, float timeToReload, float addShotTime)
        {
            Type = WeaponType.Laser;
            MaximumShots = maxShots;
            ReloadTimer = timeToReload;
            this.AddShotTime = addShotTime;
        }

        // Shot
        public override bool Shot()
        {
            if (NumOfShots > 0.99f && ReloadTimer <= 0)
            {
                NumOfShots -= 1;
                ReloadTimer = reloadTime;
                return true;
            }
            return false;
        }

        // Add num of shots
        private void AddShot(float value)
        {
            if (NumOfShots < MaximumShots)
            {
                NumOfShots += value/AddShotTime;
            }
        }

        // Reload between shots
        private void Reload(float value)
        {
            if (ReloadTimer > 0)
            {
                ReloadTimer -= value;
            }
        }

        public override void TimeFlow(float value)
        {
            AddShot(value);
            Reload(value);
        }  
    }
}
