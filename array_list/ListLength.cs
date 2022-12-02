using System;
using System.Collections.Generic;

class listLength
{

    
    public static void Main()
    {

       
        List<int> firstlist = new List<int>();

        
        for (int i = 4; i < 8; i++)
        {
            firstlist.Add(i * 2);
        }

       
        Console.WriteLine(firstlist.Count);
    }
}