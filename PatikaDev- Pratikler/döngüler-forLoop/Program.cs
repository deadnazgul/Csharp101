// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır
Console.Write("bi sayı gir içindeki tek sayıları ve çift sayıları göstereyim: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("****** Tek sayılar ******");
for(int i = 1; i <= num; i++){
    if(i%2 != 0){
        Console.WriteLine(i);
    }
}
Console.WriteLine("****** Çift sayılar ******");
for(int i = 1; i <= num; i++){
    if(i%2 == 0){
        Console.WriteLine(i);
    }
}


Console.Write("girdiğin sayıya kadar içindeki tekleri ve çiftleri ayrı ayrı toplarım: ");
int sayac = int.Parse(Console.ReadLine());
int tektoplam = 0;
int çiftToplam = 0;
for(int i = 1; i <= sayac; i++){//girilen sayıya kadar teker teker dön
    if(i%2 != 0){// 2 ile bölümünden kalan sıfıra eşit değilse...
         tektoplam += i;
    }else{
        çiftToplam += i;
    }
}
Console.WriteLine("Tek sayıların toplamı: "+ tektoplam);
Console.WriteLine("Çift sayıların toplamı: "+ çiftToplam);
