public class Kart_icerigi{
    private string Baslık;
    private string Icerik;
    private string Atanan_Kisi; // (Takım üyelerişnden biri olmalı)
    public enum buyukluk {XS = 1 , S , M , L , XL}; // (XS, S, M, L, XL)
    buyukluk buyukluk_degeri;
    public buyukluk Get_buyukluk_degeri(){
        return buyukluk_degeri;
    }
    public void Set_buyukluk_degeri(buyukluk buyukluk_degeri_){
        buyukluk_degeri = buyukluk_degeri_;
    }
    public string Get_Baslık(){
        return Baslık;
    }
    public void Set_Baslık(string Baslık_){
        Baslık = Baslık_;
    }
    public string Get_Icerik(){
        return Icerik;
    }
    public void Set_Icerik(string Icerik_){
        Icerik = Icerik_;
    }
    public string Get_AtananKisi(){
        return Atanan_Kisi;
    }
    public void Set_AtananKisi(string Atanan_Kisi_){
        Atanan_Kisi = Atanan_Kisi_;
    }
    public Kart_icerigi(string _baslik,string _icerik,string _atanan_kisi,buyukluk buyukluk_){
        Baslık = _baslik;
        Icerik = _icerik;
        Atanan_Kisi = _atanan_kisi;
        buyukluk_degeri = buyukluk_;
    }
}