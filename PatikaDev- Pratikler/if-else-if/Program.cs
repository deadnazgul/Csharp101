// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int time = DateTime.Now.Hour;
Console.WriteLine(time + " bu sadece saat...");
Console.WriteLine(DateTime.Now + " şu anki saat...");
if(time >= 6 && time < 11){
    Console.WriteLine("Günaydın!");
}else if(time <= 18){
    Console.WriteLine("iyi günler!");  
}else{
    Console.WriteLine("iyi geceler!");
}

string sonuc = time <= 18 ? "iyi günler..." : "iyi geceler";
    Console.WriteLine(sonuc);
// yukardaki if-else logic kısmını şu şekildede yazabiliriz...
sonuc=time>=6 && time<11 ? "Günaydınlar#" : time<=18 ? "Eyy günler!!" : "gecen güzel ossun!";
Console.WriteLine(sonuc);