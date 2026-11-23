Console.WriteLine("Grading (0 - 100)");
Console.Write("Enter your point: ");


if (double.TryParse(Console.ReadLine(), out double score))
{
    if (score < 0 || score > 100)
        Console.WriteLine("Invalid score!");
    else if (score >= 80)
        Console.WriteLine("Grade: A");
    else if (score >= 70)
        Console.WriteLine("Grade: B");
    else if (score >= 60)
        Console.WriteLine("Grade: C");
    else if (score >= 50)
        Console.WriteLine("Grade: D");
    else
        Console.WriteLine("Grade: F");
}
else
{
    Console.WriteLine("Please enter a valid number.");
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();