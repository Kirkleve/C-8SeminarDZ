/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
*/
                                        //complite
int numbers = InputNumber("Введите кол-то строк и столбцов");
int[,] firstArray = new int[numbers, numbers];
int[,] secondArray = new int[numbers, numbers];
FillArray(firstArray, 1, 10);
PrintArray(firstArray);
Console.WriteLine();
FillArray(secondArray, 1, 10);
PrintArray(secondArray);
Console.WriteLine();
int[,] multiplicationArray = MultiplicationMatrix(firstArray, secondArray);
PrintArray(multiplicationArray);

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

int[,] MultiplicationMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] newArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    if (firstArray.GetLength(0) != secondArray.GetLength(1))
    {
        return firstArray;
    }

    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(0); k++)
            {
                newArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return newArray;
}