class Square : Shape
{
    public double _side;

    public override double GetArea()
    {
        return _side * _side;
    }
}