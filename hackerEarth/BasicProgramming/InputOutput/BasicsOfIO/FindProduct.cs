/*
You have been given an array A of size N consisting of positive integers. 
You need to find and print the product of all the number in this array Modulo 10^9 + 7.

Input Format:
The first line contains a single integer N denoting the size of the array. 
The next line contains N space separated integers denoting the elements of the array

Output Format:
Print a single integer denoting the product of all the elements of the array Modulo 10^9 + 7.

Constraints:
1 <= N <= 10^3
1 <= A[i] <= 10^3


SAMPLE INPUT 
5
1 2 3 4 5

SAMPLE OUTPUT 
120

Explanation
There are 5 integers to multiply. 
Let's store the final answer in ans variable. 
Since 1 is identity value for multiplication, initialize ans as 1.

So the process goes as follows:

ans = 1
ans = (ans * 1) % (10^9 + 7)
ans = (ans * 2) % (10^9 + 7)
ans = (ans * 3) % (10^9 + 7)
ans = (ans * 4) % (10^9 + 7)
ans = (ans * 5) % (10^9 + 7)

The above process will yield answer as 120
*/

using System;
using System.Numerics;
class MyClass
{
    static void Main(string[] args)
    {
        int arrayLength = int.Parse(Console.ReadLine());
        var inputArray = Console.ReadLine().Split(' ');
        int[] intArray = new int[arrayLength];
        for (int i = 0; i < inputArray.Length; i++)
        {
            intArray[i] = int.Parse(inputArray[i]);
        }
        Console.WriteLine(findProduct(intArray));
    }

    static double findProduct(int[] intArray)
    {
        double result = 1;
        double constant = (Math.Pow(10, 9) + 7);
        foreach (int input in intArray)
        {
            result = (result * input) % constant;
        }
        return result;
    }
}