/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

Строка 1
Столбец 2
Вывод: 4 */

Console.Clear();
Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n, m];

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i,j] + "\t  ");
        Console.WriteLine();
}

 Console.WriteLine("Введите координаты(индекс) строки: ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координаты(индекс) столбца: ");
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m && b>n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = matrix.GetValue(a, b);
 Console.WriteLine(c);
 }

