namespace OOPExamples
{
    internal abstract class Computer : IPowerOn
    {
        protected Computer(string name)
        {
            Name = name;
            PowerController = new PowerController();
        }

        protected IPowerOn PowerController { get; private set; }
        public virtual string Name { get; private set; }
        public bool IsOn => PowerController.IsOn;

        public virtual void TogglePower()
        {
            PowerController.TogglePower();
        }
    }
}