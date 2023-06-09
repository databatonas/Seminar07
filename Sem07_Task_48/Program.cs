﻿// Задача 48.
/* Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
Amn = m + n. Выведите полученный массив на экран.
m = 3, n = 4.
0123
1234
2345*/

try /* Блок обработки исключений.*/
{
    Console.WriteLine("Введите целое натуральное число количества строк матрицы:");
    int m = int.Parse(Console.ReadLine()!); /* Функция Parse () разрешает переводить строку, которая 
    состоит из цифр, в целое число. (!)- для обработки исключений.*/

    if (m <= 0) /* Если пользователь ввёл количество строк, равным или менше нуля, то...*/
    {
        /* выведем на экран: "Количество строк  в матрице не может быть меньше или равно нулю"...*/
        Console.WriteLine("Количество строк в матрице не может быть меньше или равно нулю.");
        return; /* и вернёмся к началу операции.*/
    }
    Console.WriteLine("Введите целое натуральное число количества столбццов матрицы:");
    int n = int.Parse(Console.ReadLine()!);

    if (n <= 0) /* Если пользователь ввёл количество столбцов, равным или менше нуля, то...*/
    {
        /* выведем на экран: "Количество столбцов в матрице не может быть меньше или равно нулю"...*/
        Console.WriteLine("Количество столбцов в матрице не может быть меньше или равно нулю.");
        return; /* и вернёмся к началу операции.*/
    }    
    Console.WriteLine(); /* Пустая строка для пробела между вводом значений и ответа.*/

    int[,] matrix = new int[m, n]; /* Здесь int- тип данных, [,]- указатель того, что будет две размерности 
    (двумерный массив). matrix- наименование массива. new int- новый массив int. 
    [m,n]- (m- количество строк), (n- количество  столбцов).*/

    /* Метод, который заполняет нашу матрицу случайными числами.*/
    void FillArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++) /* Далее перебираем строки. Для общего случая можно 
        написать количество строк так- matrix.GetLength(0), где (0)- означает строки. Вводим переменную 
        (i)- счётчик строк. До тех пор, пока счётчик меньше длины массива, при каждой итерации 
        увеличиваем его на единицу и ...*/
        {
            for (int j = 0; j < matrix.GetLength(1); j++) /* (1)- означает столбцы. Вводим переменную 
            (j)- счётчик столбцов. До тех пор, пока счётчик меньше длины массива, при каждой итерации 
            увеличиваем его на единицу и ...*/
            {
                matrix[i, j] = i + j; /* присваиваем текущему элементу массива сумму текущих значений 
                                         счётчиков строки и столбца (по условию).*/
            }
        }
    }

    /* Метод, который будет выводить на экран матрицу. 
    В качестве аргумента мы передаём прямоугольную таблицу чисел int[,] с именем matrix.*/
    void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++) /* Далее перебираем строки. Для общего случая можно 
        написать количество строк так- matrix.GetLength(0), где (0)- означает строки. */
        {
            for (int j = 0; j < matrix.GetLength(1); j++) /* (1)- означает столбцы.*/
            {
                Console.Write($"{matrix[i, j]} "); /* Все значения каждой строки выводятся в одну отдельную
                строку. Если написать WriteLine- переход на следующу строку, то ответ будет выводиться в 
                столбец.*/
            }
            Console.WriteLine(); /* Пустая строка. Если её не будет, то все 
                                    значения будут выводиться в одну строку.*/
        }
    }

    FillArray(matrix);  /* Вызов метода заполнения случайными числами нашего массива.*/
    PrintArray(matrix); /* Вызов метода вывода на печать нашего массива, заполненного случайными числами.*/
}
catch /* Окончание блока обработки исключений.*/
{
    Console.WriteLine("Некорректный ввод данных. Введите целое натуральное число.");
}