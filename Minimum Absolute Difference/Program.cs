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
     * Complete the 'minimumAbsoluteDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int minimumAbsoluteDifference(List<int> arr)
    {
        var tmp = arr.OrderBy(x => x).ToList();
        var min = Math.Abs(tmp[0] - tmp[1]);
        for (var i = 0; i < tmp.Count; i++)
        {
            if (i < tmp.Count - 1) min = Math.Min(min, Math.Abs(tmp[i] - tmp[i + 1]));
        }
        return min;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Result.minimumAbsoluteDifference([1, 9, 9, 8, 1]);
    }
}