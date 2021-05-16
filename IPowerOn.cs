namespace OOPExamples
{
    internal interface IPowerOn
    {
        bool IsOn { get; }
        void TogglePower();
    }
}