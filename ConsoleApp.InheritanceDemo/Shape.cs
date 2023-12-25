using System.Security.AccessControl;

abstract class Shape
{
    public double Height { get; set; }
    public double Length { get; set; }

    public double GetArea()
    {
        return Height * Length;
    }
}