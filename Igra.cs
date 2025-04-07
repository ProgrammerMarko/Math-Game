using System.Linq.Expressions;

public static class Igra
{
    public static List<string> resultsList = new List<string>();

    public static void menuInputResoultion(int menuInput)
    {
        switch (menuInput)
        {
            case 1:
                gameZbrajanje();
                break;
            case 2:
                gameOduzimanje();
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

    public static void gameZbrajanje()
    {
        int rounds = 10;
        int tocno = 0;
        Random random = new Random();

        while (rounds > 0)
        {
            int a = random.Next(0, 100);
            int b = random.Next(0, 100);

            Console.WriteLine($"Runda: {11 - rounds}/10");
            Console.Write($"{a} + {b} = ");
            int result = Convert.ToInt32(Console.ReadLine());

            if ((a + b) == result)
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
        resultsList.Add($"+ | {tocno}/10");
    }

    public static void gameOduzimanje()
    {
        int rounds = 10;
        int tocno = 0;
        Random random = new Random();

        while (rounds > 0)
        {
            int a = random.Next(0, 100);
            int b = random.Next(0, 100);

            Console.WriteLine($"Runda: {11 - rounds}/10");
            Console.Write($"{a} - {b} = ");
            int result = Convert.ToInt32(Console.ReadLine());

            if ((a - b) == result)
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
        resultsList.Add($"- | {tocno}/10");
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
