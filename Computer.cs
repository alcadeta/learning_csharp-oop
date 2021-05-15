namespace OOPExamples
{
    abstract class Computer
    {
        public virtual string Name { get; private set; }
        public bool IsOn { get; private set; }

        protected Computer(string name) { Name = name; }

        private void TurnOn() { IsOn = true; }
        private void TurnOff() { IsOn = false; }

        public void TogglePower()
        {
            if (IsOn) { TurnOff(); } else { TurnOn(); }
        }
    }
}