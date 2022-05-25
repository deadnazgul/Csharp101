// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
-------------- Canlılar --------------
--> Bitkiler                --> Hayvanlar
1-) Tohumlu                 1-) Sürüngenler
2-) Tohumsuz                2-) Kuşlar

*/

TohumluBitkiler tohumlubitki_1 = new TohumluBitkiler();
// tohumlubitki_1.Beslenme();
// tohumlubitki_1.Solunum();
// tohumlubitki_1.Bosaltim();
//tohumlubitki_1.FotosentezYapmak();
tohumlubitki_1.TohumlaCogalma();

Console.WriteLine("* * * * * * * * * * * * * * * * * *");

Kuşlar martı = new Kuşlar();
// martı.Solunum();
// martı.Beslenme();
// martı.Bosaltim();
//martı.Adaptasyon();
martı.Ucmak();