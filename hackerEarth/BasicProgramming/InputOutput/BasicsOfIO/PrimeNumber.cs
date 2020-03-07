/*
You are given an integer N. You need to print the series of all prime numbers till N.

Input Format: 
The first and only line of the input contains a single integer N denoting the number till where you need to find the series of prime number.

Output Format: 
Print the desired output in single line separated by spaces.

-- Constraints --
1<=N<=1000

SAMPLE INPUT: 9
SAMPLE OUTPUT: 2 3 5 7
*/
using System;
using System.Numerics;
class MyClass
{
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        printPrime(N);
    }

    static void printPrime(int N)
    {
        for (int i = 2; i <= N; i++)
        {
            if (checkPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    static bool checkPrime(int isPrime)
    {
        if (isPrime <= 1)
        {
            return false;
        }
        for (int i = 2; i < isPrime; i++)
        {
            if (isPrime % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}