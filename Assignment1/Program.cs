using System;
using Assignment1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment1.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational rational1 = new Rational(0 , 2);
            Rational rational2 = new Rational(1 , 2);
            Rational rational3 = new Rational(2 , 2);
            Rational rational4 = new Rational(2 , 1);

            Console.WriteLine($"First Rational Number : {rational1}");
            Console.WriteLine($"Second Rational Number : {rational2}");
            Console.WriteLine("");
            Console.WriteLine("Adding First Rational Number with Second Rational Number");
            rational1.IncreaseBy(rational2);
            Console.WriteLine("");
            Console.WriteLine($"Increased by : {rational1}");
            Console.WriteLine("");
            Console.WriteLine($"Third Rational Number : {rational3}");
            Console.WriteLine($"Forth Rational Number : {rational4}");
            Console.WriteLine("");
            Console.WriteLine("Adding Third Rational Number with Forth Rational Number");
            rational3.DecreaseBy(rational4);
            Console.WriteLine("");
            Console.WriteLine($"Decreased by : {rational3}");
            Console.ReadKey();
            


        }
    }
}