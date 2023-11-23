using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Shape\n1.Rectangle\n2.Square\n3.Circle\n4.Triangle");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        Rectangle rect = new Rectangle();
                        Console.WriteLine("Enter the width of the rectangle");
                        double w = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the breath of the rectangle");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("The area of the rectangle is " + rect.Area(w, b) +" sq. units.");
                        break;
                    }
                case 2:
                    {
                        Square sq = new Square();
                        Console.WriteLine("Enter the length of side of the square");
                        double x = double.Parse(Console.ReadLine());
                        Console.WriteLine("The area of the square is " + sq.Area(x) + " sq. units.");
                        break;
                    }
                case 3:
                    {
                        Circle cir = new Circle();
                        Console.WriteLine("Enter the radius of the circle");
                        double r = double.Parse(Console.ReadLine());                        
                        Console.WriteLine("The area of the circle is " + cir.Area(r) + " sq. units.");
                        break;
                    }
                case 4:
                    {
                        Triangle tri = new Triangle();
                        Console.WriteLine("Enter the base of the triangle");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height of the triangle");
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine("The area of the rectangle is " + tri.Area(b, h) + " sq. units.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Shape Choice");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
