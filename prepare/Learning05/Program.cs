using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Rectangle r1 = new Rectangle("yellow" , 3 , 4);
        shapes.Add(r1);

        Circle c1 = new Circle("blue" , 5);
        shapes.Add(c1);
        
        Square s1 = new Square("red" , 6);
        shapes.Add(s1);

        foreach (Shape i in shapes)
        {
            string color = i.color;

            double area = i.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}