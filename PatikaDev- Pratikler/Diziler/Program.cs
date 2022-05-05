// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Dizi tanımlama
string[] renkler = new string[5];

string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

int[] dizi;
dizi = new int[5];
dizi[3] = 10;

//Dizilere değer atama ve erişim
renkler[0] = "Mavi";
Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

// döngüler dizi kullanımı
// klavyeden girilen n tane sayının ortalamasını hesaplayan program
Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayıdizisi = new int[diziUzunlugu];
for (int i = 0; i < diziUzunlugu; i++){
    Console.Write("Lütfen {0}. sayısını giriniz: ", i+1);
    sayıdizisi[i] = int.Parse(Console.ReadLine());
}
int toplam = 0;
foreach(var item in sayıdizisi){
   toplam += item;
}
Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);


// *************** Hacker Rank ******************




/* 





int[] sayilar = new int[10];
sayilar[2] = 12;

string[] renkler = {"Mavi","Kırmızı","Sarı","Yeşil"};

int[] dizi;
dizi = new int[4];

string[] renkler = {"Mavi","Kırmızı","Sarı","Yeşil"};
string renk = renkler[1]; // Kırmızı rengi getirir.

int[] sayiDizisi = new int[20];
int toplam = 0;
for (int i = 0; i < sayiDizisi.Length; i++)
  {
    Console.Write("Lütfen {0}. sayıyı girin:", i+1);
    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
    toplam += sayiDizisi[i];
  }
double ortalama = toplam / 20;

Console.WriteLine("Sayıların ortalaması: " + ortalama);
Console.ReadLine();





  */



  //=========================================================================================================
  // MY WRONG CODE FOR TEST HACKERRANK
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
     * Complete the 'plusMinus' function below.
     *just six decimal places // STACKOVERFLOW INFO
         String.Format("{0:0.00}", 123.4567);      // "123.46"
         String.Format("{0:0.00}", 123.4);         // "123.40"
         String.Format("{0:0.00}", 123.0);         // "123.00"
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
     
/*
    public static void plusMinus(List<int> arr)
    {
        int posNums=0,negNums=0,zeroS=0;
        foreach(var item in arr){
            if(item < 0){
                negNums++;
            }else if(item > 0){
                posNums++;
            }else{
                zeroS++;
            }
        }
        var ratioOfpos = posNums / ;
        var ratioOfneg = negNums / arr.Length;
        var ratioOfzeroS = zeroS / arr.Length;
        
        Console.WriteLine(String.Format("{0:0.000000}",ratioOfpos));
        Console.WriteLine(String.Format("{0:0.000000}",ratioOfneg));
        Console.WriteLine(String.Format("{0:0.000000}",ratioOfzeroS));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int[] myArr = new int[n];
        
        for(int i = 0; i < myArr.Length; i++){
            myArr[i] = int.Parse(Console.ReadLine());
        }
        
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

  
  */




  //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&  SUCCESS CODE**
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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     

    public static void plusMinus(List<int> arr)
    {
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;
        foreach(var item in arr){
            if(item < 0){
                negativeCount++;
            }else if(item > 0){
                positiveCount++;
            }else{
                zeroCount++;
            }
        }
        float arrLength = arr.Count;
        //Console.WriteLine(arrLength);
    
        Console.WriteLine(String.Format("{0:0.000000}",positiveCount/arrLength));
        Console.WriteLine(String.Format("{0:0.000000}",negativeCount/arrLength));
        Console.WriteLine(String.Format("{0:0.000000}",zeroCount/arrLength));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

  
  */