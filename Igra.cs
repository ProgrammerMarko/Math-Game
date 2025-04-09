using System.Linq.Expressions;

public static class Igra
{
    public static List<string> resultsList = new List<string>();

    public static void menuInputResoultion(int menuInput)
    {
        switch (menuInput)
        {
            case 1:
                game(zbrajanje, '+');
                break;
            case 2:
                game(oduzimanje, '-');
                break;
            case 3:
                gameMnozenje();
                break;
            case 4:
                gameDjeljenje();
                break;
            case 5:
                printHistory();
                break;
            default:
                Console.WriteLine("Error hanling");
                break;
        }
    }

    // metoda x(metoda z)
    // metoda game(metoda int (x, y))
    public static int zbrajanje(int x, int y)
    {
        return x + y;
    }

    public static int oduzimanje(int x, int y)
    {
        return x - y;
    }

    public static int mnozenje(int x, int y)
    {
        return x * y;
    }

    public static int djeljenje(int x, int y)
    {
        return x / y;
    }

    // string name = "Marko"
    // string helloName(string x) {return $"Hello {x}"}
    // helloName(name)
    // helloName:
    // 1. x = name => Marko ==> x = "Marko"

    // int operacije(int x, int y);
    public static void game(Func<int, int, int> operacija, char operacijaChar)
    {
        int rounds = 3;
        int tocno = 0;
        Random random = new Random();

        while (rounds > 0)
        {
            int a = random.Next(0, 100);
            int b = random.Next(0, 100);

            Console.WriteLine($"Runda: {4 - rounds}/3");
            Console.Write($"{a} {operacijaChar} {b} = ");
            int resultInput = Convert.ToInt32(Console.ReadLine());

            //    public static int zbrajanje(int x, int y)
            //    {
            //        return x + y;
            //    }
            int result = operacija(a, b);

            if (resultInput == result)
            {
                tocno++;
            }

            rounds--;
        }

        Console.WriteLine("");
        Grafika.printResult(tocno);
        resultsList.Add($"+ | {tocno}/10");
    }

    public static void gameMnozenje()
    {
        int rounds = 10;
        int tocno = 0;
        Random random = new Random();

        while (rounds > 0)
        {
            int a = random.Next(0, 20);
            int b = random.Next(0, 20);

            Console.WriteLine($"Runda: {11 - rounds}/10");
            Console.Write($"{a} * {b} = ");
            int result = Convert.ToInt32(Console.ReadLine());

            if ((a * b) == result)
            {
                tocno++;
                Console.WriteLine("Točno!");
            }
            else
            {
                Console.WriteLine("Netočno!");
            }

            rounds--;
        }

        Grafika.printResult(tocno);
        resultsList.Add($"* | {tocno}/10");
    }

    public static void gameDjeljenje()
    {
        int rounds = 10;
        int tocno = 0;
        Random random = new Random();

        while (rounds > 0)
        {
            int a = random.Next(1, 10);
            int b = a * random.Next(1, 10);

            Console.WriteLine($"Runda: {11 - rounds}/10");
            Console.Write($"{b} / {a} = ");
            int result = Convert.ToInt32(Console.ReadLine());

            if ((b / a) == result)
            {
                tocno++;
                Console.WriteLine("Točno!");
            }
            else
            {
                Console.WriteLine("Netočno!");
            }

            rounds--;
        }

        Grafika.printResult(tocno);
        resultsList.Add($"/ | {tocno}/10");
    }

    public static void printHistory()
    {
        foreach (string elem in resultsList)
        {
            Console.WriteLine(elem);
        }
    }
}
