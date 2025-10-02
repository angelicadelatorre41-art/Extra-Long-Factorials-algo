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
     * Complete the 'extraLongFactorials' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void extraLongFactorials(int n)
    {
         List<int> result = new List<int> { 1 };

        for (int i = 2; i <= n; i++)
        {
            int carry = 0;
            for (int j = 0; j < result.Count; j++)
            {
                int prod = result[j] * i + carry;
                result[j] = prod % 10;
                carry = prod / 10;
            }
            while (carry > 0)
            {
                result.Add(carry % 10);
                carry /= 10;
            }
        }

        // Print digits in reverse
        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.extraLongFactorials(n);
    }
}
