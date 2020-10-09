using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
 //2018326660145
 //Joshua Mikhay Kusuma
namespace _2._1_ShapeAreaCounter
{
    class Vector
    {
        public double x, y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Dot
    {
        public double x, y;

        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class ObjectShape
    {
        public List<Dot> vertex = new List<Dot>();
        public List<double> distance = new List<double>();

        public ObjectShape()
        { }

        public virtual double countArea()
        {
            return 0;
        }

        //count length of each edge
        public void countEdgeLength()
        {
            for (int i = 1; i < vertex.Count() - 1; i++)
            {
                distance.Add(System.Math.Sqrt(System.Math.Pow(vertex[i].x - vertex[i + 1].x, 2) + System.Math.Pow(vertex[i].y - vertex[i + 1].y, 2)));
            }
            distance.Add(System.Math.Sqrt(System.Math.Pow(vertex[0].x - vertex[vertex.Count() - 1].x, 2) + System.Math.Pow(vertex[0].y - vertex[vertex.Count() - 1].y, 2)));
        }
        class Triangle : ObjectShape
        {
            public Triangle(Dot dot1, Dot dot2, Dot dot3)
            {
                this.vertex.Add(dot1);
                this.vertex.Add(dot2);
                this.vertex.Add(dot3);
                countEdgeLength();
            }

            // Determine whether the values meet requirements
            public bool isLegal()
            {
                double maxDistance = distance[0];
                List<double> otherDistance = new List<double>();
                int i = 0;

                foreach (double d in distance)
                {
                    if (d <= 0)
                    {
                        return false;
                    }
                    if (d > maxDistance)
                    {
                        maxDistance = d;
                        i++;
                    }
                }

                for (int j = 0; j < 3; j++)
                {
                    if (j != i)
                    {
                        otherDistance.Add(distance[j]);
                    }
                }

                if (maxDistance >= otherDistance[0] + otherDistance[1])
                {
                    return false;
                }

                else
                {
                    return true;
                }

            }

            // Count Triangle Area
            public override double countArea()
            {
                if (!isLegal())
                {
                    return -1;
                }

                double p = 0.5 * (distance[0] + distance[1] + distance[2]);
                return System.Math.Sqrt(p * (p - distance[0]) * (p - distance[1]) * (p - distance[2]));
            }
        }

        class Quadrangle : ObjectShape
        {
            public Quadrangle(Dot dot1, Dot dot2, Dot dot3, Dot dot4)
            {
                this.vertex.Add(dot1);
                this.vertex.Add(dot2);
                this.vertex.Add(dot3);
                this.vertex.Add(dot4);
                countEdgeLength();
            }

            public override double countArea()
            {
                double v = (distance.Sum() / 2);
                double area = System.Math.Sqrt((v - distance[0]) * (v - distance[1]) * (v - distance[2]));

                return area;
            }

            // Deterime whether the 4 edged object it Square
            public bool isSquare()
            {
                for (int i = 0; i < distance.Count() - 1; i++)
                {
                    if (distance[i] != distance[i + 1])
                    {
                        return false;
                    }
                }

                return true;
            }

            // Determine whether the 4 edged object is Rectangle
            public bool isRectangle()
            {
                List<Vector> vec = new List<Vector>();
                for (int i = 0; i < vertex.Count - 1; i++)
                {
                    vec.Add(new Vector(vertex[i].x - vertex[i + 1].x, vertex[i].y - vertex[i + 1].y));
                    Console.WriteLine($"{vec[i].x}, {vec[i].y}");
                }

                vec.Add(new Vector(vertex[0].x - vertex[vertex.Count - 1].x, vertex[0].y - vertex[vertex.Count - 1].y));

                for (int i = 0; i < vec.Count() - 1; i++)
                {
                    if (vec[i].x * vec[i + 1].x + vec[i].y * vec[i + 1].y != 0)
                    {
                        return false;
                    }
                }

                if (vec[0].x * vec[vec.Count() - 1].x + vec[0].y * vec[vec.Count() - 1].y != 0)
                {
                    return false;
                }

                return true;
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Dot d1 = new Dot(0, 0);
                Dot d2 = new Dot(0, 1);
                Dot d3 = new Dot(1, 1);
                Dot d4 = new Dot(1, 0);

                Dot d5 = new Dot(0, 0);
                Dot d6 = new Dot(0, 1);
                Dot d7 = new Dot(0.5, 1);

                Triangle tri = new Triangle(d5, d6, d7);
                Quadrangle qua = new Quadrangle(d1, d2, d3, d4);
                Console.WriteLine($"Triangle Area: {tri.countArea()}");
                Console.WriteLine($"Quadrangle Area: {qua.countArea()}");
                Console.WriteLine($"is Rectangle: {qua.isRectangle()}");
            }
        }
    }
}

