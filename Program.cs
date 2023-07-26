// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintRequestedElement(int[,] mas, int requestedElementRow, int requestedElementColumn)
{
    if (requestedElementRow > mas.GetLength(0) | requestedElementColumn > mas.GetLength(1)) 
    {Console.WriteLine($"Такого элемента нет");}
    else {Console.WriteLine($"{mas[requestedElementRow-1,requestedElementColumn-1]}");}
}

void PrintMas(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateMas(int rows, int columns, int numMin, int numMax)
{
    int[,] mas = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            mas[i,j] = new Random().Next(numMin, numMax);
        }
    }
    return mas;
}

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите количество строк в массиве: ");
int columns = GetInput("Введите количество строк в массиве: ");
int numMin = GetInput("Введите минимальный элемент массива: ");
int numMax = GetInput("Введите максимальный элемент массива: ");
Console.WriteLine();
int[,] mas = GenerateMas(rows, columns, numMin, numMax);
PrintMas(mas);
Console.WriteLine();
int requestedElementRow = GetInput("Введите номер строки, на которой располагается требуемый элемент: ");
int requestedElementColumn = GetInput("Введите номер столбца, на которой располагается требуемый элемент: ");
PrintRequestedElement(mas, requestedElementRow, requestedElementColumn);