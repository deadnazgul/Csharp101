public class Hayvanlar:Canlilar{
    protected void Adaptasyon(){
        Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
    }
    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        Console.WriteLine("Hayvanlar temasa tepki verir.");
    }
}

public class Surungenler:Hayvanlar{
    public Surungenler(){
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }
    public void SurunerekHareketEderler(){
        Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
    }
}

public class Kuşlar:Hayvanlar{
    public Kuşlar(){
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        base.UyaranlaraTepki();
    }
    public void Ucmak(){
        Console.WriteLine("Kuşlar uçar.");
    }
}