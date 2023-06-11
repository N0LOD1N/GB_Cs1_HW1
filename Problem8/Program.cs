Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int index = 2;

while (index <= num)
{
    Console.Write($"{index}");
    index++;
    index++;
    if (index <= num) Console.Write(", ");
    else    Console.Write(".");
}