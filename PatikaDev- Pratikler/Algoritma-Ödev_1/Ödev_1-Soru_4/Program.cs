// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* 
Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/
Console.WriteLine("Lütfen bir cümle girin: ");
string sentence_1 = Console.ReadLine();

Console.WriteLine("Cümledeki Toplam Kelime sayısı: ");
Console.WriteLine(sentence_1.SpaceCounter());

Console.WriteLine("Cümledeki Toplam Harf sayısı: ");
sentence_1 = sentence_1.RemoveWhiteSpaces();
Console.WriteLine(sentence_1.CharCounter());

public static class Extension{
    public static int SpaceCounter(this string param){
        int whiteSpaceCounter = 0;
        foreach(char item in param){
            if(item == ' '){
                whiteSpaceCounter++;
            }
        }
        return whiteSpaceCounter + 1;
    }
    public static string RemoveWhiteSpaces(this string param){
        string[] dizi = param.Split(" ");
        return string.Join("",dizi);
    }
    public static int CharCounter(this string param){
        int charCount = 0;
        foreach(int charNum in param){
            charCount++;
        }
        return charCount;
    }
}