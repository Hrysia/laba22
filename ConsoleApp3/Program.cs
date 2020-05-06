using System;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x = (-3 * Math.PI)/2, y = 0;
            Console.WriteLine("X\t             \tY\n");
            Console.WriteLine("                                \n");
            while (x <= -Math.PI / 2)
            {
                y = x * x * Math.Cos(x);
                Console.WriteLine("x=" + x + "     y=" + y);               
                x += Math.PI / 10;
            }
            Console.ReadKey();
        }
    }
}
