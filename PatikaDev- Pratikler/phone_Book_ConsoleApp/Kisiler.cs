// Kişiler class ı
public class Kisi_Kartı{
    private string isim;
    private string soy_isim;
    private string numara;

    public string Getisim(){
        return isim;
    }
    public void Setisim(string _isim){
        isim = _isim;
    }

    public string Getsoyisim(){
        return soy_isim;
    }
    public void Setsoyisim(string _soyisim){
        soy_isim = _soyisim;
    }

    public string Getnumara(){
        return numara;
    }
    public void Setnumara(string _numara){
        numara = _numara;
    }

    public Kisi_Kartı(string isim_, string soyisim_, string numara_){
        isim = isim_;
        soy_isim = soyisim_;
        numara = numara_;
    }
}