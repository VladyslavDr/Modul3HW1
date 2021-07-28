using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        var array = new MyList<int>();

        array.AddRange(new int[] { 2, 5, 6, 7, 9 });

        array.Sort(new Comparer());

        foreach (var i in array.GetArray())
        {
            Console.WriteLine(i);
        }
    }
}