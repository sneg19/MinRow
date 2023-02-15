/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

/*
1, Задать двумерный массив;
2, Найти суммы элементов каждой строки;
3, Сравнить суммы элементов строки и найти наименьшую;
4, Вывести номер строки и слово "строка". 
*/

int[,] GetArray( int m, int n, int minValue, int maxValue) // Генерация двумерного массива
{
    int[,] result = new int[m, n];
    for (int row = 0; row < m; row++)
    {
        for (int column = 0; column < n; column++)
        {
            result[row, column] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // Вывод массива на консоль
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int colunm = 0; colunm < inArray.GetLength(1); colunm++)
        {
            Console.Write($"{inArray[row, colunm]}\t ");
        }
        Console.WriteLine();
    }
}

int[] Sum (int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    for(int row = 0; row < matrix.GetLength(0); row++)
    {
        for(int column = 0; column < matrix.GetLength(1); column++)
        {
            sum[row] += matrix[row, column];
        }
    }
    return sum;
}

int Proverka (int[] ourArray)
{
    int min = 0;
    for (int i = 1; i < ourArray.Length; i++)
    {
        if(ourArray[i] < ourArray[min]) min = i;
    }
    return min;
}

void Main()
{
int[,] array = GetArray(3, 4, 0, 10);
int[] sum = Sum(array);
PrintArray(array);
Console.WriteLine(String.Join(" ",sum));
int min = Proverka(sum) + 1;
System.Console.WriteLine($"{min} строка");
}

Main();