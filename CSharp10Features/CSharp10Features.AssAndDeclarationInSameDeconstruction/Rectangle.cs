namespace CSharp10Features.AssAndDeclarationInSameDeconstruction
{
    public class Rectangle
    {
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
        
        public int Height { get; init; }
        public int Width { get; init; }

        internal void Deconstruct(out int height, out int width)
        {
            height = Height;
            width = Width;
        }
    }
}