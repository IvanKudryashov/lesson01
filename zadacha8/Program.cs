//программа, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (N >= a)
{
    if ((a%2) == 0)
    {
        Console.Write(a + " ");
    }
    a++;
}