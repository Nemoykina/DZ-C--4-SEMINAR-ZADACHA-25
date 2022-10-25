// Напишите цикл, который принимает на вход двав числа (А и В)
// и возводит число А в натуральную степень В.
// 3, 5 -> 243
// 2, 4 -> 16

int GetPow(int A, int B)
{
    int pow = 1;
    int i = 0;

    while (i < B)
    {
        pow = pow * A;
        i = i + 1;
    }
    return pow;
}

Console.Clear();
Console.Write("Введите первое число: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetPow (y, x));