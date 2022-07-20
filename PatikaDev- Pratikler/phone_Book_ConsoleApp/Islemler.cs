// 1'den 5'e kadar seçilen işlemleri burda yaptırcaz

public class Islemler{
    // Önce bi kişi bilgilerini tutmak için bi kolleksiyon kullanalım
    public List<Kisi_Kartı> yeni_Kisi_Listesi = new List<Kisi_Kartı>(); 
    // 1 inci seçimdeki işlemi yapalım kişi ekle -------------------------------------------------------------------------------------------
    public void Kisi_Ekle(Kisi_Kartı yeniKisi){
        yeni_Kisi_Listesi.Add(yeniKisi);
    }
    public void islem_1(){
        Console.WriteLine("Lütfen eklemek istediğiniz kişinin ismini giriniz: ");
        string islem1_isim = Console.ReadLine();
        Console.WriteLine("Lütfen eklemek istediğiniz kişinin soy ismini giriniz:");
        string islem1_soyisim = Console.ReadLine();
        Console.WriteLine("Lütfen eklemek istediğiniz kişinin numarasını giriniz: ");
        string islem1_numara = Console.ReadLine();

        var islem1_Yeni_Kisi = new Kisi_Kartı(islem1_isim,islem1_soyisim,islem1_numara);
        Kisi_Ekle(islem1_Yeni_Kisi);
    }
    // 2 inci seçimdeki işlemi yapalım numara silme------------------------------------------------------------------------------------------------
    public void islem_2(){
        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        string silmek_istenen_kisi = Console.ReadLine();
        listede_Ara_isim(silmek_istenen_kisi);
    }
    public void listede_Ara_isim(string isim_){
        var kisi_isim = yeni_Kisi_Listesi.FirstOrDefault(c => c.Getisim() == isim_);
        if(kisi_isim == null){ // isim yada soy isim olarak listeyi tarasın
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            string secim_1 = Console.ReadLine();
            if(secim_1 == "1"){
                Console.WriteLine("Silme işlemi sonlandırıldı sonra görüşürüz by...");
            }else if(secim_1 == "2"){
                islem_2();
            }else{
                Console.WriteLine("Sadece '1' veya '2' ile seçimini yapabilirsiniz ! çıkış yapılıyor...");
            }
        }else{
            Console.WriteLine("- - - - - - - - - - - -");
            Kisi_Bilgilerini_goster(kisi_isim);
            Console.WriteLine("Bu kayıt silinmek üzere Onaylıyor musunuz? (y/n)");
            string secim_2 = Console.ReadLine();
            if(secim_2 == "y"){
                yeni_Kisi_Listesi.Remove(kisi_isim);
            }else if(secim_2 == "n"){
                Console.WriteLine("İşlem iptal edildi.");
            }else{
                Console.WriteLine("Evet için 'y' hayır için 'n' basınız. çıkış yapılıyor...");
            }
        }
    }
    // 3 üncü seçimdeki işlemi yapalım numara güncelleme-----------------------------------------------------------------------------------------------------
    public void islem_3(){
        Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
        string kisi_güncelleme = Console.ReadLine();
        Listede_Ara_for_Guncelleme(kisi_güncelleme);
    }
    public void Listede_Ara_for_Guncelleme(string güncel_isim){
        var kisi_Guncelle = yeni_Kisi_Listesi.FirstOrDefault(c => c.Getisim() == güncel_isim);
        if(kisi_Guncelle == null){
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
            Console.WriteLine("* Yeniden denemek için              : (2)");
            string secim_3 = Console.ReadLine();
            if(secim_3 == "1"){
                Console.WriteLine("Numara güncelleme işlemi sonlandırıldı. çıkış yapılıyor...");
            }else if(secim_3 == "2"){
                islem_3();
            }else{
                Console.WriteLine("Sadece '1' veya '2' ile seçimini yapabilirsiniz ! çıkış yapılıyor...");
            }
        }else{
            Console.WriteLine("- - - - - - - - - - - -");
            Kisi_Bilgilerini_goster(kisi_Guncelle);
            Console.WriteLine("Bu kayıt güncellenmek üzere Onaylıyor musunuz? (y/n)");
            string secim_3_1 = Console.ReadLine();
            if(secim_3_1 == "y"){
                Console.WriteLine("İsmini güncelle, yeni ismi giriniz: ");
                string yeni_isim = Console.ReadLine();
                kisi_Guncelle.Setisim(yeni_isim);
                Console.WriteLine("Soy ismini güncelle, yeni soy isim: ");
                string yeni_Soyisim = Console.ReadLine();
                kisi_Guncelle.Setsoyisim(yeni_Soyisim);
                Console.WriteLine("Numara güncelle, yeni numara:");
                string yeni_Numara = Console.ReadLine();
                kisi_Guncelle.Setnumara(yeni_Numara);
                Console.WriteLine("- - - - Kisi güncellendi - - - -");
            }else if(secim_3_1 == "n"){
                Console.WriteLine("Kişi güncelleme işlemi iptal edildi.");
            }else{
                Console.WriteLine("Evet için 'y' Hayır için 'n' basınız , çıkış yapılıyor...");
            }
        }
    }
    // 4 üncü seçimdeki işlemi yapalım rehberi listeleme-----------------------------------------------------------------------------------------------------
    private void Kisi_Bilgilerini_goster(Kisi_Kartı kisi_Bilgisi){
        Console.WriteLine("İsim: " + kisi_Bilgisi.Getisim());
        Console.WriteLine("Soy isim: " + kisi_Bilgisi.Getsoyisim());
        Console.WriteLine("Numara: " + kisi_Bilgisi.Getnumara());
    }
    public void islem_4(){
        Console.WriteLine("* * * * Rehber Listesi * * * *");
        Console.WriteLine("Rehberi Listele - A'dan Z'ye için  (1)");
        Console.WriteLine("Rehberi Listele - Z'den A'ya için  (2)");
        //yeni_Kisi_Listesi.OrderBy(o => o.Getisim()).ToList().Sort();
        string secim_4_1 = Console.ReadLine();
        if(secim_4_1 == "1"){
            //List<Order> SortedList = objListOrder.OrderBy(o=>o.OrderDate).ToList(); --> stack overflow yöntemi
            //yeni_Kisi_Listesi.Sort(); --> bu yöntem hata veriyo !
            List<Kisi_Kartı> sirali_Liste = yeni_Kisi_Listesi.OrderBy(o => o.Getisim()).ToList();
            foreach(var kisiler in sirali_Liste){
            Console.WriteLine("- - - - - - - - - -");
            Kisi_Bilgilerini_goster(kisiler);
            }
        }else if(secim_4_1 == "2"){
            List<Kisi_Kartı> liste_tersten = yeni_Kisi_Listesi.OrderBy(o => o.Getisim()).Reverse().ToList();
            foreach(var kisiler_tersten in liste_tersten){
            Console.WriteLine("- - - - - - - - - -");
            Kisi_Bilgilerini_goster(kisiler_tersten);
            }
        }
    }
    // 5 inci seçimdeki işlemi yapalım rehberde arama yapmak--------------------------------------------------------------------------------------------------
    public void islem_5(){
        Console.WriteLine("* * * * Rehberde Arama * * * *");
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("**********************************************");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        string secim_5_1 = Console.ReadLine();
        if(secim_5_1 == "1"){
            Console.WriteLine("İsim yada soy isim giriniz: ");
            string aramakIcin_isim_yada_soyisim = Console.ReadLine();
            Listede_Sadece_Ara_ismeGore(aramakIcin_isim_yada_soyisim);
        }else if(secim_5_1 == "2"){
            Console.WriteLine("Aramak istediğiniz telefon numarasını sunu girin: ");
            string aranan_tel_no = Console.ReadLine();
            Listede_Sadece_Ara_TelefonNo_Gore(aranan_tel_no);
        }
    }
    public void Listede_Sadece_Ara_ismeGore(string girilenIsim_yada_soyisim){
        var kisi_aranan_isim = yeni_Kisi_Listesi.FirstOrDefault(c => c.Getisim() == girilenIsim_yada_soyisim);
        var kisi_aranan_soyisim = yeni_Kisi_Listesi.FirstOrDefault(c => c.Getsoyisim() == girilenIsim_yada_soyisim);
        if(kisi_aranan_isim == null && kisi_aranan_soyisim == null){
            Console.WriteLine("Aradığınız kişi rehberde bulunamadı...");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Tekrar arama yapmak için (1)");
            Console.WriteLine("Çıkmak için              (2)");
            string secim_5_2 = Console.ReadLine();
            if(secim_5_2 == "1"){
                islem_5();
            }else if(secim_5_2 == "2"){
                Console.WriteLine("Çıkış yapılıyor...");
            }else{
                Console.WriteLine("Lütfen sadece '1' ya da '2' seçimini yapınız, çıkış yapılıyor...");
            }
        }else{
            Console.WriteLine("- - - - - - - - - - - -");
            if(kisi_aranan_isim == null){
                Kisi_Bilgilerini_goster(kisi_aranan_soyisim);
            }else if(kisi_aranan_soyisim == null){
                Kisi_Bilgilerini_goster(kisi_aranan_isim);
            }
        }
    }
    public void Listede_Sadece_Ara_TelefonNo_Gore(string telNo){
        var kisi_aranan_Tel_No = yeni_Kisi_Listesi.FirstOrDefault(c => c.Getnumara() == telNo);
        if(kisi_aranan_Tel_No == null){
            Console.WriteLine("Aranan telefon numarası bulunamadı !");
            Console.WriteLine("Tekrar arama yapmak için (1)");
            Console.WriteLine("Çıkmak için              (2)");
            string secim_5_3 = Console.ReadLine();
            if(secim_5_3 == "1"){
                islem_5();
            }else if(secim_5_3 == "2"){
                Console.WriteLine("Çıkış yapılıyor...");
            }else{
                Console.WriteLine("Lütfen sadece '1' ya da '2' seçimini yapınız, çıkış yapılıyor...");
            }
        }else{
            Console.WriteLine("- - - - - - - - - - - -");
            Kisi_Bilgilerini_goster(kisi_aranan_Tel_No);
        }
    }
}