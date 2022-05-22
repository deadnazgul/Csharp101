// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

Calisan calisan_1 = new Calisan("atakan","uludağ","Software Developer");
Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);
calisan_1.EkranaYazdir();

//Islemler islemler_1 = new Islemler(); --> static class lar bu şekilde olmaz
// direk ismiyle erişcen...
long toplama = Islemler.Topla(100,200);
long cikarma = Islemler.Cikar(400,50);
Console.WriteLine("Toplama işlemi : --> {0}",toplama);
Console.WriteLine("Çıkarma işlemi : --> {0}",cikarma);



class Calisan{
    public static int calisanSayisi;
    public static int CalisanSayisi{
        get{return calisanSayisi;}
        
    }
    private string Isim;
    private string Soyisim;
    private string Departman;
    static Calisan(){
        calisanSayisi = 0;
    }
    public Calisan(string isim,string soyisim,string departman){
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi++;
    }
    public void EkranaYazdir(){
        Console.WriteLine("İsim : {0}",Isim);
        Console.WriteLine("Soyİsim : {0}",Soyisim);
        Console.WriteLine("Departman: {0}",Departman);
    }
}

static class Islemler{
    public static long Topla(int sayi1,int sayi2){
        return sayi1 + sayi2;
    }
    public static long Cikar(int sayi1,int sayi2){
        return sayi1 - sayi2;
    }
}