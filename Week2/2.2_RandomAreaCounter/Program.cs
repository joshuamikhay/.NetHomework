
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2018326660145
//Joshua Mikhay Kusuma
namespace _2._2_RandomAreaCounter
{
    class Dot
    {
        public double x, y;

        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Vector
    {
        public double x, y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class objectShape
    {
        public List<Dot> vertex = new List<Dot>();
        public List<double> distance = new List<double>();
        public double Area = 0;

        public objectShape(List<Dot> vertex)
        {
            this.vertex = vertex;
            countArea();
        }

        public void countArea()
        {
            double sum = 0;
            for (int i = 0; i < vertex.Count - 1; i++)
            {
                sum += vertex[i].x * vertex[i + 1].y - vertex[i + 1].x * vertex[i].y;
            }

            if (sum < 0)
            {
                sum = -sum;
            }

            this.Area = 0.5 * sum;
        }

        // Count Length of Edges
        public void countEdgeLength()
        {
            for (int i = 0; i < vertex.Count() - 1; i++)
            {
                distance.Add(System.Math.Sqrt(System.Math.Pow(vertex[i].x - vertex[i + 1].x, 2) + System.Math.Pow(vertex[i].y - vertex[i + 1].y, 2)));
            }

            distance.Add(System.Math.Sqrt(System.Math.Pow(vertex[0].x - vertex[vertex.Count() - 1].x, 2) + System.Math.Pow(vertex[0].y - vertex[vertex.Count() - 1].y, 2)));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int nodeNum = 0;
            List<objectShape> shapes = new List<objectShape>();
            Random ran = new Random();
            for (int i = 0; i < 10; i++)
            {
                nodeNum = ran.Next(1, 100);
                Console.WriteLine($"Node Number : {nodeNum}");
                List<Dot> dots = new List<Dot>();

                for (int j = 0; j < nodeNum; j++)
                {
                    double x = ran.Next(-100, 100);
                    double y = ran.Next(-100, 100);
                    dots.Add(new Dot(x, y));
                }

                shapes.Add(new objectShape(dots));
            }

            double Area = 0;

            foreach (objectShape s in shapes)
            {
                Console.WriteLine($"Individual Area : {s.Area}");
                Area += s.Area;
            }

            Console.WriteLine($"Quadrangle Area: {Area}");
        }
    }
}

