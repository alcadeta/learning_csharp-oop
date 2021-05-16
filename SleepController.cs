namespace OOPExamples
{
    internal class SleepController : ISleep
    {
        public bool IsSleeping { get; private set; }
        public void ToggleSleep() => IsSleeping = !IsSleeping;
    }
}