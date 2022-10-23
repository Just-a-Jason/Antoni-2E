using System;
class Program{
     static void Main() {
        Trojkat();
     }

    static void Suma() {
        int a, b;

        a = Input("Podaj a: ");
        b = Input("Podaj b: ");
        string output = (a+b%2==0) ? "TAK" : "NIE";
        Console.WriteLine(output);
     }

    static void ArytmetycznaIGeometryczna() {
        int a, g;

        a = Input("Podaj a: ");
        g = Input("Podaj g: ");
        string output = (a+g/2 > Math.Sqrt(a*g)) ? "TAK" : "NIE";
        Console.WriteLine(output);
    }

    static void Rowne() {
        int k, m, l;

        k = Input("Podaj a: ");
        m = Input("Podaj g: ");
        l = Input("Podaj l: ");

        string output= (k == m && l == k || l==m && l == k) ? "TAK" : "NIE";
        
        Console.WriteLine(output);
    }

    static void NieRownoscTrojkata() {
        int a, b, c;

        a = Input("Podaj a: ");
        b = Input("Podaj b: ");
        c = Input("Podaj c: ");

        string output=(a< b+c && b< a+c && c < a+b) ? "TAK" : "NIE";
    
        Console.WriteLine(output);
    }

    static void Trojkat() {
        int a, b, c;

        a = Input("Podaj a: ");
        b = Input("Podaj b: ");
        c = Input("Podaj c: ");

        string output=(a*a+b*b>c*c) ? "Ostrokątny" : (a*a+b*b==c*c) ? "Prostokątny" : "Rozwartokątny";
    
        Console.WriteLine(output);
    }

    static void Najmniejsza() {
        int a,b,c,d;

        a = Input("Podaj a: ");
        b = Input("Podaj b: ");
        c = Input("Podaj c: ");
        d = Input("Podaj d: ");
       

        int najmniejsza = a;

        if(najmniejsza > b)
            najmniejsza = b;
        if(najmniejsza > c)
            najmniejsza = c;
        if(najmniejsza > d)
            najmniejsza = d;
        Console.WriteLine(najmniejsza);
    }


     static int Input(string text) {
        Console.Write(text);
        return int.Parse(Console.ReadLine());
     }
}