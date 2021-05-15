namespace OOPExamples
{
    internal abstract class Computer
    {
        public string Name { get; private set; }
        public bool IsOn { get; private set; }

        protected Computer(string name) { Name = name; }

        private void TurnOn() { IsOn = true; }
        private void TurnOff() { IsOn = false; }
        public void TogglePower() { IsOn = !IsOn; }
    }
}