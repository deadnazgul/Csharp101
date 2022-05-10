// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
*/
Console.WriteLine("Lütfen pozitif bir sayı girin: ");
int n = Int32.Parse(Console.ReadLine());
Console.WriteLine("Şimdi lütfen " + n + " tane kelime girin: ");

string[] kelimeDizisi_1 = new string[n];

for(int i = 1; i <= kelimeDizisi_1.Length; i++){
    Console.WriteLine(i + "'inci kelime: ");
    kelimeDizisi_1[i-1] = Console.ReadLine();
}
Array.Reverse(kelimeDizisi_1);

Console.WriteLine("Girilen kelime listesinin Sondan--Başa doğru listesi: ");
foreach(string item in kelimeDizisi_1){
    Console.WriteLine(item + " --> ");
}