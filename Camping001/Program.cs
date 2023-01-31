using System.Diagnostics;
// i v                     цикл по i v перебирает все элементы до элемента длинны - значения m
//   0 1 2 3 4 5 6 7 8 9 ...........// Нумерация элементов 
//   1 5 4 1 3 4 7 4 1 2 - пример
// j ^ ^ ^
// Max -> 15 
//
//
// Печать массива из n элемнтов  на экран

int size = 10; // колличество введеных элементов

int m = 3;
// Заполнение массива случайным образом из 10 элемнтов
int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10)) //Генератор псевдослучайных чисел
                        .ToArray();
//Console.WriteLine($"[{string.Join(", ", array)}]"); // Вывод элементов на экран
// Цикл на нахождение суммы 3 цифр в рандомном массиве
Stopwatch sw = new(); // Создание компляра таймера
sw.Start(); // Начало таймера
int max = 0;
for (int i = 0; i < array.Length - m; i++)
{
    int t = 0;
    for (int j = i; j < i + m; j++)
    {
        t = t + array[j];
    }
    if (t > max) max = t;
}
sw.Stop(); // Конец таймера
Console.WriteLine($"time = {sw.ElapsedMilliseconds}"); // Время затраченное на данную программу. В миллисекндах
Console.WriteLine(max); // вывод в консоль максимального значения сумм 3-х элементов