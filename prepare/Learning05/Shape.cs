using System.Formats.Asn1;

public class Shape
{
    // variable / attributes
    private string _color;

    // Constructors
    public Shape()
    {}
    public Shape(string color)
    {
        _color = color;
    }

    // Functions /  Methods
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}