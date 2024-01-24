using System;

public class Fraction
{
    // create private variables
    private int _top = 1;
    private int _bottom = 1;

    // create constructors
    public Fraction()
    {
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // create functions
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }
        
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}