// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
//ve dizinin elemanlarını sıralayan programı yazınız.

char[] sesliHarfler = {'a','e','o','ö','u','ü','ı','i'};

Console.WriteLine("Lütfen bir cümle giriniz: ");
string cümle = Console.ReadLine();
char[] cümleninSesliHarfleri = new char[cümle.Length];

for(int i = 0; i < cümle.Length; i++){
    foreach(char item in sesliHarfler){
        if(cümle[i] == item){
            cümleninSesliHarfleri[i] = item;
        }
    }
}
Console.WriteLine("Cümlenin sesli harfleri: ");
foreach(var item in cümleninSesliHarfleri){
    Console.Write(" " + item);
}