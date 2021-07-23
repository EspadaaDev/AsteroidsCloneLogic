namespace GameLogic
{
    internal static class GameConfigurations
    {

        //////////////////////////////
        /// Enemies configurations ///
        //////////////////////////////        

        // Asteroid
        public static float Asteroid_MovementSpeed = 10.0f;
        public static int   Asteroid_PointsForDestroy = 100;

        // SmallAsteroid
        public static float SmallAsteroid_MovementSpeed = 15.0f;
        public static int   SmallAsteroid_PointsForDestroy = 50;

        // FlyingSaucer
        public static float FlyingSaucer_MovementSpeed = 12.0f;
        public static int   FlyingSaucer_PointsForDestroy = 200;

        /////////////////////////////////
        /// Spaceships configurations ///
        /////////////////////////////////

        // Standart spaceship
        public static float Spaceship_MaxSpeed = 10.0f;
        public static float Spaceship_MaxForce = 100.0f;
        public static float Spaceship_TurnSpeed = 30f;

        //////////////////////////////
        /// Weapons configurations ///
        //////////////////////////////

        // Laser
        public static int Laser_MaximumShots = 5;
        public static float Laser_ShotAddTime = 3.0f;
    }
}
