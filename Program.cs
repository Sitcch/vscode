﻿using System;

class Program
{
    static void Main(string[] args)
    {
        // CONVERT POUNS TO KILOGRAMS
        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double kilograms = pounds * 0.453592;
        Console.WriteLine($"Weight in pounds: {pounds}");
        Console.WriteLine($"Weight in kilograms: {kilograms}");
        
        Console.WriteLine("========================================");
        
        // CONVERT MILES TO KILOMETERS
        Console.Write("Enter distance in miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        double kilometers = miles * 1.60934;
        Console.WriteLine($"Distance in miles: {miles}");
        Console.WriteLine($"Distance in kilometers: {kilometers}");

        Console.WriteLine("========================================");
        
        // CONVERT FAHRENHEIT TO CELSIUS
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
        Console.WriteLine($"Temperature in Celsius: {celsius}");

        Console.WriteLine("========================================");
        
        // CALCULATE AVERAGE AGE OF STUDENTS
        
        int[] ages = new int[10];
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter the age of student {i+1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            sum += ages[i];
        }

        double averageAge = (double)sum / 10;

        Console.WriteLine("Ages of all students:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Student {i+1}: {ages[i]} years old");
        }
        Console.WriteLine($"Average age of students: {averageAge}");

        Console.WriteLine("=============================================================");
        
        // Fantasy story
        string character1 = "Eleanor";
        string character2 = "Gideon";
        string character3 = "Aria";
        string character4 = "Landon";
        string character5 = "Seraphina";
        string equipment = "Sword of Destiny";
        string item = "Amulet of Power";
        string ability = "Elemental Manipulation";

        Console.WriteLine("Once upon a time, in the mystical land of Eldoria...");
        Console.WriteLine($"There lived five brave adventurers: {character1}, {character2}, {character3}, {character4}, and {character5}.");
        Console.WriteLine($"Armed with their trusty {equipment}, they embarked on a quest to find the legendary {item}.");
        Console.WriteLine($"Little did they know, their journey would test their {ability} and push them to their limits.");
        Console.WriteLine("Will they succeed in their quest and bring peace to Eldoria? Only time will tell...");

        Console.ReadLine();
    
        }
}