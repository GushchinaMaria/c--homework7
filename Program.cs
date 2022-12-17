/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
 */
/* 
 double [,] Set_array(int N, int M)                  //метод для создания массива из N элементов из вещественных чисел
{
    double [,] array = new double [(int)N, (int) M];
    Random rnd = new Random();

    for (int i = 0; i < N; i++ )
        for (int j=0;j < M; j++)
        array[i,j] = rnd.NextDouble() + rnd.Next(-100,100);              

    return (array);
}
void Print_array (double [,] array)                    // метод для печатания массива
{
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
      {  for (int j=0; j< array.GetUpperBound(1) + 1; j++)
         { Console.Write($"{array[i,j]} \t");}
        Console.WriteLine();
      }     
}

Console.WriteLine("ВВедите число элементов массивав формате MxN: ");         //здесь просим ввести число элементов
string ? s = Console.ReadLine();
string [] numbs = s.Split('x');

int N1 = Convert.ToInt32(numbs[0]);
int M1 = Convert.ToInt32(numbs[1]);

double [,] array1 = Set_array(N1 , M1);                              //создаем массив

Print_array(array1);
 */
//конец первой задачи

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */


/* 
int [,] Set_array(int N, int M)                  //метод для создания массива из N элементов из целых чисел
{
    int [,] array = new int [(int)N, (int) M];
    Random rnd = new Random();

    for (int i = 0; i < N; i++ )
        for (int j=0;j < M; j++)
        array[i,j] = rnd.Next(-10,10);              

    return (array);
}

void Print_array (int [,] array)                    // метод для печатания массива
{
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
      {  for (int j=0; j< array.GetUpperBound(1) + 1; j++)
         { Console.Write($"{array[i,j]} \t");}
        Console.WriteLine();
      }     
}

Console.WriteLine("введите число эл тов массива в формате NxM: ");
string? s = Console.ReadLine();
string [] substring = s.Split("x");

int N = Convert.ToInt32(substring[0]);
int M = Convert.ToInt32(substring[1]);
int [,] array = Set_array(N, M);
Print_array(array);

Console.WriteLine("ВВедите позицию в формате 17, где 1 - номер строки, 7 - номер столбца (нумерация начинается с 0!): ");
string? position = Console.ReadLine();
char[] a = position.ToCharArray();

int N1 = a[0] - '0';
int M1 = a[1] - '0';

if ((N1 >= N) || (M1 >= M)) 
{   
    Console.WriteLine("такой позиции не существует");
}
else 
{
    Console.WriteLine(array[N1,M1]);
} */
//конец задачи
/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

 int [,] Set_array(int N, int M)                  //метод для создания массива из N элементов из целых чисел
{
    int [,] array = new int [(int)N, (int) M];
    Random rnd = new Random();

    for (int i = 0; i < N; i++ )
        for (int j=0;j < M; j++)
        array[i,j] = rnd.Next(-10,10);              

    return (array);
}

void Print_array (int [,] array)                    // метод для печатания массива
{
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
      {  for (int j=0; j< array.GetUpperBound(1) + 1; j++)
         { Console.Write($"{array[i,j]} \t");}
        Console.WriteLine();
      }     
}


Console.WriteLine("ВВедите число элементов массива в формате NxM: ");         //здесь просим ввести число элементов
string ? s = Console.ReadLine();
string [] numbs = s.Split('x');

int N1 = Convert.ToInt32(numbs[0]);         // количество строк
int M1 = Convert.ToInt32(numbs[1]);         // количество столбцов

int [,] array1 = Set_array(N1,M1);                              //создаем массив
double [] arr_result = new double [(int)M1];

for (int i = 0; i < M1; i++)
{
    for (int j= 0; j < N1; j++)
    {
        arr_result[i] += array1[j,i];
    }
    arr_result [i] /= N1;
    
}
Print_array (array1);

for (int i = 0; i < M1; i++)
{
    Console.Write($"{arr_result[i]} \t");
} 