class Rectangle : Shape
{
    public double _length;
    public double _width;
    public override double GetArea()
    {
        return _length * _width;
    }
}