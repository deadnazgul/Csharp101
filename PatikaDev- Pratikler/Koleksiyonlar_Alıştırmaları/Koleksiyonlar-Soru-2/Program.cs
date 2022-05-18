// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
// her iki grubun kendi içerisinde ortalamalarını alan ve 
// bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

int[] sayiArray = new int[20];
for(int i = 0; i < sayiArray.Length; i++){
    Console.WriteLine("Sayı: " + (i+1) + " giriniz: ");
    sayiArray[i] = Int32.Parse(Console.ReadLine());
}
Console.WriteLine("Array içersindeki en büyük üç sayı: ");
int max1 = 0;
foreach(int item in sayiArray){
    if(item > max1){
        max1 = item;
    }
}
int max2 = 0;
foreach(int item in sayiArray){
    if(item > max2 && item < max1){
        max2 = item;
    }
}
int max3 = 0;
foreach(int item in sayiArray){
    if(item > max3 && item < max2){
        max3 = item;
    }
}
Console.Write(max1 + " " + max2 + " " + max3 + "\n");

Console.WriteLine("Array içersindeki en küçük üç sayı:");
int min1 = 999999999;
foreach(int item in sayiArray){
    if(item < min1){
        min1 = item;
    }
}
int min2 = 999999999;
foreach(int item in sayiArray){
    if(item < min2 && item > min1){
        min2 = item;
    }
}
int min3 = 999999999;
foreach(int item in sayiArray){
    if(item < min3 && item > min2){
        min3 = item;
    }
}
Console.WriteLine(min1 + " " + min2 + " " + min3);

int enbüyükOrt = (max1 + max2 + max3) / 3;
Console.WriteLine("En büyük Üç sayının Ortalaması: ");
Console.WriteLine(enbüyükOrt);
int enküçükOrt = (min1 + min2 + min3) / 3;
Console.WriteLine("En küçük Üç sayının Ortalaması: ");
Console.WriteLine(enküçükOrt);

Console.WriteLine("Ortalama Toplamları: --> " + enbüyükOrt + enküçükOrt);