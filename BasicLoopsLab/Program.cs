do
{
    Console.WriteLine("\nHello, World!");
    Console.Write("Would you like to continue (y/n)? ");
}
while (Console.ReadLine() == "y");

Console.WriteLine("Goodbye!");
Console.ReadKey();