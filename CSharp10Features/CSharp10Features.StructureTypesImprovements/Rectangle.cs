namespace CSharp10Features.StructureTypesImprovements
{

    public struct Rectangle
    {

        // Parameterless constructor is allowed in CSharp10
        public Rectangle()
        {
            Height = 0;
            Width = 0;
        }
        
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
        
        public int Height { get; init; }
        public int Width { get; init; }
    }
}