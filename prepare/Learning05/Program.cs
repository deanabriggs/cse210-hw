using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("red", 5);
        Console.WriteLine($"Square Color: {mySquare.GetColor()}  \nSquare Area: {mySquare.GetArea()}\n");

        Circle myCircle = new Circle("green", 4);
        Console.WriteLine($"Circle Color: {myCircle.GetColor()}  \nCircle Area: {myCircle.GetArea()}\n");

        Rectangle myRectangle = new Rectangle("blue", 2, 4);
        Console.WriteLine($"Rectangle Color: {myRectangle.GetColor()}  \nRectangle Area: {myRectangle.GetArea()}\n");

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(mySquare);
        shapeList.Add(myCircle);
        shapeList.Add(myRectangle);
        
        foreach (Shape item in shapeList)
        {
            Console.WriteLine($"The {item.GetColor()} shape has an area of {item.GetArea()}.");
        }
    }
        
}