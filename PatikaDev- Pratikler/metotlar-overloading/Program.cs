// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// out parametreler
string sayi = "999";

bool sonuc = int.TryParse(sayi, out int outSayi);
if(sonuc){
    Console.WriteLine("Başarılı!");
    Console.WriteLine(outSayi);
}else{
    Console.WriteLine("Başarısız...!");
}

Metotlar instance = new Metotlar();
instance.Topla(4,5, out int toplamSonucu);
Console.WriteLine(toplamSonucu);

// Metot Aşırı Yükleme - Overloading
int ifade = 333;
instance.EkranaYazdır(Convert.ToString(ifade+" Tostring ile yazıldı."));
instance.EkranaYazdır(ifade + " Metot overloading ile yazıldı.");

// metot imzası
// metotAdı + parametre sayısı + parametre

instance.EkranaYazdır("Atakan ","Furkan");

class Metotlar{
    public void Topla(int a, int b, out int toplam){
        toplam = a + b;
    }
    public void EkranaYazdır(string veri){
        Console.WriteLine(veri);
    }
    public void EkranaYazdır(int veri){
        Console.WriteLine(veri);
    }
    public void EkranaYazdır(String veri1, string veri2){
        Console.WriteLine(veri1 + veri2);
    }
}