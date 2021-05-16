namespace OOPExamples
{
    internal class Display
    {
        public Display(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }
    }
}