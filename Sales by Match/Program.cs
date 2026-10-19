using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        var result  = 0;
        var contain = new List<int>();
        for(var i = 0; i < n; i++)
        {
            if (contain.Contains(i)) continue;
            for (var j = i + 1; j < n; j++)
            {
                if (contain.Contains(j)) continue;
                if (ar[i] != ar[j]) continue;
                result++;
                contain.Add(i);
                contain.Add(j);
                break;

            }
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int result = Result.sockMerchant(15, [6, 5, 2, 3, 5, 2, 2, 1, 1, 5, 1, 3, 3, 3, 5]);

        Console.WriteLine(result);
    }
}