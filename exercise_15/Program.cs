// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter a number of the day of a week (from 1 to 7): ");

int NumberOfDay = Convert.ToInt32(Console.ReadLine());

if (NumberOfDay>=1 && NumberOfDay<=7)
{
    if (NumberOfDay == 6 || NumberOfDay == 7)
    {
       Console.WriteLine("A weekend!"); 
    }
    else
    {
        Console.WriteLine("Not a weekend :(");
    }
}
else
{
    Console.WriteLine("Try again to enter a number of the day of a week (from 1 to 7)");
}