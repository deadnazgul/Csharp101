public class Islemler{
    //Kart_icerigi kart_obj = new Kart_icerigi();
    Dictionary<int,string> takim_uyeleri = new Dictionary<int, string>();
    // To-Do kart Listesi
    List<Kart_icerigi> todo_List = new List<Kart_icerigi>();
    // In-Progress Listesi
    List<Kart_icerigi> in_Progress_List = new List<Kart_icerigi>();
    // Done ! Listesi
    List<Kart_icerigi> done_List = new List<Kart_icerigi>();
    /*
    Varsayılan olarak bir board tanımlı olmalı ve 3 tane de kart barındırmalı.
    (Kartlar herhangi bir line'da yani kolonda olabilir.)
    */
    public void Hazır_Kart(){
        // TAkımdaki kişiler varsayılan olarak atanıyor...
        takim_uyeleri.Add(001,"Necati");
        takim_uyeleri.Add(002,"Necmi");
        takim_uyeleri.Add(003,"Nusret");
        var hazir_Kart_1 = new Kart_icerigi("belgesel izle","uzay belgeseli",takim_uyeleri.ElementAt(0).Value,Kart_icerigi.buyukluk.XS);
        var hazir_Kart_2 = new Kart_icerigi("yapay zeka","makina öğrenmesi",takim_uyeleri.ElementAt(1).Value,Kart_icerigi.buyukluk.S);
        var hazir_Kart_3 = new Kart_icerigi("Gastronomi","Etli yemek",takim_uyeleri.ElementAt(2).Value,Kart_icerigi.buyukluk.M);
        todo_List.Add(hazir_Kart_1);
        in_Progress_List.Add(hazir_Kart_2);
        done_List.Add(hazir_Kart_3);
    }
    // işlem (1) Board Listelemek- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    public void Kart_Bilgileri(Kart_icerigi icerik){
            Console.WriteLine("- - -");
            Console.WriteLine("Başlık      : " + icerik.Get_Baslık());
            Console.WriteLine("İçerik      : " + icerik.Get_Icerik());
            Console.WriteLine("Atanan Kişi : " + icerik.Get_AtananKisi());
            Console.WriteLine("Büyüklük    : " + icerik.Get_buyukluk_degeri());
    }
    public void TODO_Line(){
        Console.WriteLine("- - - - - - - - - -");
            Console.WriteLine("TODO LİNE");
            Console.WriteLine("************************");
        for(int i = 0; i < todo_List.Count; i++){
            Kart_Bilgileri(todo_List[i]);
        }
    }
    public void IN_PROGRESS_Line(){
        Console.WriteLine("- - - - - - - - - -");
        Console.WriteLine("IN PROGRESS LINE");
        Console.WriteLine("************************");
        for(int j = 0; j < in_Progress_List.Count; j++){
            Kart_Bilgileri(in_Progress_List[j]);
        }
    }
    public void Done_Line(){
        Console.WriteLine("- - - - - - - - - -");
        Console.WriteLine("DONE LINE");
        Console.WriteLine("************************");
        for(int k = 0; k < done_List.Count; k++){
            Kart_Bilgileri(done_List[k]);
        } 
    }
    public void islem_1_Board_Listele(){
        TODO_Line();
        IN_PROGRESS_Line();
        Done_Line();
    }
    // işlem (2) Board'a kart eklemek- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    public void islem_2_boarda_Kart_Ekle(){
        Console.WriteLine("Hangi LINE'a kart eklemek istersiniz ? ");
        Console.WriteLine("-> TO-DO LINE       : (1)");
        Console.WriteLine("-> IN-PROGRESS LINE : (2)");
        Console.WriteLine("-> DONE LINE        : (3)");
        string line_secim = Console.ReadLine();
        Console.WriteLine("Başlık giriniz   :");
        string baslik = Console.ReadLine();
        Console.WriteLine("İçerik giriniz   :");
        string icerik = Console.ReadLine();
        Console.WriteLine("Büyüklük seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
        short ekle_buyukluk = short.Parse(Console.ReadLine());
        Console.WriteLine("Kişi seçiniz  : ");
        Console.WriteLine(takim_uyeleri.ElementAt(0).Value + " - ID -> 001");
        Console.WriteLine(takim_uyeleri.ElementAt(1).Value + " - ID -> 002");
        Console.WriteLine(takim_uyeleri.ElementAt(2).Value + " - ID -> 003");
        string kisi_secimi = Console.ReadLine();
        var kart_tanimla = new Kart_icerigi(baslik,icerik,takim_uyeleri.ElementAt(int.Parse(kisi_secimi)-1).Value,(Kart_icerigi.buyukluk)ekle_buyukluk);
        if(line_secim == "1"){
            todo_List.Add(kart_tanimla);
        }else if(line_secim == "2"){
            in_Progress_List.Add(kart_tanimla);
        }else if(line_secim == "3"){
            done_List.Add(kart_tanimla);
        }else{
            Console.WriteLine("Yanlış bir giriş yaptınız...");
        }
    }
    // işlem (3) Board'dan kart silmek- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    public void islem_3_boarddan_kart_silmek(){
        Console.WriteLine("- - - -");
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlığını yazınız:  ");
        string silmek_istenen_kart = Console.ReadLine();
        Listlerde_Ara(silmek_istenen_kart);
    }
    public void Listlerde_Ara(string aranan_kart){
        var kart_isim = todo_List.FirstOrDefault(c => c.Get_Baslık() == aranan_kart);
        if(kart_isim == null){ 
            kart_isim = in_Progress_List.FirstOrDefault(c => c.Get_Baslık() == aranan_kart);
            if(kart_isim == null){
                kart_isim = done_List.FirstOrDefault(c => c.Get_Baslık() == aranan_kart);
                if(kart_isim == null){
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("Yeniden denemek için      : (2)");
                    string seçim_1 = Console.ReadLine();
                    if(seçim_1 == "1"){
                        Console.WriteLine("Çıkış yapılıyor * * *");
                    }else if(seçim_1 == "2"){
                        islem_3_boarddan_kart_silmek();
                    }else{
                        Console.WriteLine("Yanlış bir giriş yaptınız çıkış yapılıyor * * *");
                    }
                }else{ // done listinden silincek
                    Console.WriteLine("- - - - - - - - - - - ");
                    Kart_Bilgileri(kart_isim);
                    Console.WriteLine("- - - Bu kart silinmek üzere onaylıyor musunuz? (y/n)");
                    string secim_4 = Console.ReadLine();
                    if(secim_4 == "y"){
                        done_List.Remove(kart_isim);
                        Console.WriteLine("Kart silindi !");
                    }else if(secim_4 == "n"){
                        Console.WriteLine("Kart silinmedi...");
                    }else{
                        Console.WriteLine("Yanlış bir seçim yaptınız...");
                    }
                }
            }else{ // in-progress-listinden silincek
                Console.WriteLine("- - - - - - - - - - - ");
                Kart_Bilgileri(kart_isim);
                Console.WriteLine("- - - Bu kart silinmek üzere onaylıyor musunuz? (y/n)");
                string secim_3 = Console.ReadLine();
                if(secim_3 == "y"){
                    in_Progress_List.Remove(kart_isim);
                    Console.WriteLine("Kart silindi !");
                }else if(secim_3 == "n"){
                    Console.WriteLine("Kart silinmedi...");
                }else{
                    Console.WriteLine("Yanlış bir seçim yaptınız...");
                }
            }
        }else{ // to-do list den silincek
            Console.WriteLine("- - - - - - - - - - - ");
            Kart_Bilgileri(kart_isim);
            Console.WriteLine("- - - Bu kart silinmek üzere onaylıyor musunuz? (y/n)");
            string secim_2 = Console.ReadLine();
            if(secim_2 == "y"){
                todo_List.Remove(kart_isim);
                Console.WriteLine("Kart silindi !");
            }else if(secim_2 == "n"){
                Console.WriteLine("Kart silinmedi...");
            }else{
                Console.WriteLine("Yanlış bir seçim yaptınız...");
            }
        }
    }
    // işlem (4) Kart Taşımak- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    public void islem_4_kart_tasimak(){
        Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlığını yazınız:  ");
        string tasinmak_istenen_kart = Console.ReadLine();
        Tasimak_icin_Ara(tasinmak_istenen_kart);
    }
    public void Tasimak_icin_Ara(string aranan_kart_tasimak_icin){
        var tasincak_kart = todo_List.FirstOrDefault(c => c.Get_Baslık() == aranan_kart_tasimak_icin);
        if(tasincak_kart == null){
            tasincak_kart = in_Progress_List.FirstOrDefault(c => c.Get_Baslık() == aranan_kart_tasimak_icin);
            if(tasincak_kart == null){
                tasincak_kart = done_List.FirstOrDefault(c => c.Get_Baslık() == aranan_kart_tasimak_icin);
                if(tasincak_kart == null){
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("Yeniden denemek için      : (2)");
                    string seçim = Console.ReadLine();
                    if(seçim == "1"){
                        Console.WriteLine("Çıkış yapılıyor * * *");
                    }else if(seçim == "2"){
                        islem_4_kart_tasimak();
                    }else{
                        Console.WriteLine("Yanlış bir giriş yaptınız çıkış yapılıyor * * *");
                    }
                }else{ // done line kısmı
                    Console.WriteLine("- - - - - - - - - - - ");
            Kart_Bilgileri(tasincak_kart);
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
            Console.WriteLine("(1) : TO-DO LINE");
            Console.WriteLine("(2) : IN-PROGRESS LINE");
            Console.WriteLine("(3) : DONE LINE");
            string secim_5 = Console.ReadLine();
            if(secim_5 == "1"){
                if(todo_List.Contains(tasincak_kart)){
                    Console.WriteLine("Taşımak istediğiniz kart zaten seçtiğiniz LINE'da :D");
                }else if(in_Progress_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart TO-DO LINE'a taşınıyor...");
                    in_Progress_List.Remove(tasincak_kart);
                    todo_List.Add(tasincak_kart);
                }else if(done_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart TO-DO LINE'a taşınıyor...");
                    done_List.Remove(tasincak_kart);
                    todo_List.Add(tasincak_kart);
                }
            }else if(secim_5 == "2"){
                if(todo_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart IN-PROGRESS LINE'a taşınıyor...");
                    todo_List.Remove(tasincak_kart);
                    in_Progress_List.Add(tasincak_kart);
                }else if(in_Progress_List.Contains(tasincak_kart)){
                    Console.WriteLine("Taşımak istediğiniz kart zaten seçtiğiniz LINE'da :D");
                }else if(done_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart IN-PROGRESS LINE'a taşınıyor...");
                    done_List.Remove(tasincak_kart);
                    in_Progress_List.Add(tasincak_kart);
                }
            }else if(secim_5 == "3"){
                if(todo_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart DONE LINE'a taşınıyor...");
                    todo_List.Remove(tasincak_kart);
                    done_List.Add(tasincak_kart);
                }else if(in_Progress_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart DONE LINE'a taşınıyor...");
                    in_Progress_List.Remove(tasincak_kart);
                    done_List.Add(tasincak_kart);
                }else if(done_List.Contains(tasincak_kart)){
                    Console.WriteLine("Taşımak istediğiniz kart zaten seçtiğiniz LINE'da :D");
                }
            }
                }
            }else{ // in-progress line kısmı
                Console.WriteLine("- - - - - - - - - - - ");
            Kart_Bilgileri(tasincak_kart);
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
            Console.WriteLine("(1) : TO-DO LINE");
            Console.WriteLine("(2) : IN-PROGRESS LINE");
            Console.WriteLine("(3) : DONE LINE");
            string secim_5 = Console.ReadLine();
            if(secim_5 == "1"){
                if(todo_List.Contains(tasincak_kart)){
                    Console.WriteLine("Taşımak istediğiniz kart zaten seçtiğiniz LINE'da :D");
                }else if(in_Progress_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart TO-DO LINE'a taşınıyor...");
                    in_Progress_List.Remove(tasincak_kart);
                    todo_List.Add(tasincak_kart);
                }else if(done_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart TO-DO LINE'a taşınıyor...");
                    done_List.Remove(tasincak_kart);
                    todo_List.Add(tasincak_kart);
                }
            }else if(secim_5 == "2"){
                if(todo_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart IN-PROGRESS LINE'a taşınıyor...");
                    todo_List.Remove(tasincak_kart);
                    in_Progress_List.Add(tasincak_kart);
                }else if(in_Progress_List.Contains(tasincak_kart)){
                    Console.WriteLine("Taşımak istediğiniz kart zaten seçtiğiniz LINE'da :D");
                }else if(done_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart IN-PROGRESS LINE'a taşınıyor...");
                    done_List.Remove(tasincak_kart);
                    in_Progress_List.Add(tasincak_kart);
                }
            }else if(secim_5 == "3"){
                if(todo_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart DONE LINE'a taşınıyor...");
                    todo_List.Remove(tasincak_kart);
                    done_List.Add(tasincak_kart);
                }else if(in_Progress_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart DONE LINE'a taşınıyor...");
                    in_Progress_List.Remove(tasincak_kart);
                    done_List.Add(tasincak_kart);
                }else if(done_List.Contains(tasincak_kart)){
                    Console.WriteLine("Taşımak istediğiniz kart zaten seçtiğiniz LINE'da :D");
                }
            }
            }
        }else{ // to-do list kısmı
            Console.WriteLine("- - - - - - - - - - - ");
            Kart_Bilgileri(tasincak_kart);
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
            Console.WriteLine("(1) : TO-DO LINE");
            Console.WriteLine("(2) : IN-PROGRESS LINE");
            Console.WriteLine("(3) : DONE LINE");
            string secim_5 = Console.ReadLine();
            if(secim_5 == "1"){
                if(todo_List.Contains(tasincak_kart)){
                    Console.WriteLine("Taşımak istediğiniz kart zaten seçtiğiniz LINE'da :D");
                }else if(in_Progress_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart TO-DO LINE'a taşınıyor...");
                    in_Progress_List.Remove(tasincak_kart);
                    todo_List.Add(tasincak_kart);
                }else if(done_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart TO-DO LINE'a taşınıyor...");
                    done_List.Remove(tasincak_kart);
                    todo_List.Add(tasincak_kart);
                }
            }else if(secim_5 == "2"){
                if(todo_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart IN-PROGRESS LINE'a taşınıyor...");
                    todo_List.Remove(tasincak_kart);
                    in_Progress_List.Add(tasincak_kart);
                }else if(in_Progress_List.Contains(tasincak_kart)){
                    Console.WriteLine("Taşımak istediğiniz kart zaten seçtiğiniz LINE'da :D");
                }else if(done_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart IN-PROGRESS LINE'a taşınıyor...");
                    done_List.Remove(tasincak_kart);
                    in_Progress_List.Add(tasincak_kart);
                }
            }else if(secim_5 == "3"){
                if(todo_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart DONE LINE'a taşınıyor...");
                    todo_List.Remove(tasincak_kart);
                    done_List.Add(tasincak_kart);
                }else if(in_Progress_List.Contains(tasincak_kart)){
                    Console.WriteLine("Seçtiğiniz kart DONE LINE'a taşınıyor...");
                    in_Progress_List.Remove(tasincak_kart);
                    done_List.Add(tasincak_kart);
                }else if(done_List.Contains(tasincak_kart)){
                    Console.WriteLine("Taşımak istediğiniz kart zaten seçtiğiniz LINE'da :D");
                }
            }
        }
    }
}