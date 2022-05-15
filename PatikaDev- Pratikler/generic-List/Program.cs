using System.Collections.Generic;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* 
Normalde olması gereken...

 namespace  generic_list{
     class Program{
         static void Main(string[] args){
             .
             .
             .
         }
     }
 }
*/

// List<T> class
// System.Collections.Generic
// T --> object türündedir

List<int> sayiListesi = new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);

List<string> renkListesi = new List<string>();
renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("sarı");
renkListesi.Add("Yeşil");

// Count --> eleman sayısını yazdırır
Console.WriteLine(renkListesi.Count + " = renk listesinin eleman sayısı.");
Console.WriteLine(sayiListesi.Count + " = sayı listesinin eleman sayısı.");

// Foreach ve List.ForEach ile elemanlara erişim
foreach(var sayi in sayiListesi)
    Console.Write(sayi + " ");

Console.WriteLine();

foreach(var renk in renkListesi)
    Console.Write(renk + " ");

Console.WriteLine(" \n Yada Şu şekildede kullanılabilir...");
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

// Listeden eleman çıkarma
sayiListesi.Remove(4);
renkListesi.Remove("Yeşil");
Console.WriteLine("Listeden eleman çıkarma --> ");
sayiListesi.ForEach(sayi => Console.Write(sayi + " "));
Console.WriteLine(" -- Sayı Listesinden - 4 - rakamını çıkardık.");
renkListesi.ForEach(renk => Console.Write(renk + " "));
Console.WriteLine(" -- Renk Listesinden - Yeşi - 'i çıkardık.");

// diğer yol index ile remove etme
sayiListesi.RemoveAt(0);
sayiListesi.ForEach(sayi => Console.Write(sayi + " "));
Console.WriteLine(" -- Sayı listesinin '0' indexindeki elemanı çıkardık.");
renkListesi.RemoveAt(1);
renkListesi.ForEach(renk => Console.Write(renk + " "));
Console.WriteLine(" -- Renk listesinin '1' indexindeki elemanı çıkardık.");

// Liste içerisinde Arama
if(sayiListesi.Contains(10))
    Console.WriteLine("10 Liste içerisinde bulundu!");
// Eleman ile index'e erişme
Console.WriteLine(renkListesi.BinarySearch("Sarı"));

// Diziyi List'e çevirme
string[] hayvanlar = {"Kedi","Köpek","Kuş"};
List<string> hayvanListesi = new List<string>(hayvanlar);

// Listeyi nasıl temizleriz?
hayvanListesi.Clear();

// Liste içerisinde Nesne Tutmak
List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

Kullanıcılar kullanıcı_1 = new Kullanıcılar();
kullanıcı_1.Isim = "Ayşe";
kullanıcı_1.Soyisim = "Yılmaz";
kullanıcı_1.Yas = 26;

kullanıcıListesi.Add(kullanıcı_1);

Kullanıcılar kullanıcı_2 = new Kullanıcılar();
kullanıcı_2.Isim = "Atakan";
kullanıcı_2.Soyisim = "uludağ";
kullanıcı_2.Yas = 26;

kullanıcıListesi.Add(kullanıcı_2);

List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

yeniListe.Add(new Kullanıcılar(){
    Isim = "Deniz",
    Soyisim = "Arda",
    Yas = 24
});

foreach(var kullanıcı in kullanıcıListesi){
    Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim);
    Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim);
    Console.WriteLine("Kullanıcı yas: " + kullanıcı.Yas);
}

foreach(var yeniKullanıcı in yeniListe){
    Console.WriteLine("Kullanıcı Adı: " + yeniKullanıcı.Isim);
    Console.WriteLine("Kullanıcı SoyAdı: " + yeniKullanıcı.Soyisim);
    Console.WriteLine("Kullanıcı yas: " + yeniKullanıcı.Yas);
}






public class Kullanıcılar{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim{
        get => isim;
        set => isim = value;
    }
    public string Soyisim{
        get => soyisim;
        set => soyisim = value;
    }
    public int Yas{
        get => yas;
        set => yas = value;
    }
}