// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* 
 
 dotnet new console



burda .net 5 kullanmışlar bende .net 6 var .net 6 da kodlar namespace falan filan yok buraya yazayim en iyisi:



using System;

namespace console_programlama {

 class Program {

      public static void Main(string[] args) {

  Console.WriteLine("Hello world!");  

Console.WriteLine("İsminizi giriniz: ");

   string name = Console.ReadLine();

   Console.WriteLine("Soy adınızı giriniz: ");

string surname = Console.ReadLine();  

Console.WriteLine("Merhaba "+name+" "+surname);

           }

     }

}



json file gelip "console": "intenalConsole" yazan kısmı -->

integratedTerminal olarak değiştirdik. çünkü Console.ReadLine debug consol dan okuma yapamıyo...



bide externalTerminal var oda dışarda açıyo... consolu

*/
Console.WriteLine("İsminizi giriniz: ");

   string name = Console.ReadLine();

   Console.WriteLine("Soy adınızı giriniz: ");

string surname = Console.ReadLine();  

Console.WriteLine("Merhaba "+name+" "+surname);
