using System;
using System.Threading.Tasks;
using System.Linq;
//2018326660145
//Joshua Mikhay Kusuma
// max min avg sum simulator
namespace _2._2_MinMaxSumAvg
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(" >> Max - Min - Average - Sum Simulator <<");
                int[] numSet = new int[10];
                int max = numSet[0];
                int min = 101;
                double average = 0.0;
                int sum = 0;
                Random randNum = new Random();
                Console.WriteLine("Random Number Generated: ");
                for (int i = 0; i < numSet.Length; i++)
                {
                    numSet[i] = randNum.Next(0, 100);
                    Console.Write(numSet[i] + " ");
                    if (numSet[i] > max)
                    {
                        max = numSet[i];
                    }
                    if (numSet[i] < min)
                    {
                        min = numSet[i];
                    }
                    sum += numSet[i];
                }
                average = sum / numSet.Length;
                Console.WriteLine("\n");
                Console.WriteLine("Min : " + min);
                Console.WriteLine("Max : " + max);
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Average: " + average);
            }
        }
    }
