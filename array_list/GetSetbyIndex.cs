using System;
using System.Collections;

class GetAndSetbyIndex
{

    
    public static void Main()
    {

        
        ArrayList myList = new ArrayList();

        
        myList.Add("A");
        myList.Add("B");
        myList.Add("C");
       

       
        foreach (string str in myList)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("After Item[int32] Property: ");

        
        myList[2] = "Z";

        
        foreach (string str in myList)
        {
            Console.WriteLine(str);
        }
    }
}