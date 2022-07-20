// See https://aka.ms/new-console-template for more information
// * * * * * * * Console da Rehber uygulaması * * * * * * * * *

/* 
Yeni bir console uygulaması açarak telefon rehberi uygulaması yazınız. Uygulamada olması gereken özellikler aşağıdaki gibidir.
Telefon Numarası Kaydet
Telefon Numarası Sil
Telefon Numarası Güncelle --> eğer rehberde aynı kriterlere uygun birden fazla kişi bulunursa ilk bulunan silinmeli
Rehber Listeleme (A-Z, Z-A seçimli)
Rehberde Arama
*/

bool runApp = true; // uygulamanın sürekli çalışması için
Islemler islemler_ = new Islemler();
// hali hazırda rehbere 5 kişi ekliyelim...
        var hazirKisi_1 = new Kisi_Kartı("Darth ", "Vader", "05359200843");
        var hazirKisi_2 = new Kisi_Kartı("Ak","Gandalf","05310313169");
        var hazirKisi_3 = new Kisi_Kartı("Hermony","Grencır","05324567896");
        var hazirKisi_4 = new Kisi_Kartı("Recep","İvedik","05990108675");
        var hazirKisi_5 = new Kisi_Kartı("Dweyn","Cansın","05001504209");
        islemler_.Kisi_Ekle(hazirKisi_1);
        islemler_.Kisi_Ekle(hazirKisi_2);
        islemler_.Kisi_Ekle(hazirKisi_3);
        islemler_.Kisi_Ekle(hazirKisi_4);
        islemler_.Kisi_Ekle(hazirKisi_5);
while(runApp){
    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
    Console.WriteLine("* * * Merhaba, Console Telefon Rehberi Uygulamasına hos geldiniz * * *");
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
    Console.WriteLine("*******************************************");
    Console.WriteLine("(1) Yeni Numara Kaydetmek");
    Console.WriteLine("(2) Varolan Numarayı Silmek");
    Console.WriteLine("(3) Varolan Numarayı Güncelleme");
    Console.WriteLine("(4) Rehberi Listelemek");
    Console.WriteLine("(5) Rehberde Arama Yapmak");
    Console.WriteLine("Çıkmak için 'x' tuşuna basınız...");
    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
    
    string kullanici_girisi = Console.ReadLine();
    switch(kullanici_girisi){
        case "1":
            islemler_.islem_1();
            break;
        case "2":
            islemler_.islem_2();
            break;
        case "3":
            islemler_.islem_3();
            break;
        case "4":
            islemler_.islem_4();
            break;
        case "5":
            islemler_.islem_5();
            break;
        case "x":
            runApp = false;
            Console.WriteLine("Programdan çıkış yapılıyor bye bye... :3");
            break;
        default:
            runApp = false;
            Console.WriteLine("Seçeneklerde olmayan bir işlem seçtiniz çıkış yapılıyor bye bye! :D");
            break;
    }
}