// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* // erişim_belirteci geri_dönüştipi metot_adi(parametreListesi/arguman){
            // komutlar;
            // return; 
//    }

*/

int a = 2;
int b = 3;
Console.WriteLine(a+b+" // direk Console.WriteLine kullanarak yazıldı.");

int sonuc = Topla(a,b);
Console.WriteLine(sonuc+" // Topla fonksiyonu kullanarak yazıldı.");

Metotlar ornek = new Metotlar();
ornek.EkranaYazdır(Convert.ToString(sonuc));

int sonuc2 = ornek.ArttırveTopla(ref a,ref b);
ornek.EkranaYazdır(Convert.ToString(sonuc2+" // arttır ve topla fonksiyonu ile yazıldı"));
ornek.EkranaYazdır(Convert.ToString(a+b+" // referans ile yapınca değerleri global olarak değişir "));


static int Topla(int deger1, int deger2){
     return (deger1+deger2);
}

class Metotlar{
    public void EkranaYazdır(string veri){
        Console.WriteLine(veri+" // Metotlar class'ından Ekrana yazdır fonksiyonu kullanarak yazdırıldı.");
    }
    public int ArttırveTopla(ref int deger1, ref int deger2){
        deger1++;
        deger2++;
        return deger1+deger2;
    }
}

//////////////////////////////////////////// DERS NOTLARI ///////////////////////////////////////////////////////
/* 


Metot Nedir ?
Metotları programı küçük parçalara ayrıştırmak için kullanırız. Büyük bir ii tek bir metot içinde yazmak yerine küçük parçalara ayırarak yazmak daha doğru bir yaklaşımdır.

Bu bizi hem kod tekrarından kurtarır hem de daha okunabilir kod parçaları yazmamızı sağlar. Metotlar tek başlarına kullanılabilen yapılar değildir. Bir sınıf içerisinde yazılmalı ve ancak sınıfın nesnesi aracılığıyla erişilebilir olmalıdır. (Static sınıf metodlarına sinifAdi.metotIsmi şeklinde erişilebilir.)

Söz dizimi ise aşağıdaki gibidir.

	erişim_belirteci geri_donus_tipi metot_adi(argüman/parametre)
	{
		//komutlar;
	}


Yukarıda public erişim tipinde, integer geri dönüş tipine sahip, Topla isminde ve 2 tane integer tipinde parametre alan bir metot tanımı görüyoruz.

Metotlat içerisinde tanımlanan değişkenler sadece metot içerisinden erişilebilirler. Programından başından sonuna kadar yaşamazlar. Metottan çıkıldığından lifetime ı yani yaşam süresi sona erer.

Ref Kullanımı
Bir fonksiyona parametre aktarırken değer veya referans tipinde paramtere verebiliriz.

Değer tipleri metoda bit bit kopyalanır. Yani int bir değişkeni parametre olarak değer tipinde bir fonksiyona verdiğimizde; fonksiyon çalışırken bellekten integer bir değişkeni saklayabilecek kadar yer ayrılır ve gönderilen parametre orda saklanır Fonksiyon içerisinde parametre üzerinde değişiklik yapıldığında ana değişken değişmez. Sadece kopyası üzerinde değişiklik yapılmış olur. Fonksiyon sonlandığındaysa bellekten silinir. Yani yaşam süresi sona erer.
Değer Tiplerini şu şekildedir: int, long, float, double, decimal, char, bool, byte, short, struct, enum

Referans olarak bir atama yapıldığında ise fonksiyona ilgili değişkenin bellekteki adresi gönderilmiş gibi düşünebilirsiniz. Dolayısıyla fonksiyon asıl değişken üzerinde değişiklik yapar. Fonksiyon içerisinde bir değişiklik yapıldığında çağırıldığı yerdeki değişken de değişikliğe uğramış olur. Yani değeri değişir. Bu nedenle ref anahtar kelimesini kullanırken çok dikkatli olunmalıdır.
Ref Kullanımının Özellikleri:

Referans olarak iletilmek istenen değişkenin önüne "ref" yazılmalıdır.
ref olarak metoda verilen değişkenin mutlaka bir başlangıç değeri olmak zorundadır.
Örnek ref kullanımı ise şu şekildedir :

int x = 3;
int y = 4;
int sonuc = instance.ArttırVeTopla(ref x, ref y);

public int ArttırVeTopla (ref int x, ref int y)
{
    x+=1;
    y+=y;
    return (x+y);
}


*/