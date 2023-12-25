class Triangle : Shape
{
    public double Hypoteneuse { get; set; }

    public double GetArea()
    {
        return (Height * Length) / 2;
    }
}