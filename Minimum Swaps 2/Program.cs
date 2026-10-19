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
    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        var swaps = 0;
        for (var i = 0; i < arr.Length; i++)
        {
            while (arr[i] != i + 1)
            {
                (arr[i], arr[arr[i] - 1]) = (arr[arr[i] - 1], arr[i]);
                swaps++;
            }
        }
        return swaps;
    }

    static void Main(string[] args)
    {
        int res = minimumSwaps([
            2,
            31,
            1,
            38,
            29,
            5,
            44,
            6,
            12,
            18,
            39,
            9,
            48,
            49,
            13,
            11,
            7,
            27,
            14,
            33,
            50,
            21,
            46,
            23,
            15,
            26,
            8,
            47,
            40,
            3,
            32,
            22,
            34,
            42,
            16,
            41,
            24,
            10,
            4,
            28,
            36,
            30,
            37,
            35,
            20,
            17,
            45,
            43,
            25,
            19
        ]);
        Console.WriteLine(res);
    }
}