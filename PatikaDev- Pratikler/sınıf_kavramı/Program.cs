// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Söz dizimi
/*
class SınıfAdı{
    [Erişim Belirleyici] [Veri Tipi] Özellik_Adı;
    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdı([Parametre Listesi]){
        // Metot Komutları
    }
}

--> Erişim Belirleyiciler
    * Public     Her yerden erişilebilir.
    * Private    Sadece tanımlandığı sınıf içerisinden erişilebilir.
    * Internal   Sadece bulunduğu proje içerisinden erişilebilir
    * Protected  Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

*/

Calisan calisan1 = new Calisan();
calisan1.Ad = "Atakan";
calisan1.SoyAd = "uludağ";
calisan1.No = 0497;
calisan1.Departman = "Mühendislik Departmanı";

calisan1.CalisanBilgileri();

Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");

Calisan calisan2 = new Calisan();
calisan2.Ad = "Pınar";
calisan2.SoyAd = "Kapucu";
calisan2.No = 0859;
calisan2.Departman = "Satış Alma";

calisan2.CalisanBilgileri();




class Calisan{
    public string Ad;
    public string SoyAd;
    public int No;
    public string Departman;

    public void CalisanBilgileri(){
        Console.WriteLine("Çalışanın Adı: {0}",Ad);
        Console.WriteLine("Çalışanın Soy adı: {0}",SoyAd);
        Console.WriteLine("Çalışanın Numarası: {0}",No);
        Console.WriteLine("Çalışanın Departmanı: {0}",Departman);
    }
}


// https://www.hackerrank.com/challenges/30-class-vs-instance/problem?isFullScreen=true

// using System;
// using System.Collections.Generic;
// using System.IO;

// class Person {
//     public int age;     
// 	public Person(int initialAge) {
//         // Add some more code to run some checks on initialAge
//         if(initialAge > 0){
//             age = initialAge;
//         }else{
//             Console.WriteLine("Age is not valid, setting age to 0.");
//             age = 0;
//         }
//      }
//      public void amIOld() {
//         // Do some computations in here and print out the correct statement to the console 
//         if(age < 13){
//             Console.WriteLine("You are young.");
//         }else if(age >= 13 && age < 18){
//             Console.WriteLine("You are a teenager.");
//         }else{
//             Console.WriteLine("You are old.");
//         }
//      }

//      public void yearPasses() {
//         // Increment the age of the person in here
//         age += 1;
//      }

// static void Main(String[] args) {
//         int T=int.Parse(Console.In.ReadLine());
//         for (int i = 0; i < T; i++) {
//             int age=int.Parse(Console.In.ReadLine());
//             Person p=new Person(age);
//              p.amIOld();
//                 for (int j = 0; j < 3; j++) {
//                   p.yearPasses();
//                 }
//                 p.amIOld();
//                 Console.WriteLine();
//         }
//     }
// }
