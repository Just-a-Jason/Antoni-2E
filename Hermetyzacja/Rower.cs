using System;

class Program
{
    static void Main()
    {
        Producent producent = new Producent("NiggaHaters", "PL1234567895");
        Material material = new Material(200,"NiggerBike", 92782);
        Rower rower = new Rower(producent, material, "Biały");

        Console.ReadKey();
    }

}

class Rower
{
    private Producent producent;
    private Material material;
    private string kolor;

    public Rower(Producent producent, Material material, string kolor)
    {
        this.producent = producent;
        this.material = material;
        this.kolor = kolor;
    }

    #region methods
        public void jedz()
        {
            Console.WriteLine("Jadę xdddd");
        }

        public void setColor(string kolor) => this.kolor = kolor;
        public string getColor() => kolor;
    #endregion methods
}

class Material
{
    private double cena;
    private string typ;
    private int id;

    public Material(double cena, string typ, int id)
    {
        this.cena = cena;
        this.typ = typ;
        this.id = id;
    }
    #region methods
        public void setTyp(string typ) => this.typ = typ;
        public void setId(int id) => this.id = id;
        public double getCena() => cena;
        public string getTyp() => typ;
    #endregion methods
}

class Producent
{
    private string nazwa, nip;

    public Producent(string nazwa, string nip)
    {
        this.nazwa = nazwa;
        this.nip = nip;
    }
    #region methods
        public void setNazwa(string nazwa) => this.nazwa = nazwa;
        public void setNip(string nip) => this.nip = nip;
        public string getNazwa() => nazwa; 
        public string getNip() => nip;
    #endregion methods
}