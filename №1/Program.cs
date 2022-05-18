/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/
                                //complite
int lines = InputNumber("Введите кол-то строк");
int colomns = InputNumber("Введите кол-во столбцов");
int[,] array = new int[lines, colomns];
FillArray(array, 1, 10);
PrintArray(array);
Console.WriteLine();
int minValue = MinValue(array);
int minLines = MinRow(array);
int minColomns = MinCol(array);
Console.WriteLine($"Минимальное число {minValue} находится в строке {minLines}, в столбце {minColomns}");
int[,] newArray = new int[lines-1, colomns-1];
int k = 0; 
int l = 0;
for (int i = 0; i < newArray.GetLength(0); i++)
{
    l = 0;
    if (i == minLines) k++;
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        if (j == minColomns) l++;
        newArray[i, j] = array[k, l];
        l++;
    }
    k++;
}
PrintArray(newArray);


int InputNumber(string output)
{
    Console.Write(output + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] matr, int festNumber, int secondNumber)
{
    for (int lines = 0; lines < matr.GetLength(0); lines++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[lines, columns] = new Random().Next(festNumber, secondNumber);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($" {matrix[rows, columns]}");
        }
        Console.WriteLine();
    }
}

int MinValue(int[,] matrix)
{
    int minRow = 0;
    int minCol = 0;
    int minValue = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue)
            {
                minValue = matrix[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    return minValue;
}

int MinRow(int[,] matrix)
{
    int minRow = 0;
    int minCol = 0;
    int minValue = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue)
            {
                minValue = matrix[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    return minRow;
}

int MinCol(int[,] matrix)
{
    int minRow = 0;
    int minCol = 0;
    int minValue = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue)
            {
                minValue = matrix[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    return minCol;
}