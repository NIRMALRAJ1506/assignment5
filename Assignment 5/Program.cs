using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in cm");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Name: " + name + "\nAge: " + age + "\nHeight: " + height);
            Console.ReadKey();
        }
    }
}
