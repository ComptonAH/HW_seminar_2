// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Enter three digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n>=100 && n<=999)
{    
    n /= 10;
    n %= 10;
    Console.WriteLine($"the second digit is {n}");
}
else
    {
    Console.WriteLine("You wrote not a 3-digit number, please try again");
    }