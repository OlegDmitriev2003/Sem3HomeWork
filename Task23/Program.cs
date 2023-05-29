Console.Clear();
int i = 0;
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);
while (Num >= i)
    {
        Console.WriteLine(Math.Pow(i,3));
        i++;
    }