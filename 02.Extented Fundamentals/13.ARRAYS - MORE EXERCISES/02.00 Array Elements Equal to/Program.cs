﻿using System;
using System.Linq;
class Program
{
    static void Main() // 100/100
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == i)
            {
                Console.Write(i + " ");
            }
        }
    }
}