// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// System.Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);

// for (int i=2; i<=num;)
// {
//         System.Console.Write (" " + i);
//         i +=2;
// }

System.Console.Write("Введите число: ");
if (int.TryParse(Console.ReadLine(), out int num))
{
    if (num < 2)
    {
        System.Console.WriteLine("Введите число, большее или равное 2.");
    }
    else
    {
        for (int i = 2; i <= num; i += 2)
        {
            System.Console.Write(i);
            if (i < num - 1) // Проверка, не является ли текущее число предпоследним числом
            {
                System.Console.Write(",");
            }
        }
    }
}
else
{
    System.Console.WriteLine("Некорректный ввод. Введите целое число.");
}