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
     * Complete the 'decentNumber' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void decentNumber(int n)
    {
        StringBuilder output = new StringBuilder(n);
        if (n%3 == 0)
        {
            output.Append('5', n);
        }
        else if (n >= 5 && ((n - 5) % 3 == 0))
        {
            output.Append('5', n - 5);
            output.Append('3', 5);
        }
        else if (n>=10 && ((n - 10) % 3 == 0))
        {
            output.Append('5', n - 10);
            output.Append('3', 10);
        }
        else if ((n - 3) % 5 == 0)
        {
            output.Append('5', 3);
            output.Append('3', n-3);
        }
        else if (n % 5 == 0)
        {
            output.Append('3', n);
        }
        else
        {
            output.Append("-1");
        }


        Console.WriteLine(output);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        var input = new StreamReader("source.txt");
        int t = Convert.ToInt32(input.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(input.ReadLine().Trim());

            Result.decentNumber(n);
        }
    }
}