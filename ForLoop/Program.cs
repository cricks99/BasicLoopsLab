Orchestrator();

void Orchestrator()
{
    do
    {
        OutputNumbers(GetNumber());
        Console.Write("\n\nWould you like to continue (y/n)? ");
    }
    while (Console.ReadLine() == "y");

    Console.WriteLine("Goodbye!");
    Console.ReadKey();
}

int GetNumber()
{
    int numberCounter;
    bool isValidValue;

    do
    {
        Console.Write("\nEnter a number (greater than 0): ");
        isValidValue = int.TryParse(Console.ReadLine(), out numberCounter) && numberCounter > 0;

        if (!isValidValue)
            Console.WriteLine("What are you doing?  I asked for a number greater than 0.");
    }
    while (!isValidValue);

    return numberCounter;
}

void OutputNumbers(int numberCounter)
{
    Console.WriteLine("\nHere is your number counting down to 0:");
    for (int i = numberCounter; i >= 0; i--)
        Console.Write($"{i} ");

    Console.WriteLine("\n\nHere is your number counting up from 0:");
    for (int i = 0; i <= numberCounter; i++)
        Console.Write($"{i} ");
}
