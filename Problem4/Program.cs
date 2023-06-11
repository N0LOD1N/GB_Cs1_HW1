Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum && firstNum > thirdNum)

        Console.WriteLine($"Первое число \"{firstNum}\" является максимальным");

else if (secondNum > thirdNum && secondNum > firstNum)

        Console.WriteLine($"Второе число \"{secondNum}\" является максимальным");

else if (thirdNum > firstNum && thirdNum > secondNum)

        Console.WriteLine($"Третье число \"{thirdNum}\" является максимальным");

else

    Console.WriteLine("Error");