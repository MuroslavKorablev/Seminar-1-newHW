// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число: ");
int firNum = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите второе число: ");
int secNum = int.Parse(Console.ReadLine()!);

if (firNum > secNum)
{
    System.Console.WriteLine(firNum + " > " + secNum);
}
else if (secNum > firNum)
{
    System.Console.WriteLine(secNum + " > " + firNum);
}
else
{
    System.Console.WriteLine("Числа равны");
}