// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// .Net Version 6.0.200

// Patika Dev C# 101 operatörler project

Console.WriteLine("C#101 operatörler: ");
Console.WriteLine("Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)\nMantıksal Operatörler (||, &&, !) \nİlişkisel Operatörler (==,!=, <, >, >=,<=)\nAritmetik (+, -, *, /, %, ++, --) ");
Console.WriteLine();
Console.WriteLine("HackerRank DAY:02 operators: ");
Console.WriteLine("find and print the meal's total cost. Round the result to the nearest integer.");

// Inputs 
double mealCost = Convert.ToDouble(Console.ReadLine());
int tipPercent = Convert.ToInt32(Console.ReadLine());
int taxPercent = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
mealCost = mealCost + mealCost*tipPercent/100;
mealCost = mealCost + mealCost*taxPercent/100;
Console.WriteLine("Deneme :");
var decision = mealCost % Math.Floor(mealCost);
Console.WriteLine("decision == " + decision);
var roundedmealCost = mealCost;
if(decision > 0.59){
    roundedmealCost = Math.Round(mealCost);
    Console.WriteLine(roundedmealCost);
}else{
    roundedmealCost = Math.Floor(mealCost);
    Console.WriteLine(roundedmealCost);
}




//----------------------------------------------------------------------------------------
// HACKER RANK EXERCISI VERSION
/*

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */
/*
    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        meal_cost = meal_cost + meal_cost*tip_percent/100;
        meal_cost = meal_cost + meal_cost*tax_percent/100;
        var roundedmealCost = Math.Round(meal_cost)-1;
        Console.WriteLine(roundedmealCost);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        Result.solve(meal_cost, tip_percent, tax_percent);
    }
}


*/
