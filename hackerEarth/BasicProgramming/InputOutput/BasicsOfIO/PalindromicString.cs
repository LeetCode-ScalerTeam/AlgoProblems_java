/*
You have been given a String S. You need to find and print whether this string is a palindrome or not. 
If yes, print "YES" (without quotes), else print "NO" (without quotes).

Input Format
The first and only line of input contains the String S. 
The String shall consist of lowercase English alphabets only.

Output Format
Print the required answer on a single line.

Constraints: 1 <= S <= 100

Note: String S consists of lowercase English Alphabets only.

SAMPLE INPUT 
aba
SAMPLE OUTPUT 
YES
*/

using System;
using System.Numerics;
class MyClass
{
    static void Main(string[] args)
    {
        string t = Console.ReadLine();
        Console.WriteLine(palindrome(t));
    }

    static string palindrome(string A)
    {
        int i = 0;
        int j = A.Length - 1;
        while (j >= i)
        {
            if (!A[j].Equals(A[i]))
            {
                return "NO";
            }
            i++;
            j--;
        }
        return "YES";
    }
}