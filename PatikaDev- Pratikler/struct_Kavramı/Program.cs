// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
Diğer struct yada sınıflardan kalıtım almazlar.
Interface'lerden kalıtım alabilirler.
*/
Diktortgen dikdörtgen_obj = new Diktortgen();
dikdörtgen_obj.kisaKenar = 3;
dikdörtgen_obj.UzunKenar = 4;

Console.WriteLine("Class Alan Hesabı : {0}",dikdörtgen_obj.AlanHesabı());

//Diktorgen_Struct dikdörtgen_struct_obj; // = new Diktorgen_Struct();
Diktorgen_Struct dikdörtgen_struct_obj = new Diktorgen_Struct(3,4);
//dikdörtgen_struct_obj.kisaKenar = 3;
//dikdörtgen_struct_obj.UzunKenar = 4;

Console.WriteLine("Struct Alan Hesabı : {0}",dikdörtgen_struct_obj.AlanHesabı());



class Diktortgen{
    public int kisaKenar;
    public int UzunKenar;
    public long AlanHesabı(){
        return this.kisaKenar * this.UzunKenar;
    }
    public Diktortgen(){

    }
}

struct Diktorgen_Struct{
    public int kisaKenar;
    public int UzunKenar;
    public long AlanHesabı(){
        return this.kisaKenar * this.UzunKenar;
    }
    // structlarda boş constructora izin yok ama parametrelerin hepsini verirsen okey
    public Diktorgen_Struct(int kisaKenar_1,int UzunKenar_1){
        kisaKenar = kisaKenar_1;
        UzunKenar = UzunKenar_1;
    }
}

