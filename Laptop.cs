namespace OOPExamples
{
    class Laptop : Computer, ISleep
    {
        public Display Display { get; private set; }

        public Laptop(string name, int width, int height) : base(name)
        {
            Display = new Display(width, height);
        }

        public bool IsSleeping { get; }
        public void ToggleSleep()
        {
            throw new System.NotImplementedException();
        }
    }
}