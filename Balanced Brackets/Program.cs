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
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        if (s.Length % 2 != 0) return "NO";

        var left = new Stack<char>();

        foreach (var c in s)
        {
            if (c is '{' or '[' or '(')
            {
                left.Push(c);
            }
            else
            {
                if (left.Count == 0) return "NO";

                if (!Match(left.Pop(), c)) return "NO";
            }
        }

        return left.Count == 0 ? "YES" : "NO";

        bool Match(char first, char second)
        {
            return first switch
            {
                '{' => second == '}',
                '[' => second == ']',
                '(' => second == ')',
                _   => false,
            };
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Result.isBalanced("}[()]}"));
    }
}