namespace CSharp10Features.RecordTypesSealToString;

internal record Rectangle(int Height, int Width)
{
    public /*sealed*/ override string ToString()
    {
        return $"Height is: {Height} and width is: {Width}";
    }
}

internal record Square : Rectangle
{
    protected Square(int sideLength) : base(sideLength, sideLength) {}

    public override string ToString()
    {
        return $"Side length: {Height}";
    }
}
