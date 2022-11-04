/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[m, n];

void CreateArrayint(int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().Next(1,10) ;
    }
  }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
       Console.WriteLine();
    } 
    
}

CreateArrayint(array);
PrintArray(array);
Console.WriteLine();

int First =0;
int Second = 0;

for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for( First=j+1;  First < array.GetLength(1);  First++)
            {
                if (array[i,j] < array[i, First])
                    {
                        Second = array[i,j];
                        array[i,j] = array[i, First];
                        array[i, First] = Second;
                    }
           }
           Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }