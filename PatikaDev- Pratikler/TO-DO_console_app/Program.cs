// See https://aka.ms/new-console-template for more information
// PROJE-2 : Console ToDo Uygulaması
//  proje özellikleri
//Yeni bir console uygulaması açarak bir 3 kolondan oluşan bir TODO uygulaması yazınız.
// Uygulamada olması gereken özellikler aşağıdaki gibidir.
/* 
Kart Ekle
Kart Güncelle
Kart Sil
Kart Taşı
Board Listeleme
*/
/* 
Kart İçeriği:
Baslık
Icerik
Atanan Kisi (Takım üyelerişnden biri olmalı)
Büyüklük (XS, S, M, L, XL)
*/
Islemler islemler = new Islemler();
islemler.Hazır_Kart();
bool runApp = true;
while(runApp){
// Başlangıç ekranı
Console.WriteLine(" ");
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
Console.WriteLine("*******************************************");
Console.WriteLine("(1) Board Listelemek");
Console.WriteLine("(2) Board'a Kart Eklemek");
Console.WriteLine("(3) Board'dan Kart Silmek");
Console.WriteLine("(4) Kart Taşımak");
Console.WriteLine("Çıkış yapmak için 'x' ");

string islem_secimi = Console.ReadLine();

switch(islem_secimi){
    case "1":
        islemler.islem_1_Board_Listele();
        break;
    case "2":
        islemler.islem_2_boarda_Kart_Ekle();
        break;
    case "3":
        islemler.islem_3_boarddan_kart_silmek();
        break;
    case "4":
        islemler.islem_4_kart_tasimak();
        break;
    case "x":
        Console.WriteLine("Çıkış yapılıyor...");
        runApp = false;
        break;
    default:
        Console.WriteLine("Lütfen uygun bir seçim yapınız !");
        runApp = false;
        break;
}
}
