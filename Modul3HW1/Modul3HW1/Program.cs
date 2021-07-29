using System;

public class Program
{
    public static void Main(string[] args)
    {
        var list = new MyList<int>();

        list.Add(3);
        list.Add(10);
        list.Add(2);
        list.Add(7);
        list.Add(9);
        list.Add(9);
        list.Add(6);
        list.Add(1);
        list.Add(10);

        list.Remove(9);
        list.RemoveAt(0);

        list.Sort(new Comparer());

        foreach (var i in list)
        {
            Console.Write($" {i}");
        }
    }
}