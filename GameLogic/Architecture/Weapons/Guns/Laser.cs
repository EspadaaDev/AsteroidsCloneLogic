using System;

namespace GameLogic.Architecture.Weapons.Guns
{
    public class Laser : Weapon
    {
        public readonly int MaximumShots;
        public event Action<float> NumOfShotsHandler;
        public float NumOfShots { get; private set; }
        private float reloadTimer = 0;
        private float addShotTime = 0;

        // Constructor
        public Laser(int maxShots, float timeToReload, float addShotTime)
        {
            Type = WeaponType.Laser;
            MaximumShots = maxShots;
            reloadTimer = timeToReload;
            this.addShotTime = addShotTime;
        }

        // Shot
        public override bool Shot()
        {
            if (NumOfShots > 0.99f && reloadTimer <= 0)
            {
                NumOfShots -= 1;
                reloadTimer = reloadTime;
                return true;
            }
            return false;
        }

        // Add num of shots
        private void AddShot(float value)
        {
            if (NumOfShots < MaximumShots)
            {
                NumOfShots += value/addShotTime;
            }
            NumOfShotsHandler?.Invoke(NumOfShots);
        }

        // Reload between shots
        private void Reload(float value)
        {
            if (reloadTimer > 0)
            {
                reloadTimer -= value;
            }
        }

        public override void TimeFlow(float value)
        {
            AddShot(value);
            Reload(value);
        }  
    }
}
