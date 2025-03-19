using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Class_and_Abstract_methods
{
    public abstract class program
    {
        public abstract int mul(int a, int b);
    }
    public class demo : program
    {
        public override int mul(int a, int b)
        {
            return a * b;
        }
    }
    public class main
    {
        public static void Main()
        {
            demo d = new demo();
            int j = d.mul(20, 30);
            Console.WriteLine("\n*************************************");
            Console.WriteLine("The Multiplication of {0} * {1} = {2}", 20, 30, j);
            Console.WriteLine("\n**************************************");
            Console.ReadLine();
        }
    }
}
 
