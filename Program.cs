// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

void ProverkaNum(string number)
{
    if (number[0] == number [4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - палиндром. ");
    }
    else Console.WriteLine($"{number} - Не палидром. ");
}

if (number!.Length == 5)
{
    ProverkaNum(number);
}
else Console.WriteLine($"Введи правильное число");