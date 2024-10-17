class Fraction
{
    // Attributes
    private int _top;
    private int _bottom;

    // Behaviors

    // Constructors
    public void fraction()
    // Initializes fraction to 1/1
    {
        _top = 1;
        _bottom = 1;
    }

    public void fraction(int wholeNumber)
    // Initializes fraction to a whole number
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public void fraction(int top, int bottom)
    // Initializes fraction to x/y
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters

    public int getTop()
    {
        return _top;
    }

    public int getBottom()
    {
        return _bottom;
    }

    // Setters

    public void setTop(int top)
    {
        _top = top;
    }

    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Final Getters

    public string getFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double getDecimalValue()
    {
        double top = _top;
        double bottom = _bottom;
        return top / bottom;
    }

}