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
     * Complete the 'waiter' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY number
     *  2. INTEGER q
     */

    public static List<int> waiter(List<int> number, int q)
    {
        List<int> answers = new List<int>();
        List<int> primes = new List<int>();
        List<int> B = new List<int>();
        List<int> A = new List<int>();

        int j = 0;
        int i = 2;
        while (j < q)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
                j++;
            }
            i++;
        }
        j = number.Count();
        i = 0;
        while (i < q)
        {
            int c = number.Count();
            j = number.Count()-1;
            int d = 0;
            while (c > d)
            {
                if (number.ElementAt(j) % primes.ElementAt(i) == 0)
                {
                    B.Add(number.ElementAt(j));
                    number.RemoveAt(j);
                }
                else
                {
                    A.Add(number.ElementAt(j));
                    number.RemoveAt(j);
                }
                j--;
                d++;
            }
            B.Reverse();
            answers.AddRange(B);
            B.Clear();

            number.Clear();
            number.AddRange(A);
            A.Clear();
            i++;
        }

        number.Reverse();   
        answers.AddRange(number);
        return answers;
    }

    public static bool IsPrime(int number)
    {
        int i;
        for (i = 2; i <= number - 1; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        if (i == number)
        {
            return true;
        }
        return false;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int q = 3;

        int[] nums = { 2,3,4,5,6,7 };
        //int[] nums = { 3,3,4,4,9 };
        //int[] nums = { 3, 4, 7, 6, 5 };
        List<int> number = new List<int>();
        number.AddRange(nums);

        List<int> result = Result.waiter(number, q);

        Console.WriteLine(String.Join("\n", result));

    }
}

