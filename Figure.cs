using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }
    public class Reactangle : Figure
    {
        public Reactangle(double Width,Double Height)
        {
            this.Width = Width;
            this.Height = Height;

        }
        public override double GetArea()
        {
            return Width * Height;
        }

    }
    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }
    public class Cone : Figure
    {
        public Cone(double Radius,double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
        class TeastFigures
        {
            //static void Main()
            //{
            //    Reactangle react = new Reactangle(12.33,13.32);
            //    Circle cr = new Circle(4);
            //    Cone c = new Cone(4.5,5);
            //    Console.WriteLine("Area of Reactangle : {0} ", react.GetArea());
            //    Console.WriteLine("Area of Circle : {0}", cr.GetArea());
            //    Console.WriteLine("Area of Cone : {0}", c.GetArea());
            //    Console.ReadLine();


            //}
        }
    }
}
