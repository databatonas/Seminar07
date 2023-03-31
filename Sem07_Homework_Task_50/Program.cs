﻿// Задача 50.
/* Напишите программу, которая на ввод принимает позиции элемента в двумерном массиве, 
   и возвращает значение этого элемента или же указание, что такого элемента нет.
1 4 7 2
5 9 2 3
8 4 2 4
[1, 7]- такого элемента в массиве нет.*/

try /* Блок обработки исключений.*/
{
    int[,] array = new int[,] /* Запись данного массива.*/
       {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
       };

    /* Метод, который на ввод принимает позиции элемента в двумерном массиве, 
       и возвращает значение этого элемента.*/
    void Element(int[,] matrix)
    {
        Console.WriteLine("Введите номер строки. Число должно быть натуральным, включая ноль:");
        int line = int.Parse(Console.ReadLine()!); /* (line- перевод- строки). Функция Parse () разрешает 
        переводить строку, которая состоит из цифр, в целое число. (!)- для обработки исключений.*/

        if (line < 0 | line >= array.GetLength(0)) /* Если пользователь ввёл номер строки, менше нуля или 
                                                      больше или равно длине строки, то...*/
        {
            Console.WriteLine($"Элемента с позицией строки {line} нет в данном массиве.");
            return; /* и вернёмся к началу операции.*/
        }

        Console.WriteLine("Введите номер столбца. Число должно быть натуральным, включая ноль:");
        int column = int.Parse(Console.ReadLine()!); // column- перевод- столбец.

        if (column < 0 | column >= array.GetLength(1)) /* Если пользователь ввёл номер столбца, менше 
                                                          нуля или больше или равно длине столбца, то...*/
        {
            Console.WriteLine($"Элемента с позицией столбца {column} нет в данном массиве. ");
            return; /* и вернёмся к началу операции.*/
        }

        /* Если позиции введены правильно, то...*/
        for (int i = 0; i < matrix.GetLength(0); i++) /* перебираем строки. Для общего случая можно 
        написать количество строк так- matrix.GetLength(0), где (0)- означает строки. */
        {
            for (int j = 0; j < matrix.GetLength(1); j++) /* Перебираем столбцы. (1)- означает столбцы.*/
            {
                if (i == line & j == column) /* Если, в процессе переборки, номера позиций, введённые 
                пользователем, совпали с текущими позициями массива, то...*/
                {
                    Console.WriteLine($"Элемент с позицией [{line}, {column}] равен: {matrix[i, j]} ");
                    break; /* И заканчиваем операцию.*/
                }
            }

        }
    }

    Element(array); /* Вызываем метод, который на ввод принимает позиции элемента в двумерном массиве, 
                       и возвращает значение этого элемента.*/
}
catch /* Окончание блока обработки исключений.*/
{
    Console.WriteLine("Некорректный ввод данных. Введите целое натуральное число, включая ноль.");
}

