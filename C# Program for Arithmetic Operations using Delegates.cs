//C# program to create & implement a delegates for any two arithmetic operations.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public delegate int deli(int n,int m);
    public class pgm9
    {
        public int sum(int a, int b)
        {
            return a + b;
        }
        public int diff(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
    }
public class program9
{
    public static void Main()
    {
        pgm9 p1 = new pgm9();
        deli d = p1.sum;
        int i = d(10, 20);
        Console.Write(" The sum is " + i);
        Console.WriteLine("\n**********************");
        pgm9 p2 = new pgm9();
        deli f = p2.diff;
        int j = f(40, 20);
        Console.Write(" The  difference is " + j);
        Console.WriteLine("\n**********************");
        pgm9 p3 = new pgm9();
        deli g = p3.mul;
        int k = g(2, 2);
        Console.Write(" The multiplcation is " + k);
        Console.WriteLine("\n**********************");
        pgm9 p4 = new pgm9();
        deli h = p4.div;
        int l = h(4, 2);
        Console.Write(" The division is " + l);
        Console.WriteLine("\n*********************");
        Console.ReadLine();
    }
}
}