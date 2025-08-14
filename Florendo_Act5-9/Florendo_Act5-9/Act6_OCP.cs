using System;

namespace Florendo_Act5_9
{
    internal class Act6_OCP
    {
        internal static void Run()
        {
            IShape circle = new Circle();
            IShape square = new Square();

            Console.WriteLine($"Circle Area: {circle.Area()}");
            Console.WriteLine($"Square Area: {square.Area()}");
        }
    }

    public interface IShape
    {
        double Area();
    }

    public class Circle : IShape
    {
        public double Area() => 3.14 * 5 * 5; // radius = 5
    }

    public class Square : IShape
    {
        public double Area() => 4 * 4; // side = 4
    }
}
