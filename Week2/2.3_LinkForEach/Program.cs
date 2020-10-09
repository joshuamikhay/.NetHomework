using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2018326660145
//Joshua Mikhay Kusuma
namespace _2._3_LinkForEach
{
    // List Nodes
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    // List Object
    public class myList<T>
    {
        private Node<T> head, tail;

        public myList()
        {
            head = tail = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> newNode = new Node<T>(t);

            if (head == null)
            {
                head = tail = newNode;
            }

            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        // Count Sum Value
        public double Sum()
        {
            if (tail == null)
            {
                return 0xffff;
            }
            Node<T> tempNode = head;
            double sum = 0;
            while (tempNode != null)
            {
                try
                {
                    double data = (double)Convert.ChangeType(tempNode.Data, typeof(Double));
                    sum += data;
                    tempNode = tempNode.Next;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
            }
            return sum;
        }

        // Count Max Value
        public double Max()
        {
            if (tail == null)
            {
                return 0xffff;
            }
            Node<T> tempNode = head;
            double max = (double)Convert.ChangeType(tempNode.Data, typeof(Double));
            while (tempNode != null)
            {
                try
                {
                    double data = (double)Convert.ChangeType(tempNode.Data, typeof(Double));
                    if (data >= max)
                    {
                        max = data;
                    }
                    tempNode = tempNode.Next;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
            }
            return max;
        }

        // count Min Value
        public double Min()
        {
            if (tail == null)
            {
                return 0xffff;
            }
            Node<T> tempNode = head;
            double min = (double)Convert.ChangeType(tempNode.Data, typeof(Double));
            while (tempNode != null)
            {
                try
                {
                    double data = (double)Convert.ChangeType(tempNode.Data, typeof(Double));
                    if (data <= min)
                    {
                        min = data;
                    }
                    tempNode = tempNode.Next;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
            }
            return min;
        }

        // ForEach on the List
        public void ForEach(Action<T> action)
        {
            for (var p = head; p != null; p = p.Next)
            {
                action(p.Data);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myList<int> intArray = new myList<int>();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
          

            double max = 0;
            double min = 0;
            double sum = 0;

            intArray.ForEach(x => max = Math.Max(x, max));
            intArray.ForEach(x => min = Math.Min(x, min));
            intArray.ForEach(x => sum += x);
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("max: " + max);
            Console.WriteLine("min: " + min);
        }
    }
}

