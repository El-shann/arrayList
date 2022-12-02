using System;
using System.Collections.Generic;

public class program
{
    public static void Main()
    {
        List<string> countries = new List<string>() { "Combodia", "lesoto", "Morocco", "Malta" };
        string country = "India";

        countries.Insert(countries.Count, country);

        Console.WriteLine(String.Join(", ", countries));        
    }
}
