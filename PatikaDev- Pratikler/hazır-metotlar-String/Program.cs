// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string değişken = "Dersimiz C# , Hoşgeldiniz!";
string değişken_2 = "Dersimiz C#";
string değişken_3 = "dersimiz C#";

// Length
Console.WriteLine(değişken.Length + " string değişkenin uzunluğu");

// ToUpper , ToLower
Console.Write("değişkenin hepsi büyük harf --> ");
Console.WriteLine(değişken.ToUpper());
Console.Write("değişkenin hepsi küçük harf --> ");
Console.WriteLine(değişken.ToLower());

// Concat
Console.Write("Concat metodu ile string birleştirme --> ");
Console.WriteLine(String.Concat(değişken," Merhaba!"));

// Compare , CompareTo
Console.Write("CompareTo metodu kullanımı --> ");
Console.WriteLine(değişken.CompareTo(değişken_2)); // 0 , 1 , -1
Console.WriteLine("CompareTo --> Eğer birinci değişken ikinci değişkenle aynı sayıda karakter sayısına sahipse 0 döndürür.");
Console.WriteLine("CompareTo --> Eğer birinci değişken ikinci değişkenden büyük karakter sayısına sahipse 1 döndürür.");
Console.WriteLine("CompareTo --> Eğer birinci değişken ikinci değişkenden küçük karakter sayısına sahipse -1 döndürür.");
// Compare
Console.WriteLine("Compare metodu kullanımı --> ");
Console.WriteLine(String.Compare(değişken_2,değişken_3,true));// büyük küçük harf duyarsız  0 , 1 , -1
Console.WriteLine(String.Compare(değişken_2,değişken_3,false));// büyük küçük harf duyarlı

// Contains
Console.WriteLine("Contains metodu kullanımı -->");
Console.WriteLine(değişken.Contains(değişken_2));
Console.WriteLine(değişken.EndsWith("Hoşgeldiniz!"));
Console.WriteLine(değişken.StartsWith("Merhaba!"));

// IndexOf
Console.WriteLine("IndexOf metodu kullanımı --> ");
Console.WriteLine(değişken.IndexOf("C#"));
Console.WriteLine(değişken.IndexOf("Atakan"));
Console.WriteLine(değişken.LastIndexOf("i"));

// Insert
Console.WriteLine("insert metodu kullanımı --> ");
Console.WriteLine(değişken.Insert(0, "Merhaba! "));

// PadLeft, PadRight;
Console.WriteLine("PadLeft ve PadRight metodu kullanımı --> ");
Console.WriteLine(değişken + değişken_2.PadLeft(30));
Console.WriteLine(değişken + değişken_2.PadLeft(30,'*'));
Console.WriteLine(değişken.PadRight(50) + değişken_2);
Console.WriteLine(değişken.PadRight(50,'-') + değişken_2);

// Remove
Console.WriteLine("remove metodu kullanımı --> ");
Console.WriteLine(değişken.Remove(10));
Console.WriteLine(değişken.Remove(5,3));
Console.WriteLine(değişken.Remove(0,1));

// Replace
Console.WriteLine("replace metodu kullanımı --> ");
Console.WriteLine(değişken.Replace("C#","CSharp"));
Console.WriteLine(değişken.Replace(" ","*"));

// Split
Console.WriteLine("Split metodu kullanımı --> ");
Console.WriteLine(değişken.Split(' ')[1]); // değişken stringini boşluklardan yararlanarak array haline getir ve 1inci indexi yazdır

// Substring
Console.WriteLine("Substring metodu kullanımı --> ");
Console.WriteLine(değişken.Substring(4));
Console.WriteLine(değişken.Substring(4,6)); // 4.üncü indexden başlayarak altı karakter getir


// HACKER RANK     solution       example# 1      https://www.hackerrank.com/challenges/30-exceptions-string-to-integer/problem?isFullScreen=true

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



// class Solution
// {
//     public static void Main(string[] args)
//     {
//         string S = Console.ReadLine();
//         try{
//             var strToint = int.Parse(S);
//             Console.WriteLine(strToint);
            
//         }catch(Exception e){
//             Console.WriteLine("Bad String");
//         }
//     }
// }


// HACKER RANK                   example #2           https://www.hackerrank.com/challenges/30-review-loop/problem?isFullScreen=true

// using System;
// using System.Collections.Generic;
// using System.IO;
// class Solution {
//     static void Main(String[] args) {
//         /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
//         // How many strings will enter?
//         int T = Convert.ToInt32(Console.ReadLine());
//         string[] strArr = new string[T];
//         for(int i = 0; i < strArr.Length; i++){
//             strArr[i] = Console.ReadLine();
//         }
//         //foreach(string item in strArr){
//           //  Console.WriteLine(item);
//         //}
//         foreach(string item in strArr){
//             for(int j = 0; j < item.Length; j++){
//                 if(j % 2 == 0){
//                     Console.Write(item[j]);
//                 }
//             }
//             Console.Write(" ");
//             for(int k = 0; k < item.Length; k++){
//                 if(k % 2 != 0){
//                     Console.Write(item[k]);
//                 }
//             }
//             Console.WriteLine();
//         }
//     }
// }