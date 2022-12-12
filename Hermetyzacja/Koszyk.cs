using System;

class Program
{
    static void Main()
    {
        Produkt produkt = new Produkt("Kanapka z serem.", "smaczna.", 2.50);
        Profil profil = new Profil("Peater", "Justin", "Löwenbräu Griffin Sr.");
        Uzytkownik uzytkownik = new Uzytkownik("Antoni 2069", "Brak", profil);
        Koszyk koszyk = new Koszyk(uzytkownik, produkt, 2727928);
        Console.ReadKey();
    }

}

class Uzytkownik
{
    private string login, haslo;
    private Profil profil;
    
    public bool loguj(string login, string haslo) => (this.login == login && this.haslo == haslo);
    
    
    public Uzytkownik(string login, string haslo, Profil profil)
    {
        this.profil = profil;
        this.login = login;
        this.haslo = haslo;
    }
}

class Profil
{
    string imie, drugieImie, nazwisko;

    public string getImie() => this.imie;
    public string getNazwisko() => this.nazwisko;

    public Profil(string imie, string drugieImie, string nazwisko)
    {
        this.drugieImie = drugieImie;
        this.nazwisko = nazwisko;
        this.imie = imie;
    }
}

class Koszyk
{
    private Uzytkownik uzytkownik;
    private Produkt produkt;
    private int id;

    public int getId() => id;
    public void operation()
    {

    }
    public Koszyk(Uzytkownik uzytkownik, Produkt produkt, int id)
    {
        this.uzytkownik = uzytkownik;
        this.produkt = produkt;
        this.id = id;
    }
}
class Produkt
{
    private string nazwa, opis;
    private double cena;

    public double getCena() => cena;
    public string getNazwa() => nazwa;
    public string getOpis() => opis;

    public Produkt(string nazwa, string opis, double cena)
    {
        this.nazwa = nazwa;
        this.opis = opis;
        this.cena = cena;
    }
}
