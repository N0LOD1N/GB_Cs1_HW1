﻿Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
{
    Console.WriteLine($"Первое число \"{firstNum}\" больше второго \"{secondNum}\"");
}
else
{
    Console.WriteLine($"Второе число \"{secondNum}\" больше первого \"{firstNum}\"");
}

