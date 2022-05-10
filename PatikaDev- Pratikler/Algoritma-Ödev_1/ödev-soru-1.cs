// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* 
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
*/

Console.WriteLine("Lütfen pozitif bir sayı girin: ");
int n = Int32.Parse(Console.ReadLine());
Console.WriteLine("Şimdi lütfen " + n + " adet sayı girin: ");
int[] sayıDizisi_1 = new int[n];
for(int i = 1; i <= sayıDizisi_1.Length; i++){
    Console.WriteLine(i + "'inci sayı: ");
    sayıDizisi_1[i-1] = Int32.Parse(Console.ReadLine());
}
Console.WriteLine("Sayı dizisinin içindeki çift olan sayılar: ");
foreach(int item in sayıDizisi_1){
    if(item % 2 == 0){
        Console.Write(" " + item);
    }
}