using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Enter a number to display its multiplication table: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Multiplication Table for {num}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}
