using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calling a method with a return type
            Console.WriteLine(cube(5));

            cube(5); 

            Console.ReadLine();
        }

        //declare a method with a return type
        static int cube(int n)
        {
            int res = n * n * n;
            return res;
        }
    }
}
