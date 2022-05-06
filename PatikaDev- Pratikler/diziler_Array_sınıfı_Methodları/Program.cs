// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* 
*Normalde şu sekilde başlıo

using System;
namespace diziler_array_sınıfı_metotları{
    class Program{
        static void Main(string[] args){

        }
    }
}

*/

int[] sayıDizisi = {23,12,4,86,72,3,11,17};
Console.WriteLine("**** Sırasız Dizi ****");
foreach(var sayı in sayıDizisi){
    Console.Write(" "+sayı+",");
}
Console.WriteLine();
// Array sort
Console.WriteLine("**** Sıralı Dizi ****");
Array.Sort(sayıDizisi);
foreach(var sayı in sayıDizisi){
    Console.Write(" "+sayı+",");
}
Console.WriteLine();
// Clear
Console.WriteLine("**** Array Clear ****");
// sayıDizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elemanı 0'lar.
Array.Clear(sayıDizisi,2,2);
foreach(var sayı in sayıDizisi){
    Console.Write(" "+sayı+",");
}
Console.WriteLine();
// Reverse
Console.WriteLine("**** Array Reverse ****");
Array.Reverse(sayıDizisi);
foreach(var sayı in sayıDizisi){
    Console.Write(" "+sayı+",");
}
Console.WriteLine();
// IndexOf
Console.WriteLine("**** Array IndexOf ****");
Console.WriteLine(Array.IndexOf(sayıDizisi,23));

// Resize
Console.WriteLine("**** Array Resize ****");
Array.Resize<int>(ref sayıDizisi,9);
sayıDizisi[8] = 99;
foreach(var sayı in sayıDizisi){
    Console.Write(" "+sayı+",");
}
Console.WriteLine();