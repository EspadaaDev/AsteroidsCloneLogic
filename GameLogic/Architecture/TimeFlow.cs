namespace GameLogic.Architecture
{
    public class TimeFlow
    {
        public readonly int Speed_Stop = 0;
        public readonly int Speed_X1 = 1000;

        private int currentSpeed;

        public int currentTime { get; private set; }

        public TimeFlow()
        {
            currentSpeed = Speed_X1;
        }

        public void Pause()
        {
            currentSpeed = Speed_Stop;
        }
        public void Start()
        {
            currentSpeed = Speed_X1;
        }

        public bool IsStopped()
        {
            return currentSpeed == Speed_Stop;
        }

        public void AddTime(int ms)
        {
            if (IsStopped()) return;

            currentTime += ms;

            if (currentTime < currentSpeed) return;

            currentTime -= currentSpeed;
        }
    }
}
