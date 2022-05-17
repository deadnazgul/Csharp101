// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// system.collection.generic
Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
// bu aşşagıda eklenilen key'ler unique olmalı ona göre...
kullanıcılar.Add(06,"Ankara");
kullanıcılar.Add(0497,"F-Göksu");
kullanıcılar.Add(1453,"İstanbul");
kullanıcılar.Add(81,"Türkiye");

// Dizinin elemanlarına erişim
Console.WriteLine("****** Elemanlara Erişim ******");
Console.WriteLine(kullanıcılar[81] + " --> key kullanarak direk elemana ulaşıldı.");
Console.WriteLine("--> Foreach döngüsü ile: ");
    foreach(var item in kullanıcılar)
        Console.WriteLine(item);

// Count
Console.WriteLine("****** Count ******");
Console.WriteLine(kullanıcılar.Count + " = Count");

// Contains
Console.WriteLine("****** Contains ******");
Console.WriteLine(kullanıcılar.ContainsKey(0497));
Console.WriteLine(kullanıcılar.ContainsValue("Atakan"));

// Remove
Console.WriteLine("****** Remove ******");
kullanıcılar.Remove(0497);
foreach(var item in kullanıcılar)
    Console.WriteLine(item);

// Keys
Console.WriteLine("****** Keys ******");
foreach(var item in kullanıcılar.Keys)
    Console.WriteLine(item);

// Values
Console.WriteLine("****** Values ******");
foreach(var item in kullanıcılar.Values)
    Console.WriteLine(item);


// https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem?isFullScreen=true

Dictionary<string, int> phoneBook = new Dictionary<string, int>();
        int input_T = int.Parse(Console.ReadLine());
        string[] input_Str = new string[input_T];
        string keyOf_phoneBook;
        int valueOf_phoneBook;
        for(int i = 0; i < input_T; i++){
            keyOf_phoneBook = Console.ReadLine();
            valueOf_phoneBook = int.Parse(Console.ReadLine());
            phoneBook.Add(keyOf_phoneBook, valueOf_phoneBook);
        }
        for(int k = 0; k < input_T; k++){
            input_Str[k] = Console.ReadLine();
        }
        for(int p = 0; p < input_T; p++){
            if(phoneBook.ContainsKey(input_Str[p])){
                Console.WriteLine(input_Str[p] + "=" + phoneBook[input_Str[p]]);
            }else{
                Console.WriteLine("Not found");
            }
        }