﻿using System;

namespace MinMaxofArray
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] array = { 100, 33, 9, 290, 24, 12, 7, 4 };
            int max = array[0];
            int min = array[0];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}