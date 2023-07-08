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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var arrLen      = arr.Count;
        var numPositive = 0;
        var numZero     = 0;
        var numNegative = 0;
        foreach (var element in arr)
        {
            switch (element)
            {
                case < 0:
                    numNegative += 1;
                    break;
                case 0:
                    numZero += 1;
                    break;
                case > 0:
                    numPositive += 1;
                    break;
            }
        }
        Console.WriteLine($"{(1f * numPositive / arrLen): 0.000000}");
        Console.WriteLine($"{(1f * numNegative / arrLen): 0.000000}");
        Console.WriteLine($"{(1f * numZero / arrLen): 0.000000}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}