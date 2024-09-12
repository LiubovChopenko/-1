using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
    // task1
  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Liubov";
            int age = 17;
            Console.WriteLine("task 1:");
            Console.WriteLine("Hello, {0}, I'm {1} years old", name, age);

            // task2
            int a = 3;
            int b = 6;
            double result;

            result = ((Math.Pow(a + b, 3))) - ((Math.Pow(a, 3)) - (Math.Pow(3 * a, 1))) * (Math.Pow(b, 2)) / (Math.Pow(b, 3)) - ((Math.Pow(3 * a, 2)) * (Math.Pow(b, 1)));     
            Console.WriteLine("_");
            Console.WriteLine("task 2:");
            Console.WriteLine($"result = {result}");


            // task3
            Console.WriteLine("Input number");
            int s = int.Parse(Console.ReadLine());

            int k = s % 10;
            int c = (s % 100) / 10;
            int d = s / 100;

            Console.WriteLine("Reversed number: " + k + c + d);
            

            

           
            }
    }
}
   