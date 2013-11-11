using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

abstract class Shape
{
    virtual public double CalculateSurface() { return 0.0; }
    protected double width;
    protected double height;
}

class Triangle : Shape{
    public override double CalculateSurface()
    {
        return this.width * this.height / 2.0;
    }
    public Triangle(double sideone, double sidetwo)
    {
        width = sideone;
        height = sidetwo;
    }
    public Triangle() : this(0.0, 0.0) { }
}

class Rectangle : Shape
{
    public override double CalculateSurface()
    {
        return this.width * this.height;
    }
    public Rectangle(double sidex, double sidey)
    {
        width = sidex;
        height = sidey;
    }
    public Rectangle() : this(0.0, 0.0) { }
}

class Circle : Shape
{
    public Circle(double diameter)
    {
        width = diameter;
        height = width;
    }
    public Circle() : this(0) { }
    public override double CalculateSurface()
    {
        return 3.1416 * width;
    }
}

class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapearr = new Shape[5];
            shapearr[0] = new Triangle(10.0, 5.0);
            shapearr[1] = new Triangle(5.4, 8.7);
            shapearr[2] = new Rectangle(4.2, 3.1);
            shapearr[3] = new Circle(5.3);
            shapearr[4] = new Circle(7.0);

            foreach (Shape sh in shapearr) Console.WriteLine(sh.CalculateSurface());
            
        }
    }

