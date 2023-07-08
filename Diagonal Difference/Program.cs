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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        var arr2D           = arr.Select(col => col.ToArray()).ToArray();
        var leftDiagonalSum = 0;
        var rightDiagonalSum = 0;
        var rows            = arr2D.GetLength(0);
        for (var row = 0; row < rows; row++)
        {
            leftDiagonalSum  += arr2D[row][row];
            rightDiagonalSum += arr2D[rows - 1 - row][row];
        }
     
        return Math.Abs(leftDiagonalSum - rightDiagonalSum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.Write(result);
    }
}