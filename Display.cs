namespace OOPExamples
{
    public class Display
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Display(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}