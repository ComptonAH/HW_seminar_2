// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int FindThirdDigit(int a, int b)
{
    int result = 0;
    if (b<3)
    {
        Console.WriteLine("Your number is not contained a third digit, enter at least 3-digit number");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }
        result = (a/c)%10;
    }
    return result;
}

Console.WriteLine("Enter an integer 3-digit or more number: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = number.ToString().Length;

Console.Write(FindThirdDigit(number,index));
