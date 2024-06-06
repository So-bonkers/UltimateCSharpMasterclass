// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.Write("I wonder what the difference between Console.WriteLine() and Console.Write() is?");
//Console.WriteLine("This is the first command that I'm writing using WriteLine Command. As you can see, this is in one line");
//Console.WriteLine("This is the 2nd command that I'm writing to using Write Line method. As you can see, this is in a different line");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 3;

            Console.WriteLine("The value of the remainder for " + firstNum + " % " + secondNum + " is " + (firstNum%secondNum)); 

            Console.ReadLine();
        }
    }
}