// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Fiesta fiesta_1 = new Fiesta();
Console.WriteLine(fiesta_1.HangiMarkaninAraci().ToString());
Console.WriteLine(fiesta_1.KacTekerdenOlusur().ToString());
Console.WriteLine(fiesta_1.StandardRengiNe().ToString()); // Enum olduğu için ToString kullanıoz...

Auris auris_1 = new Auris();
Console.WriteLine(auris_1.HangiMarkaninAraci().ToString());
Console.WriteLine(auris_1.KacTekerdenOlusur().ToString());
Console.WriteLine(auris_1.StandardRengiNe().ToString());

Passat passat_1 = new Passat();
Console.WriteLine(passat_1.HangiMarkaninAraci().ToString());
Console.WriteLine(passat_1.KacTekerdenOlusur().ToString());
Console.WriteLine(passat_1.StandardRengiNe().ToString());