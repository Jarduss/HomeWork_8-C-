/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

int Sum = 0;
int[] arrayM= new int [m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Sum = Sum + array[i,j];
            arrayM[i] = Sum;
        }

    }

int result = arrayM[0];
int i_min =0;
for(int i = 0;  i < arrayM.Length; i++)
{
    if(arrayM[i]<result)
    {
        result=arrayM[i];
        i_min = i;
    }
}
Console.WriteLine($"Наименьшая сумма ="+result+", находящейся в строке № " + (i_min+1));