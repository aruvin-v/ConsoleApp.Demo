class Cube : Shape
{
    public double Width { get; set; }
    public Cube()
    {
        
    }
    public Cube(int width, int height, int length)
    {
        Height = height;
        Length = length;
        Width = width;
    }
}

