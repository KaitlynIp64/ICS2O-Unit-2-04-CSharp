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
        int Base;
        int Height;

        Console.WriteLine("This program calculates the area of a triangle.");
        Console.WriteLine("");
        Console.Write("Enter the base (cm): ");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        Height = Convert.ToInt32(Console.ReadLine());

        Double Area = (Base * Height) /2 ;

        Console.WriteLine("");
        Console.Write("Area of the triangle = " + Area + " cm²");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}