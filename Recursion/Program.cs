using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Recusrion");
            string wait;

            //Console.WriteLine("Runnign Sum of 1 to N number Recursive Code");
            //Console.WriteLine("Enter N");
            //int n = int.Parse(Console.ReadLine());
            //int SumAns = Sum.SumtoN(n);
            //Console.WriteLine(SumAns);
            //wait = Console.ReadLine();

            Console.WriteLine("Runnign Power of Number Recursive Code");
            Console.WriteLine("Enter Number");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Power");
            int power = int.Parse(Console.ReadLine());
            int PowerAns = Power.CalPower(Number, power);
            Console.WriteLine(PowerAns);
            wait = Console.ReadLine();
        }
    }
}
