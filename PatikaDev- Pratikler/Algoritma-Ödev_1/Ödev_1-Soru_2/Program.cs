// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* 
Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
*/
Console.WriteLine("Lütfen İki tane sayı girin: ");
Console.WriteLine("Birinci sayı: ");
int n = Int32.Parse(Console.ReadLine());
Console.WriteLine("İkinci sayı: ");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Şimdi lütfen " + n + " adet pozitif sayı girin: ");

int[] sayıDizisi_1 = new int[n];

for(int i = 1; i <= sayıDizisi_1.Length; i++){
    Console.WriteLine(i + "'inci sayı: ");
    sayıDizisi_1[i-1] = Int32.Parse(Console.ReadLine());
}

Console.WriteLine("Şimdi ilk başta girilen ikinci sayıya eşit ya da tam bölünen sayılar: ");
foreach(var item in sayıDizisi_1){
    if(item % m == 0 || item == m){
        Console.Write(" " + item);
    }
}