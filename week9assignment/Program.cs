using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9assignment
{
    internal class Program
    {
        static void Q1() //Print elements in array
        {
            Console.Write("enter size of array: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] element = new int[input];
            Console.WriteLine($"enter {input} elements in the array");
            for (int i = 0; i < element.Length; i++)
            {
                element[i] += i;
                element[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("elements in array are: ");
            for (int i = 0; i < element.Length; i++)
            {
                Console.Write(element[i] + " ");
            }
            Console.ReadLine();
        }

        static void Q2() //Max, Min, Sum, Avg of the array
        {
            Console.Write("enter size of array: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] element = new int[input];
            Console.WriteLine($"enter {input} elements in the array");
            for (int i = 0; i < element.Length; i++)
            {
                element[i] += i;
                element[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("elements in array are: ");
            for (int i = 0; i < element.Length; i++)
            {
                Console.Write(element[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine($"the maximum of the array is: {element.Max()}");
            Console.WriteLine($"the minimum of the array is: {element.Min()}");
            Console.WriteLine($"the sum of the array is: {element.Sum()}");
            Console.WriteLine($"the average of the array is: {element.Average()}");
            Console.ReadLine();
        }

        static void Q3() //negative number in array
        {
            Console.Write("enter size of array: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] element = new int[input];
            Console.WriteLine($"enter {input} elements in the array");
            for (int i = 0; i < element.Length; i++)
            {
                element[i] += i;
                element[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("the negative elements in array are: ");
            for (int i = 0; i < element.Length; i++)
            {
                if (element[i] < 0)
                {
                    Console.Write(element[i] + " ");
                }
            }
            Console.ReadLine();
        }

        static void Q4() //negative number in array and sum of negative numbers.
        {
            Console.Write("enter size of array: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] element = new int[input];
            Console.WriteLine($"enter {input} elements in the array");
            for (int i = 0; i < element.Length; i++)
            {
                element[i] += i;
                element[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("the negative elements in array are: ");
            for (int i = 0; i < element.Length; i++)
            {
                if (element[i] < 0)
                {
                    Console.Write(element[i] + " ");
                }
            }
            Console.WriteLine();

            int nsum = 0;
            for (int i = 0; i < element.Length; i++)
            {
                if (element[i] < 0)
                {
                    nsum += element[i];
                }
            }
            Console.WriteLine($"the sum of all negative number is: {nsum}");
            Console.ReadLine();
        }

        static void Q5() //odd and even numbers of array
        {
            Console.Write("enter size of array: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] element = new int[input];
            Console.WriteLine($"enter {input} elements in the array");
            for (int i = 0; i < element.Length; i++)
            {
                element[i] += i;
                element[i] = Convert.ToInt32(Console.ReadLine());
            }

            int even = 0;
            int odd = 0;
            for (int i = 0; i < element.Length; i++)
            {
                if (element[i] % 2 == 0)
                {
                    even++;

                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine($"total even elements: {even}");
            Console.WriteLine($"total odd element: {odd}");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            //Q3();
            //Q4();
            //Q5();
        }
    }
}
