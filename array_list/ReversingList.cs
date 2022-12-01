using System;
using System.Collections.Generic;

public class Program
{
    public static void reverseList<T>(List<T> list)
    {
        
        if (list == null || list.Count <= 1)
        {
            return;
        }

        // remove the first element
        T value = list[0];
        list.RemoveAt(0);

        // recursion for remaining items
        reverseList(list);

        // insert the top element back after recurse for remaining items
        list.Add(value);
    }

    public static void Main()
    {
        List<int> list = new List<int> { 1, 9, 6, 3 };

        reverseList(list);
        Console.WriteLine(String.Join(',', list));
    }
}
