using System;
class Program {
    static void Main() {
        Zadania zadania  = new();
        
        zadania.zad1();
        zadania.zad2();
        zadania.zad3();
        zadania.zad4();
        Console.WriteLine($"Suma: {zadania.zad5()}");
        Console.WriteLine($"Suma: {zadania.zad6()}");
        Console.WriteLine($"Suma: {zadania.zad7()}");
        Console.WriteLine($"Suma: {zadania.zad9()}");
        zadania.zad10();

        Console.ReadKey();
  
    }
}

class Zadania {
    public void zad1(){
        string[] dni = new string[]{"Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela"};

        System.Console.WriteLine("-- Wszystkie dni listopada:");
        System.Console.WriteLine();
        
        for(int i=1; i<31;i++) {
            System.Console.WriteLine($"\t--Dzień: {i}, {dni[i%7]}");
        }
    }

    public void zad2() {
        Console.WriteLine();
        Console.WriteLine("Kwadraty liczb nieparzystych:");
        for(int i = 1; i < 10; i++) {
            if(i%2 > 0){
                Console.WriteLine($"\t* {i}^2 = {i*i}");
            }
        }
    }

    public void zad3() {
        Console.WriteLine();
        Console.WriteLine("Liczby czterocyfrowe podzielne przez 379:");
        for(int i = 1000; i < 10000; i++) {
            if(i%379 == 0){
                Console.WriteLine($"\t* {i} % 379 == 0");
            }
        }
    }

    public void zad4() {
        Console.WriteLine();
        Console.WriteLine("Liczby trzycyfrowe podzielne przez 5, 6 lub 11:");
        for(int i = 100; i < 1000; i++) {
            if(i%5 == 0 || i%6 == 0 || i%11 == 0){
                Console.WriteLine($"\t* {i}");
            }
        }
    }

    public int zad5() {
        Console.WriteLine();

        int n = Input("Podaj n: ");
        int suma = 0;
        
        for(int i = 0; i < n; i++) {
            suma += Input($"\tPodaj liczbę {i+1}: ");
        }
        return suma;
    }

    public int zad6() {
        Console.WriteLine();

        int k = Input("Podaj k: ");
        int suma = 0;
        
        for(int i = 1; i <= k; i++) {
            suma += (i%2==0) ? i : 0;
        }
        return suma;
    }

    public int zad7() {
        Console.WriteLine();

        int m = Input("Podaj m: ");
        int suma = 0;
        
        for(int i = 1; i <= m; i++) {
            suma += (i%2 > 0) ? i : 0;
        }
        return suma;
    }

    // public void zad8() {
    //     Console.WriteLine();
    //     System.Console.WriteLine("Liczby 1-1000, kończące się swoim pierwiastkiem:");
        
    //     for(int i = 1; i <= 1000; i++) {
    //         if(i%10 == Math.Sqrt(i)) Console.WriteLine(i);
    //     }
    // }

    public int zad9() {
        Console.WriteLine();

        int n = Input("Podaj n: ");
        int suma = 0;
        
        for(int i = 1; i <= n; i++) {
            if((i%10 == 1 && i/10%10 == 2)) Console.WriteLine(i);
            suma += (i%10 == 1 && i/10%10 == 2) ? i : 0;
        }
        return suma;
    }

    public void zad10() {
        Console.WriteLine();
        System.Console.WriteLine("Liczby 1-1000, kończące się swoim pierwiastkiem:");
        
        for(int i = 1; i <= 1000; i++) {
            if(i%10 == Math.Sqrt(i)) Console.WriteLine(i);
        }
    }

    private static int Input(string text) {
        Console.Write(text);
        return int.Parse(Console.ReadLine());
    }
}