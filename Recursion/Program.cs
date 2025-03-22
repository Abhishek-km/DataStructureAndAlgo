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

            //Console.WriteLine("Runnign Power of Number Recursive Code");
            //Console.WriteLine("Enter Number");
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Power");
            //int power = int.Parse(Console.ReadLine());
            //int PowerAns = Power.CalPower(Number, power);
            //Console.WriteLine(PowerAns);
            //wait = Console.ReadLine();

            //Console.WriteLine("Runnign Factorial of Number Recursive Code");
            //Console.WriteLine("Enter Number");
            //int Number = int.Parse(Console.ReadLine());
            //int FactorialAns = Factorial.CalFactorial(Number);
            //Console.WriteLine(FactorialAns);
            //wait = Console.ReadLine();

            //Console.WriteLine("Runnign Print of Number Recursive Code");
            //Console.WriteLine("Enter Number");
            //int Number = int.Parse(Console.ReadLine());
            //PrintNumber.Print(Number);
            //wait = Console.ReadLine();

            //Console.WriteLine("Runnign Fibonacci of Number Recursive Code");
            //Console.WriteLine("Enter Number");
            //int Number = int.Parse(Console.ReadLine());
            //int FibonacciAns = Fibonacci.Fib(Number);
            //Console.WriteLine(FibonacciAns);
            //wait = Console.ReadLine();

            //Console.WriteLine("Runnign Palindrom of Number Recursive Code");
            //Console.WriteLine("Enter String");
            //string str = Console.ReadLine();
            //bool PalindromAns = Palindrom.PalindromCheck(str);
            //Console.WriteLine(PalindromAns);
            //wait = Console.ReadLine();

            //Console.WriteLine("Runnign Stair Problem Recursive Code");
            //Console.WriteLine("Enter Number of Stairs");
            //int Number = int.Parse(Console.ReadLine());
            //int StairAns = StairProblem.Stair(Number);
            //Console.WriteLine(StairAns);
            //wait = Console.ReadLine();

            //Console.WriteLine("Running Reverse of String Recursive Code");
            //Console.WriteLine("Enter String");
            //string str = Console.ReadLine();
            //ReverseAArray.ReverseArray(str.ToCharArray());
            //wait = Console.ReadLine();

            //Console.WriteLine("Running for Power Set");
            //Console.WriteLine("Enter String");
            //string str = Console.ReadLine();
            //PowerSet.printPowerSet(str.ToCharArray());
            //wait = Console.ReadLine();

            Console.WriteLine("Subset");
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            SubSet.PrintSubSet(str.ToCharArray());
            wait = Console.ReadLine();
        }
    }
}
