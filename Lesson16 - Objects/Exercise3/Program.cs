using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point1 = new Point(input1[0], input1[1]);
            Point point2 = new Point(input2[0], input2[1]);

            Circle circle1 = new Circle(point1,input1[2]);
            Circle circle2 = new Circle(point2, input2[2]);

            Console.WriteLine(Circle.Intersect(circle1, circle2) ? "Yes" : "No");
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double CalcBetweenTwoPoints(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.Y, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            double distance = Point.CalcBetweenTwoPoints(c1.Center,c2.Center);

            if (distance <= c1.Radius + c2.Radius)
            {
                return true;
            }
            return false;
        }
    }
}
