namespace OOPExamples
{
    internal enum CaseType { Tower, MiniTower }

    internal class Desktop : Computer, ISleep
    {
        public Desktop(string name, CaseType caseType) : base(name)
        {
            CaseType = caseType;
            SleepControler = new SleepController();
        }

        private ISleep SleepControler;
        public CaseType CaseType { get; private set; }
        public override string Name => $"{base.Name} {CaseType}";
        public bool IsSleeping => SleepControler.IsSleeping;

        public void ToggleSleep()
        {
            // Desktops cannot be put to sleep unless they're on.
            if (!IsOn) { return; }
            SleepControler.ToggleSleep();
        }

        public override void TogglePower()
        {
            // Desktops cannot be toggled off while they're asleep.
            if (IsSleeping) { return; }
            base.TogglePower();
        }
    }
}