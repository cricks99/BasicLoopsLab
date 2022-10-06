Orchestrator();

void Orchestrator()
{
    int mainKeyCode = 13579, numAttempts = 1;
    bool isUnlocked;

    do
    {
        Console.WriteLine();
        if (numAttempts > 1)
            Console.Write("Try again.  ");

        Console.WriteLine($"This is attempt {numAttempts} of 5.");
        isUnlocked = IsCorrectKeyCode(GetKeyCode(), mainKeyCode);
    }
    while (!isUnlocked && numAttempts++ < 5);

    if (numAttempts == 6)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You took too many attempts!");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    Console.WriteLine("\nGoodbye!");
    Console.ReadKey();
}

int GetKeyCode()
{
    int userKeyCode;
    bool isValidValue;

    do
    {
        Console.Write("Enter the key code combination: ");
        isValidValue = int.TryParse(Console.ReadLine(), out userKeyCode) && userKeyCode > 0;

        if (!isValidValue)
            Console.WriteLine("What kind of key code is that?  Enter a valid number.");
    }
    while (!isValidValue);

    return userKeyCode;
}

bool IsCorrectKeyCode(int userKeyCode, int mainKeyCode)
{
    if (userKeyCode == mainKeyCode)
    {
        Console.Write($"Welcome!  You entered the correct code.  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The door is now unlocked!");
        Console.ForegroundColor = ConsoleColor.Gray;

        return true;
    }

    return false;
}
