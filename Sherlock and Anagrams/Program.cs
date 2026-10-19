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
     * Complete the 'sherlockAndAnagrams' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int sherlockAndAnagrams(string s)
    {
        var anagrams = 0;
        for (var length = 1; length < s.Length; length++)
        {
            for (var i = 0; i <= s.Length - length; i++)
            {
                var first = s.Substring(i, length);
                for (var j = i + 1; j <= s.Length - length; j++)
                {
                    var second = s.Substring(j, length);
                    if (new string(first.OrderBy(c => c).ToArray())
                        == new string(second.OrderBy(c => c).ToArray()))
                    {
                        anagrams++;
                    }
                }
            }
        }
        return anagrams;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Result.sherlockAndAnagrams("abba"));
    }
}