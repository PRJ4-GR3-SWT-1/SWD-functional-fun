using System;
using RomertalLib;

namespace SWD_functional_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Number:");
            while (true) { 
                var input= Console.ReadLine();
                var ar = new Arabic(int.Parse(input));
                Console.WriteLine(ar.ToRoman());
            }
        }
    }
}
