// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(DateTime.Now); // günün tarihini getirir
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(10));
Console.WriteLine(DateTime.Now.AddMilliseconds(50));

// Date time Format 

Console.WriteLine(DateTime.Now.ToString("dd")); // 24
Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat
Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

Console.WriteLine(DateTime.Now.ToString("MM")); // 04
Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
Console.WriteLine(DateTime.Now.ToString("MMMM")); // April

Console.WriteLine(DateTime.Now.ToString("yy")); // 21
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021

Console.WriteLine("****    Math Kütüphanesi    ****");
// Math Kütüphanesi
Console.WriteLine(Math.Abs(-25)); // 25
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(10));

Console.WriteLine(Math.Ceiling(22.3)); // 23
Console.WriteLine(Math.Round(22.3)); //22
Console.WriteLine(Math.Round(22.7)); // 23
Console.WriteLine(Math.Floor(22.7)); // 22

Console.WriteLine(Math.Max(2,6));
Console.WriteLine(Math.Min(2,6));

Console.WriteLine(Math.Pow(3,4)); // 3^4 ü verir. 81.
Console.WriteLine(Math.Sqrt(9)); // karekök alır. 3.
Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logaritmik karşılığını getirir
Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir.
Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı

// https://www.hackerrank.com/challenges/30-more-exceptions/problem?isFullScreen=true

// First Solution....

//Write your code here
// class Calculator
// {
//     public int power(int n, int p)
//     {
//         if (n < 0 || p < 0)
//             throw new Exception("n and p should be non-negative");
//         return (int)Math.Pow(n, p);
//     }
// }

// SEcond Solution...

// using System;

// //Write your code here
// class Calculator{
//      public int power(int var1, int var2){
//         int powOfNum = 1;
//         if(var1 > 0 && var2 > 0){
//             for(int i = 0; i < var2; i++){
//                 powOfNum *= var1;
//             }
//              return powOfNum;
//         }else{
//             throw new Exception("n and p should be non-negative");
//         }  
//     }
// }
// class Solution{
//     static void Main(String[] args){
//         Calculator myCalculator=new  Calculator();
//         int T=Int32.Parse(Console.ReadLine());
//         while(T-->0){
//             string[] num = Console.ReadLine().Split();
//             int n = int.Parse(num[0]);
//             int p = int.Parse(num[1]); 
//             try{
//                 int ans=myCalculator.power(n,p);
//                 Console.WriteLine(ans);
//             }
//             catch(Exception e){
//                Console.WriteLine(e.Message);

//             }
//         }
        
        
        
//     }
// }



//  https://www.hackerrank.com/challenges/time-conversion/problem?isFullScreen=true

// using System.CodeDom.Compiler;
// using System.Collections.Generic;
// using System.Collections;
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.IO;
// using System.Linq;
// using System.Reflection;
// using System.Runtime.Serialization;
// using System.Text.RegularExpressions;
// using System.Text;
// using System;

// class Result
// {

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */
     
     /* 
     
     class Solution
{
    static void Main(String[] args){
        var time = ReadLine();
        var amOrPm = time.Substring(8);
        var hourComponent = time.Substring(0, 2);
        var remainingTimeComponent = time.Substring(2, 6);
        if (amOrPm == "AM" && hourComponent == "12"){
            hourComponent = "00";
        }else if (amOrPm == "PM"){
            var numericHourComponent = int.Parse(hourComponent);
            if (numericHourComponent != 12){
                hourComponent = Convert.ToString(12 + numericHourComponent);
            }
        }
        WriteLine(hourComponent + remainingTimeComponent);
    }
}
     
     */

//     public static string timeConversion(string s)
//     {
//        var amOrPm = s.Substring(8);
//        var hourComponent = s.Substring(0,2);
//        var remainingTimeComponent = s.Substring(2,6);
//        if(amOrPm == "AM" && hourComponent == "12"){
//            hourComponent = "00";
//        }else if(amOrPm == "PM"){
//            var numericHourComponent = int.Parse(hourComponent);
//            if(numericHourComponent != 12){
//                hourComponent = Convert.ToString(12 + numericHourComponent);
//            }
//        }
//        return hourComponent + remainingTimeComponent;
//     }

// }

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         string s = Console.ReadLine();

//         string result = Result.timeConversion(s);

//         textWriter.WriteLine(result);

//         textWriter.Flush();
//         textWriter.Close();
//     }
// }
