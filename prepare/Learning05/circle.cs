class Circle : Shape
{
    public double _radius;

    public override double GetArea()
    {
        return 3.141592653589793238462643383279 * _radius * _radius;
    }
}