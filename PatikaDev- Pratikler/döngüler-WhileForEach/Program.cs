// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// While
// 1 den başlayarak konsolda girilen sayıya kadar 
// ortalama hesaplayan program

Console.WriteLine("Bir sayı giriniz: ");
int sayı = int.Parse(Console.ReadLine());
int toplam = 0;
int sayaç = 1;
while(sayaç <= sayı){
    toplam += sayaç;
    sayaç++;
}
Console.WriteLine("ortalama: "+toplam/sayı);

// 'a' dan 'z' ye kadar tüm harfleri console a yazdır.
char character = 'a';
while(character < 'z'){
    Console.Write(character+"-");
    character++;
}
Console.WriteLine();

Console.WriteLine("********** Foreach **********");
string[] arabalar = {"BMW","Ford","Wolkswagen","Audi"};
foreach (var item in arabalar)
{
    Console.WriteLine(item);
}