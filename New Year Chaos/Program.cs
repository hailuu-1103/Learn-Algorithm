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
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    // 1 2 3 4 5 6 7 8

    // 1 2 3 5 4 6 7 8    0 0 0 0 1 0 0 0
    // 1 2 5 3 4 6 7 8    0 0 0 0 2 0 0 0
    // 1 2 5 3 4 7 6 8    0 0 0 0 2 0 1 0
    // 1 2 5 3 7 4 6 8    0 0 0 0 2 0 2 0
    // 1 2 5 3 7 4 8 6    0 0 0 0 2 0 2 1
    // 1 2 5 3 7 8 4 6    0 0 0 0 2 0 2 2
    // 1 2 5 3 7 8 6 4    0 0 0 0 2

    // 1 2 5 3 7 8 6 4
    //
    public static void minimumBribes(List<int> q)
    {
        var bribes    = new int[q.Count];
        for (var i = q.Count - 1; i >= 0; i--)
        {
            while (i + 1 != q[i])
            {
                var idx = q.IndexOf(i + 1);
                (q[idx], q[idx +1]) = (q[idx+1], q[idx]);
                bribes[i]++;
                if (bribes[i] <= 2) continue;
                Console.WriteLine("Too chaotic");
                return;
            }
        }
        Console.WriteLine(bribes.Sum());
    }

    private static void Print(List<int> q)
    {
        q.ForEach(e => Console.Write("{0} ", e));
        Console.WriteLine();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Result.minimumBribes([1, 2, 5, 3, 7, 8, 6, 4]);
    }
}