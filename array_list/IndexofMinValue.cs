using System;

namespace IndexofMinValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] anArray = { 23, 22, 120, 6 };
            int m = anArray.Min();
            int p = Array.IndexOf(anArray, m);
            Console.WriteLine(p);

        }
    }
}