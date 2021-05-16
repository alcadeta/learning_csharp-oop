namespace OOPExamples
{
    internal sealed class PowerController : IPowerOn
    {
        public bool IsOn { get; private set; }

        private void TurnOn() { IsOn = true; }
        private void TurnOff() { IsOn = false; }
        public void TogglePower()
        {
            if (IsOn) { TurnOff(); } else { TurnOn(); }
        }
    }
}