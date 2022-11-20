class Program
{
    static void Main()
    {
        Bajtożabka();
        Domek();
        LiczbyFajowe();
    }

    static int Input(string text)
    {
        Console.Write(text);
        int x = int.Parse(Console.ReadLine());
        Console.Clear();
        return x;
    }

    static void LiczbyFajowe()
    {
        for (int i = 1000; i <= 9999; i++)
        {
            int x = i;
            int[] cyfry = new int[4];
            int index = cyfry.Length-1;
            while(x > 0)
            {
                cyfry[index--] = x%10;
                x /= 10;
            }
            try
            {
                if(cyfry[3]/cyfry[2]==2 && cyfry[2]/cyfry[1] == 2)
                {
                    Console.WriteLine(i);
                }

            }
            catch (DivideByZeroException e)
            {

            }
            /*
                1241
                1 -> 2 -> 4 -> 8

                zasady:
                    cyfra jedności musi cyć 2 razy większa 
                    od cyfry dziesiątek, która musi być dwa razy większa niż
                    cyfra setek czwarta cyfra jest już piękna. Może zostać taka jaka jest.
             */
        }

    }
    static void Bajtożabka()
    {
        int poczatek, koniec, skok;

        poczatek = Input("Podaj początek: ");
        koniec = Input("Podaj koniec: ");
        skok = Input("Podaj skok: ");

        // a

        bool trafi = ((koniec - poczatek) % skok == 0);

        if (trafi)
            Console.WriteLine("TAK");
        else Console.WriteLine("NIE");
        // b
        double ileDoKonca = Math.Round((double)koniec / skok, 0);
        Console.WriteLine(ileDoKonca);

        // c
        int skoki = (koniec - poczatek) / 5;
        Console.WriteLine($"TAK, {skoki}");
    }

    static void Domek()
    {
        int n = Input("Podaj n: ");
        int kolumny = Input("Podaj ilość kolumn: ");

        RysujDaszek(n, true);
        RysujKolumny(kolumny, n);

    }
    
    static void RysujDaszek(int n , bool odwroc=false)
    {   
        int tab = 1;
        if(!odwroc)
        {
            // 5 -> 3 -> 1 

            for (int i = n-2; i > 0; i-=2)
            {
                for(int z = 0; z < tab; z++)
                    Console.Write("\t");
                for(int j = 0; j<i; j++)
                    Console.Write("\t*");
                Console.WriteLine();
                tab++;
            }
        }
        else
        {
            // 1 -> 3 -> 5
            tab = 3;
            for (int i = 0; i < n-2 ; i += 2)
            {
                for (int z = 0; z < tab; z++)
                    Console.Write("\t");

                for (int j = 0; j <= i; j++)
                    Console.Write("\t*");
                Console.WriteLine();
                tab--;
            }
        }
    }

    static void RysujKolumny(int k, int n)
    {
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("\t*");
            }
            Console.WriteLine();
        }
    } 
}