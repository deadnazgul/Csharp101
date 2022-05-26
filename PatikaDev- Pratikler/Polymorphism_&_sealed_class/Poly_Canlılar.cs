/* 
Çok biçimcilik ile birlikte hayatımıza sanal yani virtual metotlar giriyor. 
Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız. 
Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan ve 
daha sonra alt sınıflarda yeniden yazılabilen metotlardır. 
Bunu da virtual ve override anahtar kelimeleri sağlar.
*/


public class Canlilar{
    protected void Beslenme(){
        Console.WriteLine("Canlılar beslenir.");
    }
    protected void Solunum(){
        Console.WriteLine("Canlılar solunum yapar.");
    }
    protected void Bosaltim(){
        Console.WriteLine("Canlılar boşaltım yapar");
    }
    public virtual void UyaranlaraTepki(){
        Console.WriteLine("Canlılar uyaranlara tepki verir.");
    }
}

//Eğer bir class'ın hiç bir şekilde kalıtım vermesini istemiyosak
// public sealed class Canlılar{} şeklinde oluşturabiliriz...