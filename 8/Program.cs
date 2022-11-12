// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4

// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа выведет все чётные числа от 1 до введённого вами числа. Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) {
    Console.WriteLine("Вы ввели отрицательное число. Оно будет взято по модулю!");
}
if (number == 1) {
    Console.WriteLine("Таких чисел нет");
}
else  {
    int count = 2;
    while (count <= number) {
        Console.Write($"{count} ");
        count = count + 2;
    }
}
