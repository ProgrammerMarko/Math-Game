public static class Grafika
{
    public static int menu()
    {
        int input;

        Console.WriteLine("Odaberite opciju za igranje ili history: ");
        Console.WriteLine(
            "1. Zbrajanje (+)\n2. Oduzimanje (-)\n3. Množenje (*)\n4. Djeljenje (/)\n5. Povijest"
        );

        while (true)
        {
            input = Convert.ToInt32(Console.ReadLine());
            if (input >= 1 && input <= 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Niste unjeli broj izmedu 1 i 5 -> unesite ponovno!");
            }
        }

        return input;
    }

    public static void printResult(int result)
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("Kraj runde!");
        Console.WriteLine($"Vaš rezultat je: {result}/10");
        Console.WriteLine("-------------------------");
    }
}
