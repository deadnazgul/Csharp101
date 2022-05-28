public class NewPassat:Otomobil{
    public override Marka HangiMarkaninAraci()
    {
        //throw new NotImplementedException();
        return Marka.Wolksvagen;
    }
    public override Renk StandardRengiNe()
    {
        return Renk.Gri;
    }
}