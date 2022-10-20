// Created by: Ashley Monaghan
// Created on: Oct 2022
//
// This program calculates the 

using System;

class Program 
{
    public static void Main(string[] args)
    {
        //This function accepts user input
        decimal hours;
        decimal rate;
        decimal pay;
        decimal tax;

        const Decimal Tax_Rate = (Decimal)0.18;
        const Decimal Full_Rate = (Decimal)1;

        Console.WriteLine("This program calculates the total pay and the pay minus tax");
        Console.WriteLine(" ");

        Console.WriteLine("Please enter your employment information: ");
        Console.Write("Number of hours worked: ");
        hours = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Hourly rate: $");
        rate = Convert.ToDecimal(Console.ReadLine());

        pay = (hours * rate) * (Full_Rate - Tax_Rate);
        tax = (hours * rate) * Tax_Rate;

        Console.WriteLine(" ");
        Console.WriteLine("Your pay will be: $" + pay.ToString("0.00"));
        Console.WriteLine("The goverment will take: $" + tax.ToString("0.00"));

        Console.WriteLine("\nDone.");
        
    }    
}