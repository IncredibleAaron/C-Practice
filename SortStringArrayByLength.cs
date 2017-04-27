/************************************
Description:

Write a function that takes an array of strings as an argument and returns a sorted array containing the same strings,
ordered from shortest to longest.

For example, if this array were passed as an argument:

["Telescopes", "Glasses", "Eyes", "Monocles"]

Your function would return the following array:

["Eyes", "Glasses", "Monocles", "Telescopes"]

All of the strings in the array passed to your function will be different lengths, 
so you will not have to decide how to order multiple strings of the same length.
************************************/
using System;

public class Program
{
    static void Main(String[] args)
    {
        string[] array = new string[] { "Short", "Longer", "Longest" };
        string[] ans = new string[array.Length];

        int[] keys = new int[array.Length];
        int[] values = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            keys[i] = i;
            values[i] = array[i].Length;
        }
        //This method is good. 
        Array.Sort(values, keys);

        for(int i=0;i < array.Length;i++)
        {
            ans[i] = array[keys[i]];
        }

        foreach (string i in ans)
        {
            Console.WriteLine(i);
        }




            /*============================================*/
            Console.WriteLine("Please press enter:");
        Console.ReadLine();
    }
