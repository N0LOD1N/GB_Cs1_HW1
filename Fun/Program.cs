Console.Write("Введите число: ");
string num = Console.ReadLine() ?? "";

int index = 0;
while (index < num.Length)
{
    Console.Write(num[index] + "0");
    index++;
}

