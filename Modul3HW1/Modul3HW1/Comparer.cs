using System.Collections.Generic;

public class Comparer : IComparer<int>
{
    public int Compare(int value1, int value2)
    {
        if (value1 > value2)
        {
            return 1;
        }
        else if (value1 < value2)
        {
            return -1;
        }
        else
        {
            return 0;
        }

        // return value1 - value2;
    }
}
