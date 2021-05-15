namespace OOPExamples
{
    public class Computer
    {
        public string Name { get; private set; }
        public bool IsOn { get; private set; }

        public Computer(string name)
        {
            Name = name;
        }

        protected void TurnOn()
        {
            IsOn = true;
        }

        protected void TurnOff()
        {
            IsOn = false;
        }

        public void TogglePower()
        {
            if (IsOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }
    }
}