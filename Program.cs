using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Multiplication");
Console.Write("Enter a number: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine($"Multiplication table {number}");


    for (int i = 1; i <= 12; i++){
        int result = number * i;
        Console.WriteLine($"{number} x {i} = {result}");

    }
}
else
{
    Console.WriteLine("Please enter a valid integer");
}
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();