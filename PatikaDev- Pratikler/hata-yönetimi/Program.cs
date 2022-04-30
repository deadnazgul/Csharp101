// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("bir sayı giriniz: ");

try{
   int sayı;
   sayı = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Girmiş olduğunuz sayı: "+sayı);
}
catch(Exception ex){
  Console.WriteLine("Hata: "+ex.Message.ToString());
}
finally{ // optional
   Console.WriteLine("işlem tamamlandı.");
}

try{
   int a  = int.Parse(null);
}
catch(ArgumentNullException ex){
   Console.WriteLine("Boş değer girdiniz.");
   Console.WriteLine(ex);
}
try{
    int b  = int.Parse("test");
}
catch(FormatException ex){
    Console.WriteLine("Veri tip uygun değil.");
    Console.WriteLine(ex);
}
try{
    int c  = int.Parse("-20000000000");
}
catch(OverflowException ex){
    Console.WriteLine("Çok küçük yada çok büyük bir sayı girdiniz.");
    Console.WriteLine(ex);
}
finally{
    Console.WriteLine("İşlem başarı ile tamamlandı");
}
