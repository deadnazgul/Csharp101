using System.Collections;
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

ArrayList sayiListesi = new ArrayList();
int girilenDeger;
int girilecek_deger_sayisi = 20;

for (int i = 1; i <= girilecek_deger_sayisi; i++){
    Console.WriteLine("Sayı " + i + ":");
    try{
        girilenDeger = Int32.Parse(Console.ReadLine());
        if (girilenDeger < 0){
        i--;
        Console.WriteLine("Girilen değer sıfırdan küçük olamaz!");
        Console.WriteLine("Lütfen son değeri tekrar giriniz:");
        }
        sayiListesi.Add(girilenDeger);
        }catch (Exception e){
        Console.WriteLine("Girdiğiniz değer bir sayı olmak zorunda.");
        Console.WriteLine("Girilen değer bir sayı değil lütfen tekrar giriniz: ");
        i--;
    } 
}
ArrayList asalSayılar = new ArrayList();
ArrayList asalOlmayanlar = new ArrayList();
int checkAsalmı = 1;
foreach(int item in sayiListesi){
    if(item == 1)
        asalSayılar.Add(item);
    if(item == 2)
        asalOlmayanlar.Add(item);
    for(int i = 2; i < item; i++){
        checkAsalmı = item % i;
        if(checkAsalmı == 0){
            asalOlmayanlar.Add(item);
            break;
        }else if(checkAsalmı != 0 && i == item-1){
            asalSayılar.Add(item);
        }   
    }
}

// Console.WriteLine("Asal Sayılar: birinci liste");
// foreach(var item in asalSayılar)
//     Console.Write(item + "-->");

// Console.WriteLine();
// Console.WriteLine("Asal olmayan sayılar: ikinci liste");
// foreach(var item in asalOlmayanlar)
//     Console.Write(item + "-->");

Console.WriteLine();
asalSayılar.Sort();
asalSayılar.Reverse();
Console.WriteLine("Büyükten Küçüğe Asal Sayılar Listesi: ");
foreach(var item in asalSayılar)
    Console.Write(item + "-->");

Console.WriteLine();
asalOlmayanlar.Sort();
asalOlmayanlar.Reverse();
Console.WriteLine("Büyükten Küçüğe Asal Olmayan sayılar Listesi: ");
foreach(var item in asalOlmayanlar)
    Console.Write(item + "-->");

Console.WriteLine();
Console.WriteLine("Asal Sayılar Listesinin eleman sayısı: ");
Console.WriteLine(asalSayılar.Count);
Console.WriteLine("Asal Sayılar Listesinin aritmetik ortalaması: ");
int asalOrt = 0;
foreach(int item in asalSayılar)
    asalOrt += item;
asalOrt = asalOrt / asalSayılar.Count;
Console.WriteLine(asalOrt);

Console.WriteLine("Asal olmayan Sayılar Listesinin eleman sayısı: ");
Console.WriteLine(asalOlmayanlar.Count);
Console.WriteLine("Asal Olmayan Sayılar Listesinin aritmetik ortalaması: ");
int asalOlmayanOrt = 0;
foreach(int item in asalOlmayanlar)
    asalOlmayanOrt += item;
asalOlmayanOrt = asalOlmayanOrt / asalOlmayanlar.Count;
Console.WriteLine(asalOlmayanOrt);