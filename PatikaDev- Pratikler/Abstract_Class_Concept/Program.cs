// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("************* INTERFACE ile geliştirilmiş Code **************");

Fiesta fiesta_1 = new Fiesta();
Console.WriteLine(fiesta_1.HangiMarkaninAraci().ToString());
Console.WriteLine(fiesta_1.KacTekerdenOlusur().ToString());
Console.WriteLine(fiesta_1.StandardRengiNe().ToString()); // Enum olduğu için ToString kullanıoz...

Console.WriteLine("* * * * * * * * * * * * ");

Auris auris_1 = new Auris();
Console.WriteLine(auris_1.HangiMarkaninAraci().ToString());
Console.WriteLine(auris_1.KacTekerdenOlusur().ToString());
Console.WriteLine(auris_1.StandardRengiNe().ToString());

Console.WriteLine("* * * * * * * * * * * * ");

Passat passat_1 = new Passat();
Console.WriteLine(passat_1.HangiMarkaninAraci().ToString());
Console.WriteLine(passat_1.KacTekerdenOlusur().ToString());
Console.WriteLine(passat_1.StandardRengiNe().ToString());

Console.WriteLine("************* ABSTRACT Class ile geliştirilmiş Code **************");

NewPassat newPassat_1 = new NewPassat();
Console.WriteLine(newPassat_1.HangiMarkaninAraci().ToString());
Console.WriteLine(newPassat_1.KacTekerdenOlusur().ToString());
Console.WriteLine(newPassat_1.StandardRengiNe().ToString());

Console.WriteLine("* * * * * * * * * * * * ");

NewAuris newAuris_1 = new NewAuris();
Console.WriteLine(newAuris_1.HangiMarkaninAraci().ToString());
Console.WriteLine(newAuris_1.KacTekerdenOlusur().ToString());
Console.WriteLine(newAuris_1.StandardRengiNe().ToString());

Console.WriteLine("* * * * * * * * * * * * ");

NewFiesta newFiesta_1 = new NewFiesta();
Console.WriteLine(newFiesta_1.HangiMarkaninAraci().ToString());
Console.WriteLine(newFiesta_1.KacTekerdenOlusur().ToString());
Console.WriteLine(newFiesta_1.StandardRengiNe().ToString());