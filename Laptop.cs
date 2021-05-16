namespace OOPExamples
{
    internal class Laptop : Computer, ISleep
    {
        public Laptop(string name, int width, int height) : base(name)
        {
            SleepController = new SleepController();
            Display = new Display(width, height);
        }

        private ISleep SleepController;
        public Display Display { get; private set; }

        public bool IsSleeping => SleepController.IsSleeping;
        public void ToggleSleep() => SleepController.ToggleSleep();
    }
}