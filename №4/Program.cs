/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
*/
                           //complite
int lines = InputNumber("Введите кол-то строк");
int colomns = InputNumber("Введите кол-во столбцов");
int[,] festArray = new int[lines, colomns];
int[,] secondArray = new int[lines, colomns];
int[,] newArray = new int[lines, colomns];
FillArray(festArray, 1, 10);
PrintArray(festArray);
Console.WriteLine();
FillArray(secondArray, 1, 10);
PrintArray(secondArray);
for (int i = 0; i < festArray.GetLength(0); i++)
{
    for (int j = 0;j <secondArray.GetLength(1); j++)
    {
        for ( int k =0; k < festArray.GetLength(0); k++)
        {
            newArray[i,j] += festArray[i,k] * secondArray[k,j];
        }
    }
}
Console.WriteLine();
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

