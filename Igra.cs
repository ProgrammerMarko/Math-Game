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
                game(mnozenje, '*');
                break;
            case 4:
                game(djeljenje, '/');
                break;
            case 5:
                printHistory();
                break;
            default:
                Console.WriteLine("Error hanling");
                break;
        }
    }

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

    public static void game(Func<int, int, int> operacija, char operacijaChar, int rounds = 10)
    {
        int tocno = 0;
        int roundsHistory = rounds;
        Random random = new Random();
        int a,
            b;

        while (rounds > 0)
        {
            if (operacijaChar == '/')
            {
                b = random.Next(1, 100);
                a = random.Next(1, 10) * b;
            }
            else
            {
                a = random.Next(0, 100);
                b = random.Next(0, 100);
            }

            Console.WriteLine($"Runda: {11 - rounds}/10");
            Console.Write($"{a} {operacijaChar} {b} = ");
            int resultInput = Convert.ToInt32(Console.ReadLine());
            int result = operacija(a, b);

            if (resultInput == result)
            {
                tocno++;
            }

            rounds--;
        }
        Grafika.printResult(tocno);
        resultsList.Add($"{operacijaChar} | {tocno}/{roundsHistory}");
        Console.WriteLine("Stisni ENTER za povratak na menu!");
        Console.ReadLine();
    }

    public static void printHistory()
    {
        Console.WriteLine("History:");
        foreach (string elem in resultsList)
        {
            Console.WriteLine(elem);
        }
        Console.WriteLine("-------------------------");
    }
}
