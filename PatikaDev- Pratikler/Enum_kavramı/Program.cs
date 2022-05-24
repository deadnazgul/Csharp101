// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
"enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir.
Sayısal verilerı string ifadelerle saklamanızı sağlar. 
Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.
*/

Console.WriteLine(Günler.Pazar);
Console.WriteLine("Cumartesi Haftanın "+(int)Günler.Cumartesi+" ıncı günüdür."); // enum int değeri

//int sicaklik = 32;// 32 santigrat derece
int sicaklik = 24;

if(sicaklik <= (int)Hava_Durumu.normal)
    Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
else if(sicaklik >= (int)Hava_Durumu.Çok_sıcak)
    Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün!");
else if(sicaklik >= (int)Hava_Durumu.normal && sicaklik <= (int)Hava_Durumu.sıcak)
    Console.WriteLine("Hadi dışarıya çıkalım!");


enum Günler{ // enum lar sırayla değer alarak gider...
    Pazartesi = 1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum Hava_Durumu{
    Çok_Soğuk = -5,
    Soğuk = 5,
    normal = 20,
    sıcak = 25,
    Çok_sıcak = 30
}