namespace OOPExamples
{
    class Laptop : Computer
    {
        public Display Display { get; private set; }

        public Laptop(string name, int width, int height) : base(name)
        {
            Display = new Display(width, height);
        }
    }
}