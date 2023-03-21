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
     * Complete the 'absolutePermutation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     */

    public static List<int> absolutePermutation(int n, int k)
    {
        List<int> source = new List<int>();
        List<int> ret = new List<int>();
        int cnt = 0;

        bool yes = false;

        if (k == 0)
        {
            for (cnt = 1; cnt <= n; cnt++)
            {
                ret.Add(cnt);
            }
        }
        else if(n/k == 2.0  && n%k ==0)
        {
            for(cnt = k+1;cnt<=n;cnt++)
            {
                ret.Add(cnt);
            }
            for (cnt = 1; cnt <= k; cnt++)
            {
                ret.Add(cnt);
            }
        }
        else if (n%k ==0)
        {
            
            int scnt = k;
            int acnt = 0;
            for(cnt=1;cnt<= n/(k*2);cnt++)
            {
                for(acnt = scnt+1; acnt <= scnt+k; acnt++)
                {
                    ret.Add(acnt);
                }
                scnt = acnt - (k*2);
                for (acnt = scnt; acnt < scnt + k; acnt++)
                {
                    ret.Add(acnt);
                }
                scnt = (acnt-1) + (k*2);
            }
        }
        

        if (ret.Count() != n)
        {
            ret.Clear();
            ret.Add(-1);
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

            List<int> result = Result.absolutePermutation(n, k);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}