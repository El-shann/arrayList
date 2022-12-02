using System;
using System.Collections.Generic;

class listLength
{
    public static void Main()
    {
        List<int> values = new List<int>() { 0, 117, 55, 1001 };
        int item = 4;

        values.Insert(0, item);  //

        Console.WriteLine(String.Join(", ", values));
    }
}

