// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Rekürsif - öz yinelemeli
// 3^4 = 3x3x3x3

int result = 1;
for(int i = 1; i < 5; i++){
    result = result * 3;
}
Console.WriteLine(result);

Islemler instance = new();
Console.WriteLine(instance.Expo(3,4) + "// Recursive Metot sonucu");

// Extension Metotlar
string ifade = "Atakan Furkan Efekan Volkan";
bool sonuc = ifade.CheckSpaces();
Console.WriteLine(sonuc);
if(sonuc){
    Console.WriteLine(ifade.RemoveWhiteSpaces());
}
Console.WriteLine(ifade.MakeUpperCase());
Console.WriteLine(ifade.MakeLowerCase());

int[] dizi = {9,3,6,2,1,5,0};
dizi.SortArray();
dizi.EkranaYazdır();

int sayi = 5;
Console.WriteLine(sayi.IsEvenNumber());

Console.WriteLine(ifade.GetFirstCharacter());

public class Islemler{
    public int Expo(int sayı, int üs){ // recursive kullanarak üslü sayı hesaplama
        if(üs < 2)
            return sayı;
        return Expo(sayı,üs-1)*sayı;    
    }
      // Expo(3,4)
      // Expo(3,3)*3
      // Expo(3,2)*3*3
      // Expo(3,1)*3*3*3
      // 3*3*3*3 = 3^4
}

public static class Extension{
    public static bool CheckSpaces(this string param){ // Extensionlar static olmak zorunda
        return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param){
        string[] dizi = param.Split(" ");
        return string.Join("",dizi);
    }
    public static string MakeUpperCase(this string param){
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param){
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param){
        Array.Sort(param);
        return param;
    }
    public static void EkranaYazdır(this int[] param){
        foreach(int item in param){
            Console.WriteLine(item);
        }
    }
    public static bool IsEvenNumber(this int param){
        return param % 2 == 0;
    }
    public static string GetFirstCharacter(this string param){
        return param.Substring(0,1);
    }
}