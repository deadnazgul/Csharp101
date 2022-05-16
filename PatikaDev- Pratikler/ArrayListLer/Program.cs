using System.Collections;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ArrayList liste = new ArrayList();
// liste.Add("Ayşe");
// liste.Add(2);
// liste.Add(true);
// liste.Add('A');

// liste içerisindeki verilere erişim -->
//Console.WriteLine("listenin indexinden erişim --> " + liste[1]);

// foreach(var item in liste){
//     Console.WriteLine(item);
// }
Console.WriteLine();

// AddRange
Console.WriteLine("******  Add Range  ******");
Console.WriteLine();
//string[] renkler = {"kırmızı","sarı","yesil"};
List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
//liste.AddRange(renkler);
liste.AddRange(sayılar);

foreach(var item in liste)
    Console.WriteLine(item);

// Sort
Console.WriteLine();
Console.WriteLine("****** Sort ******");
liste.Sort(); // hata verdiği için yukardaki belli kısımları commente aldık

foreach(var item in liste)
    Console.WriteLine(item);

// Binary Search 
Console.WriteLine("****** Binary Search ******");
Console.WriteLine(liste.BinarySearch(9)); // önce sort kullanılması gerekir sonra elemanın indexini getirir

// Reverse
Console.WriteLine("****** Reverse ******");
liste.Reverse();
foreach(var item in liste)
    Console.WriteLine(item);

// Clear
Console.WriteLine("****** Clear ******");
liste.Clear();

foreach(var item in liste)
    Console.WriteLine(item);