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
Console.WriteLine("******** Çalışan 1 ********");
Calisan calisan1 = new Calisan();
// Yol 1#
calisan1.Ad = "Atakan";
calisan1.SoyAd = "uludağ";
calisan1.No = 0497;
calisan1.Departman = "Mühendislik Departmanı";

calisan1.CalisanBilgileri();
Console.WriteLine();

Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
Console.WriteLine("******** Çalışan 2 ********");
Calisan calisan2 = new Calisan("Pınar","Kapucu",0859,"Satış Alma");
// Yol 2#
// calisan2.Ad = "Pınar";
// calisan2.SoyAd = "Kapucu";
// calisan2.No = 0859;
// calisan2.Departman = "Satış Alma";
calisan2.CalisanBilgileri();

Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
Console.WriteLine("******** Çalışan 3 ********");
Calisan calisan3 = new Calisan("Furkan","uludağ");
calisan3.CalisanBilgileri();



class Calisan{
    public string Ad;
    public string SoyAd;
    public int No;
    public string Departman;

    // Constructor here
    public Calisan(string ad, string soyad, int no, string departman){
        this.Ad = ad;
        this.SoyAd = soyad;
        this.No = no;
        this.Departman = departman;
    }
    // Constructor overloading
    public Calisan(){

    }

    public Calisan(string ad, string soyad){
        this.Ad = ad;
        this.SoyAd = soyad;
        // diğer değerleri otomatik set ediyor booleansa --> false stringse --> null intse --> 0
    }

    public void CalisanBilgileri(){
        Console.WriteLine("Çalışanın Adı: {0}",Ad);
        Console.WriteLine("Çalışanın Soy adı: {0}",SoyAd);
        Console.WriteLine("Çalışanın Numarası: {0}",No);
        Console.WriteLine("Çalışanın Departmanı: {0}",Departman);
    }
}
