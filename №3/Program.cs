/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
*/
                               //complite
int lines = InputNumber("Введите кол-то строк");
int colomns = InputNumber("Введите кол-во столбцов");
int[,] array = new int[lines, colomns];
int minLinesSum = int.MaxValue;
int indexMinLines = 0;

FillArray(array, 1, 10);
PrintArray(array);

for (int i = 0; i < lines; i++)
{
    int linesSum = 0;
    for (int j = 0; j < colomns; j++)
    {
        linesSum += array[i, j];
    }
    Console.WriteLine(linesSum + " ");
    if (linesSum < minLinesSum)
    {
        minLinesSum = linesSum;
        indexMinLines = i;
    }
}
Console.WriteLine("Строка с минимальной суммой элементов");
for (int j = 0; j < colomns; j++)
{
    Console.Write(array[indexMinLines, j]);
}


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

