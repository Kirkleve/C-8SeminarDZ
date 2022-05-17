/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
*/
int lines = InputNumber("Введите кол-то строк");
int colomns = InputNumber("Введите кол-во столбцов");
int[,] array = new int[lines, colomns];
FillArray(array, 1, 10);
PrintArray(array);





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
