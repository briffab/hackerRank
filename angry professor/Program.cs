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
     * Complete the 'angryProfessor' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY a
     */

    public static string angryProfessor(int k, List<int> a)
    {
        string ret = "NO";
        int vcnt = 0;

        foreach(int s in a)
        {
            if(s<=0)
            {
                vcnt++;
            }
        }

        if( vcnt < k)
        {
            ret = "YES";
        }

        return ret;
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
            string[] firstMultipleInput = input.ReadLine().TrimEnd().Split(" ");

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> a = input.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            string result = Result.angryProfessor(k, a);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}