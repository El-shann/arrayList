using System;

namespace MinMaxofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] anArray = { 0, 17, 233, 5 };
            int m = anArray.Max();
            int p = Array.IndexOf(anArray, m);
            Console.WriteLine(p);

        }
    }
}