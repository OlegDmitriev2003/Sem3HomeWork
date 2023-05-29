Console.Clear();
Console.Write("Введите координату X(1): ");
double X1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y(1): ");
double Y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z(1): ");
double Z1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату X(2): ");
double X2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y(2): ");
double Y2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z(2): ");
double Z2 = double.Parse(Console.ReadLine()!);

double Dist = Math.Sqrt(Math.Pow(X1-X2, 2)+ Math.Pow(Y1-Y2, 2) + Math.Pow(Z1-Z2, 2));
Console.WriteLine($"Расстояние равно {Dist}");
