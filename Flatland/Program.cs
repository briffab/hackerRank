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
using System.Reflection.Emit;
using System.Collections.Immutable;

class Solution
{

    // Complete the flatlandSpaceStations function below.
    static int flatlandSpaceStations(int n, int[] c)
    {
        int flat = 0;
        int stata = 0;
        int statb = 0;
        int cnt = 0;
        int hd = 0;
        int hd1 = 0;
        int hd2 = 0;
        int spc = 0;


        int portnum = c.Count();
        Array.Sort(c);
        if (c.Count() > 1)
        {
            stata = c[spc];
            statb = c[spc + 1];
            spc++;
        }
        else
        {
            stata = c[spc];
            statb = c[spc];
        }

        while (cnt < n)
        {
            
            if(!c.Contains(cnt))
            {
                hd1 = cnt - stata;
                hd2 = statb - cnt;

                if(hd1 < 0) { hd1 = hd1 * -1; }
                if (hd2 < 0) { hd2 = hd2 * -1; }

                if (hd1 == hd2)
                {
                    hd = hd1;
                }
                else if (hd1 < hd2)
                {
                    hd = hd1;
                }
                else
                {
                    hd = hd2;
                }

                if(hd > flat)
                {
                    flat = hd;
                }
            }
            else if(cnt == statb)
            {
                if (spc < portnum-1)
                {
                    stata = c[spc];
                    statb = c[spc + 1];
                    spc++;
                }
            }
            cnt++;
        }

        return flat;

    }

    static void Main(string[] args)
    {
       

        int n = 100;


        int[] c = {99};
    
        int result = flatlandSpaceStations(n, c);

        Console.WriteLine(result);
    }
}