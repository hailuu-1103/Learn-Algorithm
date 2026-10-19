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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        var valleys = 0;
        var levels  = 0;
        foreach (var step in path)
        {
            if (step == 'U')
            {
                levels++;
                if (levels == 0)
                {
                    valleys++;
                }
            }
            else
            {
                levels--;
            }
        }
        return valleys;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int result = Result.countingValleys(8, "DDUUDDUDUUUD");
        Console.WriteLine(result);
    }
}