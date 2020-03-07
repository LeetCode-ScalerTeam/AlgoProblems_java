/*
Given two strings, a and b , that may or may not be of the same length, 
determine the minimum number of character deletions required to make a and b anagrams.
Any characters can be deleted from either of the strings.

Input :
test cases, t
two strings a and b, for each test case

Output:
Desired O/p

Constraints :
string lengths<=10000

Note :
Anagram of a word is formed by rearranging the letters of the word.

For e.g. -> For the word RAM - MAR, ARM, AMR, RMA etc. are few anagrams.

SAMPLE INPUT 
1
cde
abc

SAMPLE OUTPUT 
4
*/

using System;
using System.Numerics;
class MyClass
{
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(anagrams(a, b));
        }
    }
    static int anagrams(string A, string B)
    {
        int result = 0;
        int[] a = new int[26];
        int[] b = new int[26];
        for (int i = 0; i < A.Length; i++)
        {
            a[A[i] - 'a']++;
        }
        for (int i = 0; i < B.Length; i++)
        {
            b[B[i] - 'a']++;
        }
        for (int i = 0; i < 26; i++)
        {
            if ((a[i] > b[i]) || (b[i] > a[i]))
            {
                result = result + Math.Abs(a[i] - b[i]);
            }
        }
        return result;
    }
}