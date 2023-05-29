Console.Clear();
int i = 0;
bool IsPalindrome = true;
Console.Write("Введите число: ");
string Num = Console.ReadLine();

int N = Num.Length;

while (i < N)
{
    if (Num[i] == Num[(N-1) - i])
    {
i++;
IsPalindrome = true;
    }

    else
    {
        IsPalindrome = false;
        i++;
    }
}

if (IsPalindrome == true)
    Console.WriteLine($"Число {Num} - палиндром");
else
    Console.WriteLine($"Число {Num} - не палиндром");