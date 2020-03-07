/*
https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/seating-arrangement-1/

Akash and Vishal are quite fond of travelling. They mostly travel by railways. 
They were travelling in a train one day and they got interested in the seating arrangement of their compartment. 
The compartment looked something like

6   7  || 18   19 || 30    and so on. 
5   8  || 17   20 || 29    and so on. 
4   9  || 16   21 || 28    and so on. 

3   10 || 15   22 || 27    and so on. 
2   11 || 14   23 || 26    and so on. 
1   12 || 13   24 || 25    and so on. 

So they got interested to know the seat number facing them and the seat type facing them. 
The seats are denoted as follows :

Window Seat : WS
Middle Seat : MS
Aisle Seat : AS

You will be given a seat number, find out the seat number facing you and the seat type, i.e. WS, MS or AS.

INPUT
First line of input will consist of a single integer T denoting number of test-cases. 
Each test-case consists of a single integer N denoting the seat-number.

OUTPUT
For each test case, print the facing seat-number and the seat-type, separated by a single space in a new line.

CONSTRAINTS
1<=T<=105
1<=N<=108

SAMPLE INPUT 
2
18
40

SAMPLE OUTPUT 
19 WS
45 AS

*/

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
class MyClass
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());
        for (int i = 0; i < testCases; i++)
        {
            int[] windowSeat = new int[] { 1, 6, 7, 12 };
            int[] middleSeat = new int[] { 2, 5, 8, 11 };
            int seatNumber = int.Parse(Console.ReadLine());
            int f = seatNumber / 12;
            int of = seatNumber % 12;
            if (of == 0)
            {
                f -= 1;
                of = 12;
            }
            int op = f * 12 + 13 - of;
            if (windowSeat.Contains(of))
            {
                Console.Write(op + " " + "WS");
                Console.Write("\n");
            }
            else if (middleSeat.Contains(of))
            {
                Console.Write(op + " " + "MS");
                Console.Write("\n");
            }
            else
            {
                Console.Write(op + " " + "AS");
                Console.Write("\n");
            }
        }
    }
}