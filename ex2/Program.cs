// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.Write("Введите первое число: ");
// int firNum = int.Parse(Console.ReadLine()!);

// System.Console.Write("Введите второе число: ");
// int secNum = int.Parse(Console.ReadLine()!);

// System.Console.Write("Введите третье число: ");
// int thrNum = int.Parse(Console.ReadLine()!);

// if (firNum > secNum && firNum > thrNum)
// {
//     System.Console.Write("Наибольшее число: " + firNum);
// }
// else if (secNum > thrNum)
// {
//     System.Console.Write("Наибольшее число: " + secNum);
// }
// else
// {
//     System.Console.Write("Наибольшее число: " + thrNum);
// }

int[] numbers = new int[3];

for (int i = 0; i < 3; i++)
{
    System.Console.Write($"Введите {i + 1}-е число: ");
    numbers[i] = int.Parse(Console.ReadLine()!);
}

int maxNum = numbers.Max();
System.Console.WriteLine($"Наибольшее число:  {maxNum}");
