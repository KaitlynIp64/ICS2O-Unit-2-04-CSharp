// Created by: Kaitlyn Ip
// Created on: Mar 2022
//
// This program finds the area and perimeter of a triangle
using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int length;
        int height;

        Console.WriteLine("This program calculates the area of a triangle.");
        Console.WriteLine("");
        Console.Write("Enter the length (mm): ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height (mm): ");
        height = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("");
        Console.WriteLine("Area:  ");

        Console.WriteLine("\nDone.");
    }
}