using GameLogic.Architecture.Weapons;

namespace GameLogic.Architecture.Spacesheeps
{
    class StandartSpacesheep : Spacesheep
    {
        public StandartSpacesheep()
        {
            MaxSpeed = GameConfigurations.Spacesheep_MaxSpeed;
            Acceleration = GameConfigurations.Spacesheep_Acceleration;

            Weapons = new Weapon[2]
            {
            new Laser(),
            new MachineGun()
            };
        }
    }
}
