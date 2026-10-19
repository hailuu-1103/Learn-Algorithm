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

class Solution
{
    //1 3 9 9 27 81

    // 1 1
    // 3 1
    // 9 2
    // 27 1
    // 81 1

    // Complete the countTriplets function below.
    static long countTriplets(List<long> arr, long r)
    {
        var count = 0;
        var left  = new Dictionary<long, int>();
        var right = new Dictionary<long, int>();
        foreach (var value in arr)
        {
            right[value] = right.GetValueOrDefault(value) + 1;
        }

        foreach (var mid in arr)
        {
            right[mid]--; // loai mid khoi right
            if (mid % r == 0)
            {
                var first     = mid / r;
                var third     = mid * r;
                var leftCount = left.GetValueOrDefault(first);
                var rightCount = right.GetValueOrDefault(third);
                count += leftCount * rightCount;
            }
            left[mid] = left.GetValueOrDefault(mid) + 1;
        }
        return count;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(countTriplets([1, 3, 9, 9, 27, 81], 3));
    }
}